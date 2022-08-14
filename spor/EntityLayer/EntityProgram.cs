using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityProgram
    {
        private int pid;
        public int PID { get => pid; set => pid = value; }

        private string tekrar;
        public string Tekrar { get => tekrar; set => tekrar = value; }

        private int eklkısı;
        public int EklKısı { get => eklkısı; set => eklkısı = value; }

        private string ekltarih;
        public string EklTarih { get => ekltarih; set => ekltarih = value; }

        private int gunckisi;
        public int GuncKisi { get => gunckisi; set => gunckisi = value; }

        private string gunctarih;
        public string GuncTarih { get => gunctarih; set => gunctarih = value; }
    }
}
