namespace EducationalPractice.Models
{
    internal class Employee
    {
        public string EmployeeCode { get; set; }
        public string Position { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<int> Services { get; set; }
        public string LastLogin { get; set; }

        public Employee(string employeeCode, string position, string fullName, string login, string password, List<int> services, string lastLogin)
        {
            EmployeeCode = employeeCode;
            Position = position;
            FullName = fullName;
            Login = login;
            Password = password;
            Services = services ?? new List<int>();
            LastLogin = lastLogin;
        }
    }
}
