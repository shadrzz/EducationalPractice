namespace EducationalPractice.Forms
{
    partial class ClientCorporateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            companyNameLabel = new Label();
            companyNameTextBox = new TextBox();
            saveButton = new Button();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            innLabel = new Label();
            innLabelTextBox = new TextBox();
            accountNumberLabel = new Label();
            accountNumberTextBox = new TextBox();
            bikLabel = new Label();
            bikTextBox = new TextBox();
            ceoNameLabel = new Label();
            ceoNameLabelTextBox = new TextBox();
            contactPersonNameLabel = new Label();
            contactPersonNameTextBox = new TextBox();
            contactPhoneLabel = new Label();
            contactPhoneTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(12, 40);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(121, 15);
            companyNameLabel.TabIndex = 4;
            companyNameLabel.Text = "Название компании:";
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyNameTextBox.Location = new Point(12, 58);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(200, 23);
            companyNameTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Location = new Point(12, 349);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(460, 50);
            saveButton.TabIndex = 5;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 91);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(43, 15);
            addressLabel.TabIndex = 7;
            addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 109);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 23);
            addressTextBox.TabIndex = 6;
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new Point(12, 141);
            innLabel.Name = "innLabel";
            innLabel.Size = new Size(37, 15);
            innLabel.TabIndex = 9;
            innLabel.Text = "ИНН:";
            // 
            // innLabelTextBox
            // 
            innLabelTextBox.Location = new Point(12, 159);
            innLabelTextBox.Name = "innLabelTextBox";
            innLabelTextBox.Size = new Size(200, 23);
            innLabelTextBox.TabIndex = 8;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(12, 192);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(97, 15);
            accountNumberLabel.TabIndex = 11;
            accountNumberLabel.Text = "Расчётный счёт:";
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(12, 210);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(200, 23);
            accountNumberTextBox.TabIndex = 10;
            // 
            // bikLabel
            // 
            bikLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bikLabel.AutoSize = true;
            bikLabel.Location = new Point(12, 243);
            bikLabel.Name = "bikLabel";
            bikLabel.Size = new Size(33, 15);
            bikLabel.TabIndex = 13;
            bikLabel.Text = "БИК:";
            // 
            // bikTextBox
            // 
            bikTextBox.Location = new Point(12, 261);
            bikTextBox.Name = "bikTextBox";
            bikTextBox.Size = new Size(200, 23);
            bikTextBox.TabIndex = 12;
            // 
            // ceoNameLabel
            // 
            ceoNameLabel.Anchor = AnchorStyles.Right;
            ceoNameLabel.AutoSize = true;
            ceoNameLabel.Location = new Point(235, 40);
            ceoNameLabel.Name = "ceoNameLabel";
            ceoNameLabel.Size = new Size(116, 15);
            ceoNameLabel.TabIndex = 15;
            ceoNameLabel.Text = "ФИО руководителя:";
            // 
            // ceoNameLabelTextBox
            // 
            ceoNameLabelTextBox.Anchor = AnchorStyles.Right;
            ceoNameLabelTextBox.Location = new Point(235, 58);
            ceoNameLabelTextBox.Name = "ceoNameLabelTextBox";
            ceoNameLabelTextBox.Size = new Size(200, 23);
            ceoNameLabelTextBox.TabIndex = 14;
            // 
            // contactPersonNameLabel
            // 
            contactPersonNameLabel.Anchor = AnchorStyles.Right;
            contactPersonNameLabel.AutoSize = true;
            contactPersonNameLabel.Location = new Point(235, 91);
            contactPersonNameLabel.Name = "contactPersonNameLabel";
            contactPersonNameLabel.Size = new Size(138, 15);
            contactPersonNameLabel.TabIndex = 17;
            contactPersonNameLabel.Text = "ФИО контактного лица:";
            // 
            // contactPersonNameTextBox
            // 
            contactPersonNameTextBox.Anchor = AnchorStyles.Right;
            contactPersonNameTextBox.Location = new Point(235, 109);
            contactPersonNameTextBox.Name = "contactPersonNameTextBox";
            contactPersonNameTextBox.Size = new Size(200, 23);
            contactPersonNameTextBox.TabIndex = 16;
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.Anchor = AnchorStyles.Right;
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new Point(235, 141);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new Size(205, 15);
            contactPhoneLabel.TabIndex = 19;
            contactPhoneLabel.Text = "Номер телефона контактного лица:";
            // 
            // contactPhoneTextBox
            // 
            contactPhoneTextBox.Anchor = AnchorStyles.Right;
            contactPhoneTextBox.Location = new Point(235, 159);
            contactPhoneTextBox.Name = "contactPhoneTextBox";
            contactPhoneTextBox.Size = new Size(200, 23);
            contactPhoneTextBox.TabIndex = 18;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(235, 192);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 15);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Электронная почта:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Right;
            emailTextBox.Location = new Point(235, 210);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 23);
            emailTextBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(235, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 15);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Right;
            passwordTextBox.Location = new Point(235, 261);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.TabIndex = 22;
            // 
            // ClientCorporateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(contactPhoneLabel);
            Controls.Add(contactPhoneTextBox);
            Controls.Add(contactPersonNameLabel);
            Controls.Add(contactPersonNameTextBox);
            Controls.Add(ceoNameLabel);
            Controls.Add(ceoNameLabelTextBox);
            Controls.Add(bikLabel);
            Controls.Add(bikTextBox);
            Controls.Add(accountNumberLabel);
            Controls.Add(accountNumberTextBox);
            Controls.Add(innLabel);
            Controls.Add(innLabelTextBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(saveButton);
            Controls.Add(companyNameLabel);
            Controls.Add(companyNameTextBox);
            MinimumSize = new Size(500, 450);
            Name = "ClientCorporateForm";
            Text = "Добавление нового клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label companyNameLabel;
        private TextBox companyNameTextBox;
        private Button saveButton;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label innLabel;
        private TextBox innLabelTextBox;
        private Label accountNumberLabel;
        private TextBox accountNumberTextBox;
        private Label bikLabel;
        private TextBox bikTextBox;
        private Label ceoNameLabel;
        private TextBox ceoNameLabelTextBox;
        private Label contactPersonNameLabel;
        private TextBox contactPersonNameTextBox;
        private Label contactPhoneLabel;
        private TextBox contactPhoneTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
    }
}