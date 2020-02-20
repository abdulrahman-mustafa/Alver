namespace Alver.UI.Accounts.Transfers
{
    partial class frmTransferFunds
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
            System.Windows.Forms.Label senderIdLabel;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label operationDateLabel;
            System.Windows.Forms.Label declarationLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransferFunds));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fromclientComboBox = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.toclientcomboBox = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            senderIdLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            operationDateLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderIdLabel
            // 
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(366, 25);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(47, 20);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الاسم:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(366, 25);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(47, 20);
            label14.TabIndex = 37;
            label14.Text = "الاسم:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(89, 23);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(49, 20);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "المبلع:";
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(362, 23);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(51, 20);
            operationDateLabel.TabIndex = 1;
            operationDateLabel.Text = "التاريخ:";
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(368, 71);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(45, 20);
            declarationLabel.TabIndex = 13;
            declarationLabel.Text = "البيان:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(214, 23);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(52, 20);
            currencyIdLabel.TabIndex = 15;
            currencyIdLabel.Text = "العملة:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.fromclientComboBox);
            this.groupBox4.Controls.Add(senderIdLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(419, 55);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "من صندوق الوكيل";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 40;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fromclientComboBox
            // 
            this.fromclientComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fromclientComboBox.DataSource = this.accountsInfoBindingSource;
            this.fromclientComboBox.DisplayMember = "Fullname";
            this.fromclientComboBox.FormattingEnabled = true;
            this.fromclientComboBox.Location = new System.Drawing.Point(37, 22);
            this.fromclientComboBox.Name = "fromclientComboBox";
            this.fromclientComboBox.Size = new System.Drawing.Size(308, 28);
            this.fromclientComboBox.TabIndex = 18;
            this.fromclientComboBox.ValueMember = "Id";
            this.fromclientComboBox.SelectedIndexChanged += new System.EventHandler(this.fromclientComboBox_SelectedIndexChanged);
            // 
            // accountsInfoBindingSource
            // 
            this.accountsInfoBindingSource.DataSource = typeof(DAL.Account);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.toclientcomboBox);
            this.groupBox3.Controls.Add(label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 55);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "إلى صندوق الوكيل";
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(6, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(25, 25);
            this.button9.TabIndex = 39;
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // toclientcomboBox
            // 
            this.toclientcomboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toclientcomboBox.DataSource = this.accountsInfoBindingSource1;
            this.toclientcomboBox.DisplayMember = "Fullname";
            this.toclientcomboBox.FormattingEnabled = true;
            this.toclientcomboBox.Location = new System.Drawing.Point(37, 22);
            this.toclientcomboBox.Name = "toclientcomboBox";
            this.toclientcomboBox.Size = new System.Drawing.Size(307, 28);
            this.toclientcomboBox.TabIndex = 38;
            this.toclientcomboBox.ValueMember = "Id";
            // 
            // accountsInfoBindingSource1
            // 
            this.accountsInfoBindingSource1.DataSource = typeof(DAL.Account);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currencyIdComboBox);
            this.groupBox2.Controls.Add(currencyIdLabel);
            this.groupBox2.Controls.Add(this.amountNumericUpDown);
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(this.operationDateDateTimePicker);
            this.groupBox2.Controls.Add(operationDateLabel);
            this.groupBox2.Controls.Add(declarationLabel);
            this.groupBox2.Controls.Add(this.declarationTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 135);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات عملية التحويل";
            // 
            // currencyIdComboBox
            // 
            this.currencyIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdComboBox.DataSource = this.currencyBindingSource;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(134, 40);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(121, 28);
            this.currencyIdComboBox.TabIndex = 16;
            this.currencyIdComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(DAL.Currency);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 3;
            this.amountNumericUpDown.Location = new System.Drawing.Point(8, 41);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 27);
            this.amountNumericUpDown.TabIndex = 10;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.amountNumericUpDown_ValueChanged);
            // 
            // operationDateDateTimePicker
            // 
            this.operationDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.operationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.operationDateDateTimePicker.Location = new System.Drawing.Point(261, 41);
            this.operationDateDateTimePicker.Name = "operationDateDateTimePicker";
            this.operationDateDateTimePicker.RightToLeftLayout = true;
            this.operationDateDateTimePicker.Size = new System.Drawing.Size(142, 27);
            this.operationDateDateTimePicker.TabIndex = 2;
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationTextBox.Location = new System.Drawing.Point(7, 90);
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(396, 27);
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
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 283);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(442, 27);
            this.bindingNavigator2.TabIndex = 50;
            // 
            // addbtn
            // 
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
            // frmTransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 310);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 357);
            this.MinimumSize = new System.Drawing.Size(460, 357);
            this.Name = "frmTransferFunds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد من صندوق وكيل إلى وكيل آخر";
            this.Load += new System.EventHandler(this.frmTransferFunds_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTransferFunds_KeyDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox fromclientComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox toclientcomboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DateTimePicker operationDateDateTimePicker;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource1;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
    }
}