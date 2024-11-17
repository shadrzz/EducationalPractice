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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            idLaboratoryVesselLabel = new Label();
            customerChoiceLabel = new Label();
            idLaboratoryVesselTextBox = new TextBox();
            customerChoiceComboBox = new ComboBox();
            placeOrderButton = new Button();
            clientDataTextBox = new TextBox();
            clientDataLabel = new Label();
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
            placeOrderButton.Text = "Проверить данные";
            placeOrderButton.UseVisualStyleBackColor = true;
            placeOrderButton.Visible = false;
            placeOrderButton.Click += placeOrderButton_Click;
            // 
            // clientDataTextBox
            // 
            clientDataTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clientDataTextBox.Location = new Point(239, 48);
            clientDataTextBox.Name = "clientDataTextBox";
            clientDataTextBox.Size = new Size(295, 23);
            clientDataTextBox.TabIndex = 3;
            clientDataTextBox.Visible = false;
            // 
            // clientDataLabel
            // 
            clientDataLabel.AutoSize = true;
            clientDataLabel.Location = new Point(239, 30);
            clientDataLabel.Name = "clientDataLabel";
            clientDataLabel.Size = new Size(0, 15);
            clientDataLabel.TabIndex = 8;
            clientDataLabel.Visible = false;
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
            Controls.Add(clientDataLabel);
            Controls.Add(clientDataTextBox);
            Controls.Add(placeOrderButton);
            Controls.Add(customerChoiceComboBox);
            Controls.Add(idLaboratoryVesselTextBox);
            Controls.Add(customerChoiceLabel);
            Controls.Add(idLaboratoryVesselLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(12, 50);
            MinimumSize = new Size(575, 300);
            Name = "OrderForm";
            Text = "ЗАО «Русская косметика» | Формирование заказа";
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
        private TextBox clientDataTextBox;
        private Label clientDataLabel;
        private Button idLaboratoryVesselButton;
    }
}
