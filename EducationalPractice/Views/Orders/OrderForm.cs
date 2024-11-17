using EducationalPractice.Controllers;
using EducationalPractice.Views.Services;
using System.Text.RegularExpressions;

namespace EducationalPractice
{
    public partial class OrderForm : Form
    {
        private readonly OrderController orderController;
        private readonly ClientController clientController;
        private readonly ServiceController serviceController;

        public OrderForm(OrderController orderController, ClientController clientController, ServiceController serviceController)
        {
            InitializeComponent();
            this.orderController = orderController;
            this.clientController = clientController;
            this.serviceController = serviceController;
        }

        private void OrderFormation_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(idLaboratoryVesselTextBox, $"���������. ��� ������: {orderController.GetNextOrderNumber()}");
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;

            string[] customerItems = orderController.GetCustomerTypes();
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void IdLaboratoryVesselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                idLaboratoryVesselTextBox.Text = orderController.GetNextOrderNumber();
            }
        }

        private bool IsValidVesselCodeFormat(string code)
        {
            string pattern = @"^\d+/[0-9]+$";
            return Regex.IsMatch(code, pattern);
        }

        private void idLaboratoryVesselTextBox_TextChanged(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void idLaboratoryVesselButton_Click(object sender, EventArgs e)
        {
            string orderNumber = idLaboratoryVesselTextBox.Text;

            if (string.IsNullOrEmpty(orderNumber))
            {
                MessageBox.Show($"���� '��� ������������� ������' ������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // �������� �� ������ �����
            if (!IsValidVesselCodeFormat(orderNumber))
            {
                MessageBox.Show("�������� ������! ��� ������ ������ ���� � ������� '�����/�����'.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ���������, ���������� �� OrderNumber
            bool orderExists = orderController.DoesOrderNumberExist(orderNumber);

            if (orderExists)
            {
                MessageBox.Show($"������! ����� � ������� {orderNumber} ��� ����������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            idLaboratoryVesselButton.Visible = false;
            customerChoiceLabel.Visible = true;
            customerChoiceComboBox.Visible = true;
        }

        private void customerChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customerChoiceComboBox.SelectedItem != null)
            {
                string clientType = customerChoiceComboBox.SelectedItem.ToString();
                bool isLegalEntity = clientController.IsLegalEntity(clientType);

                clientDataLabel.Text = isLegalEntity ? "�������� ��������:" : "���:";

                clientDataLabel.Visible = true;
                clientDataTextBox.Visible = true;
                placeOrderButton.Visible = true;
            }
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string orderNumber = idLaboratoryVesselTextBox.Text;

            string clientType = customerChoiceComboBox.SelectedItem?.ToString();
            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            string clientData = clientDataTextBox.Text.Trim();
            bool clientExists = clientController.DoesClientExist(clientData, clientType);

            if (string.IsNullOrEmpty(clientData))
            {
                MessageBox.Show($"���� '{(isLegalEntity ? "�������� ��������" : "���")}' ������.", "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ���� ������ ����������
            if (clientExists)
            {
                Form serviceForm = new ServiceForm(this, orderController, serviceController, clientController, orderNumber, clientType, clientData);
                MessageBox.Show($"������ \"{clientData}\" ������ � ���� ������. ���������� ��������� ���� �����.", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serviceForm.Show();
                return;
            }

            var result = MessageBox.Show(
                $"������ �� ������ � ���� ������.\n�� ������ �������� ������ �������?\n��� ����������� ������ ������� \"���\".",
                "�������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // ���� ������� �� ���������� � ������������ ����� �������� �������
            if (result == DialogResult.Yes)
            {
                Form clientForm = clientController.GetClientForm(clientType);
                clientForm.Show();
            }
        }

        public void ClearForm(bool cleanValues = false)
        {
            idLaboratoryVesselButton.Visible = true;
            customerChoiceLabel.Visible = false;
            customerChoiceComboBox.Visible = false;
            clientDataLabel.Visible = false;
            clientDataTextBox.Visible = false;
            placeOrderButton.Visible = false;

            if (cleanValues)
            {
                idLaboratoryVesselTextBox.Clear();
                customerChoiceComboBox.SelectedIndex = -1;
                clientDataTextBox.Clear();
            }
        }
    }
}
