<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="PSDProject.Views.ViewTransactionHistory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Transaction History Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Transaction History"></asp:Label>
            <br />
            <asp:GridView ID="transactionHistoryView" runat="server" OnSelectedIndexChanging="transactionHistoryView_SelectedIndexChanging">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Select"></asp:CommandField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="backButton" runat="server" Text="Go Back" onclick="backButton_Click"/>
        </div>
    </form>
</body>
</html>
