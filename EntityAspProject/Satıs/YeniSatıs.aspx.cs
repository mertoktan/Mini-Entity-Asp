﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityAspProject.Entity;

namespace EntityAspProject.Satıs
{
    public partial class YeniSatıs : System.Web.UI.Page
    {
        AspDbEntities db = new AspDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                var urun = (from x in db.Tbl_Urunler select new { x.URUNID, x.URUNAD }).ToList();
                DropDownList1.DataTextField = "URUNAD";
                DropDownList1.DataValueField = "URUNID";
                DropDownList1.DataSource = urun;
                DropDownList1.DataBind();

                var mus = (from x in db.Tbl_Musteri select new { x.MUSTERIID, ADSOYAD=x.MUSTERIAD +" "+ x.MUSTERISOYAD}).ToList();
                DropDownList2.DataTextField = "ADSOYAD";
                DropDownList2.DataValueField = "MUSTERIID";
                DropDownList2.DataSource = mus;
                DropDownList2.DataBind();

                var per = (from x in db.Tbl_Personel select new { x.PERSONELID, x.PERSONELADSOYAD}).ToList();
                DropDownList3.DataTextField = "PERSONELADSOYAD";
                DropDownList3.DataValueField = "PERSONELID";
                DropDownList3.DataSource = per;
                DropDownList3.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Tbl_Satıs t = new Tbl_Satıs();
            t.MUSTERI=int.Parse(DropDownList2.SelectedValue);
            t.URUN=int.Parse(DropDownList1.SelectedValue);
            t.PERSONEL=byte.Parse(DropDownList3.SelectedValue);
            t.FIYAT = decimal.Parse(Txtfıyat.Text);
            db.Tbl_Satıs.Add(t);
            db.SaveChanges();
            Response.Redirect("Satıslar.aspx");


        }
    }
}