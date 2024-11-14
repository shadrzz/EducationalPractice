using EducationalPractice.Controllers;
using EducationalPractice.Models.Client;

namespace EducationalPractice
{
    public partial class OrderForm : Form
    {
        private readonly OrderController orderController;
        private readonly ClientController clientController;
        private readonly ServiceController serviceController;

        public OrderForm()
        {
            InitializeComponent();
            orderController = new OrderController();
            clientController = new ClientController();
            serviceController = new ServiceController();
        }

        private void OrderFormation_Load(object sender, EventArgs e)
        {
            idLaboratoryVesselTextBox.Text = orderController.GetNextOrderNumber();
            idLaboratoryVesselTextBox.KeyPress += IdLaboratoryVesselTextBox_KeyPress;

            string[] customerItems = orderController.GetCustomerTypes();
            customerChoiceComboBox.Items.AddRange(customerItems);
            customerChoiceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            var serviceNames = serviceController.GetServiceNames();
            servicesCheckedListBox.Items.AddRange(serviceNames.ToArray());
        }

        private void IdLaboratoryVesselTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string enteredVesselNumber = idLaboratoryVesselTextBox.Text;
                string validationMessage = orderController.ValidateVesselNumber(enteredVesselNumber);
                MessageBox.Show(validationMessage);
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
            servicesLabel.Visible = true;
            servicesCheckedListBox.Visible = true;
            costLabel.Visible = true;
            costValue.Visible = true;
        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text.Trim();
            ClientAddResult result = clientController.AddIndividualClientIfNotExists(fullName);
            MessageBox.Show(result.Message);
        }

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string clientType = customerChoiceComboBox.SelectedItem.ToString();
            Form clientForm = clientController.GetClientForm(clientType);
            clientForm.Show();
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = servicesCheckedListBox.Items[e.Index].ToString();
            var selectedServices = servicesCheckedListBox.CheckedItems.Cast<string>().ToList();

            if (e.NewValue == CheckState.Checked)
                selectedServices.Add(item);
            else
                selectedServices.Remove(item);

            costValue.Text = $"{serviceController.CalculateTotalCost(selectedServices)} руб.";
        }
    }
}
