namespace EducationalPractice.Models
{
    public class ClientCorporate
    {
        public string ClientCode { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string AccountNumber { get; set; }
        public string BIK { get; set; }
        public string CEOName { get; set; }
        public string ContactPersonName { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ClientCorporate(string companyName, string address, string inn, string accountNumber, string bik,
                      string ceoName, string contactPersonName, string contactPhone, string email,
                      string password, string clientCode)
        {
            CompanyName = companyName;
            Address = address;
            INN = inn;
            AccountNumber = accountNumber;
            BIK = bik;
            CEOName = ceoName;
            ContactPersonName = contactPersonName;
            ContactPhone = contactPhone;
            Email = email;
            Password = password;
            ClientCode = clientCode;
        }
    }
}
