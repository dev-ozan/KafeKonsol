﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class SiparisDetay
    {
        public string UrunAd { get; set; } = string.Empty;

        public decimal BirimFiyat { get; set; }

        public int Adet { get; set; }

        public string TutarTL { get; } = string.Empty;

        public decimal Tutar()
        {
            return 0;
        }

    }
}
