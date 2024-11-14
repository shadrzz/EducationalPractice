using EducationalPractice.Models.Client;
using EducationalPractice.Utils;

namespace EducationalPractice.Controllers
{
    internal class ClientController
    {
        private List<ClientCorporate> corporateClients;
        private List<ClientIndividual> individualClients;

        public ClientController()
        {
            corporateClients = DataInitializer.GetCorporateClients();
            individualClients = DataInitializer.GetIndividualClients();
        }

        public bool AddIndividualClient(ClientIndividual client)
        {
            if (!individualClients.Any(c => c.FullName == client.FullName))
            {
                individualClients.Add(client);
                return true;
            }
            return false;
        }

        public List<ClientCorporate> GetCorporateClients() => corporateClients;
        public List<ClientIndividual> GetIndividualClients() => individualClients;
    }
}
