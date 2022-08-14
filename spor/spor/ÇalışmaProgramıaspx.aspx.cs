using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace spor
{
    public partial class CalısmaProgramıaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
                List<EntityCalısma> CalısmaProgramıaspx = BLLCALISMA.BllCalısmaProgramı();
            Repeater1.DataSource = CalısmaProgramıaspx;
            Repeater1.DataBind();
        }

        
    }
}