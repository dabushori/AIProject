using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace AI_Project
{
    public partial class BlockUser : System.Web.UI.Page
    {
        private SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{0}\\DATABASE.mdf\";Integrated Security=True", Server.MapPath("~/App_Data"));
            con = new SqlConnection(conStr);
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

        protected void BlockButton_Click(object sender, EventArgs e)
        {
            string username = BlockUserTB.Text.Trim();
            if (username == "admin")
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert(\"Admin can't be blocked.\")</script>");
                return;
            }
            if (!IsUserExist(username))
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert(\"Username doesn't exists.\")</script>");
                return;
            }
            con.Open();
            string query = "delete from Users where username=@username";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.ExecuteNonQuery();
            con.Close();
            BlockUserTB.Text = "";
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User has been blocked successfully.')</script>");
        }
    }
}