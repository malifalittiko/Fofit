using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace spor
{
    public partial class DiyetListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDiyet> DiyetListesi = BLLDiyet.BllDiyetListele();
            Repeater2.DataSource = DiyetListesi;
            Repeater2.DataBind();
        }
    }
}