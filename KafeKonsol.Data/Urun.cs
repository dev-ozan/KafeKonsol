﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class Urun
    {
        public string UrunAd { get; set; } = string.Empty;

        public decimal BirimFiyat { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
