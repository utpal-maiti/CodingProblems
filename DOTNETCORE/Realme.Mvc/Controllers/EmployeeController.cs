using Microsoft.AspNetCore.Mvc;

using Realme.Mvc.Models;
using Realme.Mvc.Services;

namespace Realme.Mvc.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/employee")]
    public class EmployeeController : Controller
    {
        // Controller actions
        #region Property  
        private readonly IEmployeeService _employeeService;
        #endregion

        #region Constructor  
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int EmpID)
        {
            var result = await _employeeService.GetEmployeebyId(EmpID);
            return result;
        }
        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int EmpID)
        {
            var result = await _employeeService.GetEmployeeDetails(EmpID);
            return result;
        }
    }

}
