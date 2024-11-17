using EducationalPractice.Controllers;

namespace EducationalPractice.Forms
{
    public partial class ClientIndividualForm : Form
    {
        private readonly ClientController clientController;
        public ClientIndividualForm(ClientController clientController)
        {
            InitializeComponent();

            this.clientController = clientController;
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            string clientId = clientIdTextBox.Text;
            string fullName = fullNameTextBox.Text;
            string passportData = passportDataTextBox.Text;
            string dateOfBirth = dateOfBirthTextBox.Text;
            string address = addressTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            var client = new ClientsIndividual(clientId, fullName, passportData, dateOfBirth, address, email, password);

            if (string.IsNullOrWhiteSpace(client.ClientId) ||
                string.IsNullOrWhiteSpace(client.FullName) ||
                string.IsNullOrWhiteSpace(client.PassportDate) ||
                string.IsNullOrWhiteSpace(client.BirthDate) ||
                string.IsNullOrWhiteSpace(client.Address) ||
                string.IsNullOrWhiteSpace(client.Email) ||
                string.IsNullOrWhiteSpace(client.Password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clientController.AddIndividualClient(client);
            MessageBox.Show($"Клиент успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
