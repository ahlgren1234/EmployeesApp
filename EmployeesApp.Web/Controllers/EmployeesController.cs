using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    EmployeeService employeeService = new EmployeeService();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = employeeService.GetAll();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(Employee employee)
    {
        employeeService.Add(employee);
        return RedirectToAction("Index");
    }
}
