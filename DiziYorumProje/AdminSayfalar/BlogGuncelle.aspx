<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="BlogGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.BlogGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <form runat="server" class="form-group">
        <div style="margin-top: 15px">
            <asp:TextBox ID="TxtBlogBaslık" runat="server" placeholder="Blog Başlık" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 15px">
            <asp:TextBox ID="TxtBlogTarih" runat="server" placeholder="Blog Tarih" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 15px">
            <asp:TextBox ID="TxtBlogGorsel" runat="server" placeholder="Blog Görsel" CssClass="form-control"></asp:TextBox>
        </div>
        <div style="margin-top: 15px">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div style="margin-top: 15px">
            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div style="margin-top: 15px">
            <textarea id="TextArea1" cols="20" rows="7" runat="server" class="form-control" placeholder="Blog İçerik" required=""></textarea>
        </div>
        <div style="margin-top: 25px">
            <asp:Button ID="BtnGuncelle" runat="server" Text="Güncelle" CssClass="btn btn-success" Width="150px" OnClick="BtnGuncelle_Click" />
        </div>

    </form>

</asp:Content>
