using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Musterı
{
    public partial class Musterıler : System.Web.UI.Page
    {

        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var musterı = db.Tbl_Musteri.ToList();
            Repeater1.DataSource = musterı;
            Repeater1.DataBind();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {//BURADA HATA VAR DÜZELT!!!
                Tbl_Musteri t = new Tbl_Musteri();
                t.MUSTERIAD = TextBox1.Text;
                t.MUSTERISOYAD = TextBox2.Text;
                db.Tbl_Musteri.Add(t);
                db.SaveChanges();
                Response.Redirect("Musterıler.aspx");
            }
            
            
            

        }
    }
}