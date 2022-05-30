using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class Login:BaseEntity
    {
        public string SurName { get; set; }
        public string EMail { get; set; }

        public int AuthorityId { get; set; }
        


    }
}
