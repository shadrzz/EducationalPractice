using System.ComponentModel.DataAnnotations;

namespace EducationalPractice.Models.Client
{
    public class ClientIndividual
    {
        [Key]
        public string ClientId { get; set; }
        public string FullName { get; set; }
        public string PassportData { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ClientIndividual(string clientId, string fullName, string passportData, string dateOfBirth, string address, string email, string password)
        {
            ClientId = clientId;
            FullName = fullName;
            PassportData = passportData;
            DateOfBirth = dateOfBirth;
            Address = address;
            Email = email;
            Password = password;
        }
    }
}
