﻿using DiziYorumProje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DiziYorumProje.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        BlogDiziEntities db = new BlogDiziEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["BLOGID"]);

            var blog = db.TBLBLOG.Find(x);
            db.TBLBLOG.Remove(blog);
            db.SaveChanges();
            Response.Redirect("Bloglar.Aspx");


        }
    }
}