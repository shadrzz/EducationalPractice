using EducationalPractice.Forms;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ClientController
    {
        private readonly ApplicationDbContext _context;

        public ClientController(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool IsLegalEntity(string clientType)
        {
            return clientType == "Юридическое лицо (ЮЛ)";
        }

        public Form GetClientForm(string clientType)
        {
            if (IsLegalEntity(clientType))
            {
                return new ClientCorporateForm(this);
            }
            else
            {
                return new ClientIndividualForm(this);
            }
        }

        public bool DoesClientExist(string clientData, string clientType)
        {
            clientData = clientData.Trim();

            if (IsLegalEntity(clientType))
            {
                return _context.ClientsCorporates
                               .Any(client => client.CompanyName.Trim() == clientData);
            }
            return _context.ClientsIndividuals
                           .Any(client => client.FullName.Trim() == clientData);
        }

        public void AddIndividualClient(ClientsIndividual client)
        {
            _context.ClientsIndividuals.Add(client);
            _context.SaveChanges();
        }

        public void AddCorporateClient(ClientsCorporate client)
        {
            _context.ClientsCorporates.Add(client);
            _context.SaveChanges();
        }

        public ClientsIndividual GetIndividualClientData(string clientData)
        {
            return _context.ClientsIndividuals
                           .FirstOrDefault(client => client.FullName == clientData);
        }

        public ClientsCorporate GetCorporateClientData(string clientData)
        {
            return _context.ClientsCorporates
                           .FirstOrDefault(client => client.CompanyName == clientData);
        }

    }
}
