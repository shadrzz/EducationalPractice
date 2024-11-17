using System;
using System.Collections.Generic;

namespace EducationalPractice.Models;

public partial class Employee
{
    public string EmployeeId { get; set; } = null!;

    public string? Position { get; set; }

    public string? FullName { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? LastLogin { get; set; }

    public string? Services { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
