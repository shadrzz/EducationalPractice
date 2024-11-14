using EducationalPractice.Forms;
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

        public ClientAddResult AddIndividualClientIfNotExists(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                return new ClientAddResult(false, "Поле ФИО пустое.");
            }

            if (individualClients.Any(c => c.FullName == fullName))
            {
                return new ClientAddResult(false, "Клиент с таким ФИО уже существует.");
            }

            var newClient = new ClientIndividual(fullName, "новый код клиента", "новые паспортные данные", "дата рождения", "адрес", "email@example.com", "пароль");
            individualClients.Add(newClient);
            return new ClientAddResult(true, $"Клиент {newClient.FullName} добавлен.");
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
                return new ClientIndividualForm(GetIndividualClients());
            }
        }

        public List<ClientCorporate> GetCorporateClients() => corporateClients;
        public List<ClientIndividual> GetIndividualClients() => individualClients;
    }
}
