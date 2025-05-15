using System.ComponentModel.DataAnnotations;

namespace EmployeesApp.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter a name")]
        [RegularExpression("^[A-Z].*", ErrorMessage = "Name must begin with capitalized character")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Enter an e-mail")]
        [Display(Name= "E-mail")]
        public string Email { get; set; }
    }
}
