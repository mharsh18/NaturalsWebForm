<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="NaturalsWebForm.SignIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="signup-box">
            <h2>Sign In</h2>
            <input runat="server" id="txtMail" type="email" placeholder="Email Id">
            <input runat="server" id="txtPassword" type="password" placeholder="Password">
            <button runat="server" id="BtnSignin" type="submit" onserverclick="BtnSignin_Click">Sign In</button>
        </div>
</asp:Content>
