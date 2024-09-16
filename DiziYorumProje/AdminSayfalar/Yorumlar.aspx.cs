using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorum = (from x in db.TBLYORUM
                         select new
                         {
                             x.YORUMID,
                             x.KULLANICIAD,
                             x.TBLBLOG.BLOGBASLIK,
                             x.YORUMICERIK
                         }).ToList();
            Repeater1.DataSource = yorum;
            Repeater1.DataBind();
        }
    }
}