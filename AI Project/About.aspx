<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="AI_Project.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <hr />
    <h3>This is an AI chat bot web application.
        <br />
    </h3>
    <h4>
        <b>Some commands you can use: </b>
        <br />
    </h4>

    <ul>
        <li>
            <b>translate from_lang to_lang string_to_translate</b> - Translates a string between two languages.
        <br />
        </li>
        <li>
            <b>help</b> - shows a list of commands you can use.
        <br />
        </li>
        <li>
            <b>time format_string</b> - Tells the current time using the given format string. For more information about the format string,
        visit <a href="https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings">this website. </a>
            <br />
            If used without format string, it prints the output with the format string "dd.MM.yyyy hh:mm: ss tt".<br />
        </li>
        <li>
            <b>eval arithmetic_expression</b> - Evaluates the given expression (pay attention that those are int expressions, so / is integer division and % is integer modulo).<br>
        </li>
        <li>
            <b>joke</b> - Tells a random (hilarious) joke.

        </li>
    </ul>

    <h3>You can contact me in my gmail - <a href="mailto:dabushori@gmail.com">dabushori@gmail.com</a></h3>

    <h3>Requirements:</h3>
    <ul>
        <li><a href="https://dotnet.microsoft.com/apps/aspnet">ASP.NET Version 4.8.4330.0</a></li>
        <li><a href="https://www.microsoft.com/en-us/sql-server/sql-server-downloads">SQL Server</a></li>
        <li><a href="https://eval-expression.net">C# Eval Expression NuGet package</a></li>
    </ul>

</asp:Content>
