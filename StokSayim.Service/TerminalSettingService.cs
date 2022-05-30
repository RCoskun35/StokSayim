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
    public class TerminalSettingService : Service<TerminalSetting>,ITerminalSettingService
    {
        private readonly ITerminalSettingRepository _terminalSettingRepository;
        public TerminalSettingService(IGenericRepository<TerminalSetting> repository,IUnitOfWork unitOfWork,ITerminalSettingRepository terminalSettingRepository):base(repository,unitOfWork)
        {
            _terminalSettingRepository = terminalSettingRepository;
        }
    }
}
