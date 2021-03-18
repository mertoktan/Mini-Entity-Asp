using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Urun
{
    public partial class UrunSil : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);

            var urun = db.Tbl_Urunler.Find(id);
            urun.DURUM = false;
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");

        }
    }
}