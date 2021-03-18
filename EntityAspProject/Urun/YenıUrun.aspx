<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YenıUrun.aspx.cs" Inherits="EntityAspProject.Urun.YeniÜrün" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" css="form-group">
        <div>
            <asp:TextBox ID="Txturunad" runat="server" placeholder="Ürün Adını Giriniz..." CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:TextBox ID="Txtmarka" runat="server" placeholder="Ürün Markasını Giriniz..." CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:TextBox ID="Txtfıyat" runat="server" placeholder="Ürün Fiyatını Giriniz..." CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:TextBox ID="Txtstok" runat="server" placeholder="Ürün Stoğunu Giriniz..." CssClass="form-control"></asp:TextBox>

        </div>
        <br />
        <div>
            <asp:Button  ID="Button1" runat="server" Text="Ürün Ekle" CssClass="btn btn-info" OnClick="Button1_Click1" />
        </div>

    </form>


</asp:Content>
