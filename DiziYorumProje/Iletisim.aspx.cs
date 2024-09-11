using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje
{
    public partial class Iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        BlogDiziEntities db = new BlogDiziEntities();
        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            TBLILETISIM t = new TBLILETISIM();
            t.ADSOYAD = TxtAd.Text;
            t.MAIL = TxtMail.Text;
            t.TELEFON = TxtTelefon.Text;
            t.KONU = TxtKonu.Text;
            t.MESAJ = TextArea1.Value;
            db.TBLILETISIM.Add(t);
            db.SaveChanges();
            //Response.Redirect("Iletisim.aspx");
            
        }
    }
}