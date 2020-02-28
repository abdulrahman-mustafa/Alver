namespace Alver.UI.Payments.Expenses
{
    partial class frmExpense
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
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label expenseDateLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpense));
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsExpenseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.expenseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            notesLabel = new System.Windows.Forms.Label();
            expenseDateLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(325, 156);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(36, 15);
            notesLabel.TabIndex = 23;
            notesLabel.Text = "البيان:";
            // 
            // expenseDateLabel
            // 
            expenseDateLabel.AutoSize = true;
            expenseDateLabel.Location = new System.Drawing.Point(325, 32);
            expenseDateLabel.Name = "expenseDateLabel";
            expenseDateLabel.Size = new System.Drawing.Size(41, 15);
            expenseDateLabel.TabIndex = 13;
            expenseDateLabel.Text = "التاريخ:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(325, 122);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(45, 15);
            categoryIdLabel.TabIndex = 21;
            categoryIdLabel.Text = "الصنف:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(324, 86);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(39, 15);
            amountLabel.TabIndex = 19;
            amountLabel.Text = "المبلغ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(325, 60);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 17;
            currencyIdLabel.Text = "العملة:";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // paymentsExpenseCategoryBindingSource
            // 
            this.paymentsExpenseCategoryBindingSource.DataSource = typeof(Alver.DAL.ExpenseCategory);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(406, 347);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(398, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بيانات المصروف";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.expenseDateDateTimePicker);
            this.groupBox1.Controls.Add(notesLabel);
            this.groupBox1.Controls.Add(expenseDateLabel);
            this.groupBox1.Controls.Add(this.notesTextBox);
            this.groupBox1.Controls.Add(categoryIdLabel);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Controls.Add(this.currencyIdComboBox);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Controls.Add(currencyIdLabel);
            this.groupBox1.Controls.Add(this.amountNumericUpDown);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 286);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // expenseDateDateTimePicker
            // 
            this.expenseDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expenseDateDateTimePicker.Location = new System.Drawing.Point(6, 26);
            this.expenseDateDateTimePicker.Name = "expenseDateDateTimePicker";
            this.expenseDateDateTimePicker.RightToLeftLayout = true;
            this.expenseDateDateTimePicker.Size = new System.Drawing.Size(313, 23);
            this.expenseDateDateTimePicker.TabIndex = 14;
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(6, 151);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(313, 84);
            this.notesTextBox.TabIndex = 24;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.categoryComboBox.DataSource = this.paymentsExpenseCategoryBindingSource;
            this.categoryComboBox.DisplayMember = "Title";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(6, 117);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(313, 23);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // currencyIdComboBox
            // 
            this.currencyIdComboBox.DataSource = this.currencyBindingSource;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(6, 55);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(313, 23);
            this.currencyIdComboBox.TabIndex = 18;
            this.currencyIdComboBox.ValueMember = "Id";
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DecimalPlaces = 3;
            this.amountNumericUpDown.Location = new System.Drawing.Point(6, 84);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(313, 23);
            this.amountNumericUpDown.TabIndex = 20;
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
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 289);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(392, 27);
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
            // frmExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(406, 347);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmExpense";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مصروف";
            this.Load += new System.EventHandler(this.frmExpensess_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmExpensess_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource paymentsExpenseCategoryBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker expenseDateDateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
    }
}