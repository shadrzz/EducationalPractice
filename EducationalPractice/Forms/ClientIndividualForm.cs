using EducationalPractice.Models;
using System.Data;

namespace EducationalPractice.Forms
{
    public partial class ClientIndividualForm : Form
    {
        private List<ClientIndividual> clientIndividuals;
        public ClientIndividualForm(List<ClientIndividual> clientIndividuals)
        {
            InitializeComponent();
            this.clientIndividuals = clientIndividuals;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            string clientCode = (clientIndividuals.Select(client => int.Parse(client.ClientCode))
                .Max() + 1).ToString(); // по идеи должен бд сам сгенерировать как ключ
            string dateOfBirth = dateOfBirthTextBox.Text;
            string passportData = passportDataTextBox.Text;
            //string phoneNumber = phoneNumberTextBox.Text;
            string address = addressTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            ValidateFields();
            //clientIndividuals.Add(new ClientIndividual(fullName, clientCode, passportData, dateOfBirth, address, email, password));
            //MessageBox.Show($"Новый клиент добавлен {clientCode}", "!", MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);
            Close();
        }

        private void ValidateFields()
        {
            // Список для хранения названий незаполненных полей
            List<string> emptyFields = new List<string>();

            // Проверка каждого текстового поля на заполненность
            if (string.IsNullOrWhiteSpace(fullNameTextBox.Text))
                emptyFields.Add("ФИО");
            if (string.IsNullOrWhiteSpace(passportDataTextBox.Text))
                emptyFields.Add("Паспортные данные");
            if (string.IsNullOrWhiteSpace(dateOfBirthTextBox.Text))
                emptyFields.Add("Дата рождения");
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
                emptyFields.Add("Адрес");
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                emptyFields.Add("E-mail");
            if (string.IsNullOrWhiteSpace(phoneNumberTextBox.Text))
                emptyFields.Add("Номер телефона");
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                emptyFields.Add("Пароль");

            // Если есть незаполненные поля, вывести сообщение с их названиями
            if (emptyFields.Count > 0)
            {
                string message = "Заполните следующие поля:\n" + string.Join("\n", emptyFields);
                MessageBox.Show(message, "Незаполненные поля", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Все поля заполнены корректно.", "Проверка полей", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
