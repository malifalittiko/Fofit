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
    public partial class CalismaProgramiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["CALISMA_ID"].ToString());
            TxtSid.Text = x.ToString();
            TxtSid.Enabled = false;
           

            if (Page.IsPostBack == false)
            {

                List<EntityCalısma> CalısmaProgramı = BLLCALISMA.BllCalısmaDetay(x);
                TxtGogus.Text = CalısmaProgramı[0].Gogus.ToString();
                TxtSirt.Text = CalısmaProgramı[0].Sirt.ToString();
                TxtKol.Text = CalısmaProgramı[0].Kol.ToString();
                TxtBacak.Text = CalısmaProgramı[0].Bacak.ToString();
                TxtKarin.Text = CalısmaProgramı[0].Karin.ToString();
                TxtOmuz.Text = CalısmaProgramı[0].Omuz.ToString();
                TxtFull.Text = CalısmaProgramı[0].Full.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityCalısma ent = new EntityCalısma();
            ent.Gogus = TxtGogus.Text;
            ent.Sirt = TxtSirt.Text;
            ent.Kol = TxtKol.Text;
            ent.Bacak = TxtBacak.Text;
            ent.Karin = TxtKarin.Text;
            ent.Omuz = TxtOmuz.Text;
            ent.Full = TxtFull.Text;
            ent.Sid = Convert.ToInt32(TxtSid.Text);
            BLLCALISMA.CalısmaGuncelleBll(ent);
            Response.Redirect("CalısmaProgramı.Aspx");
        }
    }
}