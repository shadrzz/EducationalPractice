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
using EducationalPractice.Models.Client;
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
                return _context.ClientsCorporate.Any(client => client.CompanyName == clientData);
            }
            return _context.ClientsIndividual.Any(client => client.FullName == clientData);
        }

        public void AddIndividualClient(ClientIndividual client)
        {
            _context.ClientsIndividual.Add(client);
            _context.SaveChanges();
        }

        public void AddCorporateClient(ClientCorporate client)
        {
            _context.ClientsCorporate.Add(client);
            _context.SaveChanges();
        }

        public ClientIndividual GetIndividualClientData(string clientData)
        {
            return _context.ClientsIndividual
                           .FirstOrDefault(client => client.FullName == clientData);
        }

        public ClientCorporate GetCorporateClientData(string clientData)
        {
            return _context.ClientsCorporate
                           .FirstOrDefault(client => client.CompanyName == clientData);
        }

        public List<ClientCorporate> GetCorporateClients()
        {
            return _context.ClientsCorporate.ToList();
        }

        public List<ClientIndividual> GetIndividualClients()
        {
            return _context.ClientsIndividual.ToList();
        }
    }
}
