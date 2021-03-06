using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.LinqKartlar
{
    public partial class İstatistik : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();

        protected void Page_Load(object sender, EventArgs e)
        {   
            Label1.Text = db.Tbl_Urunler.Count().ToString();
            Label2.Text = db.Tbl_Musteri.Count().ToString();
            Label3.Text = db.Tbl_Satıs.Sum(x=>x.FIYAT).ToString();
            Label4.Text = db.Tbl_Kategori.Count().ToString();
            Label5.Text = db.Tbl_Urunler.Count(x=>x.DURUM==true).ToString();
            Label6.Text = db.Tbl_Urunler.Count(x=>x.DURUM==false).ToString();
            Label7.Text = (from x in db.Tbl_Urunler orderby x.URUNSTOK descending select x.URUNAD).FirstOrDefault();
        }
    }
}