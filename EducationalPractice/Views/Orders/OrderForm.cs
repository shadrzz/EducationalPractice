using EducationalPractice.Controllers;
using EducationalPractice.Models.Client;

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

        private void placeOrderButton_Click(object sender, EventArgs e)
        {
            string clientType = customerChoiceComboBox.SelectedItem?.ToString();
            string fullName = fullNameTextBox.Text.Trim();
            string companyName = companyNameTextBox.Text.Trim();

            var result = orderController.HandleOrder(clientType, fullName, companyName, clientController);

            if (!result.Success)
            {
                if (result.Message == "Поле ФИО пустое." || result.Message == "Поле названия компании пустое.")
                {
                    MessageBox.Show(result.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Клиент не найден в базе данных.\nВы хотите добавить нового клиента?\nДля исправления данных нажмите \"Нет\".",
                    "Клиент не найден",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Form clientForm = clientController.GetClientForm(clientType);
                    clientForm.Show();
                }
            }
            else
            {
                MessageBox.Show(result.Message, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void servicesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string serviceName = servicesCheckedListBox.Items[e.Index].ToString();
            bool isSelected = e.NewValue == CheckState.Checked;

            decimal totalCost = serviceController.HandleServiceSelection(serviceName, isSelected);
            costValue.Text = $"{totalCost} руб.";
        }
    }
}
