namespace EducationalPractice.Forms
{
    partial class ClientCorporateFormSand
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
            bikLabel = new Label();
            passwordTextBox = new TextBox();
            ceoNameLabel = new Label();
            ceoNameTextBox = new TextBox();
            contactPersonNameLabel = new Label();
            contactPersonNameTextBox = new TextBox();
            contactPhoneLabel = new Label();
            contactPhoneTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            bikTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            accountNumberLabel = new Label();
            companyNameTextBox = new TextBox();
            companyNameLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            innLabel = new Label();
            innLabelTextBox = new TextBox();
            accountNumberTextBox = new TextBox();
            saveButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // bikLabel
            // 
            bikLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bikLabel.AutoSize = true;
            bikLabel.Location = new Point(3, 204);
            bikLabel.Name = "bikLabel";
            bikLabel.Size = new Size(196, 15);
            bikLabel.TabIndex = 13;
            bikLabel.Text = "БИК:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(225, 222);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(196, 23);
            passwordTextBox.TabIndex = 12;
            // 
            // ceoNameLabel
            // 
            ceoNameLabel.AutoSize = true;
            ceoNameLabel.Dock = DockStyle.Fill;
            ceoNameLabel.Location = new Point(225, 0);
            ceoNameLabel.Name = "ceoNameLabel";
            ceoNameLabel.RightToLeft = RightToLeft.No;
            ceoNameLabel.Size = new Size(196, 15);
            ceoNameLabel.TabIndex = 15;
            ceoNameLabel.Text = "ФИО руководителя:";
            // 
            // ceoNameTextBox
            // 
            ceoNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ceoNameTextBox.Location = new Point(225, 18);
            ceoNameTextBox.Name = "ceoNameTextBox";
            ceoNameTextBox.Size = new Size(196, 23);
            ceoNameTextBox.TabIndex = 14;
            // 
            // contactPersonNameLabel
            // 
            contactPersonNameLabel.AutoSize = true;
            contactPersonNameLabel.Location = new Point(225, 51);
            contactPersonNameLabel.Name = "contactPersonNameLabel";
            contactPersonNameLabel.Size = new Size(138, 15);
            contactPersonNameLabel.TabIndex = 17;
            contactPersonNameLabel.Text = "ФИО контактного лица:";
            // 
            // contactPersonNameTextBox
            // 
            contactPersonNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contactPersonNameTextBox.Location = new Point(225, 69);
            contactPersonNameTextBox.Name = "contactPersonNameTextBox";
            contactPersonNameTextBox.Size = new Size(196, 23);
            contactPersonNameTextBox.TabIndex = 16;
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new Point(225, 102);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new Size(175, 15);
            contactPhoneLabel.TabIndex = 19;
            contactPhoneLabel.Text = "Номер телефона контактного лица:";
            // 
            // contactPhoneTextBox
            // 
            contactPhoneTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            contactPhoneTextBox.Location = new Point(225, 120);
            contactPhoneTextBox.Name = "contactPhoneTextBox";
            contactPhoneTextBox.Size = new Size(196, 23);
            contactPhoneTextBox.TabIndex = 18;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(225, 153);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(116, 15);
            emailLabel.TabIndex = 21;
            emailLabel.Text = "Электронная почта:";
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(225, 171);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(196, 23);
            emailTextBox.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(225, 204);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(52, 15);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Пароль:";
            // 
            // bikTextBox
            // 
            bikTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bikTextBox.Location = new Point(3, 222);
            bikTextBox.Name = "bikTextBox";
            bikTextBox.Size = new Size(196, 23);
            bikTextBox.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(passwordLabel, 2, 12);
            tableLayoutPanel1.Controls.Add(accountNumberLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(companyNameTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(emailTextBox, 2, 10);
            tableLayoutPanel1.Controls.Add(emailLabel, 2, 9);
            tableLayoutPanel1.Controls.Add(companyNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(addressLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(contactPhoneTextBox, 2, 7);
            tableLayoutPanel1.Controls.Add(contactPhoneLabel, 2, 6);
            tableLayoutPanel1.Controls.Add(addressTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(innLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(contactPersonNameTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(innLabelTextBox, 0, 7);
            tableLayoutPanel1.Controls.Add(bikLabel, 0, 12);
            tableLayoutPanel1.Controls.Add(ceoNameTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(ceoNameLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(contactPersonNameLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(accountNumberTextBox, 0, 10);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 2, 13);
            tableLayoutPanel1.Controls.Add(bikTextBox, 0, 13);
            tableLayoutPanel1.Controls.Add(saveButton, 0, 15);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 16;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.Size = new Size(424, 351);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(3, 153);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(196, 15);
            accountNumberLabel.TabIndex = 26;
            accountNumberLabel.Text = "Расчётный счёт:";
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyNameTextBox.Location = new Point(3, 18);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(196, 23);
            companyNameTextBox.TabIndex = 25;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Dock = DockStyle.Fill;
            companyNameLabel.Location = new Point(3, 0);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(196, 15);
            companyNameLabel.TabIndex = 25;
            companyNameLabel.Text = "Название компании:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(3, 51);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(196, 15);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(3, 69);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(196, 23);
            addressTextBox.TabIndex = 25;
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new Point(3, 102);
            innLabel.Name = "innLabel";
            innLabel.Size = new Size(37, 15);
            innLabel.TabIndex = 25;
            innLabel.Text = "ИНН:";
            // 
            // innLabelTextBox
            // 
            innLabelTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            innLabelTextBox.Location = new Point(3, 120);
            innLabelTextBox.Name = "innLabelTextBox";
            innLabelTextBox.Size = new Size(196, 23);
            innLabelTextBox.TabIndex = 25;
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountNumberTextBox.Location = new Point(3, 171);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(196, 23);
            accountNumberTextBox.TabIndex = 25;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(saveButton, 3);
            saveButton.Location = new Point(3, 279);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(418, 69);
            saveButton.TabIndex = 27;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // ClientCorporateFormSand
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(500, 450);
            Name = "ClientCorporateFormSand";
            Padding = new Padding(30);
            Text = "Добавление нового клиента";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label bikLabel;
        private TextBox passwordTextBox;
        private Label ceoNameLabel;
        private TextBox ceoNameTextBox;
        private Label contactPersonNameLabel;
        private TextBox contactPersonNameTextBox;
        private Label contactPhoneLabel;
        private TextBox contactPhoneTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private TextBox bikTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox accountNumberTextBox;
        private Label accountNumberLabel;
        private Label innLabel;
        private TextBox innLabelTextBox;
        private Button saveButton;
    }
}