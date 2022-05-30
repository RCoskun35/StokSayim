using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Core.Models
{
    public class TerminalSetting:BaseEntity
    {
        public int TerminalId { get; set; }
        public bool MultipleCount { get; set; }
        public bool VerificationCount { get; set; }
        public bool Synchronicity { get; set; }
        public bool CheckCount { get; set; }
        public bool AutoCount { get; set; }
    }
}
