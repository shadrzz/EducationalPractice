using EducationalPractice.Controllers;
using EducationalPractice.Models.Client;

namespace EducationalPractice.Forms
{
    public partial class ClientCorporateForm : Form
    {
        private readonly ClientController clientController;

        public ClientCorporateForm(ClientController clientController)
        {
            InitializeComponent();

            this.clientController = clientController;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            string clientId = clientIdTextBox.Text;
            string companyName = companyNameTextBox.Text;
            string address = addressTextBox.Text;
            string inn = innLabelTextBox.Text;
            string accountNumber = accountNumberTextBox.Text;
            string bik = bikTextBox.Text;
            string ceoName = ceoNameTextBox.Text;
            string contactPersonName = contactPersonNameTextBox.Text;
            string contactPhone = contactPhoneTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            var client = new ClientCorporate(companyName, address, inn, accountNumber, bik, ceoName, contactPersonName, contactPhone, email, password, clientId);

            if (string.IsNullOrWhiteSpace(client.ClientId) ||
                string.IsNullOrWhiteSpace(client.CompanyName) ||
                string.IsNullOrWhiteSpace(client.Address) ||
                string.IsNullOrWhiteSpace(client.INN) ||
                string.IsNullOrWhiteSpace(client.AccountNumber) ||
                string.IsNullOrWhiteSpace(client.BIK) ||
                string.IsNullOrWhiteSpace(client.CEOName) ||
                string.IsNullOrWhiteSpace(client.ContactPersonName) ||
                string.IsNullOrWhiteSpace(client.ContactPhone) ||
                string.IsNullOrWhiteSpace(client.Email) ||
                string.IsNullOrWhiteSpace(client.Password)
            )
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientController.AddCorporateClient(client);
            MessageBox.Show($"Клиент успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
