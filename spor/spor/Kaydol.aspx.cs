using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace spor
{
    public partial class Kaydol : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void Unnamed11_Click(object sender, EventArgs e, EntityKullanıcı p)
        {
            EntityKullanıcı ent = new EntityKullanıcı();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Mail = TxtMail.Text;
            ent.Sifre = TxtSifre.Text;
            ent.Cinsiyet = TxtCinsiyet.Text;
            ent.Kan = TxtKan.Text;
            ent.Boy = int.Parse(TxtBoy.Text);
            ent.Kilo = int.Parse(TxtKilo.Text);
            ent.Yas = int.Parse(TxtYas.Text);
            ent.Yag = int.Parse(TxtYag.Text);

            BLLKullanıcı.KullanıcıEkleBLL(ent);

            if (p.Ad != null && p.Soyad != null && p.Mail != null && p.Sifre != null && p.Boy != 0 && p.Kilo != 0 && p.Yas != 0 && p.Cinsiyet != null && p.Kan != null && p.Yag != 0 && p.Yag < 100)
            {
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("Yanlış Girdin");
            }
        }
    }
}