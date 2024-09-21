<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeup.aspx.cs" Inherits="PSDProject.Views.AddMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add New Makeup Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Makeup Name"></asp:Label>
            <br />
            <asp:TextBox ID="makeupNameBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Makeup Price"></asp:Label>
            <br />
            <asp:TextBox ID="makeupPriceBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Makeup Weight"></asp:Label>
            <br />
            <asp:TextBox ID="makeupWeightBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Makeup Type ID"></asp:Label>
            <br />
            <asp:TextBox ID="makeupTypeIDBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Makeup Brand ID"></asp:Label>
            <br />
            <asp:TextBox ID="makeupBrandIDBox" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add Makeup" onclick="addButton_Click"/>
            <asp:Button ID="backButton" runat="server" Text="Go Back" onclick="backButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
