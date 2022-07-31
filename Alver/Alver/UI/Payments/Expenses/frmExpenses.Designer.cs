namespace Alver.UI.Payments.Expenses
{
    partial class frmExpenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpenses));
            this.payments_ExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentsExpenseCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.expenseCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.paymentsExpenseCategoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new Alver.MISC.CalendarColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeclarationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotals = new System.Windows.Forms.DataGridView();
            this.payments_ExpenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.payments_ExpenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.اكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            senderIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseBindingNavigator)).BeginInit();
            this.payments_ExpenseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(137, 197);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(45, 15);
            senderIdLabel.TabIndex = 29;
            senderIdLabel.Text = "الصنف:";
            // 
            // payments_ExpenseBindingSource
            // 
            this.payments_ExpenseBindingSource.DataSource = typeof(Alver.DAL.Expens);
            this.payments_ExpenseBindingSource.CurrentChanged += new System.EventHandler(this.payments_ExpenseBindingSource_CurrentChanged);
            // 
            // paymentsExpenseCategoryBindingSource
            // 
            this.paymentsExpenseCategoryBindingSource.DataSource = typeof(Alver.DAL.ExpenseCategory);
            // 
            // fundBindingSource
            // 
            this.fundBindingSource.DataSource = typeof(Alver.DAL.Fund);
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.expenseCategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(senderIdLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton3);
            this.splitContainer1.Panel1.Controls.Add(this.radioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.FromDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.ToDateTimePicker);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(836, 512);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 6;
            // 
            // expenseCategoryComboBox
            // 
            this.expenseCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expenseCategoryComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.expenseCategoryComboBox.DataSource = this.paymentsExpenseCategoryBindingSource1;
            this.expenseCategoryComboBox.DisplayMember = "Title";
            this.expenseCategoryComboBox.Enabled = false;
            this.expenseCategoryComboBox.FormattingEnabled = true;
            this.expenseCategoryComboBox.Location = new System.Drawing.Point(24, 220);
            this.expenseCategoryComboBox.Name = "expenseCategoryComboBox";
            this.expenseCategoryComboBox.Size = new System.Drawing.Size(158, 23);
            this.expenseCategoryComboBox.TabIndex = 30;
            this.expenseCategoryComboBox.ValueMember = "Id";
            // 
            // paymentsExpenseCategoryBindingSource1
            // 
            this.paymentsExpenseCategoryBindingSource1.DataSource = typeof(Alver.DAL.ExpenseCategory);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Alver.Properties.Resources.getdata;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(24, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "جلب";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(136, 130);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 19);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "الكل";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(91, 160);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 19);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.Text = "حسب الصنف";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "إلى تاريخ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "من تاريخ:";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(24, 43);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.RightToLeftLayout = true;
            this.FromDateTimePicker.ShowCheckBox = true;
            this.FromDateTimePicker.Size = new System.Drawing.Size(158, 23);
            this.FromDateTimePicker.TabIndex = 18;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(24, 97);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.RightToLeftLayout = true;
            this.ToDateTimePicker.Size = new System.Drawing.Size(158, 23);
            this.ToDateTimePicker.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 512);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.dgvTotals);
            this.tabPage1.Controls.Add(this.payments_ExpenseBindingNavigator);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "المصاريف";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.DeclarationColumn});
            this.dgv.DataSource = this.payments_ExpenseBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(3, 30);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(608, 401);
            this.dgv.TabIndex = 2;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.payments_ExpenseDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExpenseDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "التاريخ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 63;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CategoryId";
            this.dataGridViewTextBoxColumn6.DataSource = this.paymentsExpenseCategoryBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn6.HeaderText = "نوع المصروف";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "Id";
            this.dataGridViewTextBoxColumn6.Width = 99;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrencyId";
            this.dataGridViewTextBoxColumn4.DataSource = this.currencyBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "CurrencyName";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn4.HeaderText = "العملة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "Id";
            this.dataGridViewTextBoxColumn4.Width = 63;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "المبلغ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // DeclarationColumn
            // 
            this.DeclarationColumn.DataPropertyName = "Declaration";
            this.DeclarationColumn.HeaderText = "البيان";
            this.DeclarationColumn.Name = "DeclarationColumn";
            this.DeclarationColumn.Width = 58;
            // 
            // dgvTotals
            // 
            this.dgvTotals.AllowUserToAddRows = false;
            this.dgvTotals.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTotals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTotals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Format = "N5";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotals.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTotals.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTotals.Location = new System.Drawing.Point(3, 431);
            this.dgvTotals.Name = "dgvTotals";
            this.dgvTotals.ReadOnly = true;
            this.dgvTotals.Size = new System.Drawing.Size(608, 50);
            this.dgvTotals.TabIndex = 3;
            // 
            // payments_ExpenseBindingNavigator
            // 
            this.payments_ExpenseBindingNavigator.AddNewItem = null;
            this.payments_ExpenseBindingNavigator.BindingSource = this.payments_ExpenseBindingSource;
            this.payments_ExpenseBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.payments_ExpenseBindingNavigator.CountItemFormat = "من أصل {0}";
            this.payments_ExpenseBindingNavigator.DeleteItem = null;
            this.payments_ExpenseBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.payments_ExpenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorDeleteItem,
            this.payments_ExpenseBindingNavigatorSaveItem,
            this.toolStripDropDownButton1});
            this.payments_ExpenseBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.payments_ExpenseBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.payments_ExpenseBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.payments_ExpenseBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.payments_ExpenseBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.payments_ExpenseBindingNavigator.Name = "payments_ExpenseBindingNavigator";
            this.payments_ExpenseBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.payments_ExpenseBindingNavigator.Size = new System.Drawing.Size(608, 27);
            this.payments_ExpenseBindingNavigator.TabIndex = 1;
            this.payments_ExpenseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 24);
            this.bindingNavigatorCountItem.Text = "من أصل {0}";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = global::Alver.Properties.Resources.Delete;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(103, 24);
            this.bindingNavigatorDeleteItem.Text = "إلغاء المصروف";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // payments_ExpenseBindingNavigatorSaveItem
            // 
            this.payments_ExpenseBindingNavigatorSaveItem.Image = global::Alver.Properties.Resources.save;
            this.payments_ExpenseBindingNavigatorSaveItem.Name = "payments_ExpenseBindingNavigatorSaveItem";
            this.payments_ExpenseBindingNavigatorSaveItem.Size = new System.Drawing.Size(103, 24);
            this.payments_ExpenseBindingNavigatorSaveItem.Text = "حفظ التعديلات";
            this.payments_ExpenseBindingNavigatorSaveItem.Click += new System.EventHandler(this.payments_ExpenseBindingNavigatorSaveItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اكسلToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::Alver.Properties.Resources.export;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 24);
            this.toolStripDropDownButton1.Text = "تصدير";
            // 
            // اكسلToolStripMenuItem
            // 
            this.اكسلToolStripMenuItem.Image = global::Alver.Properties.Resources.xls;
            this.اكسلToolStripMenuItem.Name = "اكسلToolStripMenuItem";
            this.اكسلToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.اكسلToolStripMenuItem.Text = "اكسل";
            this.اكسلToolStripMenuItem.Click += new System.EventHandler(this.اكسلToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Image = global::Alver.Properties.Resources.pdf;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(105, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 512);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpenses";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المصاريف";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExpensesses_FormClosing);
            this.Load += new System.EventHandler(this.frmExpensesses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paymentsExpenseCategoryBindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseBindingNavigator)).EndInit();
            this.payments_ExpenseBindingNavigator.ResumeLayout(false);
            this.payments_ExpenseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource payments_ExpenseBindingSource;
        private System.Windows.Forms.BindingSource fundBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.BindingSource paymentsExpenseCategoryBindingSource;
#pragma warning disable CS0169 // The field 'frmExpenses.dataGridViewTextBoxColumn7' is never used
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
#pragma warning restore CS0169 // The field 'frmExpenses.dataGridViewTextBoxColumn7' is never used
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox expenseCategoryComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingNavigator payments_ExpenseBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton payments_ExpenseBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource paymentsExpenseCategoryBindingSource1;
        private System.Windows.Forms.DataGridView dgvTotals;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem اكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
#pragma warning disable CS0169 // The field 'frmExpenses.dataGridViewTextBoxColumn3' is never used
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
#pragma warning restore CS0169 // The field 'frmExpenses.dataGridViewTextBoxColumn3' is never used
        private MISC.CalendarColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeclarationColumn;
    }
}