<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeupBrand.aspx.cs" Inherits="PSDProject.Views.AddMakeupBrand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Makeup Brand Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Makeup Brand Name"></asp:Label>
            <br />
            <asp:TextBox ID="brandNameBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Makeup Brand Rating"></asp:Label>
            <br />
            <asp:TextBox ID="brandRatingBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add New Makeup Brand" onclick="addButton_Click"/>
            <asp:Button ID="backButton" runat="server" Text="Go Back" OnClick="backButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
