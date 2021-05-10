<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="AI_Project.SignUp" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="text-align:center">

    <asp:Table runat="server" Width="100%">
        <asp:TableRow>
            <asp:TableCell Width="30%">
                <asp:Label ID="lblUsername" runat="server" Text="Enter your username: " Font-Size="XX-Large"/>
            </asp:TableCell>

            <asp:TableCell Width="30%">
                <asp:TextBox ID="tbUsername" CssClass="tb" runat="server" placeholder="Username" Width="50%"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell Width="40%">
                <div style="text-align: left">
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="tbUsername" ErrorMessage="Field is required."/>
                    <asp:CustomValidator runat="server" ControlToValidate="tbUsername" ID="UsernameValidator" Display="Static" OnServerValidate="UsernameValidator_ServerValidate" />
                </div>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow Height="10"/>

        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblPassword" runat="server" Text="Enter your password: " Font-Size="XX-Large"/>
            </asp:TableCell>

            <asp:TableCell>
                <asp:TextBox ID="tbPassword" CssClass="tb" runat="server" placeholder="Password" Width="50%" TextMode="Password"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="tbPassword" ErrorMessage="Field is required."/>
                <asp:CustomValidator runat="server" ControlToValidate="tbPassword" ID="PasswordValidator" Display="Static" OnServerValidate="PasswordValidator_ServerValidate" />
            </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow Height="10"/>
        
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="signupButton" runat="server" text="Sign Up" Width="50%" OnClick="signupButton_Click"/>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="clearButton" runat="server" text="Clear" Width="50%" OnClick="clearButton_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    </div>
</asp:Content>