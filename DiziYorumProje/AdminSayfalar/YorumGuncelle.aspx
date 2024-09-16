<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YorumGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.YorumGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form runat="server" class="form-group">
        <div style="margin-top: 15px">
            <asp:TextBox ID="TxtBlogBaslık" runat="server" placeholder="Blog Başlık" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
        <div style="margin-top: 15px">
            <asp:TextBox ID="TxtYorumKullanici" runat="server" placeholder="Kullanıcı Adı" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 15px">
            <textarea id="TextArea1" cols="20" rows="7" runat="server" class="form-control" placeholder="Yorum İçerik" required=""></textarea>
        </div>
        <div style="margin-top: 25px">
            <asp:Button ID="BtnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-success" Width="150px" OnClick="BtnKaydet_Click" />
        </div>

    </form>

</asp:Content>
