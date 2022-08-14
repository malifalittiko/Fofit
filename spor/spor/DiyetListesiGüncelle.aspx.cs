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
    public partial class DiyetListesiGüncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["DIYET_ID"].ToString());
            TxtDiyetId.Text = x.ToString();
            TxtDiyetId.Enabled = false;

            if (Page.IsPostBack == false)
            {

                List<EntityDiyet> KullanıcıListesi = BLLDiyet.BllDiyetDetay(x);
                TxtVakit.Text = KullanıcıListesi[0].Vakit.ToString();
                TxtPtesi.Text = KullanıcıListesi[0].Ptesi.ToString();
                TxtSali.Text = KullanıcıListesi[0].Sali.ToString();
                TxtCars.Text = KullanıcıListesi[0].Cars.ToString();
                TxtPers.Text = KullanıcıListesi[0].Pers.ToString();
                TxtCuma.Text = KullanıcıListesi[0].Cuma.ToString();
                TxtCtesi.Text = KullanıcıListesi[0].Ctesi.ToString();
                TxtPazar.Text = KullanıcıListesi[0].Pazar.ToString();
            }
        }
            protected void Unnamaed14_Click(object sender, EventArgs e)
            {
                EntityDiyet ent = new EntityDiyet();
                ent.Vakit = TxtVakit.Text;
                ent.Ptesi = TxtPtesi.Text;
                ent.Sali = TxtSali.Text;
                ent.Cars = TxtCars.Text;
                ent.Pers = TxtPers.Text;
                ent.Cuma = TxtCuma.Text;
                ent.Ctesi = TxtCtesi.Text;
                ent.Pazar = TxtPazar.Text;
                ent.Did = Convert.ToInt32(TxtDiyetId.Text);
                BLLDiyet.DiyetGuncelleBll(ent);
                Response.Redirect("DiyetListesi.Aspx");
            }
        }
    }
