using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace spor
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Unnamed1_Click1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-8OLT44QL\SQLEXPRESS;Initial Catalog=Kullanici_id;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From KULLANICI where MAIL=@P1 AND SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", TextBox1.Text);
            komut.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Response.Redirect("Anasayfa.aspx");
            }
            else
            {
                Response.Write("Yanlış Girdin");
            }
            baglanti.Close();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
          
          Response.Redirect("Kaydol.aspx");
        }
    }
}