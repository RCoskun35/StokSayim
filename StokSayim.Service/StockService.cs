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
    public class StockService : Service<Stock>,IStockService
    {
        private readonly IStockRepository _stockRepository;
        public StockService(IGenericRepository<Stock> repository,IUnitOfWork unitOfWork,IStockRepository stockRepository):base(repository,unitOfWork)
        {
            _stockRepository = stockRepository;
        }
    }
}
