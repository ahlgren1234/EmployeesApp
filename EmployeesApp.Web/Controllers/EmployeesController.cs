using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeeService employeeService = new EmployeeService();

        [Route("")]
        public IActionResult Index()
        {
            var model = employeeService.GetAll();
            return View(model);
        }
    }
}
