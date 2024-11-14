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

            // ��������� ��������� ��� ������ ������
            idLaboratoryVesselTextBox.Text = GetNextOrderNumber();

            // ���������� ������� Enter
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;


            string[] customerItems = { "��", "��" };
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var service in services)
            {
                servicesCheckedListBox.Items.Add(service.Name);
            }
        }
        private string GetNextOrderNumber()
        {
            // ������� ��������� ����� ������, �������� ������ � ������ (��������, � �������� "�������")
            var lastOrderNumber = orders
                .Select(order => ParseOrderNumber(order.OrderNumber))
                .Max();

            // ���������� ��������� �����
            return (lastOrderNumber + 1).ToString();
        }

        private int ParseOrderNumber(string orderNumber)
        {
            // ��������� �������� ����� �� ������ ������
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

                // ��������� ������������ ������
                if (IsUniqueVesselNumber(enteredVesselNumber))
                {
                    MessageBox.Show("����� ������ �����������: " + enteredVesselNumber);
                }
                else
                {
                    MessageBox.Show("���� ����� ��� ����������. ����������, ������� ���������� �����.");
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
                bool isLegalEntity = customerChoiceComboBox.SelectedItem.ToString() == "��";

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

            // �������� ������� ������� �� ���
            if (!string.IsNullOrEmpty(fullName) && !clientsIndividual.Any(c => c.FullName == fullName))
            {
                // ���������� ������ �������
                ClientIndividual newClient = new ClientIndividual(
                    fullName,
                    "����� ��� �������",
                    "����� ���������� ������",
                    "���� ��������",
                    "�����",
                    "email@example.com",
                    "������"
                );

                clientsIndividual.Add(newClient);
                MessageBox.Show($"������ {newClient.FullName} ��������.");
            }
            else
            {
                MessageBox.Show("������ � ����� ��� ��� ���������� ��� ���� ��� ������.");
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string customerChoiceValue = customerChoiceComboBox.SelectedItem.ToString();
            if (customerChoiceValue == "��")
            {
                ClientCorporateForm newForm = new ClientCorporateForm();
                newForm.Show();
            }
            else if (customerChoiceValue == "��")
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
                // �������� ������� ���������
                decimal currentTotalCost = 0;
                if (decimal.TryParse(costValue.Text.Replace(" ���.", ""), out decimal parsedCost))
                {
                    currentTotalCost = parsedCost;
                }

                // ������������ ����� ��������� � ����������� �� ��������� NewValue
                if (e.NewValue == CheckState.Checked)
                {
                    // ���� ������� �������, ��������� ��� ���������
                    currentTotalCost += selectedService.Cost;
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    // ���� ������� ���������, �������� ��� ���������
                    currentTotalCost -= selectedService.Cost;
                }

                // ��������� ����������� ���������, �������� " ���."
                costValue.Text = $"{currentTotalCost} ���.";
            }
        }
    }
}

