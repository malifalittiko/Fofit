using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDiyet
    {
        private int did;
        private string vakit;
        private string ptesi;
        private string sali;
        private string cars;
        private string pers;
        private string cuma;
        private string ctesi;
        private string pazar;

        public int Did { get => did; set => did = value; }
        public string Vakit { get => vakit; set => vakit = value; }
        public string Ptesi { get => ptesi; set => ptesi = value; }
        public string Sali { get => sali; set => sali = value; }
        public string Cars { get => cars; set => cars = value; }
        public string Pers { get => pers; set => pers = value; }
        public string Cuma { get => cuma; set => cuma = value; }
        public string Ctesi { get => ctesi; set => ctesi = value; }
        public string Pazar { get => pazar; set => pazar = value; }

    }
}
