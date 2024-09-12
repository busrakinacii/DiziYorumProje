using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }

        }

        protected void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TxtBlogBaslık.Text;
            t.BLOGTARIH = Convert.ToDateTime(TxtBlogTarih.Text);
            t.BLOGGORSEL = TxtBlogGorsel.Text;
            t.BLOGICERIK = TextArea1.Value;
            t.BLOGTUR = Convert.ToByte(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = Convert.ToByte(DropDownList2.SelectedValue);
            db.TBLBLOG.Add(t);
            db.SaveChanges();
            Response.Redirect("Bloglar.aspx");




        }
    }
}