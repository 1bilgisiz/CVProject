<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDeaty.aspx.cs" Inherits="CvEntityProje.MesajDeaty" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>Mesaj Detayları</h4>
    <br />   
     <asp:TextBox ID="txtadsoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
     <asp:TextBox ID="txtmail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
     <asp:TextBox ID="txtkonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
     <asp:TextBox ID="txtmesaj" TextMode="MultiLine" runat="server" CssClass="form-control" Height="100" Enabled="false"></asp:TextBox>

</asp:Content>
