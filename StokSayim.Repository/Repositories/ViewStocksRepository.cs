using StokSayim.Core.Models;
using StokSayim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Repository.Repositories
{
    public class ViewStocksRepository : GenericRepository<ViewStocks>, IViewStocksRepository
    {
        public ViewStocksRepository(AppDbContext context) : base(context)
        {
        }
    }
}
