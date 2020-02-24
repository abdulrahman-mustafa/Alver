namespace Alver.UI.Funds
{
    partial class frmRefund
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label operationDateLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.Windows.Forms.Label declarationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefund));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.refundRadioButton = new System.Windows.Forms.RadioButton();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.paymentsOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fundComboBox = new System.Windows.Forms.ComboBox();
            this.fundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            amountLabel = new System.Windows.Forms.Label();
            operationDateLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(133, 56);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(39, 15);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "المبلع:";
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(351, 28);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(41, 15);
            operationDateLabel.TabIndex = 1;
            operationDateLabel.Text = "التاريخ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(351, 56);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 11;
            currencyIdLabel.Text = "العملة:";
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(27, 278);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(36, 15);
            declarationLabel.TabIndex = 13;
            declarationLabel.Text = "البيان:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawRadioButton);
            this.groupBox2.Controls.Add(this.refundRadioButton);
            this.groupBox2.Controls.Add(this.amountNumericUpDown);
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(this.currencyIdComboBox);
            this.groupBox2.Controls.Add(this.operationDateDateTimePicker);
            this.groupBox2.Controls.Add(operationDateLabel);
            this.groupBox2.Controls.Add(currencyIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 174);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيانات الأساسية";
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.BackColor = System.Drawing.Color.Gold;
            this.withdrawRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.withdrawRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.withdrawRadioButton.ForeColor = System.Drawing.Color.Black;
            this.withdrawRadioButton.Location = new System.Drawing.Point(6, 122);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(339, 30);
            this.withdrawRadioButton.TabIndex = 35;
            this.withdrawRadioButton.Text = "سحب من الصندوق";
            this.withdrawRadioButton.UseVisualStyleBackColor = false;
            // 
            // refundRadioButton
            // 
            this.refundRadioButton.BackColor = System.Drawing.Color.Gold;
            this.refundRadioButton.Checked = true;
            this.refundRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refundRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.refundRadioButton.ForeColor = System.Drawing.Color.Black;
            this.refundRadioButton.Location = new System.Drawing.Point(6, 86);
            this.refundRadioButton.Name = "refundRadioButton";
            this.refundRadioButton.Size = new System.Drawing.Size(339, 30);
            this.refundRadioButton.TabIndex = 34;
            this.refundRadioButton.TabStop = true;
            this.refundRadioButton.Text = "تغذية الصندوق";
            this.refundRadioButton.UseVisualStyleBackColor = false;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 3;
            this.amountNumericUpDown.Location = new System.Drawing.Point(6, 52);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(121, 23);
            this.amountNumericUpDown.TabIndex = 10;
            // 
            // currencyIdComboBox
            // 
            this.currencyIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.paymentsOperationBindingSource, "CurrencyId", true));
            this.currencyIdComboBox.DataSource = this.currencyBindingSource;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(178, 52);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(167, 23);
            this.currencyIdComboBox.TabIndex = 12;
            this.currencyIdComboBox.ValueMember = "Id";
            this.currencyIdComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyIdComboBox_SelectedIndexChanged);
            // 
            // paymentsOperationBindingSource
            // 
            this.paymentsOperationBindingSource.DataSource = typeof(Alver.DAL.Payment);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // operationDateDateTimePicker
            // 
            this.operationDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.operationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.operationDateDateTimePicker.Location = new System.Drawing.Point(224, 22);
            this.operationDateDateTimePicker.Name = "operationDateDateTimePicker";
            this.operationDateDateTimePicker.RightToLeftLayout = true;
            this.operationDateDateTimePicker.Size = new System.Drawing.Size(121, 23);
            this.operationDateDateTimePicker.TabIndex = 2;
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationTextBox.Location = new System.Drawing.Point(82, 275);
            this.declarationTextBox.Multiline = true;
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(335, 115);
            this.declarationTextBox.TabIndex = 14;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.CountItemFormat = "من أصل {0}";
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbtn,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.savebtn,
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 406);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(431, 27);
            this.bindingNavigator2.TabIndex = 37;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::Alver.Properties.Resources.Add;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(61, 24);
            this.addbtn.Text = "إضافة";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Image = global::Alver.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(54, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // fundComboBox
            // 
            this.fundComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fundComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fundComboBox.DataSource = this.fundBindingSource;
            this.fundComboBox.DisplayMember = "FundTitle";
            this.fundComboBox.FormattingEnabled = true;
            this.fundComboBox.Location = new System.Drawing.Point(6, 43);
            this.fundComboBox.Name = "fundComboBox";
            this.fundComboBox.Size = new System.Drawing.Size(379, 23);
            this.fundComboBox.TabIndex = 19;
            this.fundComboBox.ValueMember = "Id";
            // 
            // fundBindingSource
            // 
            this.fundBindingSource.DataMember = "Funds";
            this.fundBindingSource.DataSource = this.currencyBindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fundComboBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 77);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الصندوق";
            // 
            // frmRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(431, 433);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.declarationTextBox);
            this.Controls.Add(declarationLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRefund";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة دفعة - صندوق";
            this.Load += new System.EventHandler(this.frmNewPayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRefund_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.DateTimePicker operationDateDateTimePicker;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource paymentsOperationBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.RadioButton refundRadioButton;
        private System.Windows.Forms.ComboBox fundComboBox;
        private System.Windows.Forms.BindingSource fundBindingSource;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.ToolStripButton addbtn;
    }
}
