using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace AI_Project
{
    public partial class Login : System.Web.UI.Page
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

        protected void sendButton_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Users where username=@username and password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            string username = tbUsername.Text.Trim(), password = tbPassword.Text.Trim();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Session["username"] = username;
                if (username == "admin" && password == "admin")
                {
                    Session["admin"] = true;
                }
                Response.Redirect("Default.aspx");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
            }
            con.Close();
        }

    }
}