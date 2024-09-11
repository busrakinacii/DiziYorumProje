<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Iletisim.aspx.cs" Inherits="DiziYorumProje.Iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İLETİŞİM</h2>
			 <p>BİZİMLE İLETİŞİME GEÇİN.</p>
		     </div>
			 <div class="contact-details">				 
			 <form runat="server">
				 <asp:TextBox ID="TxtAd" runat="server"  placeholder="Ad Soyad"></asp:TextBox>
				  <asp:TextBox ID="TxtMail" runat="server" placeholder="Mail"></asp:TextBox>
				  <asp:TextBox ID="TxtTelefon" runat="server" placeholder="Telefon"></asp:TextBox>
				  <asp:TextBox ID="TxtKonu" runat="server" placeholder="Konu"></asp:TextBox>
				<textarea id="TextArea1" cols="20" rows="2" placeholder="Mesajınız" runat="server"></textarea>

				 <asp:Button ID="BtnGonder" runat="server" Text="Gönder" OnClick="BtnGonder_Click" />
		
			 </form>
		  </div>
		  <div class="contact-details">
			  <div class="col-md-6 contact-map">
				 <h4>BİZ BURADAYIZ</h4>
				<div style="max-width:100%;list-style:none; transition: none;overflow:hidden;width:500px;height:500px;"><div id="my-map-display" style="height:100%; width:100%;max-width:100%;"><iframe style="height:100%;width:100%;border:0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=istanbul&key=AIzaSyBFw0Qbyq9zTFTd-tUY6dZWTgaQzuU17R8"></iframe></div><a class="google-map-code-enabler" rel="nofollow" href="https://www.bootstrapskins.com/themes" id="get-map-data">premium bootstrap themes</a><style>#my-map-display img{max-height:none;max-width:none!important;background:none!important;}</style></div>
			  </div>
			
			  <div class="clearfix"></div>
	     </div>		 


			 </div>
	 </div>
</div>

</asp:Content>
