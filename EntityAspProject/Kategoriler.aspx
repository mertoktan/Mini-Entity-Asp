<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Kategoriler.aspx.cs" Inherits="EntityAspProject.Kategoriler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>KATEGORİ ID</th>
            <th>KATEGORİ ADI</th>
            <th>GÜNCELLE</th>
            <th>SİL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server"><%--//DATALAR İÇİN REPEATER GEREKLİ--%>
            <ItemTemplate>
                <tr>
                    <td><%#Eval("KATEGORIID") %></td>
                    <td><%#Eval("KATEGORIAD") %></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriSil.aspx?KATEGORIID="+ Eval("KATEGORIID") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                    <td><asp:HyperLink NavigateUrl='<%#"~/KategoriGuncelle.Aspx?KATEGORIID="+ Eval("KATEGORIID") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
            </asp:Repeater>
    </table>
    <a href="KategoriEkle.aspx" class="btn btn-info">Yeni Kategori</a>
</asp:Content>
