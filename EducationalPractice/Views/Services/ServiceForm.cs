using EducationalPractice.Controllers;
using EducationalPractice.Models;
using EducationalPractice.Models.Client;

namespace EducationalPractice.Views.Services
{
    public partial class ServiceForm : Form
    {
        private readonly OrderForm orderForm;

        private readonly ServiceController serviceController;
        private readonly ClientController clientController;

        private readonly string clientType;
        private readonly string clientData;

        public ServiceForm(OrderForm orderForm, ServiceController serviceController, ClientController clientController, string clientType, string clientData)
        {
            InitializeComponent();

            this.orderForm = orderForm;
            this.serviceController = serviceController;
            this.clientController = clientController;
            this.clientType = clientType;
            this.clientData = clientData;
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            var serviceNames = serviceController.GetServiceNames();
            servicesCheckedListBox.Items.AddRange(serviceNames.ToArray());

            ClientCorporate clientCorporate;
            ClientIndividual clientIndividual;

            if (isLegalEntity)
            {
                clientCorporate = clientController.GetCorporateClientData(clientData);
                clientIndividual = null;
            }
            else
            {
                clientCorporate = null;
                clientIndividual = clientController.GetIndividualClientData(clientData);
            }

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

            clientIdLabel.Text = $"Client ID: {(isLegalEntity ? clientCorporate.ClientCode : clientIndividual.ClientCode)}";

            if (isLegalEntity)
            {
                companyNameLabel.Text = $"Название компании: {clientCorporate.CompanyName}";
                corporateAddressLabel.Text = $"Адрес: {clientCorporate.Address}";
                innLabel.Text = $"ИНН: {clientCorporate.INN}";
                accountNumberLabel.Text = $"Расчётный счёт: {clientCorporate.AccountNumber}";
                bikLabel.Text = $"БИК: {clientCorporate.BIK}";
                ceoNameLabel.Text = $"ФИО руководителя: {clientCorporate.CEOName}";
                contactPhoneLabel.Text = $"Номер телефона: {clientCorporate.ContactPersonName}";
                corporateEmailLabel.Text = $"Электронная почта: {clientCorporate.Email}";
                return;
            }

            passportDataLabel.Text = $"Серия и номер паспорта: {clientIndividual.PassportData}";
            dateOfBirthLabel.Text = $"Дата рождения: {clientIndividual.DateOfBirth}";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (serviceController.GetTotalCost() == 0)
            {
                MessageBox.Show($"Выберите хотя бы одну услугу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show($"Заказ успешно оформлен.\nУслуги: {string.Join(", ", serviceController.GetSelectedServiceNames())}\nСтоимость: {serviceController.GetTotalCost()} руб.\nВремя выполнения: {serviceController.GetTotalTime()}", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
