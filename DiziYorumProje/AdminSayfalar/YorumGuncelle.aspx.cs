using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack != true)
            {
                var deger = db.TBLYORUM.Find(x);
                TxtBlogBaslık.Text = deger.TBLBLOG.BLOGBASLIK;
                TxtYorumKullanici.Text = deger.KULLANICIAD;
                TextArea1.Value = deger.YORUMICERIK;

            }
        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorum = db.TBLYORUM.Find(x);
            yorum.KULLANICIAD = TxtBlogBaslık.Text;
            yorum.YORUMICERIK = TextArea1.Value;
            db.SaveChanges();
            Response.Redirect("Yorumlar.aspx");
        }
    }
}