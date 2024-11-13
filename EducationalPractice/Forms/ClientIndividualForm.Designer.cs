namespace EducationalPractice.Forms
{
    partial class ClientIndividualForm
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
            saveButton = new Button();
            emailTextBox = new TextBox();
            dateOfBirthLabel = new Label();
            dateOfBirthTextBox = new TextBox();
            passportDataLabel = new Label();
            passportDataTextBox = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            emailLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.Location = new Point(12, 349);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(460, 50);
            saveButton.TabIndex = 0;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(12, 109);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 23);
            emailTextBox.TabIndex = 1;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(12, 144);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(93, 15);
            dateOfBirthLabel.TabIndex = 6;
            dateOfBirthLabel.Text = "Дата рождения:";
            // 
            // dateOfBirthTextBox
            // 
            dateOfBirthTextBox.Location = new Point(12, 162);
            dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            dateOfBirthTextBox.Size = new Size(200, 23);
            dateOfBirthTextBox.TabIndex = 5;
            // 
            // passportDataLabel
            // 
            passportDataLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passportDataLabel.AutoSize = true;
            passportDataLabel.Location = new Point(235, 40);
            passportDataLabel.Name = "passportDataLabel";
            passportDataLabel.Size = new Size(147, 15);
            passportDataLabel.TabIndex = 8;
            passportDataLabel.Text = "Серия и номер паспорта:";
            // 
            // passportDataTextBox
            // 
            passportDataTextBox.Location = new Point(235, 58);
            passportDataTextBox.Name = "passportDataTextBox";
            passportDataTextBox.Size = new Size(225, 23);
            passportDataTextBox.TabIndex = 7;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(235, 91);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(104, 15);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Номер телефона:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(235, 109);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(225, 23);
            phoneNumberTextBox.TabIndex = 9;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 40);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(37, 15);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "ФИО:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(12, 58);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(200, 23);
            fullNameTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 91);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Электронная почта:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 195);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(43, 15);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 213);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 23);
            addressTextBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(235, 144);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 15);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(235, 162);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(225, 23);
            passwordTextBox.TabIndex = 13;
            // 
            // ClientIndividualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(passwordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(addressLabel);
            Controls.Add(addressTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(passportDataLabel);
            Controls.Add(passportDataTextBox);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(dateOfBirthTextBox);
            Controls.Add(fullNameTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(saveButton);
            Controls.Add(fullNameLabel);
            MinimumSize = new Size(500, 450);
            Name = "ClientIndividualForm";
            Text = "Добавление нового клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private TextBox emailTextBox;
        private Label dateOfBirthLabel;
        private TextBox dateOfBirthTextBox;
        private Label passportDataLabel;
        private TextBox passportDataTextBox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label emailLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
    }
}