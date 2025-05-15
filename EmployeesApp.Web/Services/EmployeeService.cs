using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee[] GetAll() => employees
            .OrderBy(e => e.Name)
            .ToArray();

        public Employee? GetById(int Id) => employees
            .SingleOrDefault(e => e.Id == Id);
    }
}
