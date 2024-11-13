namespace EducationalPractice
{
    partial class OrderFormation
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
            resetButton = new Button();
            saveButton = new Button();
            fullNameLabelTextBox = new TextBox();
            fullNameLabel = new Label();
            companyNameTextBox = new TextBox();
            companyNameLabel = new Label();
            servicesLabel = new Label();
            servicesCheckedListBox = new CheckedListBox();
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
            // resetButton
            // 
            resetButton.Location = new Point(599, 118);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 50);
            resetButton.TabIndex = 4;
            resetButton.Text = "Сброс";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(599, 40);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 50);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // fullNameLabelTextBox
            // 
            fullNameLabelTextBox.Location = new Point(250, 162);
            fullNameLabelTextBox.Name = "fullNameLabelTextBox";
            fullNameLabelTextBox.Size = new Size(293, 23);
            fullNameLabelTextBox.TabIndex = 7;
            fullNameLabelTextBox.Visible = false;
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
            companyNameTextBox.Location = new Point(250, 162);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(293, 23);
            companyNameTextBox.TabIndex = 9;
            companyNameTextBox.Visible = false;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(40, 162);
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
            // 
            // OrderFormation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 412);
            Controls.Add(servicesCheckedListBox);
            Controls.Add(servicesLabel);
            Controls.Add(companyNameTextBox);
            Controls.Add(companyNameLabel);
            Controls.Add(fullNameLabelTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(saveButton);
            Controls.Add(resetButton);
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
        private Button resetButton;
        private Button saveButton;
        private TextBox fullNameLabelTextBox;
        private Label fullNameLabel;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private Label servicesLabel;
        private CheckedListBox servicesCheckedListBox;
    }
}
