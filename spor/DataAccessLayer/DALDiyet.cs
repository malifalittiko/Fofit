using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALDiyet
    {
        public static int DiyetEkle(EntityDiyet parametre)
        {
            SqlCommand komut10 = new SqlCommand("insert into DIYET (VAKIT,PTESI,SALI,CARS,PERS,CUMA,CTESI,PAZAR) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", Baglanti.bgl);

            if (komut10.Connection.State != ConnectionState.Open)
            {
                komut10.Connection.Open();
            }
            komut10.Parameters.AddWithValue("@p1", parametre.Vakit);
            komut10.Parameters.AddWithValue("@p2", parametre.Ptesi);
            komut10.Parameters.AddWithValue("@p3", parametre.Sali);
            komut10.Parameters.AddWithValue("@p4", parametre.Cars);
            komut10.Parameters.AddWithValue("@p5", parametre.Pers);
            komut10.Parameters.AddWithValue("@p6", parametre.Cuma);
            komut10.Parameters.AddWithValue("@p7", parametre.Ctesi);
            komut10.Parameters.AddWithValue("@p8", parametre.Pazar);
            return komut10.ExecuteNonQuery();
        }
        public static List<EntityDiyet> DiyetListesi()
        {
            List<EntityDiyet> degerler = new List<EntityDiyet>();
            SqlCommand komut12 = new SqlCommand("Select * From DIYET", Baglanti.bgl);
            if (komut12.Connection.State != ConnectionState.Open)
            {
                komut12.Connection.Open();
            }
            SqlDataReader dr = komut12.ExecuteReader();
            while (dr.Read())
            {
                EntityDiyet ent = new EntityDiyet();
                ent.Did = Convert.ToInt32(dr["DIYET_ID"].ToString());
                ent.Vakit = dr["VAKIT"].ToString();
                ent.Ptesi = dr["PTESI"].ToString();
                ent.Sali = dr["SALI"].ToString();
                ent.Cars = dr["CARS"].ToString();
                ent.Pers = dr["PERS"].ToString();
                ent.Cuma = dr["CUMA"].ToString();
                ent.Ctesi = dr["CTESI"].ToString();
                ent.Pazar = dr["PAZAR"].ToString();

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
      
        public static List<EntityDiyet> DiyetDetay(int id)
        {
            List<EntityDiyet> degerler = new List<EntityDiyet>();
            SqlCommand komut14 = new SqlCommand("Select * From DIYET Where DIYET_ID=@P1", Baglanti.bgl);
            komut14.Parameters.AddWithValue("@P1", id);
            if (komut14.Connection.State != ConnectionState.Open)
            {
                komut14.Connection.Open();
            }
            SqlDataReader dr = komut14.ExecuteReader();
            while (dr.Read())
            {
                EntityDiyet ent = new EntityDiyet();
                ent.Vakit = dr["VAKIT"].ToString();
                ent.Ptesi = dr["PTESI"].ToString();
                ent.Sali = dr["SALI"].ToString();
                ent.Cars = dr["CARS"].ToString();
                ent.Pers = dr["PERS"].ToString();
                ent.Cuma = dr["CUMA"].ToString();
                ent.Ctesi = dr["CTESI"].ToString();
                ent.Pazar = dr["PAZAR"].ToString();
              
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool DiyetGüncelle(EntityDiyet parametre13)//Entity Diyet Deger
        {
            SqlCommand komut15 = new SqlCommand("Update dbo.DIYET Set VAKIT=@P1,PTESI=@P2,SALI=@P3,CARS=@P4,PERS=@P5,CUMA=@P6,CTESI=@P7,PAZAR=@P8 WHERE DIYET_ID=@P9", Baglanti.bgl);
            komut15.Parameters.AddWithValue("@P1", parametre13.Vakit);
            komut15.Parameters.AddWithValue("@P2", parametre13.Ptesi);
            komut15.Parameters.AddWithValue("@P3", parametre13.Sali);
            komut15.Parameters.AddWithValue("@P4", parametre13.Cars);
            komut15.Parameters.AddWithValue("@P5", parametre13.Pers);
            komut15.Parameters.AddWithValue("@P6", parametre13.Cuma);
            komut15.Parameters.AddWithValue("@P7", parametre13.Ctesi);
            komut15.Parameters.AddWithValue("@P8", parametre13.Pazar);
            komut15.Parameters.AddWithValue("@P9", parametre13.Did);
            return komut15.ExecuteNonQuery() >= 0;


        }
    }
}
