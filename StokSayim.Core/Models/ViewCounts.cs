using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class ViewCounts
    {
        public int TerminalID { get; set; }
        public string StokKodu { get; set; }
        public bool SayimDurumu { get; set; }
        public float SayimMiktari { get; set; }
        public DateTime OkumaTarihi { get; set; }
        public DateTime GonderimTarihi { get; set; }
        public string OkuyanSoyadi { get; set; }
        public string OkuyanAdi { get; set; }
        public string OkuyanKimlikNo { get; set; }
        public bool LokasyonDurumu { get; set; }
        public string LokasyonAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public string UrunBirimi { get; set; }
        public float StokMiktari { get; set; }
        public DateTime SonKullanimTarihi { get; set; }
        public string UrunAdi { get; set; }
        public string TerminalIpAdresi { get; set; }
        public string TerminalAdi { get; set; }
    }
}
