using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject
{
    public partial class Login : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = (from x in db.Tbl_Admin where x.KULLANICI == TxtKullanıcıad.Text && x.SIFRE == TxtSifre1.Text select x);
            if (sorgu.Any())
            {
                Response.Redirect("Kategoriler.aspx");
            }
            else
            {
                Response.Write("HATALI BİLGİ GİRİŞİ");
            }
        }
    }
}