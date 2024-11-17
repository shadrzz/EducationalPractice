﻿namespace EducationalPractice.Models.Client
{
    public class ClientIndividual
    {
        public string FullName { get; set; }
        public string ClientId { get; set; }
        public string PassportData { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ClientIndividual(string fullName, string clientId, string passportData, string dateOfBirth, string address, string email, string password)
        {
            FullName = fullName;
            ClientId = clientId;
            PassportData = passportData;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            Password = password;
        }
    }
}
