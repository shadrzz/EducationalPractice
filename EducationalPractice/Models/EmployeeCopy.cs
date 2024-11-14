using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducationalPractice.Models
{
    public class EmployeeCopy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Устанавливаем автоинкремент
        public int EmployeeID { get; set; }

        public string Position { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string LastLogin { get; set; }

        public string? Services { get; set; }

        public EmployeeCopy() { }
        public EmployeeCopy(string position, string fullName, string login, string password, string lastLogin, string? services)
        {
            Position = position;    
            FullName = fullName;
            Login = login;
            Password = password;
            Services = services;
            LastLogin = lastLogin;
        }
    }
}
