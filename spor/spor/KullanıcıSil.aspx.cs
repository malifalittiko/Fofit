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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(Request.QueryString["KULLANICI_ID"]);
            Response.Write(x);
            EntityKullanıcı ent = new EntityKullanıcı();
            ent.KID = x;
            BLLKullanıcı.KullanıcıSilBll(ent.KID);
            Response.Redirect("KullanıcıListesi.aspx");
        }
    }
}