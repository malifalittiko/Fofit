using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;

namespace spor
{
    public partial class KullanıcıListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityKullanıcı> KullanıcıListesi = BLLKullanıcı.BllListele();
            Repeater1.DataSource = KullanıcıListesi;
            Repeater1.DataBind();

        }
    }
}