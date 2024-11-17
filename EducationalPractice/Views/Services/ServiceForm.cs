using EducationalPractice.Controllers;
using EducationalPractice.Models;

namespace EducationalPractice.Views.Services
{
    public partial class ServiceForm : Form
    {
        private readonly OrderForm orderForm;

        private readonly OrderController orderController;
        private readonly ServiceController serviceController;
        private readonly ClientController clientController;

        private readonly string orderNumber;
        private readonly string clientType;
        private readonly string clientData;

        public ServiceForm(OrderForm orderForm, OrderController orderController, ServiceController serviceController, ClientController clientController, string orderNumber, string clientType, string clientData)
        {
            InitializeComponent();

            this.orderForm = orderForm;
            this.orderController = orderController;
            this.serviceController = serviceController;
            this.clientController = clientController;
            this.orderNumber = orderNumber;
            this.clientType = clientType;
            this.clientData = clientData;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            var serviceNames = serviceController.GetServiceNames();
            servicesCheckedListBox.Items.AddRange(serviceNames.ToArray());

            ClientsCorporate clientCorporate = clientController.GetCorporateClientData(clientData);
            ClientsIndividual clientIndividual = clientController.GetIndividualClientData(clientData);

            companyNameLabel.Visible = isLegalEntity;
            corporateAddressLabel.Visible = isLegalEntity;
            innLabel.Visible = isLegalEntity;
            accountNumberLabel.Visible = isLegalEntity;
            bikLabel.Visible = isLegalEntity;
            ceoNameLabel.Visible = isLegalEntity;
            contactPhoneLabel.Visible = isLegalEntity;
            corporateEmailLabel.Visible = isLegalEntity;

            passportDataLabel.Visible = !isLegalEntity;
            dateOfBirthLabel.Visible = !isLegalEntity;
            individualAddressLabel.Visible = !isLegalEntity;
            individualEmailLabel.Visible = !isLegalEntity;

            clientIdLabel.Text = $"Client ID: {(isLegalEntity ? clientCorporate.ClientId : clientIndividual.ClientId)}";

            if (isLegalEntity)
            {
                companyNameLabel.Text = $"Название компании: {clientCorporate.CompanyName}";
                corporateAddressLabel.Text = $"Адрес: {clientCorporate.Address}";
                innLabel.Text = $"ИНН: {clientCorporate.Inn}";
                accountNumberLabel.Text = $"Расчётный счёт: {clientCorporate.BankAccount}";
                bikLabel.Text = $"БИК: {clientCorporate.Bic}";
                ceoNameLabel.Text = $"ФИО руководителя: {clientCorporate.Ceoname}";
                contactPhoneLabel.Text = $"Номер телефона: {clientCorporate.ContactPhone}";
                corporateEmailLabel.Text = $"Электронная почта: {clientCorporate.Email}";
                return;
            }

            passportDataLabel.Text = $"Серия и номер паспорта: {clientIndividual.PassportDate}";
            dateOfBirthLabel.Text = $"Дата рождения: {clientIndividual.BirthDate}";
            individualAddressLabel.Text = $"Адрес: {clientIndividual.Address}";
            individualEmailLabel.Text = $"Электронная почта: {clientIndividual.Email}";
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Получаем выбранный элемент как объект Service
            Service selectedService = serviceController.GetServices()[e.Index];

            if (selectedService == null)
                return; // Если услуга не найдена, выходим

            int serviceId = selectedService.Id; // Получаем ID услуги
            bool isSelected = e.NewValue == CheckState.Checked;

            // Передаём ID услуги вместо имени
            decimal totalCost = serviceController.HandleServiceSelection(serviceId, isSelected);
            costValue.Text = $"{totalCost} руб.";
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            if (serviceController.GetSelectedServiceCount() == 0)
            {
                MessageBox.Show($"Выберите хотя бы одну услугу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            ClientsCorporate clientCorporate = clientController.GetCorporateClientData(clientData);
            ClientsIndividual clientIndividual = clientController.GetIndividualClientData(clientData);

            int orderId = orderController.GetNextOrderId();
            string creationDate = DateTime.Now.ToString("d/M/yyyy");
            string clientId = isLegalEntity ? clientCorporate.ClientId.ToString() : clientIndividual.ClientId;
            string services = serviceController.GetSelectedServiceIds();
            string status = "Новая";
            string? closingDate = null;
            string? employeeId = null;
            string executionTime = serviceController.GetTotalTime();

            var order = new Order(orderId, orderNumber, creationDate, clientId, services, status, closingDate, employeeId, executionTime);
            orderController.AddOrder(order);

            MessageBox.Show($"Заказ успешно оформлен.\nУслуги: {string.Join(", ", serviceController.GetSelectedServiceNames())}\nСтоимость: {serviceController.GetTotalCost()} руб.\nВремя выполнения: {executionTime}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            serviceController.ClearSelectedServices();
            orderForm.ClearForm(true);
            Close();
        }
    }
}
