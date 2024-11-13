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
            idLaboratoryVesselLabel.Location = new Point(12, 25);
            idLaboratoryVesselLabel.Name = "idLaboratoryVesselLabel";
            idLaboratoryVesselLabel.Size = new Size(158, 15);
            idLaboratoryVesselLabel.TabIndex = 0;
            idLaboratoryVesselLabel.Text = "Код лабораторного сосуда:";
            // 
            // customerChoiceLabel
            // 
            customerChoiceLabel.AutoSize = true;
            customerChoiceLabel.Location = new Point(12, 76);
            customerChoiceLabel.Name = "customerChoiceLabel";
            customerChoiceLabel.Size = new Size(104, 15);
            customerChoiceLabel.TabIndex = 1;
            customerChoiceLabel.Text = "Выбор заказчика:";
            // 
            // idLaboratoryVesselTextBox
            // 
            idLaboratoryVesselTextBox.Location = new Point(12, 43);
            idLaboratoryVesselTextBox.Name = "idLaboratoryVesselTextBox";
            idLaboratoryVesselTextBox.Size = new Size(174, 23);
            idLaboratoryVesselTextBox.TabIndex = 2;
            // 
            // customerChoiceComboBox
            // 
            customerChoiceComboBox.FormattingEnabled = true;
            customerChoiceComboBox.Location = new Point(12, 93);
            customerChoiceComboBox.Name = "customerChoiceComboBox";
            customerChoiceComboBox.Size = new Size(174, 23);
            customerChoiceComboBox.TabIndex = 3;
            customerChoiceComboBox.SelectedIndexChanged += customerChoiceComboBox_SelectedIndexChanged;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(12, 158);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(174, 47);
            placeOrderButton.TabIndex = 5;
            placeOrderButton.Text = "Оформить заказ";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(239, 43);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(308, 23);
            fullNameTextBox.TabIndex = 7;
            fullNameTextBox.Visible = false;
            fullNameTextBox.TextChanged += fullNameTextBox_TextChanged;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(238, 25);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(37, 15);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "ФИО:";
            fullNameLabel.Visible = false;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyNameTextBox.Location = new Point(239, 43);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(308, 23);
            companyNameTextBox.TabIndex = 9;
            companyNameTextBox.Visible = false;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(239, 25);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(121, 15);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Название компании:";
            companyNameLabel.Visible = false;
            // 
            // servicesLabel
            // 
            servicesLabel.AutoSize = true;
            servicesLabel.Location = new Point(239, 75);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(48, 15);
            servicesLabel.TabIndex = 10;
            servicesLabel.Text = "Услуги:";
            servicesLabel.Visible = false;
            // 
            // servicesCheckedListBox
            // 
            servicesCheckedListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            servicesCheckedListBox.FormattingEnabled = true;
            servicesCheckedListBox.Location = new Point(239, 93);
            servicesCheckedListBox.Name = "servicesCheckedListBox";
            servicesCheckedListBox.Size = new Size(308, 112);
            servicesCheckedListBox.TabIndex = 12;
            servicesCheckedListBox.Visible = false;
            servicesCheckedListBox.ItemCheck += servicesCheckedListBox_ItemCheck;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(239, 208);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(70, 15);
            costLabel.TabIndex = 13;
            costLabel.Text = "Стоимость:";
            costLabel.Visible = false;
            // 
            // costValue
            // 
            costValue.AutoSize = true;
            costValue.Location = new Point(315, 208);
            costValue.Name = "costValue";
            costValue.Size = new Size(39, 15);
            costValue.TabIndex = 14;
            costValue.Text = "0 руб.";
            costValue.Visible = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
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
            Location = new Point(12, 50);
            MinimumSize = new Size(575, 300);
            Name = "OrderForm";
            Text = "Формирование заказа";
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
