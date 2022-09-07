using System;
using System.Collections.Generic;
using System.Text;

namespace yazlab11.GUI_2
{
   internal class Pozisyonlar
    {
        internal static Pozisyonlar result;
        public string KargoID { get; set; }
        public string KargoAdi { get; set; }
        public string KargoTuru { get; set; }
        public string KargoDurum { get; set; }
        public string KargoAdres { get; set; }
        public double KargoEnlem { get; set; }
        public double KargoBoylam { get; set; }
        public double BirdDistance { get; set; }
    }
}
