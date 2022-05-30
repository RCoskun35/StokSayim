using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class ViewStocks
    {
        public string LokasyonAdi { get; set; }
        public int StokId { get; set; }
        public string StokKodu { get; set; }
        public string StokAciklamasi { get; set; }
        public float StokAdedi { get; set; }
        public string StokBirimi { get; set; }
        public int StokLokasyonId { get; set; }
        public DateTime StokSonKullanmaTarihi { get; set; }
        public string StokUrunAdi { get; set; }
        public bool StokDurumu { get; set; }
    }
}
