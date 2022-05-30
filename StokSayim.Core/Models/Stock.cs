using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class Stock:BaseEntity
    {
        public string Code { get; set; }
        public string Explanation { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
        public int LocationId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
