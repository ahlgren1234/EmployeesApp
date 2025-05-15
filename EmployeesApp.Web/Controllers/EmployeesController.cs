using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesApp.Web.Controllers;

public class EmployeesController : Controller
{
    static EmployeeService employeeService = new EmployeeService();

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
        if (!ModelState.IsValid)
            return View();
        employeeService.Add(employee);
        return RedirectToAction("Index");
    }

    [HttpGet("details/{Id}")]
    public IActionResult Details(int Id)
    {
        var model = employeeService.GetById(Id);
        return View(model);
    }
}
