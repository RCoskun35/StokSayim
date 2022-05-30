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
    public class EmployeeService : Service<Employee>,IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IGenericRepository<Employee> repository,IUnitOfWork unitOfWork,IEmployeeRepository employeeRepository):base(repository,unitOfWork)
        {
            _employeeRepository = employeeRepository;
        }
    }
}
