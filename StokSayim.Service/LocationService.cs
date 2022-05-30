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
    public class LocationService : Service<Location>,ILocationService
    {
        private readonly ILocationRepository _locationRepository;
        public LocationService(IGenericRepository<Location> repository,IUnitOfWork unitOfWork,ILocationRepository locationRepository):base(repository,unitOfWork)
        {
            _locationRepository = locationRepository;
        }
    }
}
