<%@ Page Title="Create User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="AI_Project.CreateUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <h1><strong>Welcome, Admin.</strong> Please create a user.</h1>

    <fieldset style="margin: 5px 5px 5px 5px">

        <asp:TextBox ID="tbUsername" CssClass="tb" runat="server" placeholder="Username"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUsername" ErrorMessage="Field is required." />
        <br />
        <br />
        <asp:TextBox ID="tbPassword" CssClass="tb" runat="server" placeholder="Password" TextMode="Password" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" ErrorMessage="Field is required." />
        <br />
        <br />
        <asp:Button ID="sendButton" runat="server" Text="Create User" OnClick="sendButton_Click" />
        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
        <br />

    </fieldset>

</asp:Content>
