using EducationalPractice.Controllers;
using EducationalPractice.Models.Client;
using EducationalPractice.Utils.Extension;
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

            //var serviceNames = serviceController.GetServiceNames();
            //servicesCheckedListBox.Items.AddRange(serviceNames.ToArray());
        }

        private void IdLaboratoryVesselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                idLaboratoryVesselTextBox.Text = orderController.GetNextOrderNumber();
            }
        }

        private void customerChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clientType = customerChoiceComboBox.SelectedItem.ToString();
            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            companyNameLabel.Visible = isLegalEntity;
            companyNameTextBox.Visible = isLegalEntity;

            fullNameLabel.Visible = !isLegalEntity;
            fullNameTextBox.Visible = !isLegalEntity;

            placeOrderButton.Visible = true;
            //servicesLabel.Visible = true;
            //servicesCheckedListBox.Visible = true;
            //costLabel.Visible = true;
            //costValue.Visible = true;
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            //string clientType = customerChoiceComboBox.SelectedItem?.ToString();
            //bool isLegalEntity = clientController.IsLegalEntity(clientType);

            //string inputValue = isLegalEntity ? companyNameTextBox.Text.Trim() : fullNameTextBox.Text.Trim();
            //string fieldName = isLegalEntity ? "�������� ��������" : "���";

            //if (!inputValue.ValidateInput(fieldName, out string errorMessage))
            //{
            //    MessageBox.Show(errorMessage, "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// ������ ��������� �������
            //ProcessClient(inputValue, clientType, () =>
            //    isLegalEntity
            //        ? clientController.GetCorporateClients().FirstOrDefault(c => c.CompanyName == inputValue)
            //        : clientController.GetIndividualClients().FirstOrDefault(c => c.FullName == inputValue));

            string clientType = customerChoiceComboBox.SelectedItem?.ToString();
            bool isLegalEntity = clientController.IsLegalEntity(clientType);

            string fieldName = isLegalEntity ? "�������� ��������" : "���";
            string clientData = isLegalEntity ? companyNameTextBox.Text.Trim() : fullNameTextBox.Text.Trim();
            bool clientExists = clientController.DoesClientExist(clientData, clientType);

            if (!clientData.ValidateInput(fieldName, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clientExists)
            {
                Form serviceForm = new ServiceForm();
                serviceForm.Show();
                return;
            }

            var result = MessageBox.Show(
                $"������ �� ������ � ���� ������.\n�� ������ �������� ������ �������?\n��� ����������� ������ ������� \"���\".",
                "�������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form clientForm = clientController.GetClientForm(clientType);
                clientForm.Show();
            }
        }

        //private void ProcessClient(string inputValue, string clientType, Func<object> getExistingClient)
        //{
        //    var existingClient = getExistingClient();
        //    if (existingClient == null)
        //    {
        //var result = MessageBox.Show(
        //    $"������ �� ������ � ���� ������.\n�� ������ �������� ������ �������?\n��� ����������� ������ ������� \"���\".",
        //    "�������������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            Form clientForm = clientController.GetClientForm(clientType);
        //clientForm.Show();
        //        }
        //    }
        //    else
        //    {

        //        if (clientController.IsLegalEntity(clientType))
        //        {

        //        }
        //        else
        //        {

        //        }
        //    }
        //}

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string serviceName = servicesCheckedListBox.Items[e.Index].ToString();
            bool isSelected = e.NewValue == CheckState.Checked;

            decimal totalCost = serviceController.HandleServiceSelection(serviceName, isSelected);
            costValue.Text = $"{totalCost} ���.";
        }

        private void idLaboratoryVesselButton_Click(object sender, EventArgs e)
        {
            string fieldName = "��� ������������� ������";
            string orderNumber = idLaboratoryVesselTextBox.Text;

            if (!orderNumber.ValidateInput(fieldName, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "������ �����", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool IsValidVesselCodeFormat(string code)
        {
            string pattern = @"^\d+/[0-9]+$";
            return Regex.IsMatch(code, pattern);
        }

        private void idLaboratoryVesselTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
