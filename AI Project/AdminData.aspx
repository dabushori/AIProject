<%@ Page Title="Admin Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminData.aspx.cs" Inherits="AI_Project.AdminData" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> </h2>
        
    <asp:Button ID="ShowUsers" runat="server" Text="View Users" OnClick="ShowUsers_Click"/>
    <asp:Button ID="ShowCommands" runat="server" Text="View Commands" OnClick="ShowCommands_Click" />
       
    <div runat="server" id="dataDiv" visible="false">
        <asp:GridView ID="SqlDataGV" runat="server"/>
    </div>
    
    <div runat="server" visible="false">
        <asp:SqlDataSource
            id="UsersData"
            runat="server"
            DataSourceMode="DataReader"
            ConnectionString=""
            SelectCommand="select * from Users" />
            
        <asp:SqlDataSource
            id="CommandsData"
            runat="server"
            DataSourceMode="DataReader"
            ConnectionString=""
            SelectCommand="select * from Commands" />
    </div>
    
</asp:Content>
