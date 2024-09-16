<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Yorumlar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Yorumlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>KULLANICI</th>
            <th>YORUMLAR</th>
            <th>BLOG</th>
            <th>SİL</th>
            <th>GÜNCELLE</th>
        </tr>

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("YORUMID") %></td>
                    <td><%#Eval("KULLANICIAD") %></td>
                     <td><%#Eval("YORUMICERIK") %></td>
                    <td><%#Eval("BLOGBASLIK") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"YorumSil.Aspx?YORUMID="+Eval("YORUMID") %>' CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                    <td>
                        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"YorumGuncelle.Aspx?YORUMID="+Eval("YORUMID") %>' runat="server" CssClass="btn btn-warning">GÜNCELLE</asp:HyperLink></td>

                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>

</asp:Content>
