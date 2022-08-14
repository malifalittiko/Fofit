using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using BusinessLogicLayer;
using EntityLayer;

namespace spor
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["KULLANICI_ID"].ToString());
            TxtKullanıcıId.Text = x.ToString();
            TxtKullanıcıId.Enabled = false;
            
            if (Page.IsPostBack == false)
            { 
            
            List<EntityKullanıcı> KullanıcıListesi = BLLKullanıcı.BllDetay(x);
            TxtAd.Text = KullanıcıListesi[0].Ad.ToString();
            TxtSoyad.Text = KullanıcıListesi[0].Soyad.ToString();
            TxtMail.Text = KullanıcıListesi[0].Mail.ToString();
            TxtSifre.Text = KullanıcıListesi[0].Sifre.ToString();
            TxtBoy.Text = KullanıcıListesi[0].Boy.ToString();
            TxtKilo.Text = KullanıcıListesi[0].Kilo.ToString();
            TxtYas.Text = KullanıcıListesi[0].Yas.ToString();
            TxtCinsiyet.Text = KullanıcıListesi[0].Cinsiyet.ToString();
            TxtKan.Text = KullanıcıListesi[0].Kan.ToString();
            TxtYag.Text = KullanıcıListesi[0].Yag.ToString();

            }
        }
        protected void Unnamed12_Click(object sender, EventArgs e)
        {
            EntityKullanıcı ent = new EntityKullanıcı();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Mail = TxtMail.Text;
            ent.Boy = Convert.ToInt32(TxtBoy.Text);
            ent.Kilo = Convert.ToInt32(TxtKilo.Text);
            ent.Yas = Convert.ToInt32(TxtYas.Text);
            ent.Cinsiyet = TxtCinsiyet.Text;
            ent.Kan = TxtKan.Text;
            ent.Yag = Convert.ToInt32(TxtYag.Text);
            ent.KID = Convert.ToInt32(TxtKullanıcıId.Text);
            BLLKullanıcı.KullanıcıGuncelleBll(ent);
            Response.Redirect("KullanıcıListesi.Aspx");
        }
    }
}