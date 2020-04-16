namespace Alver.UI.Accounts.Transfers
{
    partial class frmTransfer
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
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label operationDateLabel;
            System.Windows.Forms.Label declarationLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label currencyIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FromFundcomboBox = new System.Windows.Forms.ComboBox();
            this.accountsFundBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.displayer = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ratenud = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transferClientFundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToFundcomboBox = new System.Windows.Forms.ComboBox();
            this.accountsFundBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            senderIdLabel = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            operationDateLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferClientFundBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(389, 27);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(37, 15);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الاسم:";
            // 
            // label12
            // 
            label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(159, 29);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(54, 15);
            label12.TabIndex = 40;
            label12.Text = "الصندوق:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(369, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 15);
            label4.TabIndex = 36;
            label4.Text = "سعر الصرف:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(91, 21);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(39, 15);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "المبلع:";
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(397, 21);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(41, 15);
            operationDateLabel.TabIndex = 1;
            operationDateLabel.Text = "التاريخ:";
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(402, 71);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(36, 15);
            declarationLabel.TabIndex = 13;
            declarationLabel.Text = "البيان:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(159, 29);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 15);
            label5.TabIndex = 40;
            label5.Text = "الصندوق:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(239, 21);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 15;
            currencyIdLabel.Text = "العملة:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.clientComboBox);
            this.groupBox4.Controls.Add(senderIdLabel);
            this.groupBox4.Location = new System.Drawing.Point(12, 140);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 59);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الوكيل";
            // 
            // clientComboBox
            // 
            this.clientComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clientComboBox.DataSource = this.accountsInfoBindingSource;
            this.clientComboBox.DisplayMember = "Fullname";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(10, 22);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(374, 23);
            this.clientComboBox.TabIndex = 18;
            this.clientComboBox.ValueMember = "Id";
            // 
            // accountsInfoBindingSource
            // 
            this.accountsInfoBindingSource.DataSource = typeof(Alver.DAL.Account);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label12);
            this.groupBox3.Controls.Add(this.FromFundcomboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 76);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "من صندوق";
            // 
            // FromFundcomboBox
            // 
            this.FromFundcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromFundcomboBox.DataSource = this.accountsFundBindingSource1;
            this.FromFundcomboBox.DisplayMember = "FundTitle";
            this.FromFundcomboBox.Enabled = false;
            this.FromFundcomboBox.FormattingEnabled = true;
            this.FromFundcomboBox.Location = new System.Drawing.Point(10, 47);
            this.FromFundcomboBox.Name = "FromFundcomboBox";
            this.FromFundcomboBox.Size = new System.Drawing.Size(203, 23);
            this.FromFundcomboBox.TabIndex = 43;
            this.FromFundcomboBox.ValueMember = "Id";
            this.FromFundcomboBox.SelectedIndexChanged += new System.EventHandler(this.FromFundcomboBox_SelectedIndexChanged);
            // 
            // accountsFundBindingSource1
            // 
            this.accountsFundBindingSource1.DataMember = "AccountFunds";
            this.accountsFundBindingSource1.DataSource = this.accountsInfoBindingSource;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.displayer);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(label4);
            this.groupBox5.Controls.Add(this.ratenud);
            this.groupBox5.Location = new System.Drawing.Point(12, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(444, 128);
            this.groupBox5.TabIndex = 31;
            this.groupBox5.TabStop = false;
            // 
            // displayer
            // 
            this.displayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.displayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayer.DecimalPlaces = 3;
            this.displayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.displayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.displayer.InterceptArrowKeys = false;
            this.displayer.Location = new System.Drawing.Point(3, 73);
            this.displayer.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.displayer.Name = "displayer";
            this.displayer.Size = new System.Drawing.Size(438, 52);
            this.displayer.TabIndex = 50;
            this.displayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.displayer.ThousandsSeparator = true;
            this.displayer.UseWaitCursor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(13, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 20);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "/";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(62, 20);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(36, 20);
            this.radioButton2.TabIndex = 38;
            this.radioButton2.Text = "*";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ratenud
            // 
            this.ratenud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratenud.DecimalPlaces = 10;
            this.ratenud.Location = new System.Drawing.Point(159, 20);
            this.ratenud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.ratenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratenud.Name = "ratenud";
            this.ratenud.Size = new System.Drawing.Size(204, 23);
            this.ratenud.TabIndex = 37;
            this.ratenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratenud.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
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
            this.groupBox2.Size = new System.Drawing.Size(444, 122);
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
            this.currencyIdComboBox.Location = new System.Drawing.Point(159, 38);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(121, 23);
            this.currencyIdComboBox.TabIndex = 16;
            this.currencyIdComboBox.ValueMember = "Id";
            this.currencyIdComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyIdComboBox_SelectedIndexChanged);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 3;
            this.amountNumericUpDown.Location = new System.Drawing.Point(10, 39);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.amountNumericUpDown.TabIndex = 10;
            this.amountNumericUpDown.ValueChanged += new System.EventHandler(this.amountNumericUpDown_ValueChanged);
            // 
            // operationDateDateTimePicker
            // 
            this.operationDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.operationDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transferClientFundBindingSource, "TransferDate", true));
            this.operationDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.operationDateDateTimePicker.Location = new System.Drawing.Point(296, 39);
            this.operationDateDateTimePicker.Name = "operationDateDateTimePicker";
            this.operationDateDateTimePicker.RightToLeftLayout = true;
            this.operationDateDateTimePicker.Size = new System.Drawing.Size(142, 23);
            this.operationDateDateTimePicker.TabIndex = 2;
            // 
            // transferClientFundBindingSource
            // 
            this.transferClientFundBindingSource.DataSource = typeof(Alver.DAL.Transfer);
            this.transferClientFundBindingSource.CurrentChanged += new System.EventHandler(this.transferClientFundBindingSource_CurrentChanged);
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationTextBox.Location = new System.Drawing.Point(10, 89);
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(428, 23);
            this.declarationTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.ToFundcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(237, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 76);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إلى صندوق";
            // 
            // ToFundcomboBox
            // 
            this.ToFundcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToFundcomboBox.DataSource = this.accountsFundBindingSource2;
            this.ToFundcomboBox.DisplayMember = "FundTitle";
            this.ToFundcomboBox.FormattingEnabled = true;
            this.ToFundcomboBox.Location = new System.Drawing.Point(10, 47);
            this.ToFundcomboBox.Name = "ToFundcomboBox";
            this.ToFundcomboBox.Size = new System.Drawing.Size(203, 23);
            this.ToFundcomboBox.TabIndex = 43;
            this.ToFundcomboBox.ValueMember = "Id";
            // 
            // accountsFundBindingSource2
            // 
            this.accountsFundBindingSource2.DataMember = "AccountFunds";
            this.accountsFundBindingSource2.DataSource = this.accountsInfoBindingSource;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigator2.BindingSource = this.transferClientFundBindingSource;
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
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 430);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(470, 27);
            this.bindingNavigator2.TabIndex = 49;
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
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 457);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(486, 504);
            this.MinimumSize = new System.Drawing.Size(486, 425);
            this.Name = "frmTransfer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قص رصيد وكيل";
            this.Load += new System.EventHandler(this.frmTransferFunds_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTransfer_KeyDown);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferClientFundBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox FromFundcomboBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown ratenud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.DateTimePicker operationDateDateTimePicker;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource transferClientFundBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ToFundcomboBox;
        private System.Windows.Forms.BindingSource accountsFundBindingSource1;
        private System.Windows.Forms.BindingSource accountsFundBindingSource2;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.NumericUpDown displayer;
    }
}
