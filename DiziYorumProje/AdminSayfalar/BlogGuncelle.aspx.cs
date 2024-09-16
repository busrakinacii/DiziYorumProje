using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Request.QueryString["BLOGID"]);

            if (Page.IsPostBack != true)
            {
                var turler = (from x in db.TBLTUR
                              select new
                              {
                                  x.TURID,
                                  x.TURAD
                              }).ToList();

                DropDownList1.DataTextField = "TURAD";
                DropDownList1.DataValueField = "TURID";
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();


                var kategori = (from t in db.TBLKATEGORI
                                select new
                                {
                                    t.KATEGORIID,
                                    t.KATEGORIAD
                                }).ToList();
                DropDownList2.DataValueField = "KATEGORIID";
                DropDownList2.DataTextField = "KATEGORIAD";
                DropDownList2.DataSource = kategori;
                DropDownList2.DataBind();

                var deger = db.TBLBLOG.Find(y);
                TxtBlogBaslık.Text = deger.BLOGBASLIK;
                TxtBlogTarih.Text = deger.BLOGTARIH.ToString();
                TxtBlogGorsel.Text = deger.BLOGGORSEL;
                TextArea1.Value = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();

            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var guncel = db.TBLBLOG.Find(y);
            guncel.BLOGBASLIK = TxtBlogBaslık.Text;
            guncel.BLOGTARIH = Convert.ToDateTime(TxtBlogTarih.Text);
            guncel.BLOGGORSEL = TxtBlogGorsel.Text;
            guncel.BLOGICERIK = TextArea1.Value;
            guncel.BLOGTUR =Convert.ToByte(DropDownList1.SelectedValue);
            guncel.BLOGKATEGORI=Convert.ToByte(DropDownList2.SelectedValue);
            db.SaveChanges();
            Response.Redirect("Bloglar.Aspx");

        }
    }
}