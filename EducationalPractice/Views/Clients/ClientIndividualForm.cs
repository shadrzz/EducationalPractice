using EducationalPractice.Controllers;
using EducationalPractice.Models;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils.Extensions;
using System.Data;

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

            var client = new ClientIndividual(fullName, clientId, passportData, dateOfBirth, address, email, password);

            if (string.IsNullOrWhiteSpace(client.ClientId) ||
                string.IsNullOrWhiteSpace(client.FullName) ||
                string.IsNullOrWhiteSpace(client.PassportData) ||
                string.IsNullOrWhiteSpace(client.DateOfBirth) ||
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

            //using (var db = new ApplicationDbContext())
            //{
            //    // Добавление нового клиента
            //    //db.Employees.Add(new EmployeeCopy("Менеджер по работе с клиентами", "Иванов Иван Иванович", "Ivanov@namecomp.ru", "2L6KZG", "15:05:2022 13:13:00", "fsafas"));
            //    //db.SaveChanges();

            //    // Получаем первую строку из таблицы Clients
            //    var employee = db.Employees.FirstOrDefault();

            //    if (employee != null)
            //    {
            //        // Формируем сообщение с данными клиента
            //        string message = $"Имя: {employee.FullName}, Позиция: {employee.Position}";
            //        MessageBox.Show(message, "Данные сотрудника");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Данные сотрудника не найдены", "Ошибка");
            //    }
            //}

            //DatabaseReader reader = new DatabaseReader();
            //reader.ShowData();

            //ValidateFields();
            //clientIndividuals.Add(new ClientIndividual(fullName, clientCode, passportData, dateOfBirth, address, email, password));
            //MessageBox.Show($"Новый клиент добавлен {clientCode}", "!", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            //Close();
        }
    }
}
