<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateMakeupType.aspx.cs" Inherits="PSDProject.Views.UpdateMakeupType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Makeup Type Button</h1>
            <asp:Label ID="Label1" runat="server" Text="Makeup Type Name"></asp:Label>
            <br />
            <asp:TextBox ID="typeNameBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="updateButton" runat="server" Text="Update" onclick="updateButton_Click"/>
            <asp:Button ID="backButton" runat="server" Text="Go Back" onclick="backButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
