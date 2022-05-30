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
    public class GetCountsService : Service<GetCounts>,IGetCountsService
    {
        private readonly IGetCountsRepository _getCountsRepository;
        public GetCountsService(IGenericRepository<GetCounts> repository,IUnitOfWork unitOfWork,IGetCountsRepository getCountsRepository):base(repository,unitOfWork)
        {
            _getCountsRepository = getCountsRepository;
        }
    }
}
