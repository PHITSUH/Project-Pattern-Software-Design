<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="PSDProject.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register Page</h1>
            <br />
            <asp:Label ID="usernameLabel" runat="server" Text="Input Username: "></asp:Label>
            <asp:TextBox ID="usernameBox" runat="server" Placeholder="Username"></asp:TextBox>
            <br />
            <asp:Label ID="emailLabel" runat="server" Text="Input Email: "></asp:Label>
            <asp:TextBox ID="emailBox" runat="server" TextMode="Email" Placeholder="Email"></asp:TextBox>
            <br />
            <asp:Label ID="genderLabel" runat="server" Text="Input Gender: "></asp:Label>
            <asp:RadioButtonList ID="genderGroup" runat="server">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:RadioButtonList>

            <br />
            <asp:Label ID="passwordLabel" runat="server" Text="Input Password: "></asp:Label>
            <asp:TextBox ID="passwordBox" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox>
            <br />
            <asp:Label ID="confirmLabel" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="confirmBox" runat="server" TextMode="Password" Placeholder="Confirm Password"></asp:TextBox>
            <br />
            <asp:Label ID="dateLabel" runat="server" Text="Input Date of Birth: "></asp:Label>
            <asp:TextBox ID="dateBox" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <asp:Button ID="submitButton" runat="server" Text="Submit" onclick="submitButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
            <a href="LoginPage.aspx">Already have an account?</a>
        </div>
    </form>
</body>
</html>
