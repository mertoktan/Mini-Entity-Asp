<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="KategoriGuncelle.aspx.cs" Inherits="EntityAspProject.KategoriGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" css="form-group">
         <div>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:TextBox ID="TxtAd" runat="server" placeholder="Kategori Adını Giriniz..." CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:Button  ID="Button1" runat="server" Text="Kategori Güncelle" CssClass="btn btn-success" OnClick="Button1_Click"/>
        </div>

    </form>

</asp:Content>
