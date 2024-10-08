﻿using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

            Repeater1.DataSource = db.TBLBLOG.ToList();
            Repeater1.DataBind();

            Repeater2.DataSource = db.TBLKATEGORI.ToList();
            Repeater2.DataBind();

            Repeater3.DataSource = db.TBLBLOG.OrderByDescending(x => x.BLOGID).Take(4).ToList();
            Repeater3.DataBind();


            var query = (from yrm in db.TBLYORUM
                         join blg in db.TBLBLOG
                         on yrm.YORUMBLOG equals blg.BLOGID
                         select new
                         {
                             yrm.KULLANICIAD,
                             yrm.YORUMID,
                             blg.BLOGBASLIK,
                             yrm.YORUMICERIK,
                             blg.BLOGID

                         }).OrderByDescending(x =>x.YORUMID).Take(3).ToList();
            Repeater4.DataSource = query;
            Repeater4.DataBind();

        }
    }
}