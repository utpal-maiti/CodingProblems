using Realme.Mvc.Models;

namespace Realme.Mvc.Services
{
    public interface IEmployeeService
    {
        Task<Employee?> GetEmployeeByIdAsync(int id);
    }

}
