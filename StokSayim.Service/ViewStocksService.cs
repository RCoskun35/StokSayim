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
    public class ViewStocksService : Service<ViewStocks>,IViewStocksService
    {
        private readonly IViewStocksRepository _viewStocksRepository;
        public ViewStocksService(IGenericRepository<ViewStocks> repository,IUnitOfWork unitOfWork,IViewStocksRepository viewStocksRepository):base(repository,unitOfWork)
        {
            _viewStocksRepository = viewStocksRepository;
        }
    }
}
