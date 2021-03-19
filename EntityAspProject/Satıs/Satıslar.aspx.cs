using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Satıs
{   
    
    public partial class Satıslar : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var satıs = db.Tbl_Satıs.ToList();

            var satıs = (from x in db.Tbl_Satıs
                        select new
                        {
                            x.SATISID,
                            x.Tbl_Urunler.URUNAD,
                            x.Tbl_Personel.PERSONELADSOYAD,
                            MUSTERI= x.Tbl_Musteri.MUSTERIAD +""+ x.Tbl_Musteri.MUSTERISOYAD,
                            x.FIYAT
                        }).ToList();
            
            Repeater1.DataSource = satıs;
            Repeater1.DataBind();
        }
    }
}