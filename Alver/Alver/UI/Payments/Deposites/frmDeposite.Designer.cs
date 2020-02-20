namespace Alver.UI.Payments.Deposites
{
    partial class frmDeposite
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeposite));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.outDepositeRadioButton = new System.Windows.Forms.RadioButton();
            this.inDepositeRadioButton = new System.Windows.Forms.RadioButton();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addClientpb = new System.Windows.Forms.PictureBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            amountLabel = new System.Windows.Forms.Label();
            operationDateLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(133, 56);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(49, 20);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "المبلع:";
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(351, 28);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(51, 20);
            operationDateLabel.TabIndex = 1;
            operationDateLabel.Text = "التاريخ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(351, 56);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(52, 20);
            currencyIdLabel.TabIndex = 11;
            currencyIdLabel.Text = "العملة:";
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(27, 263);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(45, 20);
            declarationLabel.TabIndex = 13;
            declarationLabel.Text = "البيان:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(351, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(47, 20);
            label2.TabIndex = 15;
            label2.Text = "الاسم:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outDepositeRadioButton);
            this.groupBox2.Controls.Add(this.inDepositeRadioButton);
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
            // outDepositeRadioButton
            // 
            this.outDepositeRadioButton.BackColor = System.Drawing.Color.Gold;
            this.outDepositeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outDepositeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.outDepositeRadioButton.ForeColor = System.Drawing.Color.Black;
            this.outDepositeRadioButton.Location = new System.Drawing.Point(6, 122);
            this.outDepositeRadioButton.Name = "outDepositeRadioButton";
            this.outDepositeRadioButton.Size = new System.Drawing.Size(339, 30);
            this.outDepositeRadioButton.TabIndex = 35;
            this.outDepositeRadioButton.Text = "تسليم أمانة";
            this.outDepositeRadioButton.UseVisualStyleBackColor = false;
            // 
            // inDepositeRadioButton
            // 
            this.inDepositeRadioButton.BackColor = System.Drawing.Color.Gold;
            this.inDepositeRadioButton.Checked = true;
            this.inDepositeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inDepositeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.inDepositeRadioButton.ForeColor = System.Drawing.Color.Black;
            this.inDepositeRadioButton.Location = new System.Drawing.Point(6, 86);
            this.inDepositeRadioButton.Name = "inDepositeRadioButton";
            this.inDepositeRadioButton.Size = new System.Drawing.Size(339, 30);
            this.inDepositeRadioButton.TabIndex = 34;
            this.inDepositeRadioButton.TabStop = true;
            this.inDepositeRadioButton.Text = "استلام أمانة";
            this.inDepositeRadioButton.UseVisualStyleBackColor = false;
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
            this.amountNumericUpDown.Size = new System.Drawing.Size(121, 27);
            this.amountNumericUpDown.TabIndex = 10;
            // 
            // currencyIdComboBox
            // 
            this.currencyIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdComboBox.DataSource = this.currencyBindingSource;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(178, 52);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(167, 28);
            this.currencyIdComboBox.TabIndex = 12;
            this.currencyIdComboBox.ValueMember = "Id";
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
            this.operationDateDateTimePicker.Size = new System.Drawing.Size(121, 27);
            this.operationDateDateTimePicker.TabIndex = 2;
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationTextBox.Location = new System.Drawing.Point(82, 260);
            this.declarationTextBox.Multiline = true;
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(335, 143);
            this.declarationTextBox.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addClientpb);
            this.groupBox4.Controls.Add(this.clientComboBox);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 62);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الوكيل";
            // 
            // addClientpb
            // 
            this.addClientpb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientpb.Location = new System.Drawing.Point(18, 20);
            this.addClientpb.Name = "addClientpb";
            this.addClientpb.Size = new System.Drawing.Size(25, 25);
            this.addClientpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addClientpb.TabIndex = 36;
            this.addClientpb.TabStop = false;
            this.addClientpb.Click += new System.EventHandler(this.addClientpb_Click);
            // 
            // clientComboBox
            // 
            this.clientComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clientComboBox.DataSource = this.accountsInfoBindingSource;
            this.clientComboBox.DisplayMember = "FullName";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(49, 22);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(296, 28);
            this.clientComboBox.TabIndex = 19;
            this.clientComboBox.ValueMember = "Id";
            // 
            // accountsInfoBindingSource
            // 
            this.accountsInfoBindingSource.DataSource = typeof(Alver.DAL.Account);
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
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(52, 24);
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
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(43, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // frmDeposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
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
            this.MaximumSize = new System.Drawing.Size(449, 480);
            this.MinimumSize = new System.Drawing.Size(449, 480);
            this.Name = "frmDeposite";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة أمانة لوكيل";
            this.Load += new System.EventHandler(this.frmNewPayment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClientDeposite_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.DateTimePicker operationDateDateTimePicker;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.RadioButton outDepositeRadioButton;
        private System.Windows.Forms.RadioButton inDepositeRadioButton;
        private System.Windows.Forms.PictureBox addClientpb;
    }
}
