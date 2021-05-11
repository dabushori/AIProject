<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AI_Project.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1><strong>Welcome.</strong> Please login.</h1>

    <fieldset style="margin: 5px 5px 5px 5px">

        <asp:TextBox ID="tbUsername" CssClass="tb" runat="server" placeholder="Username" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUsername" ErrorMessage="Field is required." />
        <br />
        <br />
        <asp:TextBox ID="tbPassword" CssClass="tb" runat="server" placeholder="Password" TextMode="Password" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" ErrorMessage="Field is required." />
        <br />
        <br />
        <asp:Button ID="sendButton" runat="server" Text="Login" OnClick="sendButton_Click" />
        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
        <br />

    </fieldset>

</asp:Content>
