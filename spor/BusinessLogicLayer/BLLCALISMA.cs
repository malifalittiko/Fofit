using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLCALISMA
    {
        public static int CalısmaEkleBLL(EntityCalısma p)
        {
            if (p.Sid != 0 && p.Gogus != null && p.Sirt != null && p.Kol != null && p.Bacak != null && p.Karin != null && p.Omuz != null && p.Full != null)
            {
                return DALCalısma.CalısmaEkle(p);
            }
            return -1;
        }
        public static List<EntityCalısma> BllCalısmaProgramı()
        {
            return DALCalısma.CalısmaProgramı();
        }
        public static List<EntityCalısma> BllCalısmaDetay(int p)
        {
            return DALCalısma.CalısmaDetay(p);
        }
        public static bool CalısmaGuncelleBll(EntityCalısma p)
        {
            if (p.Sid != 0 && p.Gogus != null && p.Sirt != null && p.Kol != null && p.Bacak != null && p.Karin != null && p.Omuz != null && p.Full != null && p.CID > 0)
            {
                return DALCalısma.CalısmaGüncelle(p);
            }
            return false;
        }
    }
}
