using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace AI_Project
{
    public partial class Chat : Page
    {
        private CommandExecutioner excecutioner;
        private SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{0}\\DATABASE.mdf\";Integrated Security=True", Server.MapPath("~/App_Data"));
            excecutioner = new CommandExecutioner(conStr, Server.MapPath("~/App_Data"));
            con = new SqlConnection(conStr);
        }

        private string GetBotResponse(string command)
        {
            return excecutioner.GetResponse(command);
        }

        private void AddMessage(string message)
        {
            lblChat.Text += "<br>";
            lblChat.Text += message;
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string command = tbMessage.Text;
            if (command != "")
            {
                AddMessage("<b><u>You:</u></b> " + command);
                string response = GetBotResponse(command);
                AddMessage("<b><u>Bot:</u></b> " + response);
                tbMessage.Text = "";
            }
        }
    }
}