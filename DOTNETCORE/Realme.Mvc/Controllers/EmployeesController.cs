using Microsoft.AspNetCore.Mvc;

namespace Realme.Mvc.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/employees")]
    public class EmployeesController : Controller
    {
        // Controller actions
        public EmployeesController()
        {
        }
    }

}
