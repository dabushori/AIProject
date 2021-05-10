<%@ Page Title="Create User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="AI_Project.CreateUser" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div id="LoginPage">
        
        <asp:Table runat="server" Width="100%">
           
            <asp:TableRow>
                <asp:TableCell Width="40%">
                    <asp:Label ID="lblUsername" runat="server" Text="Username: " Font-Size="XX-Large"/>
                </asp:TableCell>
                <asp:TableCell Width="60%">
                    <asp:TextBox ID="tbUsername" CssClass="tb" runat="server" placeholder="Username" Width="50%"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUsername" ErrorMessage="Field is required." ForeColor="Red" />
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow Height="10"/>

            <asp:TableRow>
                <asp:TableCell Width="40%">
                    <asp:Label ID="lblPassword" runat="server" Text="Password: " Font-Size="XX-Large"/>
                </asp:TableCell>
                <asp:TableCell Width="60%">
                    <asp:TextBox ID="tbPassword" CssClass="tb" runat="server" placeholder="Password" Width="50%" TextMode="Password"/>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" ErrorMessage="Field is required." ForeColor="Red" />
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow Height="10"/>
        
            <asp:TableRow>
                <asp:TableCell Width="50%">
                    <asp:Button ID="sendButton" runat="server" text="Create User" Width="50%" OnClick="sendButton_Click"/>
                </asp:TableCell>
                <asp:TableCell Width="50%">
                    <asp:Button ID="clearButton" runat="server" text="Clear" Width="50%" OnClick="clearButton_Click"/>
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>

    </div>
</asp:Content>
