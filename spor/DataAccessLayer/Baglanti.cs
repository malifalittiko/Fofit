using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-8OLT44QL\SQLEXPRESS;Initial Catalog=Kullanici_id;Integrated Security=True");
    }
}
