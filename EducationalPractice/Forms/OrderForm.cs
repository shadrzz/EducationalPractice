using EducationalPractice.Forms;
using EducationalPractice.Models;

namespace EducationalPractice
{
    public partial class OrderForm : Form
    {
        private List<Order> orders;
        private List<ClientCorporate> clientsCorporate;
        private List<ClientIndividual> clientsIndividual;
        private List<Service> services;
        private List<Employee> employees;

        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderFormation_Load(object sender, EventArgs e)
        {
            services = new List<Service>
            {
                new Service(336, "Содержание хрома", "8HFJHG443", "12 часов", "0.04", 12000, 1100),
                new Service(353, "Содержание никеля", "87FDJKHJ", "3 сут", "0.012", 24000, 800),
                new Service(31, "Содержание ртути", "JUR8R", "10 час", "0.06", 24000, 930),
                new Service(34, "Содержание хлора", "JKFBJ09", "120 мин", "0.011", 32000, 450)
            };

            clientsCorporate = new List<ClientCorporate>
            {
                new ClientCorporate("ЗАО \"Русская косметика\"", "МО, Одинцово, Ворошилова ул, 153", "7927728472", "78123678892", "445334327",
               "Харитонова Ева Адамовна", "Кузнецов Александр Сергеевич", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234", "hh123"),
                new ClientCorporate("ООО «Коконат»", "МО, Чехов, Минская ул, 128", "7934728472", "78123678842", "445622227",
                           "Орлова Татьяна Мироновна", "Демидов Дмитрий Глебович", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235", "fj23"),
                new ClientCorporate("Nicole laboratory", "МО, Ногинск, Заводская ул, 34", "7927425472", "78122378892", "493993327",
                           "Дементьев Ярослав Георгиевич", "Розанова Камила Максимовна", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"),
            };

            clientsIndividual = new List<ClientIndividual>
            {
                new ClientIndividual("Фролов Андрей Иванович", "45462526", "Серия 1180 Номер 176596", "7/14/2001", "344288, г. Москва, ул. Чехова, 1, кв. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
                new ClientIndividual("Николаев Даниил Всеволодович", "45462527", "Серия 2280 Номер 223523", "2/10/2001", "614164, г. Москва, ул. Степная, 30, кв. 75", "xawugosune-1385@yopmail.com", "cl12346"),
                new ClientIndividual("Снегирев Макар Иванович", "45462528", "Серия 4560 Номер 354155", "5/21/1998", "394242, г. Москва, ул. Коммунистическая, 43, кв. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
            };

            orders = new List<Order>
            {
                new Order(1, "45462527/44632", "3/12/2022", "45462527", new List<int> { 34, 31, 353, 336 }, "Новая", null, "ID 104", "78 ч"),
                new Order(2, "45462528/44633", "3/13/2022", "45462528", new List<int> { 98, 45, 89, 99, 123 }, "На исследовании", null, "ID 105", "16 ч"),
                new Order(3, "45462529/44634", "3/14/2022", "45462529", new List<int> { 92, 45, 57, 88 }, "На исследовании", null, "ID 106", "28 ч"),
            };

            employees = new List<Employee>
            {
                new Employee("ID 101", "Менеджер по работе с клиентами", "Иванов Иван Иванович", "Ivanov@namecomp.ru", "2L6KZG", new List<int>(), "15:05:2022 13:13:00"),
                new Employee("ID 102", "Менеджер по работе с клиентами", "Петров Петр Петрович", "petrov@namecomp.ru", "uzWC67", new List<int>(), "15:05:2022 13:13:01"),
                new Employee("ID 103", "Администратор", "Федоров Федор Федорович", "fedorov@namecomp.ru", "8ntwUp", new List<int>(), "15:05:2022 13:13:02"),
                new Employee("ID 104", "Лаборант", "Миронов Вениамин Куприянович", "mironov@namecomp.ru", "YOyhfR", new List<int> {34, 31, 353, 336}, "15:05:2022 13:13:03"),
                new Employee("ID 105", "Лаборант", "Ширяев Ермолай Вениаминович", "shiryev@namecomp.ru", "RSbvHv", new List<int> {98, 45, 89, 99, 123}, "15:05:2022 13:13:04"),
            };

            // Установка подсказки для номера заказа
            idLaboratoryVesselTextBox.Text = GetNextOrderNumber();

            // Обработчик нажатия Enter
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;


            string[] customerItems = { "ЮЛ", "ФЛ" };
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var service in services)
            {
                servicesCheckedListBox.Items.Add(service.Name);
            }
        }
        private string GetNextOrderNumber()
        {
            // Находим последний номер заказа, исключая заказы в архиве (например, с статусом "Закрыта")
            var lastOrderNumber = orders
                .Select(order => ParseOrderNumber(order.OrderNumber))
                .Max();

            // Возвращаем следующий номер
            return (lastOrderNumber + 1).ToString();
        }

        private int ParseOrderNumber(string orderNumber)
        {
            // Извлекаем числовую часть из номера заказа
            int numericPart;
            if (int.TryParse(orderNumber.Split('/')[0], out numericPart))
                return numericPart;
            return 0;
        }

        private void IdLaboratoryVesselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string enteredVesselNumber = idLaboratoryVesselTextBox.Text;

                // Проверяем уникальность номера
                if (IsUniqueVesselNumber(enteredVesselNumber))
                {
                    MessageBox.Show("Номер сосуда подтвержден: " + enteredVesselNumber);
                }
                else
                {
                    MessageBox.Show("Этот номер уже существует. Пожалуйста, введите уникальный номер.");
                }
            }
        }

        private bool IsUniqueVesselNumber(string vesselNumber)
        {
            return !orders.Any(order => order.OrderNumber.Split('/')[0] == vesselNumber);
        }

        private void customerChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerChoiceComboBox.SelectedItem != null)
            {
                bool isLegalEntity = customerChoiceComboBox.SelectedItem.ToString() == "ЮЛ";

                companyNameLabel.Visible = isLegalEntity;
                companyNameTextBox.Visible = isLegalEntity;

                fullNameLabel.Visible = !isLegalEntity;
                fullNameTextBox.Visible = !isLegalEntity;
            }
            placeOrderButton.Visible = true;
            servicesLabel.Visible = true;
            servicesCheckedListBox.Visible = true;
            costLabel.Visible = true;
            costValue.Visible = true;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();

            // Проверка наличия клиента по ФИО
            if (!string.IsNullOrEmpty(fullName) && !clientsIndividual.Any(c => c.FullName == fullName))
            {
                // Добавление нового клиента
                ClientIndividual newClient = new ClientIndividual(
                    fullName,
                    "новый код клиента",
                    "новые паспортные данные",
                    "дата рождения",
                    "адрес",
                    "email@example.com",
                    "пароль"
                );

                clientsIndividual.Add(newClient);
                MessageBox.Show($"Клиент {newClient.FullName} добавлен.");
            }
            else
            {
                MessageBox.Show("Клиент с таким ФИО уже существует или поле ФИО пустое.");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string customerChoiceValue = customerChoiceComboBox.SelectedItem.ToString();
            if (customerChoiceValue == "ЮЛ")
            {
                ClientCorporateForm newForm = new ClientCorporateForm();
                newForm.Show();
            }
            else if (customerChoiceValue == "ФЛ")
            {
                ClientIndividualForm newForm = new ClientIndividualForm(clientsIndividual);
                newForm.Show();
            }
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the item that is being checked or unchecked
            string item = servicesCheckedListBox.Items[e.Index].ToString();

            // Get the service associated with the checked item
            Service selectedService = services.FirstOrDefault(s => s.Name == item);

            if (selectedService != null)
            {
                // Получаем текущую стоимость
                decimal currentTotalCost = 0;
                if (decimal.TryParse(costValue.Text.Replace(" руб.", ""), out decimal parsedCost))
                {
                    currentTotalCost = parsedCost;
                }

                // Корректируем общую стоимость в зависимости от состояния NewValue
                if (e.NewValue == CheckState.Checked)
                {
                    // Если элемент отмечен, добавляем его стоимость
                    currentTotalCost += selectedService.Cost;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    // Если элемент снимается, вычитаем его стоимость
                    currentTotalCost -= selectedService.Cost;
                }

                // Обновляем отображение стоимости, добавляя " руб."
                costValue.Text = $"{currentTotalCost} руб.";
            }
        }
    }
}

