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
    public class LoginService : Service<Login>,ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(IGenericRepository<Login> repository,IUnitOfWork unitOfWork,ILoginRepository loginRepository):base(repository,unitOfWork)
        {
            _loginRepository = loginRepository;
        }
    }
}
