<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PSDProject.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login Page</h1>
            <br />
            <asp:Label ID="usernameLabel" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="usernameBox" runat="server" PlaceHolder="Input Username"></asp:TextBox>
            <br />
            <asp:Label ID="passwordLabel" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="passwordBox" runat="server" PlaceHolder="Input Password" TextMode="Password"></asp:TextBox>
            <br />
            <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me?"/>
            <br />
            <asp:Button ID="loginButton" runat="server" Text="Submit" onclick="loginButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
            <a href="RegisterPage.aspx">Don't have an account?</a>
        </div>
    </form>
</body>
</html>
