using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.Login_Sayfa
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BlogDiziEntities db = new BlogDiziEntities();
        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where
                        TxtKullaniciAd.Text == x.KULLANICI && TxtSifre.Text == x.SIFRE
                        select x;
            if (sorgu.Any())
            {
                Session.Add("KULLANICI", TxtKullaniciAd.Text);
                Response.Redirect("/AdminSayfalar/Bloglar.aspx");
            }
            else
            {
                Response.Write("<script>alert('Kullanıcı adı veya şifre hatalı!')</script>");
            }



        }
    }
}