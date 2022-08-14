using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDiyet
    {
        public static int DiyetEkleBLL(EntityDiyet p)
        {
            if (p.Vakit != null && p.Ptesi != null && p.Sali != null && p.Cars != null && p.Pers != null && p.Cuma != null && p.Ctesi != null && p.Pazar != null)
            {
                return DALDiyet.DiyetEkle(p);
            }
            return -1;
        }
        public static List<EntityDiyet> BllDiyetListele()
        {
            return DALDiyet.DiyetListesi();
        }
        public static List<EntityDiyet> BllDiyetDetay(int p)
        {
            return DALDiyet.DiyetDetay(p);
        }
        public static bool DiyetGuncelleBll(EntityDiyet p)
        {
            if (p.Vakit != null && p.Ptesi != null && p.Sali != null && p.Cars != null && p.Pers != null && p.Cuma != null && p.Ctesi != null && p.Pazar != null && p.Did > 0)
            {
                return DALDiyet.DiyetGüncelle(p);
            }
            return false;
        }
    }
}
