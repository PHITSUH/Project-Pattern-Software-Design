<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PSDProject.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 id="pageTitle" runat="server"></h1>
    <asp:GridView ID="customerView" runat="server">
    </asp:GridView>
</asp:Content>

