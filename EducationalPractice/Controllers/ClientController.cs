using EducationalPractice.Forms;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    public class ClientController
    {
        private List<ClientCorporate> corporateClients;
        private List<ClientIndividual> individualClients;

        public ClientController()
        {
            corporateClients = DataInitializer.GetCorporateClients();
            individualClients = DataInitializer.GetIndividualClients();
        }

        public bool IsLegalEntity(string clientType)
        {
            return clientType == "ЮЛ";
        }

        public Form GetClientForm(string clientType)
        {
            if (IsLegalEntity(clientType))
            {
                return new ClientCorporateForm();
            }
            else
            {
                return new ClientIndividualForm();
            }
        }

        public bool DoesClientExist(string clientData, string clientType)
        {
            if (IsLegalEntity(clientType))
            {
                return corporateClients.Any(client => client.CompanyName == clientData);
            }
            return individualClients.Any(client => client.FullName == clientData);
        }

        public ClientIndividual GetIndividualClientData(string clientData)
        {
            return individualClients.FirstOrDefault(client => client.FullName == clientData);
        }

        public ClientCorporate GetCorporateClientData(string clientData)
        {
            return corporateClients.FirstOrDefault(client => client.CompanyName == clientData);
        }

        public List<ClientCorporate> GetCorporateClients() => corporateClients;
        public List<ClientIndividual> GetIndividualClients() => individualClients;
    }
}
