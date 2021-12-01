<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="NaturalsWebForm.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="signup-box">
            <h2>Create Account</h2>
            <input runat="server" id="txtName" type="text" placeholder="Name">
            <input runat="server" id="txtMail" type="email" placeholder="Email Id">
            <input runat="server" id="txtPassword" type="password" placeholder="Set Password">
            <button runat="server" type="submit" id="BtnSignup" onserverclick="BtnSignup_Click">Sign Up</button>
        </div>
</asp:Content>
