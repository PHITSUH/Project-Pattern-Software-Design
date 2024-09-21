<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="PSDProject.Views.ManageMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Manage Makeup Page</h1>
    <asp:Label ID="makeupLabel" runat="server" Text="Makeups"></asp:Label>
    <br />
    <asp:GridView ID="makeupView" runat="server" OnRowDeleting="makeupView_RowDeleting" OnRowEditing="makeupView_RowEditing">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Actions"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="addMakeupButton" runat="server" Text="Add New Makeup" OnClick="addMakeupButton_Click"/>
    <br />
    <asp:Label ID="MakeupBrandLabel" runat="server" Text="Makeup Brands"></asp:Label>
    <br />
    <asp:GridView ID="makeupBrandView" runat="server" OnRowDeleting="makeupBrandView_RowDeleting" OnRowEditing="makeupBrandView_RowEditing">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Actions"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="addMakeupBrandButton" runat="server" Text="Add New Makeup Brand" OnClick="addMakeupBrandButton_Click"/>
    <br />
    <asp:Label ID="MakeupTypeLabel" runat="server" Text="Makeup Types"></asp:Label>
    <br />
    <asp:GridView ID="makeupTypeView" runat="server" OnRowDeleting="makeupTypeView_RowDeleting" OnRowEditing="makeupTypeView_RowEditing"> 
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ButtonType="Button" ShowHeader="True" HeaderText="Actions"></asp:CommandField>
        </Columns>
    </asp:GridView>
    <asp:Button ID="addMakeupTypeButton" runat="server" Text="Add New Makeup Type" OnClick="addMakeupTypeButton_Click"/>
</asp:Content>
