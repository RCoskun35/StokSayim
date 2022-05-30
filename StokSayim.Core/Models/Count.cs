using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class Count:BaseEntity
    {
        
        public string Code { get; set; }
      
        public float Quantity { get; set; }
       
        public int LocationId { get; set; }
        public int TerminalId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReadDate { get; set; }
        public DateTime SendDate { get; set; }
        


    }
}
