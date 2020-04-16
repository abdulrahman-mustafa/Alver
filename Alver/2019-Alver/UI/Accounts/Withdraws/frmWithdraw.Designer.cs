﻿namespace Alver.UI.Accounts.Withdraws
{
    partial class frmWithdraw
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label operationDateLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.Windows.Forms.Label declarationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWithdraw));
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addClientpb = new System.Windows.Forms.PictureBox();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.losscb = new System.Windows.Forms.RadioButton();
            this.gaincb = new System.Windows.Forms.RadioButton();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.declarationTextBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            operationDateLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(360, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(37, 15);
            label2.TabIndex = 15;
            label2.Text = "الاسم:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(133, 53);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(39, 15);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "المبلع:";
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(345, 28);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(41, 15);
            operationDateLabel.TabIndex = 1;
            operationDateLabel.Text = "التاريخ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(345, 54);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 11;
            currencyIdLabel.Text = "العملة:";
            // 
            // declarationLabel
            // 
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(13, 258);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(36, 15);
            declarationLabel.TabIndex = 39;
            declarationLabel.Text = "البيان:";
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
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 410);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(426, 27);
            this.bindingNavigator2.TabIndex = 38;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addClientpb);
            this.groupBox4.Controls.Add(this.clientComboBox);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Location = new System.Drawing.Point(11, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 55);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الوكيل";
            // 
            // addClientpb
            // 
            this.addClientpb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientpb.Location = new System.Drawing.Point(16, 20);
            this.addClientpb.Name = "addClientpb";
            this.addClientpb.Size = new System.Drawing.Size(25, 25);
            this.addClientpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addClientpb.TabIndex = 37;
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
            this.clientComboBox.Location = new System.Drawing.Point(47, 20);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(307, 23);
            this.clientComboBox.TabIndex = 19;
            this.clientComboBox.ValueMember = "Id";
            // 
            // accountsInfoBindingSource
            // 
            this.accountsInfoBindingSource.DataSource = typeof(Alver.DAL.Account);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.losscb);
            this.groupBox2.Controls.Add(this.gaincb);
            this.groupBox2.Controls.Add(this.amountNumericUpDown);
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(this.currencyIdComboBox);
            this.groupBox2.Controls.Add(this.operationDateDateTimePicker);
            this.groupBox2.Controls.Add(operationDateLabel);
            this.groupBox2.Controls.Add(currencyIdLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 163);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "البيانات الأساسية";
            // 
            // losscb
            // 
            this.losscb.BackColor = System.Drawing.Color.Gold;
            this.losscb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.losscb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.losscb.ForeColor = System.Drawing.Color.Black;
            this.losscb.Location = new System.Drawing.Point(6, 121);
            this.losscb.Name = "losscb";
            this.losscb.Size = new System.Drawing.Size(329, 30);
            this.losscb.TabIndex = 33;
            this.losscb.Text = "إيداع أرباح / علينا";
            this.losscb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.losscb.UseVisualStyleBackColor = false;
            // 
            // gaincb
            // 
            this.gaincb.BackColor = System.Drawing.Color.Gold;
            this.gaincb.Checked = true;
            this.gaincb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gaincb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gaincb.ForeColor = System.Drawing.Color.Black;
            this.gaincb.Location = new System.Drawing.Point(6, 85);
            this.gaincb.Name = "gaincb";
            this.gaincb.Size = new System.Drawing.Size(329, 30);
            this.gaincb.TabIndex = 32;
            this.gaincb.TabStop = true;
            this.gaincb.Text = "سحب أرباح / لنا";
            this.gaincb.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.gaincb.UseVisualStyleBackColor = false;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.DecimalPlaces = 3;
            this.amountNumericUpDown.Location = new System.Drawing.Point(6, 51);
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
            this.currencyIdComboBox.DataSource = this.currencyBindingSource;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(182, 51);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(157, 23);
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
            this.operationDateDateTimePicker.Location = new System.Drawing.Point(182, 22);
            this.operationDateDateTimePicker.Name = "operationDateDateTimePicker";
            this.operationDateDateTimePicker.RightToLeftLayout = true;
            this.operationDateDateTimePicker.Size = new System.Drawing.Size(157, 23);
            this.operationDateDateTimePicker.TabIndex = 2;
            // 
            // declarationTextBox
            // 
            this.declarationTextBox.Location = new System.Drawing.Point(64, 242);
            this.declarationTextBox.Multiline = true;
            this.declarationTextBox.Name = "declarationTextBox";
            this.declarationTextBox.Size = new System.Drawing.Size(335, 161);
            this.declarationTextBox.TabIndex = 40;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(426, 437);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.declarationTextBox);
            this.Controls.Add(declarationLabel);
            this.Controls.Add(this.bindingNavigator2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWithdraw";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب/إيداع";
            this.Load += new System.EventHandler(this.frmWithdraw_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWithdraw_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addClientpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox addClientpb;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton losscb;
        private System.Windows.Forms.RadioButton gaincb;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.DateTimePicker operationDateDateTimePicker;
        private System.Windows.Forms.TextBox declarationTextBox;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
    }
}