using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKonsol.Data
{
    public class Siparis
    {
        public int MasaNo { get; set; }
        public SiparisDurum Durum { get; set; }
        public decimal OdenenTutar { get; set; }
        public DateTime AcilisZamani { get; set; } = DateTime.Now;
        public DateTime? KapanisZamani { get; set; }   // kALKACAĞI ZAMAN BELLİ OLMADIĞI İÇİN  dATETİME NULLABLE GİRİLEBİLİR YANİ NESNE TANIMLANIRKEN TANIMALAMASAKTA OLUR
        public List<SiparisDetay> SiparisDetaylar { get; set; } = new List<SiparisDetay>(); // new() kullanılabilr
        public string ToplamTutarTL { get; } = string.Empty;
        public decimal ToplamTutar() => SiparisDetaylar.Sum(x => x.Tutar());
        public string ToplamTutarTl => ToplamTutar().ToString("c2");

    }
}
