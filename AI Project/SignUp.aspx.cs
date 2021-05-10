using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace AI_Project
{
    public partial class SignUp : System.Web.UI.Page
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

        protected void signupButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
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

            Session["username"] = tbUsername.Text.Trim();
            Response.Redirect("Default.aspx");
        }

        protected void UsernameValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            string username = args.Value;
            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9_-]{3,15}$")) {
                UsernameValidator.ErrorMessage = "Username must contain letters, digits and '-' and '_', and its length must be between 3 to 15 characters.";
                args.IsValid = false;
            }
        }

        protected void PasswordValidator_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            string password = args.Value;
            if (!Regex.IsMatch(password, @"^[a-zA-Z0-9]{8,}$"))
            {
                PasswordValidator.ErrorMessage = "Password can contain only letters and digits and its length must be at least 8 characters.";
                args.IsValid = false;
            }
        }
    }
}