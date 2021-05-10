using System;
using System.Web.UI;

namespace AI_Project
{
    public partial class AdminData : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string conStr = String.Format("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{0}\\DATABASE.mdf\";Integrated Security=True", Server.MapPath("~/App_Data"));
            UsersData.ConnectionString = conStr;
            CommandsData.ConnectionString = conStr;
        }

        protected void ShowUsers_Click(object sender, EventArgs e)
        {
            dataDiv.Visible = true;
            SqlDataGV.DataSourceID = "UsersData";
        }

        protected void ShowCommands_Click(object sender, EventArgs e)
        {
            dataDiv.Visible = true;
            SqlDataGV.DataSourceID = "CommandsData";
        }
    }
}