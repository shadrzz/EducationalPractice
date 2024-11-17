using System;
using System.Collections.Generic;

namespace EducationalPractice;

public partial class Order
{
    public int Id { get; set; }

    public string? OrderNumber { get; set; }

    public string? CreationDate { get; set; }

    public string? ClientId { get; set; }

    public string? Services { get; set; }

    public string? Status { get; set; }

    public string? ClosureDate { get; set; }

    public string? EmployeeId { get; set; }

    public string? ExecutionTime { get; set; }

    public virtual Employee? Employee { get; set; }
}
