using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class Location: BaseEntity
    {
        public float Quantity { get; set; }
        public string Unit { get; set; }
        public bool Read { get; set; }
       
    }
}
