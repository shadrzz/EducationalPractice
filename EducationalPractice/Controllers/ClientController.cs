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

        public ClientAddResult AddCorporateClientIfNotExists(string companyName)
        {
            if (string.IsNullOrEmpty(companyName))
            {
                return new ClientAddResult(false, "Поле названия компании пустое.");
            }

            if (corporateClients.Any(c => c.CompanyName == companyName))
            {
                return new ClientAddResult(false, "Клиент с таким названием компании уже существует.");
            }

            var newClient = new ClientCorporate(
                companyName, "МО, Ногинск, Заводская ул, 34", "7927425472", "78122378892", "493993327",
                           "Дементьев Ярослав Георгиевич", "Розанова Камила Максимовна", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"
            );

            corporateClients.Add(newClient);
            return new ClientAddResult(true, $"Клиент {newClient.CompanyName} добавлен.");
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
