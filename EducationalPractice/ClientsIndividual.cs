using System;
using System.Collections.Generic;

namespace EducationalPractice;

public partial class ClientsIndividual
{
    public string ClientId { get; set; } = null!;

    public string? FullName { get; set; }

    public string? PassportDate { get; set; }

    public string? BirthDate { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }
}
