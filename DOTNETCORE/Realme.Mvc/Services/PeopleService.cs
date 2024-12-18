using Realme.Mvc.Models;
using Realme.Mvc.Repositories;

namespace Realme.Mvc.Services
{
   
    public class PeopleService :BaseService
    {
        private readonly IRepository<Employee> _employeeRepository;

        public PeopleService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        // Other service methods...
    }

}
