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
    public class ViewCountsService : Service<ViewCounts>,IViewCountsService
    {
        private readonly IViewCountsRepository _viewCountsRepository;
        public ViewCountsService(IGenericRepository<ViewCounts> repository,IUnitOfWork unitOfWork,IViewCountsRepository viewCountsRepository) :base(repository,unitOfWork)
        {
            _viewCountsRepository = viewCountsRepository;
        }
    }
}
