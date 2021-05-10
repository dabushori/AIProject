using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using AI_Project.Executioners;

namespace AI_Project
{
    public class CommandExecutioner
    {
        private SqlConnection con;
        private List<IExecutioner> executioners;
        public CommandExecutioner(string conStr, string appDataDir)
        {
            con = new SqlConnection(conStr);

            executioners = new List<IExecutioner>
            {
                new TranslateExecutioner(),
                new HelpExecutioner(this),
                new TimeExecutioner(),
                new EvaluateExecutioner(),
                new JokeExecutioner(appDataDir)
            };
        }

        public void Learn(string command, string response)
        {
            // update db
            con.Open();
            string query = String.Format("insert into Commands(command, response) values('{0}','{1}')", command.Trim().Replace("'","''"), response.Trim().Replace("'", "\\'"));
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private List<string> GetValuesByColumnName(SqlDataReader reader, string name)
        {
            List<string> vals = new List<string>();
            while (reader.Read())
            {
                vals.Add(reader[name].ToString());
            }
            return vals;
        }

        public string HelpString
        {
            get
            {
                string s = "Some commands you can use: <br/>";
                for (int i = 0; i < executioners.Count; ++i)
                {
                    s += executioners[i].Info;
                    if (i != executioners.Count - 1) s += "<br/>";
                }
                return s;
            }
        }

        private string ExcecuteSavedCommand(string command, out bool toLearn) {
            foreach (var e in executioners)
            {
                var res = e.Execute(command);
                if (res != null)
                {
                    toLearn = e.ToLearn;
                    return res;
                }
            }
            toLearn = false;
            return null;
        }

        Random rand = new Random();

        public string GetResponse(string command)
        {
            command = Regex.Replace(command, @"\s+", " ").Trim();
            string response;

            con.Open();
            string query = "select * from Commands where command=@command";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@command", command);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                List<string> responses = GetValuesByColumnName(reader, "response");
                reader.Close();
                response = responses[rand.Next(responses.Count)] + "<br/>(This is from data base!!!)"; // db part can be removed
                con.Close();
            }
            else
            {
                reader.Close();
                con.Close();
                response = ExcecuteSavedCommand(command, out bool toLearn);
                if (response != null)
                {
                    if (toLearn) Learn(command, response);
                } 
                else
                {
                    response = "Wrong command. Use <b>help</b> to read about the commands format.";
                }
            }
            return response;
        }
    }
}