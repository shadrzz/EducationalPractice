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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientIndividualForm));
            emailTextBox = new TextBox();
            dateOfBirthLabel = new Label();
            dateOfBirthTextBox = new TextBox();
            passportDataLabel = new Label();
            passportDataTextBox = new TextBox();
            fullNameLabel = new Label();
            fullNameTextBox = new TextBox();
            emailLabel = new Label();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            clientIdLabel = new Label();
            addClientButton = new Button();
            clientIdTextBox = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailTextBox.Location = new Point(250, 69);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(221, 23);
            emailTextBox.TabIndex = 6;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(3, 153);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(221, 15);
            dateOfBirthLabel.TabIndex = 6;
            dateOfBirthLabel.Text = "Дата рождения:";
            // 
            // dateOfBirthTextBox
            // 
            dateOfBirthTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateOfBirthTextBox.Location = new Point(3, 171);
            dateOfBirthTextBox.Name = "dateOfBirthTextBox";
            dateOfBirthTextBox.Size = new Size(221, 23);
            dateOfBirthTextBox.TabIndex = 4;
            // 
            // passportDataLabel
            // 
            passportDataLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passportDataLabel.AutoSize = true;
            passportDataLabel.Location = new Point(3, 102);
            passportDataLabel.Name = "passportDataLabel";
            passportDataLabel.Size = new Size(221, 15);
            passportDataLabel.TabIndex = 8;
            passportDataLabel.Text = "Серия и номер паспорта:";
            // 
            // passportDataTextBox
            // 
            passportDataTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passportDataTextBox.Location = new Point(3, 120);
            passportDataTextBox.Name = "passportDataTextBox";
            passportDataTextBox.Size = new Size(221, 23);
            passportDataTextBox.TabIndex = 3;
            // 
            // fullNameLabel
            // 
            fullNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(3, 51);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(221, 15);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "ФИО:";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBox.Location = new Point(3, 69);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(221, 23);
            fullNameTextBox.TabIndex = 2;
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(250, 51);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(221, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Электронная почта:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(250, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(221, 15);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressTextBox.Location = new Point(250, 18);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(221, 23);
            addressTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(250, 102);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(221, 15);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Пароль:";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.Location = new Point(250, 120);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(221, 23);
            passwordTextBox.TabIndex = 7;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(clientIdLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 2, 7);
            tableLayoutPanel1.Controls.Add(passwordLabel, 2, 6);
            tableLayoutPanel1.Controls.Add(addClientButton, 0, 12);
            tableLayoutPanel1.Controls.Add(addressLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(addressTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(dateOfBirthTextBox, 0, 10);
            tableLayoutPanel1.Controls.Add(dateOfBirthLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(fullNameTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(fullNameLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(clientIdTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(passportDataLabel, 0, 6);
            tableLayoutPanel1.Controls.Add(passportDataTextBox, 0, 7);
            tableLayoutPanel1.Controls.Add(emailLabel, 2, 3);
            tableLayoutPanel1.Controls.Add(emailTextBox, 2, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(30, 30);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
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
            tableLayoutPanel1.Size = new Size(474, 351);
            tableLayoutPanel1.TabIndex = 25;
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new Point(3, 0);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new Size(55, 15);
            clientIdLabel.TabIndex = 31;
            clientIdLabel.Text = "Client ID:";
            // 
            // addClientButton
            // 
            addClientButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(addClientButton, 3);
            addClientButton.Location = new Point(3, 279);
            addClientButton.Name = "addClientButton";
            addClientButton.Size = new Size(468, 69);
            addClientButton.TabIndex = 10;
            addClientButton.Text = "Сохранить";
            addClientButton.UseVisualStyleBackColor = true;
            addClientButton.Click += addClientButton_Click;
            // 
            // clientIdTextBox
            // 
            clientIdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientIdTextBox.Location = new Point(3, 18);
            clientIdTextBox.Name = "clientIdTextBox";
            clientIdTextBox.Size = new Size(221, 23);
            clientIdTextBox.TabIndex = 1;
            // 
            // ClientIndividualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 411);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(550, 450);
            Name = "ClientIndividualForm";
            Padding = new Padding(30);
            Text = "ЗАО «Русская косметика» | Добавление физического лица";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox emailTextBox;
        private Label dateOfBirthLabel;
        private TextBox dateOfBirthTextBox;
        private Label passportDataLabel;
        private TextBox passportDataTextBox;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label emailLabel;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addClientButton;
        private Label clientIdLabel;
        private TextBox clientIdTextBox;
    }
}