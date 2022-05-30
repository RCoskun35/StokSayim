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
    public class AuthorityService:Service<Authority>,IAuthorityService
    {
        private readonly IAuthorityRepository _authorityRepository;
        public AuthorityService(IGenericRepository<Authority> repository,IUnitOfWork unitOfWork,IAuthorityRepository authorityRepository):base(repository,unitOfWork)
        {
            _authorityRepository = authorityRepository;
        }
    }
}
