<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IoTEvKontrol.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Led Aç" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Led Kapat" />
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Sıcaklık" />
    <asp:Button ID="Button4" runat="server" OnClick="Nem_Click" Text="Nem" />
    <asp:Label ID="Label1" runat="server" Text="Durum : ---"></asp:Label>
    
</asp:Content>
