using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Urun
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {   //ÖNEMLİ
                var ktgr = (from x in db.Tbl_Kategori select new { x.KATEGORIID, x.KATEGORIAD }).ToList();
                DropDownList1.DataTextField = "KATEGORIAD";
                DropDownList1.DataValueField = "KATEGORIID";
                DropDownList1.DataSource = ktgr;
                DropDownList1.DataBind();


                int id = Convert.ToInt32(Request.QueryString["URUNID"]);
                var P = db.Tbl_Urunler.Find(id);
                Txturunad.Text = P.URUNAD.ToString();
                Txtstok.Text = P.URUNSTOK.ToString();
                Txtmarka.Text = P.URUNMARKA.ToString();
                Txtfıyat.Text = P.URUNFIYAT.ToString();
                DropDownList1.SelectedValue = P.URUNKATEGORI.ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["URUNID"]);

            var p = db.Tbl_Urunler.Find(id);


            p.URUNAD = Txturunad.Text;
            p.URUNSTOK = short.Parse(Txtstok.Text);
            p.URUNMARKA = Txtmarka.Text;
            p.URUNFIYAT = decimal.Parse(Txtfıyat.Text);
            p.URUNKATEGORI = byte.Parse(DropDownList1.SelectedValue.ToString());
            
            db.SaveChanges();
            Response.Redirect("Urunler.aspx");
        }
    }
}