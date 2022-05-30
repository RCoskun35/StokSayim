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
    public class CountService : Service<Count>,ICountService
    {
        private readonly ICountRepository _countRepository;
        public CountService(IGenericRepository<Count> repository,IUnitOfWork unitOfWork,ICountRepository countRepository):base(repository,unitOfWork)
        {
            _countRepository = (ICountRepository?)repository;
        }
    }
}
