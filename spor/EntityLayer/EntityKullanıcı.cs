using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityKullanıcı
    {
        private int kid;
        private string ad;
        private string soyad;
        private decimal boy;
        private decimal kilo;
        private int yas;
        private string cinsiyet;
        private string kan;
        private int? yag;
        private string mail;
        private string sifre;
        private bool statu;

        public bool Statu { get { return statu; } set { statu = value; } }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int KID { get => kid; set => kid = value; }
        public decimal Boy { get => boy; set => boy = value; }
        public decimal Kilo { get => kilo; set => kilo = value; }
        public int Yas { get => yas; set => yas = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Kan { get => kan; set => kan = value; }
        public int? Yag { get => yag; set => yag = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Sifre { get => sifre; set => sifre = value; }

    }
}
