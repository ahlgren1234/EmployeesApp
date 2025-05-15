using EmployeesApp.Web.Models;

namespace EmployeesApp.Web.Services
{
    public class EmployeeService
    {
        private List<Employee> employees = new List<Employee>();

        public void Add(Employee employee)
        {
            employee.Id = employees.Count == 0 ? 1 : employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public Employee[] GetAll() => employees
            .OrderBy(e => e.Name)
            .ToArray();

        public Employee? GetById(int Id) => employees
            .SingleOrDefault(e => e.Id == Id);
    }
}
