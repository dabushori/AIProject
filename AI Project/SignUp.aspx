<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AI_Project.SignUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <h1><strong>Welcome.</strong> Please sign up.</h1>

    <fieldset style="margin: 5px 5px 5px 5px">

        <asp:TextBox ID="tbUsername" CssClass="tb" runat="server" placeholder="Username" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUsername" ErrorMessage="Field is required." />
        <asp:CustomValidator runat="server" ControlToValidate="tbUsername" ID="UsernameValidator" Display="Static" OnServerValidate="UsernameValidator_ServerValidate" />
        <br />
        <br />
        <asp:TextBox ID="tbPassword" CssClass="tb" runat="server" placeholder="Password" TextMode="Password" />
        <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" ErrorMessage="Field is required." />
        <asp:CustomValidator runat="server" ControlToValidate="tbPassword" ID="PasswordValidator" Display="Static" OnServerValidate="PasswordValidator_ServerValidate" />
        <br />
        <br />
        <asp:Button ID="signupButton" runat="server" Text="Sign Up" OnClick="signupButton_Click" />
        <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" />
        <br />

    </fieldset>

</asp:Content>
