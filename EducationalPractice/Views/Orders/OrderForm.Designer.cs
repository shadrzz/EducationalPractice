﻿namespace EducationalPractice
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
            idLaboratoryVesselButton = new Button();
            SuspendLayout();
            // 
            // idLaboratoryVesselLabel
            // 
            idLaboratoryVesselLabel.AutoSize = true;
            idLaboratoryVesselLabel.Location = new Point(30, 30);
            idLaboratoryVesselLabel.Name = "idLaboratoryVesselLabel";
            idLaboratoryVesselLabel.Size = new Size(158, 15);
            idLaboratoryVesselLabel.TabIndex = 0;
            idLaboratoryVesselLabel.Text = "Код лабораторного сосуда:";
            // 
            // customerChoiceLabel
            // 
            customerChoiceLabel.AutoSize = true;
            customerChoiceLabel.Location = new Point(30, 81);
            customerChoiceLabel.Name = "customerChoiceLabel";
            customerChoiceLabel.Size = new Size(104, 15);
            customerChoiceLabel.TabIndex = 1;
            customerChoiceLabel.Text = "Выбор заказчика:";
            customerChoiceLabel.Visible = false;
            // 
            // idLaboratoryVesselTextBox
            // 
            idLaboratoryVesselTextBox.Location = new Point(30, 48);
            idLaboratoryVesselTextBox.Name = "idLaboratoryVesselTextBox";
            idLaboratoryVesselTextBox.Size = new Size(174, 23);
            idLaboratoryVesselTextBox.TabIndex = 0;
            idLaboratoryVesselTextBox.TextChanged += idLaboratoryVesselTextBox_TextChanged;
            // 
            // customerChoiceComboBox
            // 
            customerChoiceComboBox.FormattingEnabled = true;
            customerChoiceComboBox.Location = new Point(30, 99);
            customerChoiceComboBox.Name = "customerChoiceComboBox";
            customerChoiceComboBox.Size = new Size(174, 23);
            customerChoiceComboBox.TabIndex = 1;
            customerChoiceComboBox.Visible = false;
            customerChoiceComboBox.SelectedIndexChanged += customerChoiceComboBox_SelectedIndexChanged;
            // 
            // placeOrderButton
            // 
            placeOrderButton.Location = new Point(30, 164);
            placeOrderButton.Name = "placeOrderButton";
            placeOrderButton.Size = new Size(174, 47);
            placeOrderButton.TabIndex = 100;
            placeOrderButton.Text = "Оформить заказ";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Visible = false;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBox.Location = new Point(239, 48);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(279, 23);
            fullNameTextBox.TabIndex = 3;
            fullNameTextBox.Visible = false;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(238, 30);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(37, 15);
            fullNameLabel.TabIndex = 6;
            fullNameLabel.Text = "ФИО:";
            fullNameLabel.Visible = false;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyNameTextBox.Location = new Point(239, 48);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(279, 23);
            companyNameTextBox.TabIndex = 2;
            companyNameTextBox.Visible = false;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(239, 30);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(121, 15);
            companyNameLabel.TabIndex = 8;
            companyNameLabel.Text = "Название компании:";
            companyNameLabel.Visible = false;
            // 
            // idLaboratoryVesselButton
            // 
            idLaboratoryVesselButton.Location = new Point(30, 164);
            idLaboratoryVesselButton.Name = "idLaboratoryVesselButton";
            idLaboratoryVesselButton.Size = new Size(174, 47);
            idLaboratoryVesselButton.TabIndex = 101;
            idLaboratoryVesselButton.Text = "Подтвердить";
            idLaboratoryVesselButton.UseVisualStyleBackColor = true;
            idLaboratoryVesselButton.Click += idLaboratoryVesselButton_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
            Controls.Add(idLaboratoryVesselButton);
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
        private Button idLaboratoryVesselButton;
    }
}
