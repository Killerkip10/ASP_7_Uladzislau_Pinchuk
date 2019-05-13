<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="laba7.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <asp:Login ID="Login1" runat="server"
        CreateUserText="Registration"
        CreateUserUrl="~/Registration.aspx" OnAuthenticate="Login1_Authenticate"></asp:Login>
</asp:Content>
