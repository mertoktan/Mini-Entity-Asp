using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject
{
    public partial class KategoriSil : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x =Convert.ToInt32(Request.QueryString["KATEGORIID"]);
            var p = db.Tbl_Kategori.Find(x);
            db.Tbl_Kategori.Remove(p);
            db.SaveChanges();
            Response.Redirect("Kategoriler.aspx");

        }
    }
}