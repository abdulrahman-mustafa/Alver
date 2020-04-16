namespace SimpleEx.PL.BaseFund
{
    partial class frmDamaged
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
            System.Windows.Forms.Label exchangeDateLabel;
            System.Windows.Forms.Label wageAmountLabel;
            System.Windows.Forms.Label wageCurrencyIdLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label declarationLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDamaged));
            this.sellradioButton = new System.Windows.Forms.RadioButton();
            this.buyradioButton = new System.Windows.Forms.RadioButton();
            this.exchangeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.moneyExchangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toAmountnumeric = new System.Windows.Forms.NumericUpDown();
            this.fundsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fromCurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fromamountnumeric = new System.Windows.Forms.NumericUpDown();
            this.fundsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            exchangeDateLabel = new System.Windows.Forms.Label();
            wageAmountLabel = new System.Windows.Forms.Label();
            wageCurrencyIdLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moneyExchangeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAmountnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromamountnumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // exchangeDateLabel
            // 
            exchangeDateLabel.AutoSize = true;
            exchangeDateLabel.Location = new System.Drawing.Point(324, 16);
            exchangeDateLabel.Name = "exchangeDateLabel";
            exchangeDateLabel.Size = new System.Drawing.Size(91, 20);
            exchangeDateLabel.TabIndex = 3;
            exchangeDateLabel.Text = "تاريخ العملية:";
            // 
            // wageAmountLabel
            // 
            wageAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            wageAmountLabel.AutoSize = true;
            wageAmountLabel.Location = new System.Drawing.Point(107, 23);
            wageAmountLabel.Name = "wageAmountLabel";
            wageAmountLabel.Size = new System.Drawing.Size(49, 20);
            wageAmountLabel.TabIndex = 19;
            wageAmountLabel.Text = "المبلغ:";
            // 
            // wageCurrencyIdLabel
            // 
            wageCurrencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            wageCurrencyIdLabel.AutoSize = true;
            wageCurrencyIdLabel.Location = new System.Drawing.Point(363, 23);
            wageCurrencyIdLabel.Name = "wageCurrencyIdLabel";
            wageCurrencyIdLabel.Size = new System.Drawing.Size(52, 20);
            wageCurrencyIdLabel.TabIndex = 21;
            wageCurrencyIdLabel.Text = "العملة:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(363, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 20);
            label3.TabIndex = 32;
            label3.Text = "العملة:";
            // 
            // declarationLabel
            // 
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(380, 87);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(45, 20);
            declarationLabel.TabIndex = 34;
            declarationLabel.Text = "البيان:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(107, 23);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "المبلغ:";
            // 
            // sellradioButton
            // 
            this.sellradioButton.AutoSize = true;
            this.sellradioButton.BackColor = System.Drawing.Color.Gold;
            this.sellradioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sellradioButton.Location = new System.Drawing.Point(10, 30);
            this.sellradioButton.Name = "sellradioButton";
            this.sellradioButton.Size = new System.Drawing.Size(49, 24);
            this.sellradioButton.TabIndex = 0;
            this.sellradioButton.Text = "بيع";
            this.sellradioButton.UseVisualStyleBackColor = false;
            // 
            // buyradioButton
            // 
            this.buyradioButton.AutoSize = true;
            this.buyradioButton.BackColor = System.Drawing.Color.Gold;
            this.buyradioButton.Checked = true;
            this.buyradioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buyradioButton.Location = new System.Drawing.Point(65, 30);
            this.buyradioButton.Name = "buyradioButton";
            this.buyradioButton.Size = new System.Drawing.Size(56, 24);
            this.buyradioButton.TabIndex = 1;
            this.buyradioButton.TabStop = true;
            this.buyradioButton.Text = "شراء";
            this.buyradioButton.UseVisualStyleBackColor = false;
            // 
            // exchangeDateDateTimePicker
            // 
            this.exchangeDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.exchangeDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.exchangeDateDateTimePicker.Location = new System.Drawing.Point(303, 39);
            this.exchangeDateDateTimePicker.Name = "exchangeDateDateTimePicker";
            this.exchangeDateDateTimePicker.RightToLeftLayout = true;
            this.exchangeDateDateTimePicker.Size = new System.Drawing.Size(112, 27);
            this.exchangeDateDateTimePicker.TabIndex = 4;
            // 
            // moneyExchangeBindingSource
            // 
            this.moneyExchangeBindingSource.DataSource = typeof(DAL.MoneyExchange);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toCurrencyComboBox);
            this.groupBox1.Controls.Add(wageCurrencyIdLabel);
            this.groupBox1.Controls.Add(this.toAmountnumeric);
            this.groupBox1.Controls.Add(wageAmountLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 84);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملة التي تم التصريف إليها";
            // 
            // toCurrencyComboBox
            // 
            this.toCurrencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toCurrencyComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toCurrencyComboBox.DataSource = this.currencyBindingSource1;
            this.toCurrencyComboBox.DisplayMember = "CurrencyName";
            this.toCurrencyComboBox.FormattingEnabled = true;
            this.toCurrencyComboBox.Location = new System.Drawing.Point(189, 46);
            this.toCurrencyComboBox.Name = "toCurrencyComboBox";
            this.toCurrencyComboBox.Size = new System.Drawing.Size(226, 28);
            this.toCurrencyComboBox.TabIndex = 22;
            this.toCurrencyComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataSource = typeof(DAL.Currency);
            // 
            // toAmountnumeric
            // 
            this.toAmountnumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toAmountnumeric.DecimalPlaces = 3;
            this.toAmountnumeric.Location = new System.Drawing.Point(12, 46);
            this.toAmountnumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.toAmountnumeric.Name = "toAmountnumeric";
            this.toAmountnumeric.Size = new System.Drawing.Size(134, 27);
            this.toAmountnumeric.TabIndex = 20;
            // 
            // fundsBindingSource1
            // 
            this.fundsBindingSource1.DataMember = "Funds";
            this.fundsBindingSource1.DataSource = this.currencyBindingSource1;
            // 
            // fromCurrencyComboBox
            // 
            this.fromCurrencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromCurrencyComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fromCurrencyComboBox.DataSource = this.currencyBindingSource;
            this.fromCurrencyComboBox.DisplayMember = "CurrencyName";
            this.fromCurrencyComboBox.FormattingEnabled = true;
            this.fromCurrencyComboBox.Location = new System.Drawing.Point(189, 46);
            this.fromCurrencyComboBox.Name = "fromCurrencyComboBox";
            this.fromCurrencyComboBox.Size = new System.Drawing.Size(226, 28);
            this.fromCurrencyComboBox.TabIndex = 33;
            this.fromCurrencyComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(DAL.Currency);
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Location = new System.Drawing.Point(6, 84);
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(367, 27);
            this.declarationTextBox.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.fromamountnumeric);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.fromCurrencyComboBox);
            this.groupBox2.Location = new System.Drawing.Point(14, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 84);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "العملة الاساس";
            // 
            // fromamountnumeric
            // 
            this.fromamountnumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromamountnumeric.DecimalPlaces = 3;
            this.fromamountnumeric.Location = new System.Drawing.Point(12, 46);
            this.fromamountnumeric.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.fromamountnumeric.Name = "fromamountnumeric";
            this.fromamountnumeric.Size = new System.Drawing.Size(134, 27);
            this.fromamountnumeric.TabIndex = 20;
            // 
            // fundsBindingSource
            // 
            this.fundsBindingSource.DataMember = "Funds";
            this.fundsBindingSource.DataSource = this.currencyBindingSource;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sellradioButton);
            this.groupBox3.Controls.Add(this.buyradioButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(202, 62);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "نوع العملية";
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
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 331);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(443, 27);
            this.bindingNavigator2.TabIndex = 38;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::SimpleEx.Properties.Resources.add;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(72, 24);
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
            this.savebtn.Image = global::SimpleEx.Properties.Resources.icons8_save_25px_1;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(63, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.exchangeDateDateTimePicker);
            this.groupBox4.Controls.Add(exchangeDateLabel);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(declarationLabel);
            this.groupBox4.Controls.Add(this.declarationTextBox);
            this.groupBox4.Location = new System.Drawing.Point(14, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 119);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            // 
            // frmDamaged
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(443, 358);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDamaged";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شراء وبيع العملات التالفة";
            this.Load += new System.EventHandler(this.frmTransferMoney_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTransferMoney_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.moneyExchangeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toAmountnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fromamountnumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sellradioButton;
        private System.Windows.Forms.RadioButton buyradioButton;
        private System.Windows.Forms.BindingSource moneyExchangeBindingSource;
        private System.Windows.Forms.DateTimePicker exchangeDateDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown toAmountnumeric;
        private System.Windows.Forms.ComboBox toCurrencyComboBox;
        private System.Windows.Forms.ComboBox fromCurrencyComboBox;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown fromamountnumeric;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource fundsBindingSource;
        private System.Windows.Forms.BindingSource fundsBindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}