namespace EducationalPractice
{
    partial class OrderFormSand
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
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
            customerChoiceLabel.Location = new Point(12, 75);
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
            tableLayoutPanel1.SetColumnSpan(servicesCheckedListBox, 2);
            servicesCheckedListBox.FormattingEnabled = true;
            servicesCheckedListBox.Location = new Point(0, 0);
            servicesCheckedListBox.Margin = new Padding(0);
            servicesCheckedListBox.Name = "servicesCheckedListBox";
            servicesCheckedListBox.Size = new Size(308, 112);
            servicesCheckedListBox.TabIndex = 12;
            servicesCheckedListBox.Visible = false;
            servicesCheckedListBox.ItemCheck += servicesCheckedListBox_ItemCheck;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(0, 113);
            costLabel.Margin = new Padding(0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(70, 15);
            costLabel.TabIndex = 13;
            costLabel.Text = "Стоимость:";
            costLabel.Visible = false;
            // 
            // costValue
            // 
            costValue.AutoSize = true;
            costValue.Location = new Point(70, 113);
            costValue.Margin = new Padding(0);
            costValue.Name = "costValue";
            costValue.Size = new Size(39, 15);
            costValue.TabIndex = 14;
            costValue.Text = "0 руб.";
            costValue.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(servicesCheckedListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(costValue, 1, 1);
            tableLayoutPanel1.Controls.Add(costLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(239, 93);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(308, 128);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // OrderFormSand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
            Controls.Add(tableLayoutPanel1);
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
            Name = "OrderFormSand";
            Text = "Формирование заказа";
            Load += OrderFormation_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
