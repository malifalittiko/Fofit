using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLKullanıcı
    {
        public static int KullanıcıEkleBLL(EntityKullanıcı p)
        {
            if (p.Ad != null && p.Soyad != null && p.Mail != null && p.Sifre != null && p.Boy != 0 && p.Kilo != 0 && p.Yas != 0 && p.Cinsiyet != null && p.Kan != null && p.Yag != 0 && p.Yag<100)
            {
                return DALKullanıcı.KullanıcıEkle(p);
            }
            return -1;
        }
        public static List<EntityKullanıcı> BllListele()
        {
            return DALKullanıcı.KullanıcıListesi();
        }
        public static bool KullanıcıSilBll(int p)
        {
            if (p != 0)
            {
                return DALKullanıcı.KullanıcıSil(p);
            }
            return false;
        }
        public static List<EntityKullanıcı> BllDetay(int p)
        {
            return DALKullanıcı.KullanıcıDetay(p);
        }
        public static bool KullanıcıGuncelleBll(EntityKullanıcı p)
        {
            if (p.Ad != null && p.Soyad != null && p.Mail != null && p.Sifre != null && p.Boy != 0 && p.Kilo != 0 && p.Yas != 0 && p.Cinsiyet != null && p.Kan != null && p.Yag != 0 && p.KID > 0)
            {
                return DALKullanıcı.KullanıcıGuncelle(p);
            }
            return false;
        }

    }
}
