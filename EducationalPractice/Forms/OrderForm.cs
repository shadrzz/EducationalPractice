using EducationalPractice.Forms;
using EducationalPractice.Models;

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
            services = new List<Service>
            {
                new Service(336, "���������� �����", "8HFJHG443", "12 �����", "0.04", 12000, 1100),
                new Service(353, "���������� ������", "87FDJKHJ", "3 ���", "0.012", 24000, 800),
                new Service(31, "���������� �����", "JUR8R", "10 ���", "0.06", 24000, 930),
                new Service(34, "���������� �����", "JKFBJ09", "120 ���", "0.011", 32000, 450)
            };

            clientsCorporate = new List<ClientCorporate>
            {
                new ClientCorporate("��� \"������� ���������\"", "��, ��������, ���������� ��, 153", "7927728472", "78123678892", "445334327",
               "���������� ��� ��������", "�������� ��������� ���������", "16(7185)250-54-23556", "dcoppit@mac.com", "UL1234", "hh123"),
                new ClientCorporate("��� ��������", "��, �����, ������� ��, 128", "7934728472", "78123678842", "445622227",
                           "������ ������� ���������", "������� ������� ��������", "33(5855)767-28-30549", "tezbo@mac.com", "UL1235", "fj23"),
                new ClientCorporate("Nicole laboratory", "��, �������, ��������� ��, 34", "7927425472", "78122378892", "493993327",
                           "��������� ������� ����������", "�������� ������ ����������", "2(63)151-61-70518", "stecoop@yahoo.com", "UL1236", "8739"),
            };

            clientsIndividual = new List<ClientIndividual>
            {
                new ClientIndividual("������ ������ ��������", "45462526", "����� 1180 ����� 176596", "7/14/2001", "344288, �. ������, ��. ������, 1, ��. 34", "gohufreilagrau-3818@yopmail.com", "cl12345"),
                new ClientIndividual("�������� ������ ������������", "45462527", "����� 2280 ����� 223523", "2/10/2001", "614164, �. ������, ��. �������, 30, ��. 75", "xawugosune-1385@yopmail.com", "cl12346"),
                new ClientIndividual("�������� ����� ��������", "45462528", "����� 4560 ����� 354155", "5/21/1998", "394242, �. ������, ��. ����������������, 43, ��. 57", "satrahuddusei-4458@yopmail.com", "cl12347"),
            };

            orders = new List<Order>
            {
                new Order(1, "45462527/44632", "3/12/2022", "45462527", new List<int> { 34, 31, 353, 336 }, "�����", null, "ID 104", "78 �"),
                new Order(2, "45462528/44633", "3/13/2022", "45462528", new List<int> { 98, 45, 89, 99, 123 }, "�� ������������", null, "ID 105", "16 �"),
                new Order(3, "45462529/44634", "3/14/2022", "45462529", new List<int> { 92, 45, 57, 88 }, "�� ������������", null, "ID 106", "28 �"),
            };

            employees = new List<Employee>
            {
                new Employee("ID 101", "�������� �� ������ � ���������", "������ ���� ��������", "Ivanov@namecomp.ru", "2L6KZG", new List<int>(), "15:05:2022 13:13:00"),
                new Employee("ID 102", "�������� �� ������ � ���������", "������ ���� ��������", "petrov@namecomp.ru", "uzWC67", new List<int>(), "15:05:2022 13:13:01"),
                new Employee("ID 103", "�������������", "������� ����� ���������", "fedorov@namecomp.ru", "8ntwUp", new List<int>(), "15:05:2022 13:13:02"),
                new Employee("ID 104", "��������", "������� �������� �����������", "mironov@namecomp.ru", "YOyhfR", new List<int> {34, 31, 353, 336}, "15:05:2022 13:13:03"),
                new Employee("ID 105", "��������", "������ ������� ������������", "shiryev@namecomp.ru", "RSbvHv", new List<int> {98, 45, 89, 99, 123}, "15:05:2022 13:13:04"),
            };

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

