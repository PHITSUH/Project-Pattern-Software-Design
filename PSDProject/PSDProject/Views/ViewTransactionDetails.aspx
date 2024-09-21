<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionDetails.aspx.cs" Inherits="PSDProject.Views.ViewTransactionDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Transaction Detail Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Transaction Detail"></asp:Label>
            <br />
            <asp:GridView ID="transactionDetailView" runat="server"></asp:GridView>
            <asp:Button ID="backButton" runat="server" Text="Go Back to Transaction Header Page" onclick="backButton_Click"/>
        </div>
    </form>
</body>
</html>
