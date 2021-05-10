<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="AI_Project.Chat" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="Container">
      <asp:Label ID="lblChat" runat="server" CssClass="ChatLabel" Text="<b><u>Bot:</u></b> Hi! I am chat-bot. Write <b>help</b> for information about commands." Width="100%" Height="90%"/>
        <div style="display: flex; height: auto; width: 100%">
          <asp:TextBox ID="tbMessage" CssClass="MessageBox" runat="server" Width="90%" Height="10%" AutoCompleteType="Disabled"/>
          <asp:Button ID="btnSend" CssClass="SendButton" runat="server" Text="Send" Width="10%" Height="10%" OnClick="btnSend_Click"/>
        </div>
    </div>
</asp:Content>
