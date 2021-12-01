<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NaturalsWebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div class="home-welcome">
            <h1>Welcome to NATURALS</h1>
            <h2>Your own 100% Natural Products Store</h2>
            <div class="home-welcome-buttons">
                <a runat="server" href="~/SignUp.aspx">Sign Up</a>
                <a runat="server" href="~/SignIn.aspx">Sign In</a>
            </div>
        </div>
</asp:Content>