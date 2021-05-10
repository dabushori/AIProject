<%@ Page Title="Block User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BlockUser.aspx.cs" Inherits="AI_Project.BlockUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %> </h2>
    <asp:TextBox runat="server" ID="BlockUserTB" />
    <asp:RequiredFieldValidator runat="server" ControlToValidate="BlockUserTB" ErrorMessage="Field is required." ForeColor="Red" />
    <br />
    <asp:Button runat="server" ID="BlockButton" Text="Block User" OnClick="BlockButton_Click" />
</asp:Content>
