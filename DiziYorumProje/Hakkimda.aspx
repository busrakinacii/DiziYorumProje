<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="DiziYorumProje.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="about-content">
        <div class="container">
            <h2>HAKKIMIZDA</h2>
            <div class="about-section">

                <div class="about-grid2">
                    <h3>Hakkımızda Yazısı Ve Sayfamızda Bulunan Kategoriler</h3>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>

                            <p><%#Eval("ACIKLAMA") %> </p>

                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:Repeater ID="Repeater2" runat="server">
                        <ItemTemplate>
                            <ul>
                                <li><a href="#"><%#Eval("KATEGORIAD") %></a></li>

                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
                <div class="who-iam">

                    <div class="man-pic">
                        <img src="web/images/man.jpg" alt="" />
                    </div>
                    <div class="clearfix"></div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
