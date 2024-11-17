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

    public ClientsIndividual() { }
    public ClientsIndividual(string clientId, string fullName, string passportDate, string dateOfBirth, string address, string email, string password)
    {
        ClientId = clientId;
        FullName = fullName;
        PassportDate = passportDate;
        BirthDate = dateOfBirth;
        Address = address;
        Email = email;
        Password = password;
    }
}
