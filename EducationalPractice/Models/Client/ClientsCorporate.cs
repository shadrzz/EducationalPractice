namespace EducationalPractice;

public partial class ClientsCorporate
{
    public int ClientId { get; set; }

    public string? CompanyName { get; set; }

    public string? Address { get; set; }

    public string? Inn { get; set; }

    public string? BankAccount { get; set; }

    public string? Bic { get; set; }

    public string? Ceoname { get; set; }

    public string? ContactPhone { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public ClientsCorporate() { }

    public ClientsCorporate(int clientId, string companyName, string address, string inn, string bankAccount, string bic,
                      string ceoName, string contactPhone, string email,
                      string password)
    {
        ClientId = clientId;
        CompanyName = companyName;
        Address = address;
        Inn = inn;
        BankAccount = bankAccount;
        Bic = bic;
        Ceoname = ceoName;
        ContactPhone = contactPhone;
        Email = email;
        Password = password;
    }
}