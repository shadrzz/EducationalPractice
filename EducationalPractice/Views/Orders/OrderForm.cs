using EducationalPractice.Forms;
using EducationalPractice.Models;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils;

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
            services = DataInitializer.GetServices();
            clientsCorporate = DataInitializer.GetCorporateClients();
            clientsIndividual = DataInitializer.GetIndividualClients();
            orders = DataInitializer.GetOrders();
            employees = DataInitializer.GetEmployees();

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

