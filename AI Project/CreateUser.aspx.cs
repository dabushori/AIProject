using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace AI_Project
{
    public partial class CreateUser : System.Web.UI.Page
    {
        private SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{0}\\DATABASE.mdf\";Integrated Security=True", Server.MapPath("~/App_Data"));
            con = new SqlConnection(conStr);
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            tbPassword.Text = "";
            tbUsername.Text = "";
        }

        private bool IsUserExist(string username)
        {
            con.Open();
            string query = "select * from Users where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            var reader = cmd.ExecuteReader();
            bool res = reader.Read();
            con.Close();
            return res;
        }

        protected void sendButton_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim(), password = tbPassword.Text.Trim();
            if (IsUserExist(username))
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Username already exists.')</script>");
                return;
            }
            con.Open();
            string query = String.Format("insert into Users(username, password) values('{0}','{1}')", username, password);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User created successfully.')</script>");
        }
    }
}