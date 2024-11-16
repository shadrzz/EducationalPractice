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
            tableLayoutPanel1 = new TableLayoutPanel();
            servicesCheckedListBox = new CheckedListBox();
            costValue = new Label();
            costLabel = new Label();
            servicesLabel = new Label();
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
            tableLayoutPanel1.Location = new Point(238, 72);
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
            servicesCheckedListBox.Visible = false;
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
            costValue.Visible = false;
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
            costLabel.Visible = false;
            // 
            // servicesLabel
            // 
            servicesLabel.Anchor = AnchorStyles.None;
            servicesLabel.AutoSize = true;
            servicesLabel.Location = new Point(238, 54);
            servicesLabel.Name = "servicesLabel";
            servicesLabel.Size = new Size(48, 15);
            servicesLabel.TabIndex = 16;
            servicesLabel.Text = "Услуги:";
            servicesLabel.Visible = false;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 261);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(servicesLabel);
            MinimumSize = new Size(575, 300);
            Name = "ServiceForm";
            Text = "Form1";
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
    }
}