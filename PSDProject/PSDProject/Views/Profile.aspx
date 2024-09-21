<%@ Page Title="" Language="C#" MasterPageFile="~/Views/NavBar.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="PSDProject.Views.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Profile Page</h1>
    <asp:Label ID="Label5" runat="server" Text="Account Information"></asp:Label>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
    <asp:TextBox ID="usernameBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Email: "></asp:Label>
    <asp:TextBox ID="emailBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Gender: "></asp:Label>
    <asp:RadioButtonList ID="genderGroup" runat="server">
        <asp:ListItem>Female</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="Label4" runat="server" Text="Date of Birth: "></asp:Label>
    <asp:TextBox ID="dateBox" runat="server" TextMode="Date"></asp:TextBox>
    <br />
    <asp:Button ID="updateButton" runat="server" Text="Update Account" onclick="updateButton_Click"/>
    <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Change Password"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Old Password: "></asp:Label>
    <asp:TextBox ID="oldPassBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label8" runat="server" Text="New Password: "></asp:Label>
    <asp:TextBox ID="newPassBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="updatePassButton" runat="server" Text="Update Password" onclick="updatePassButton_Click"/>
    <br />
    <asp:Label ID="passErrorMessage" runat="server" Text=""></asp:Label>
</asp:Content>
