//using EducationalPractice.Forms;
//using EducationalPractice.Models.Client;
//using EducationalPractice.Utils;

//namespace EducationalPractice.Controllers
//{
//    public class ClientController
//    {
//        private List<ClientCorporate> corporateClients;
//        private List<ClientIndividual> individualClients;

//        public ClientController()
//        {
//            corporateClients = DataInitializer.GetCorporateClients();
//            individualClients = DataInitializer.GetIndividualClients();
//        }

//        public bool IsLegalEntity(string clientType)
//        {
//            return clientType == "Юридическое лицо (ЮЛ)";
//        }

//        public Form GetClientForm(string clientType)
//        {
//            if (IsLegalEntity(clientType))
//            {
//                return new ClientCorporateForm(this);
//            }
//            else
//            {
//                return new ClientIndividualForm(this);
//            }
//        }

//        public bool DoesClientExist(string clientData, string clientType)
//        {
//            if (IsLegalEntity(clientType))
//            {
//                return corporateClients.Any(client => client.CompanyName == clientData);
//            }
//            return individualClients.Any(client => client.FullName == clientData);
//        }

//        public void AddIndividualClient(ClientIndividual client)
//        {
//            individualClients.Add(client);
//        }

//        public void AddCorporateClient(ClientCorporate client)
//        {
//            corporateClients.Add(client);
//        }

//        public ClientIndividual GetIndividualClientData(string clientData)
//        {
//            return individualClients.FirstOrDefault(client => client.FullName == clientData);
//        }

//        public ClientCorporate GetCorporateClientData(string clientData)
//        {
//            return corporateClients.FirstOrDefault(client => client.CompanyName == clientData);
//        }

//        public List<ClientCorporate> GetCorporateClients() => corporateClients;
//        public List<ClientIndividual> GetIndividualClients() => individualClients;
//    }
//}

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
            if (IsLegalEntity(clientType))
            {
                return _context.ClientsCorporates.Any(client => client.CompanyName == clientData);
            }
            return _context.ClientsIndividuals.Any(client => client.FullName == clientData);
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

        public List<ClientsCorporate> GetCorporateClients()
        {
            return _context.ClientsCorporates.ToList();
        }

        public List<ClientsIndividual> GetIndividualClients()
        {
            return _context.ClientsIndividuals.ToList();
        }
    }
}
