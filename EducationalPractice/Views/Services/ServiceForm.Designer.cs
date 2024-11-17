namespace EducationalPractice.Views.Services
{
    partial class ServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            servicesCheckedListBox = new CheckedListBox();
            costValue = new Label();
            costLabel = new Label();
            servicesLabel = new Label();
            addOrderButton = new Button();
            clientIdLabel = new Label();
            passportDataLabel = new Label();
            dateOfBirthLabel = new Label();
            individualAddressLabel = new Label();
            individualEmailLabel = new Label();
            companyNameLabel = new Label();
            corporateAddressLabel = new Label();
            innLabel = new Label();
            accountNumberLabel = new Label();
            bikLabel = new Label();
            contactPhoneLabel = new Label();
            corporateEmailLabel = new Label();
            ceoNameLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(servicesCheckedListBox, 0, 0);
            tableLayoutPanel1.Controls.Add(costValue, 1, 1);
            tableLayoutPanel1.Controls.Add(costLabel, 0, 1);
            tableLayoutPanel1.Location = new Point(427, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(279, 132);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // servicesCheckedListBox
            // 
            servicesCheckedListBox.Anchor = AnchorStyles.None;
            tableLayoutPanel1.SetColumnSpan(servicesCheckedListBox, 2);
            servicesCheckedListBox.FormattingEnabled = true;
            servicesCheckedListBox.Location = new Point(0, 2);
            servicesCheckedListBox.Margin = new Padding(0);
            servicesCheckedListBox.Name = "servicesCheckedListBox";
            servicesCheckedListBox.Size = new Size(279, 112);
            servicesCheckedListBox.TabIndex = 4;
            servicesCheckedListBox.ItemCheck += servicesCheckedListBox_ItemCheck;
            // 
            // costValue
            // 
            costValue.AutoSize = true;
            costValue.Location = new Point(70, 117);
            costValue.Margin = new Padding(0);
            costValue.Name = "costValue";
            costValue.Size = new Size(39, 15);
            costValue.TabIndex = 14;
            costValue.Text = "0 руб.";
            // 
            // costLabel
            // 
            costLabel.Anchor = AnchorStyles.None;
            costLabel.AutoSize = true;
            costLabel.Location = new Point(0, 117);
            costLabel.Margin = new Padding(0);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(70, 15);
            costLabel.TabIndex = 13;
            costLabel.Text = "Стоимость:";
            // 
            // servicesLabel
            // 
            servicesLabel.Anchor = AnchorStyles.None;
            servicesLabel.AutoSize = true;
            servicesLabel.Location = new Point(427, 31);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(48, 15);
            servicesLabel.TabIndex = 16;
            servicesLabel.Text = "Услуги:";
            // 
            // addOrderButton
            // 
            addOrderButton.Location = new Point(427, 202);
            addOrderButton.Name = "addOrderButton";
            addOrderButton.Size = new Size(279, 48);
            addOrderButton.TabIndex = 103;
            addOrderButton.Text = "Подтвердить";
            addOrderButton.UseVisualStyleBackColor = true;
            addOrderButton.Click += addOrderButton_Click;
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new Point(30, 31);
            clientIdLabel.Margin = new Padding(3, 0, 3, 5);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new Size(0, 15);
            clientIdLabel.TabIndex = 104;
            // 
            // passportDataLabel
            // 
            passportDataLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passportDataLabel.AutoSize = true;
            passportDataLabel.Location = new Point(30, 50);
            passportDataLabel.Margin = new Padding(3, 0, 3, 5);
            passportDataLabel.Name = "passportDataLabel";
            passportDataLabel.Size = new Size(0, 15);
            passportDataLabel.TabIndex = 105;
            passportDataLabel.Visible = false;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new Point(30, 70);
            dateOfBirthLabel.Margin = new Padding(3, 0, 3, 5);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(0, 15);
            dateOfBirthLabel.TabIndex = 106;
            dateOfBirthLabel.Visible = false;
            // 
            // individualAddressLabel
            // 
            individualAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            individualAddressLabel.AutoSize = true;
            individualAddressLabel.Location = new Point(30, 90);
            individualAddressLabel.Margin = new Padding(3, 0, 3, 5);
            individualAddressLabel.Name = "individualAddressLabel";
            individualAddressLabel.Size = new Size(0, 15);
            individualAddressLabel.TabIndex = 107;
            individualAddressLabel.Visible = false;
            // 
            // individualEmailLabel
            // 
            individualEmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            individualEmailLabel.AutoSize = true;
            individualEmailLabel.Location = new Point(30, 110);
            individualEmailLabel.Margin = new Padding(3, 0, 3, 5);
            individualEmailLabel.Name = "individualEmailLabel";
            individualEmailLabel.Size = new Size(0, 15);
            individualEmailLabel.TabIndex = 108;
            individualEmailLabel.Visible = false;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(30, 50);
            companyNameLabel.Margin = new Padding(3, 0, 3, 5);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(0, 15);
            companyNameLabel.TabIndex = 109;
            companyNameLabel.Visible = false;
            // 
            // corporateAddressLabel
            // 
            corporateAddressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            corporateAddressLabel.AutoSize = true;
            corporateAddressLabel.Location = new Point(30, 70);
            corporateAddressLabel.Margin = new Padding(3, 0, 3, 5);
            corporateAddressLabel.Name = "corporateAddressLabel";
            corporateAddressLabel.Size = new Size(0, 15);
            corporateAddressLabel.TabIndex = 110;
            corporateAddressLabel.Visible = false;
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new Point(30, 90);
            innLabel.Margin = new Padding(3, 0, 3, 5);
            innLabel.Name = "innLabel";
            innLabel.Size = new Size(0, 15);
            innLabel.TabIndex = 111;
            innLabel.Visible = false;
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(30, 110);
            accountNumberLabel.Margin = new Padding(3, 0, 3, 5);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(0, 15);
            accountNumberLabel.TabIndex = 112;
            accountNumberLabel.Visible = false;
            // 
            // bikLabel
            // 
            bikLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bikLabel.AutoSize = true;
            bikLabel.Location = new Point(30, 130);
            bikLabel.Margin = new Padding(3, 0, 3, 5);
            bikLabel.Name = "bikLabel";
            bikLabel.Size = new Size(0, 15);
            bikLabel.TabIndex = 113;
            bikLabel.Visible = false;
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new Point(30, 170);
            contactPhoneLabel.Margin = new Padding(3, 0, 3, 5);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new Size(0, 15);
            contactPhoneLabel.TabIndex = 114;
            contactPhoneLabel.Visible = false;
            // 
            // corporateEmailLabel
            // 
            corporateEmailLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            corporateEmailLabel.AutoSize = true;
            corporateEmailLabel.Location = new Point(30, 190);
            corporateEmailLabel.Margin = new Padding(3, 0, 3, 5);
            corporateEmailLabel.Name = "corporateEmailLabel";
            corporateEmailLabel.Size = new Size(0, 15);
            corporateEmailLabel.TabIndex = 115;
            corporateEmailLabel.Visible = false;
            // 
            // ceoNameLabel
            // 
            ceoNameLabel.AutoSize = true;
            ceoNameLabel.Location = new Point(30, 150);
            ceoNameLabel.Margin = new Padding(3, 0, 3, 5);
            ceoNameLabel.Name = "ceoNameLabel";
            ceoNameLabel.RightToLeft = RightToLeft.No;
            ceoNameLabel.Size = new Size(0, 15);
            ceoNameLabel.TabIndex = 116;
            ceoNameLabel.Visible = false;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 286);
            Controls.Add(ceoNameLabel);
            Controls.Add(corporateEmailLabel);
            Controls.Add(contactPhoneLabel);
            Controls.Add(bikLabel);
            Controls.Add(accountNumberLabel);
            Controls.Add(innLabel);
            Controls.Add(corporateAddressLabel);
            Controls.Add(companyNameLabel);
            Controls.Add(individualEmailLabel);
            Controls.Add(individualAddressLabel);
            Controls.Add(dateOfBirthLabel);
            Controls.Add(passportDataLabel);
            Controls.Add(clientIdLabel);
            Controls.Add(addOrderButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(servicesLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(750, 325);
            Name = "ServiceForm";
            Text = "ЗАО «Русская косметика» | Форма заказа услуг";
            Load += ServiceForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CheckedListBox servicesCheckedListBox;
        private Label costValue;
        private Label costLabel;
        private Label servicesLabel;
        private Button addOrderButton;
        private Label clientIdLabel;
        private Label passportDataLabel;
        private Label dateOfBirthLabel;
        private Label individualAddressLabel;
        private Label individualEmailLabel;
        private Label companyNameLabel;
        private Label corporateAddressLabel;
        private Label innLabel;
        private Label accountNumberLabel;
        private Label bikLabel;
        private Label contactPhoneLabel;
        private Label corporateEmailLabel;
        private Label ceoNameLabel;
    }
}