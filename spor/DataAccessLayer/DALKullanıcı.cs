using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALKullanıcı
    {
        public static int KullanıcıEkle(EntityKullanıcı parametre)
        {



            SqlCommand komut1 = new SqlCommand("insert into KULLANICI (AD,SOYAD,MAIL,SIFRE,BOY,KILO,YAS,CINSIYET,KAN_GRUBU,YAG_ORANI,STATU) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", Baglanti.bgl);

            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.Ad);
            komut1.Parameters.AddWithValue("@p2", parametre.Soyad);
            komut1.Parameters.AddWithValue("@p3", parametre.Mail);
            komut1.Parameters.AddWithValue("@p4", parametre.Sifre);
            komut1.Parameters.AddWithValue("@p5", parametre.Boy);
            komut1.Parameters.AddWithValue("@p6", parametre.Kilo);
            komut1.Parameters.AddWithValue("@p7", parametre.Yas);
            komut1.Parameters.AddWithValue("@p8", parametre.Cinsiyet);
            komut1.Parameters.AddWithValue("@p9", parametre.Kan);
            komut1.Parameters.AddWithValue("@p10", parametre.Yag);
            komut1.Parameters.AddWithValue("@p11", parametre.Statu);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntityKullanıcı> KullanıcıListesi()
        {
            List<EntityKullanıcı> degerler = new List<EntityKullanıcı>();
            SqlCommand komut2 = new SqlCommand("Select * From KULLANICI", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityKullanıcı ent = new EntityKullanıcı();
                ent.KID = Convert.ToInt32(dr["KULLANICI_ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Mail = dr["MAIL"].ToString();
                ent.Sifre = dr["SIFRE"].ToString();
                ent.Boy = Convert.ToInt16(dr["BOY"].ToString());
                ent.Kilo = Convert.ToInt16(dr["KILO"].ToString());
                ent.Yas = Convert.ToInt16(dr["YAS"].ToString());
                ent.Cinsiyet = dr["CINSIYET"].ToString();
                ent.Kan = dr["KAN_GRUBU"].ToString();
                ent.Yag = String.IsNullOrEmpty(dr["YAG_ORANI"].ToString()) ? (int?)null : int.Parse(dr["YAG_ORANI"].ToString());
               

                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool KullanıcıSil(int parametre2)
        {
            SqlCommand komut3 = new SqlCommand("Delete From dbo.KULLANICI where KULLANICI_ID=@P1", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", parametre2);
            return komut3.ExecuteNonQuery() > 0;

        }
        public static List<EntityKullanıcı> KullanıcıDetay(int id)
        {
            List<EntityKullanıcı> degerler = new List<EntityKullanıcı>();
            SqlCommand komut4 = new SqlCommand("Select * From KULLANICI Where KULLANICI_ID=@P1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@P1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityKullanıcı ent = new EntityKullanıcı();
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Mail = dr["MAIL"].ToString();
                ent.Sifre = dr["SIFRE"].ToString();
                ent.Boy = Convert.ToInt16(dr["BOY"].ToString());
                ent.Kilo = Convert.ToInt16(dr["KILO"].ToString());
                ent.Yas = Convert.ToInt16(dr["YAS"].ToString());
                ent.Cinsiyet = dr["CINSIYET"].ToString();
                ent.Kan = dr["KAN_GRUBU"].ToString();
                ent.Yag = String.IsNullOrEmpty(dr["YAG_ORANI"].ToString()) ? (int?)null : int.Parse(dr["YAG_ORANI"].ToString());
                ent.Statu = Convert.ToBoolean(dr["STATU"].ToString());


                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool KullanıcıGuncelle(EntityKullanıcı parametre3)//Entity Kullanıcı Deger
        {
            SqlCommand komut5 = new SqlCommand("Update dbo.KULLANICI Set AD=@P1,SOYAD=@P2,MAIL=@P3,SIFRE=@P4,BOY=@P5,KILO=@P6,YAS=@P7,CINSIYET=@P8,KAN_GRUBU=@P9,YAG_ORANI=@P10,STATU=@P12 WHERE KULLANICI_ID=@P11", Baglanti.bgl);
            komut5.Parameters.AddWithValue("@P1", parametre3.Ad);
            komut5.Parameters.AddWithValue("@P2", parametre3.Soyad);
            komut5.Parameters.AddWithValue("@P3", parametre3.Mail);
            komut5.Parameters.AddWithValue("@P4", parametre3.Sifre);
            komut5.Parameters.AddWithValue("@P5", parametre3.Boy);
            komut5.Parameters.AddWithValue("@P6", parametre3.Kilo);
            komut5.Parameters.AddWithValue("@P7", parametre3.Yas);
            komut5.Parameters.AddWithValue("@P8", parametre3.Cinsiyet);
            komut5.Parameters.AddWithValue("@P9", parametre3.Kan);
            komut5.Parameters.AddWithValue("@P10", parametre3.Yag);
            komut5.Parameters.AddWithValue("@P11", parametre3.KID);
            komut5.Parameters.AddWithValue("@P12", parametre3.Statu);

            return komut5.ExecuteNonQuery() > 0;
           
           
        }
    }
}

