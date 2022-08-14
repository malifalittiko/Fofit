using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALCalısma
    {
        public static int CalısmaEkle(EntityCalısma parametre)
        {
            SqlCommand komut100 = new SqlCommand("insert into CALISMA (SPORCU_ID,GOGUS,SIRT,KOL,BACAK,KARIN,OMUZ,FULL_BODY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.bgl);

            if (komut100.Connection.State != ConnectionState.Open)
            {
                komut100.Connection.Open();
            }
            komut100.Parameters.AddWithValue("@p1", parametre.CID);
            komut100.Parameters.AddWithValue("@p2", parametre.Gogus);
            komut100.Parameters.AddWithValue("@p3", parametre.Sirt);
            komut100.Parameters.AddWithValue("@p4", parametre.Kol);
            komut100.Parameters.AddWithValue("@p5", parametre.Bacak);
            komut100.Parameters.AddWithValue("@p6", parametre.Karin);
            komut100.Parameters.AddWithValue("@p7", parametre.Omuz);
            komut100.Parameters.AddWithValue("@p8", parametre.Full);
            return komut100.ExecuteNonQuery();
        }
        public static List<EntityCalısma> CalısmaProgramı()
        {
            List<EntityCalısma> degerler = new List<EntityCalısma>();
            SqlCommand komut120 = new SqlCommand("Select * From CALISMA, KULLANICI", Baglanti.bgl);
            if (komut120.Connection.State != ConnectionState.Open)
            {
                komut120.Connection.Open();
            }
            SqlDataReader dr = komut120.ExecuteReader();
            while (dr.Read())
            {
                EntityCalısma ent = new EntityCalısma();
                ent.CID = Convert.ToInt32(dr["CALISMA_ID"].ToString());
               ent.Sid = Convert.ToInt32(dr["KULLANICI_ID"].ToString());
                ent.Gogus = dr["GOGUS"].ToString();
                ent.Sirt = dr["SIRT"].ToString();
                ent.Kol = dr["KOL"].ToString();
                ent.Bacak = dr["BACAK"].ToString();
                ent.Karin = dr["KARIN"].ToString();
                ent.Omuz = dr["OMUZ"].ToString();
                ent.Full = dr["FULL_BODY"].ToString();
   

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static List<EntityCalısma> CalısmaDetay(int id)
        {
            List<EntityCalısma> degerler = new List<EntityCalısma>();
            SqlCommand komut140 = new SqlCommand("Select * From CALISMA Where SPORCU_ID=@P1", Baglanti.bgl);
            komut140.Parameters.AddWithValue("@P1", id);
            if (komut140.Connection.State != ConnectionState.Open)
            {
                komut140.Connection.Open();
            }
            SqlDataReader dr = komut140.ExecuteReader();
            while (dr.Read())
            {
                EntityCalısma ent = new EntityCalısma();
                ent.Sid = Convert.ToInt32(dr["SPORCU_ID"].ToString());
                ent.Gogus = dr["GOGUS"].ToString();
                ent.Sirt = dr["SIRT"].ToString();
                ent.Kol = dr["KOL"].ToString();
                ent.Bacak = dr["BACAK"].ToString();
                ent.Karin = dr["KARIN"].ToString();
                ent.Omuz = dr["OMUZ"].ToString();
                ent.Full = dr["FULL_BODY"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool CalısmaGüncelle(EntityCalısma parametre18)//Entity Calısma Deger
        {
            SqlCommand komut150 = new SqlCommand("Update dbo.CALISMA Set SPORCU_ID=@P1,GOGUS=@P2,SIRT=@P3,KOL=@P4,BACAK=@P5,KARIN=@P6,OMUZ=@P7,FULL_BODY=@P8 WHERE CALISMA_ID=@P9", Baglanti.bgl);
            komut150.Parameters.AddWithValue("@P1", parametre18.Sid);
            komut150.Parameters.AddWithValue("@P2", parametre18.Gogus);
            komut150.Parameters.AddWithValue("@P3", parametre18.Sirt);
            komut150.Parameters.AddWithValue("@P4", parametre18.Kol);
            komut150.Parameters.AddWithValue("@P5", parametre18.Bacak);
            komut150.Parameters.AddWithValue("@P6", parametre18.Karin);
            komut150.Parameters.AddWithValue("@P7", parametre18.Omuz);
            komut150.Parameters.AddWithValue("@P8", parametre18.Full);
            komut150.Parameters.AddWithValue("@P9", parametre18.CID);
            return komut150.ExecuteNonQuery() >= 0;


        }
    }
}
