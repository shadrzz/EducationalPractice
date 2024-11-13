using EducationalPractice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string email = emailTextBox.Text;
            string dateOfBirth = dateOfBirthTextBox.Text;
            string passportData = passportDataTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;

            clientIndividuals.Add(new ClientIndividual(fullName, clientCode, email, dateOfBirth, passportData, phoneNumber, "241"));
            MessageBox.Show($"Новый клиент добавлен {clientCode}", "!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }
    }
}
