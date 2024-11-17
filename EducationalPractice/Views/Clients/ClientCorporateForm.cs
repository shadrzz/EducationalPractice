using EducationalPractice.Controllers;

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
            int clientId = int.Parse(clientIdTextBox.Text);
            string companyName = companyNameTextBox.Text;
            string address = addressTextBox.Text;
            string inn = innLabelTextBox.Text;
            string bankAccount = accountNumberTextBox.Text;
            string bik = bikTextBox.Text;
            string ceoName = ceoNameTextBox.Text;
            string contactPersonName = contactPersonNameTextBox.Text;
            string contactPhone = contactPhoneTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            var client = new ClientsCorporate(clientId, companyName, address, inn, bankAccount, bik, ceoName, contactPhone, email, password);

            if (string.IsNullOrWhiteSpace(clientIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(client.CompanyName) ||
                string.IsNullOrWhiteSpace(client.Address) ||
                string.IsNullOrWhiteSpace(client.Inn) ||
                string.IsNullOrWhiteSpace(client.BankAccount) ||
                string.IsNullOrWhiteSpace(client.Bic) ||
                string.IsNullOrWhiteSpace(client.Ceoname) ||
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
