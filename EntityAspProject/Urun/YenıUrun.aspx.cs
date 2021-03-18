using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Urun
{
    public partial class YeniÜrün : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var ktgr = (from x in db.Tbl_Kategori select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = ktgr;
                DropDownList1.DataBind();
            }
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {   
            
           
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Tbl_Urunler t = new Tbl_Urunler();
            t.URUNAD = Txturunad.Text;
            t.URUNSTOK = short.Parse(Txtstok.Text);
            t.URUNMARKA = Txtmarka.Text;
            t.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            t.URUNFIYAT = decimal.Parse(Txtfıyat.Text);

            db.Tbl_Urunler.Add(t);
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}