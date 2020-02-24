using Alver.Misc;

namespace Alver.UI.Exchange
{
    partial class frmCurrenciesBulletin
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
            System.Windows.Forms.Label operationDateLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrenciesBulletin));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDateDataGridViewTextBoxColumn = new Alver.Misc.CalendarColumn();
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReversedRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyBulletinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.users_UserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.exportbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.excelexportbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfexportbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.drb = new System.Windows.Forms.RadioButton();
            this.mrd = new System.Windows.Forms.RadioButton();
            this.currencyIdComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.ratenud = new System.Windows.Forms.NumericUpDown();
            operationDateLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBulletinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingNavigator)).BeginInit();
            this.users_UserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).BeginInit();
            this.SuspendLayout();
            // 
            // operationDateLabel
            // 
            operationDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            operationDateLabel.AutoSize = true;
            operationDateLabel.Location = new System.Drawing.Point(811, 1);
            operationDateLabel.Name = "operationDateLabel";
            operationDateLabel.Size = new System.Drawing.Size(41, 15);
            operationDateLabel.TabIndex = 13;
            operationDateLabel.Text = "التاريخ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(683, 1);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 17;
            currencyIdLabel.Text = "العملة:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(475, 2);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 15);
            label4.TabIndex = 36;
            label4.Text = "سعر الصرف:";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.rateDateDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.Rate,
            this.ReversedRate});
            this.dgv.DataSource = this.currencyBulletinBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 26;
            this.dgv.Size = new System.Drawing.Size(875, 304);
            this.dgv.TabIndex = 3;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // rateDateDataGridViewTextBoxColumn
            // 
            this.rateDateDataGridViewTextBoxColumn.DataPropertyName = "RateDate";
            this.rateDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.rateDateDataGridViewTextBoxColumn.Name = "rateDateDataGridViewTextBoxColumn";
            this.rateDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rateDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // currencyIdDataGridViewTextBoxColumn
            // 
            this.currencyIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn.DataSource = this.currencyBindingSource;
            this.currencyIdDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.currencyIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyIdDataGridViewTextBoxColumn.Name = "currencyIdDataGridViewTextBoxColumn";
            this.currencyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // Rate
            // 
            this.Rate.DataPropertyName = "Rate";
            this.Rate.HeaderText = "سعر التصريف";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // ReversedRate
            // 
            this.ReversedRate.DataPropertyName = "ReversedRate";
            this.ReversedRate.HeaderText = "مقلوب السعر";
            this.ReversedRate.Name = "ReversedRate";
            this.ReversedRate.ReadOnly = true;
            // 
            // currencyBulletinBindingSource
            // 
            this.currencyBulletinBindingSource.DataSource = typeof(Alver.DAL.CurrencyBulletin);
            // 
            // users_UserBindingNavigator
            // 
            this.users_UserBindingNavigator.AddNewItem = null;
            this.users_UserBindingNavigator.BindingSource = this.currencyBulletinBindingSource;
            this.users_UserBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.users_UserBindingNavigator.CountItemFormat = " من أصل {0}";
            this.users_UserBindingNavigator.DeleteItem = null;
            this.users_UserBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.users_UserBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.deletebtn,
            this.exportbtn});
            this.users_UserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.users_UserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.users_UserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.users_UserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.users_UserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.users_UserBindingNavigator.Name = "users_UserBindingNavigator";
            this.users_UserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.users_UserBindingNavigator.Size = new System.Drawing.Size(875, 27);
            this.users_UserBindingNavigator.TabIndex = 2;
            this.users_UserBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(68, 24);
            this.bindingNavigatorCountItem.Text = " من أصل {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::Alver.Properties.Resources.deleterow;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeftAutoMirrorImage = true;
            this.deletebtn.Size = new System.Drawing.Size(56, 24);
            this.deletebtn.Text = "حذف";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // exportbtn
            // 
            this.exportbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelexportbtn,
            this.pdfexportbtn});
            this.exportbtn.Image = global::Alver.Properties.Resources.export;
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(71, 24);
            this.exportbtn.Text = "تصدير";
            // 
            // excelexportbtn
            // 
            this.excelexportbtn.Image = global::Alver.Properties.Resources.xls;
            this.excelexportbtn.Name = "excelexportbtn";
            this.excelexportbtn.Size = new System.Drawing.Size(184, 26);
            this.excelexportbtn.Text = "اكسل";
            this.excelexportbtn.Click += new System.EventHandler(this.excelexportbtn_Click);
            // 
            // pdfexportbtn
            // 
            this.pdfexportbtn.Image = global::Alver.Properties.Resources.pdf;
            this.pdfexportbtn.Name = "pdfexportbtn";
            this.pdfexportbtn.Size = new System.Drawing.Size(184, 26);
            this.pdfexportbtn.Text = "PDF";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox5);
            this.splitContainer1.Panel1.Controls.Add(this.currencyIdComboBox);
            this.splitContainer1.Panel1.Controls.Add(label4);
            this.splitContainer1.Panel1.Controls.Add(this.datetimepicker);
            this.splitContainer1.Panel1.Controls.Add(this.ratenud);
            this.splitContainer1.Panel1.Controls.Add(operationDateLabel);
            this.splitContainer1.Panel1.Controls.Add(currencyIdLabel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.Controls.Add(this.users_UserBindingNavigator);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(875, 418);
            this.splitContainer1.SplitterDistance = 62;
            this.splitContainer1.SplitterWidth = 25;
            this.splitContainer1.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Alver.Properties.Resources.save;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(33, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 38;
            this.button1.Text = "حفظ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.drb);
            this.groupBox5.Controls.Add(this.mrd);
            this.groupBox5.Location = new System.Drawing.Point(220, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 44);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "طريقة التحويل إلى الدولار";
            // 
            // drb
            // 
            this.drb.AutoSize = true;
            this.drb.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drb.Checked = true;
            this.drb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.drb.Location = new System.Drawing.Point(6, 16);
            this.drb.Name = "drb";
            this.drb.Size = new System.Drawing.Size(36, 20);
            this.drb.TabIndex = 39;
            this.drb.TabStop = true;
            this.drb.Text = "/";
            this.drb.UseVisualStyleBackColor = true;
            // 
            // mrd
            // 
            this.mrd.AutoSize = true;
            this.mrd.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mrd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.mrd.Location = new System.Drawing.Point(55, 16);
            this.mrd.Name = "mrd";
            this.mrd.Size = new System.Drawing.Size(36, 20);
            this.mrd.TabIndex = 38;
            this.mrd.Text = "*";
            this.mrd.UseVisualStyleBackColor = true;
            // 
            // currencyIdComboBox
            // 
            this.currencyIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdComboBox.DataSource = this.currencyBindingSource1;
            this.currencyIdComboBox.DisplayMember = "CurrencyName";
            this.currencyIdComboBox.FormattingEnabled = true;
            this.currencyIdComboBox.Location = new System.Drawing.Point(564, 21);
            this.currencyIdComboBox.Name = "currencyIdComboBox";
            this.currencyIdComboBox.Size = new System.Drawing.Size(167, 23);
            this.currencyIdComboBox.TabIndex = 18;
            this.currencyIdComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataSource = typeof(Alver.DAL.Currency);
            // 
            // datetimepicker
            // 
            this.datetimepicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimepicker.Location = new System.Drawing.Point(737, 21);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.RightToLeftLayout = true;
            this.datetimepicker.Size = new System.Drawing.Size(121, 23);
            this.datetimepicker.TabIndex = 14;
            // 
            // ratenud
            // 
            this.ratenud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ratenud.DecimalPlaces = 10;
            this.ratenud.Location = new System.Drawing.Point(415, 22);
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
            this.ratenud.Size = new System.Drawing.Size(143, 23);
            this.ratenud.TabIndex = 37;
            this.ratenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCurrenciesBulletin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(875, 418);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCurrenciesBulletin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملات";
            this.Load += new System.EventHandler(this.frmCurrencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBulletinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingNavigator)).EndInit();
            this.users_UserBindingNavigator.ResumeLayout(false);
            this.users_UserBindingNavigator.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingNavigator users_UserBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton exportbtn;
        private System.Windows.Forms.ToolStripMenuItem excelexportbtn;
        private System.Windows.Forms.ToolStripMenuItem pdfexportbtn;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource currencyBulletinBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox currencyIdComboBox;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton drb;
        private System.Windows.Forms.RadioButton mrd;
        private System.Windows.Forms.NumericUpDown ratenud;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private CalendarColumn rateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReversedRate;
    }
}