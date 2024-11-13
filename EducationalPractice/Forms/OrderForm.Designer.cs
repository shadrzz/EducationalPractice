namespace EducationalPractice
{
    partial class OrderForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idLaboratoryVesselLabel = new Label();
            customerChoiceLabel = new Label();
            idLaboratoryVesselTextBox = new TextBox();
            customerChoiceComboBox = new ComboBox();
            placeOrderButton = new Button();
            fullNameTextBox = new TextBox();
            fullNameLabel = new Label();
            companyNameTextBox = new TextBox();
            companyNameLabel = new Label();
            servicesLabel = new Label();
            servicesCheckedListBox = new CheckedListBox();
            costLabel = new Label();
            costValue = new Label();
            SuspendLayout();
            // 
            // idLaboratoryVesselLabel
            // 
            idLaboratoryVesselLabel.AutoSize = true;
            idLaboratoryVesselLabel.Location = new Point(40, 40);
            idLaboratoryVesselLabel.Name = "idLaboratoryVesselLabel";
            idLaboratoryVesselLabel.Size = new Size(155, 15);
            idLaboratoryVesselLabel.TabIndex = 0;
            idLaboratoryVesselLabel.Text = "Код лабораторного сосуда";
            // 
            // customerChoiceLabel
            // 
            customerChoiceLabel.AutoSize = true;
            customerChoiceLabel.Location = new Point(40, 100);
            customerChoiceLabel.Name = "customerChoiceLabel";
            customerChoiceLabel.Size = new Size(101, 15);
            customerChoiceLabel.TabIndex = 1;
            customerChoiceLabel.Text = "Выбор заказчика";
            // 
            // idLaboratoryVesselTextBox
            // 
            idLaboratoryVesselTextBox.Location = new Point(250, 40);
            idLaboratoryVesselTextBox.Name = "idLaboratoryVesselTextBox";
            idLaboratoryVesselTextBox.Size = new Size(120, 23);
            idLaboratoryVesselTextBox.TabIndex = 2;
            // 
            // customerChoiceComboBox
            // 
            customerChoiceComboBox.FormattingEnabled = true;
            customerChoiceComboBox.Location = new Point(250, 100);
            customerChoiceComboBox.Name = "customerChoiceComboBox";
            customerChoiceComboBox.Size = new Size(120, 23);
            customerChoiceComboBox.TabIndex = 3;
            customerChoiceComboBox.SelectedIndexChanged += customerChoiceComboBox_SelectedIndexChanged;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(599, 40);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(150, 50);
            placeOrderButton.TabIndex = 5;
            placeOrderButton.Text = "Оформить заказ";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(250, 162);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(293, 23);
            fullNameTextBox.TabIndex = 7;
            fullNameTextBox.Visible = false;
            fullNameTextBox.TextChanged += fullNameTextBox_TextChanged;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(40, 162);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(34, 15);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "ФИО";
            fullNameLabel.Visible = false;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Location = new Point(250, 195);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(293, 23);
            companyNameTextBox.TabIndex = 9;
            companyNameTextBox.Visible = false;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(40, 195);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(118, 15);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Название компании";
            companyNameLabel.Visible = false;
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Location = new Point(40, 233);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(45, 15);
            servicesLabel.TabIndex = 10;
            servicesLabel.Text = "Услуги";
            servicesLabel.Visible = false;
            // 
            // servicesCheckedListBox
            // 
            servicesCheckedListBox.FormattingEnabled = true;
            servicesCheckedListBox.Location = new Point(250, 233);
            servicesCheckedListBox.Name = "servicesCheckedListBox";
            servicesCheckedListBox.Size = new Size(293, 112);
            servicesCheckedListBox.TabIndex = 12;
            servicesCheckedListBox.Visible = false;
            servicesCheckedListBox.ItemCheck += servicesCheckedListBox_ItemCheck;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(598, 108);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(70, 15);
            costLabel.TabIndex = 13;
            costLabel.Text = "Стоимость:";
            costLabel.Visible = false;
            // 
            // costValue
            // 
            costValue.AutoSize = true;
            costValue.Location = new Point(665, 108);
            costValue.Name = "costValue";
            costValue.Size = new Size(13, 15);
            costValue.TabIndex = 14;
            costValue.Text = "0";
            costValue.Visible = false;
            // 
            // OrderFormation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 412);
            Controls.Add(costValue);
            Controls.Add(costLabel);
            Controls.Add(servicesCheckedListBox);
            Controls.Add(servicesLabel);
            Controls.Add(companyNameTextBox);
            Controls.Add(companyNameLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(placeOrderButton);
            Controls.Add(customerChoiceComboBox);
            Controls.Add(idLaboratoryVesselTextBox);
            Controls.Add(customerChoiceLabel);
            Controls.Add(idLaboratoryVesselLabel);
            Name = "OrderFormation";
            Text = "OrderFormation";
            Load += OrderFormation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLaboratoryVesselLabel;
        private Label customerChoiceLabel;
        private TextBox idLaboratoryVesselTextBox;
        private ComboBox customerChoiceComboBox;
        private Button placeOrderButton;
        private TextBox fullNameTextBox;
        private Label fullNameLabel;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private Label servicesLabel;
        private CheckedListBox servicesCheckedListBox;
        private Label costLabel;
        private Label costValue;
    }
}
