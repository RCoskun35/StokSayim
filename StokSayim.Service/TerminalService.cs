using StokSayim.Core.Models;
using StokSayim.Core.Repositories;
using StokSayim.Core.Services;
using StokSayim.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Service
{
    public class TerminalService : Service<Terminal>,ITerminalService
    {
        private readonly ITerminalRepository _terminalRepository;
        public TerminalService(IGenericRepository<Terminal> repository,IUnitOfWork unitOfWork,ITerminalRepository terminalRepository):base(repository,unitOfWork)
        {
            _terminalRepository = terminalRepository;
        }
    }
}
