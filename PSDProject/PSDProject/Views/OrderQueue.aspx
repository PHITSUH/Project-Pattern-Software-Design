<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="PSDProject.Views.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Order Queue Page</h1>
    <asp:Label  ID="Label1" runat="server" Text="Handled Transactions"></asp:Label>
    <asp:GridView ID="handledTransactionView" runat="server"></asp:GridView>
    <asp:Label ID="Label2" runat="server" Text="Unhandled Transactions"></asp:Label>
    <asp:GridView ID="unhandledTransactionView" runat="server" OnSelectedIndexChanging="unhandledTransactionView_SelectedIndexChanging">
        <Columns>
            <asp:CommandField ShowSelectButton="true" ShowHeader="True" HeaderText="Handle" ></asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="Label3" runat="server" Text="Selected Transaction: "></asp:Label>
    <asp:Label ID="selected" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="handleButton" runat="server" Text="Handle Button" onclick="handleButton_Click"/>
</asp:Content>
