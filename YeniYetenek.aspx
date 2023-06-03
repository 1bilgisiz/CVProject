<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YeniYetenek.aspx.cs" Inherits="CvEntityProje.YeniYetenek" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4>YENİ YETENEK EKLEME SAYFASI</h4>
    <br />

    <asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeHolder="Yetenek Ekleyiniz"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-info" OnClick="Button1_Click" />
</asp:Content>
