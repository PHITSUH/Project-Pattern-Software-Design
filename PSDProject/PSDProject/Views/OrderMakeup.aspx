<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="PSDProject.Repository.OrderMakeup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Order Makeup Page</h1>
            <asp:Label ID="Label1" runat="server" Text="Makeups"></asp:Label>
            <asp:GridView ID="makeupView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="makeupView_SelectedIndexChanging">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ShowHeader="True" HeaderText="Order"></asp:CommandField>
                    <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID"></asp:BoundField>
                    <asp:BoundField DataField="MakeupName" HeaderText="Makeup Name" SortExpression="MakeupName"></asp:BoundField>
                    <asp:BoundField DataField="MakeupWeight" HeaderText="Makeup Weight" SortExpression="MakeupWeight"></asp:BoundField>
                    <asp:BoundField DataField="MakeupPrice" HeaderText="Makeup Price" SortExpression="MakeupPrice"></asp:BoundField>
                    <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Makeup Brand Name" SortExpression="MakeupBrand.MakeupBrandName"></asp:BoundField>
                    <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Makeup Type Name" SortExpression="MakeupType.MakeupTypeName"></asp:BoundField>
                    
                </Columns>
            </asp:GridView>
            <asp:Label ID="a" runat="server" Text="Makeup Selected: "></asp:Label>
            <asp:Label ID="makeupSelected" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Quantity: "></asp:Label>
            <asp:TextBox ID="quantityBox" runat="server" TextMode="Number" Text="0"></asp:TextBox>
            <br />
            <asp:Button ID="addButton" runat="server" Text="Add to Cart" onclick="addButton_Click"/>
            <asp:Button ID="backButton" runat="server" Text="Go Back to Home" onclick="backButton_Click"/>
            <br />
            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
            <asp:GridView ID="cartView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Makeup.MakeupName" HeaderText="MakeupName" SortExpression="Makeup.MakeupName"></asp:BoundField>
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="clearCartButton" runat="server" Text="Clear Cart" Visible="false" OnClick="clearCartButton_Click"/>
            <asp:Button ID="orderButton" runat="server" Text="Order Makeup" Visible="false" OnClick="orderButton_Click"/>
        </div>
    </form>
</body>
</html>
