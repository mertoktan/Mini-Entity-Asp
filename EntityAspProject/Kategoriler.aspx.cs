using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var degeler = db.Tbl_Kategori.ToList();
            Repeater1.DataSource = degeler;
            Repeater1.DataBind();
        }
    }
}