namespace Alver.UI.Accounts.Transactions
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactions));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.accountcb = new System.Windows.Forms.ComboBox();
            this.accountsInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountchkb = new System.Windows.Forms.CheckBox();
            this.currencycheckBox = new System.Windows.Forms.CheckBox();
            this.currencycomboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runningTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeclarationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTotals = new System.Windows.Forms.DataGridView();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.firstbtn = new System.Windows.Forms.ToolStripButton();
            this.prevbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nextbtn = new System.Windows.Forms.ToolStripButton();
            this.lastbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editobjectbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripDropDownButton();
            this.اكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.onlypurchases = new JCS.ToggleSwitch();
            this.label9 = new System.Windows.Forms.Label();
            this.onlyWithdraw = new JCS.ToggleSwitch();
            this.label7 = new System.Windows.Forms.Label();
            this.onlytransfers = new JCS.ToggleSwitch();
            this.label8 = new System.Windows.Forms.Label();
            this.onlycuts = new JCS.ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.onlydeposites = new JCS.ToggleSwitch();
            this.label6 = new System.Windows.Forms.Label();
            this.onlyloans = new JCS.ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.onlypayments = new JCS.ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.onlysales = new JCS.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.accountcb);
            this.splitContainer1.Panel1.Controls.Add(this.accountchkb);
            this.splitContainer1.Panel1.Controls.Add(this.currencycheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.currencycomboBox);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.splitContainer1.Size = new System.Drawing.Size(932, 553);
            this.splitContainer1.SplitterDistance = 187;
            this.splitContainer1.SplitterIncrement = 10;
            this.splitContainer1.SplitterWidth = 15;
            this.splitContainer1.TabIndex = 36;
            // 
            // accountcb
            // 
            this.accountcb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountcb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.accountcb.DataSource = this.accountsInfoBindingSource;
            this.accountcb.DisplayMember = "Fullname";
            this.accountcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountcb.FormattingEnabled = true;
            this.accountcb.Location = new System.Drawing.Point(11, 139);
            this.accountcb.Name = "accountcb";
            this.accountcb.Size = new System.Drawing.Size(165, 23);
            this.accountcb.TabIndex = 55;
            this.accountcb.ValueMember = "Id";
            // 
            // accountsInfoBindingSource
            // 
            this.accountsInfoBindingSource.DataSource = typeof(Alver.DAL.Account);
            // 
            // accountchkb
            // 
            this.accountchkb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountchkb.AutoSize = true;
            this.accountchkb.Checked = true;
            this.accountchkb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.accountchkb.Location = new System.Drawing.Point(80, 119);
            this.accountchkb.Name = "accountchkb";
            this.accountchkb.Size = new System.Drawing.Size(95, 19);
            this.accountchkb.TabIndex = 54;
            this.accountchkb.Text = "بحسب الوكيل:";
            this.accountchkb.UseVisualStyleBackColor = true;
            this.accountchkb.CheckedChanged += new System.EventHandler(this.accountchkb_CheckedChanged);
            // 
            // currencycheckBox
            // 
            this.currencycheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencycheckBox.AutoSize = true;
            this.currencycheckBox.Checked = true;
            this.currencycheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.currencycheckBox.Location = new System.Drawing.Point(80, 171);
            this.currencycheckBox.Name = "currencycheckBox";
            this.currencycheckBox.Size = new System.Drawing.Size(95, 19);
            this.currencycheckBox.TabIndex = 53;
            this.currencycheckBox.Text = "بحسب العملة:";
            this.currencycheckBox.UseVisualStyleBackColor = true;
            this.currencycheckBox.CheckedChanged += new System.EventHandler(this.currencycheckBox_CheckedChanged);
            // 
            // currencycomboBox
            // 
            this.currencycomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencycomboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currencycomboBox.DataSource = this.currencyBindingSource;
            this.currencycomboBox.DisplayMember = "CurrencyName";
            this.currencycomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencycomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencycomboBox.FormattingEnabled = true;
            this.currencycomboBox.Location = new System.Drawing.Point(11, 190);
            this.currencycomboBox.Name = "currencycomboBox";
            this.currencycomboBox.Size = new System.Drawing.Size(164, 23);
            this.currencycomboBox.TabIndex = 52;
            this.currencycomboBox.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Alver.Properties.Resources.getdata;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(11, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 30);
            this.button1.TabIndex = 27;
            this.button1.Text = "جلب";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "إلى تاريخ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 9);
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
            this.FromDateTimePicker.Location = new System.Drawing.Point(11, 32);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.RightToLeftLayout = true;
            this.FromDateTimePicker.ShowCheckBox = true;
            this.FromDateTimePicker.Size = new System.Drawing.Size(164, 23);
            this.FromDateTimePicker.TabIndex = 18;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(11, 86);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.RightToLeftLayout = true;
            this.ToDateTimePicker.Size = new System.Drawing.Size(164, 23);
            this.ToDateTimePicker.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(250, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 553);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Controls.Add(this.dgvTotals);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "كشف حساب";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountIdDataGridViewTextBoxColumn,
            this.tTSDataGridViewTextBoxColumn,
            this.tTDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.runningTotalDataGridViewTextBoxColumn,
            this.DeclarationColumn});
            this.dgv.DataSource = this.transactionBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(3, 108);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 32;
            this.dgv.Size = new System.Drawing.Size(716, 354);
            this.dgv.TabIndex = 35;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.DoubleClick += new System.EventHandler(this.editobjectbtn_Click);
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.DataSource = this.accountsInfoBindingSource;
            this.accountIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.accountIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.accountIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "الوكيل";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accountIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accountIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.accountIdDataGridViewTextBoxColumn.Visible = false;
            this.accountIdDataGridViewTextBoxColumn.Width = 78;
            // 
            // tTSDataGridViewTextBoxColumn
            // 
            this.tTSDataGridViewTextBoxColumn.DataPropertyName = "TTS";
            this.tTSDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.tTSDataGridViewTextBoxColumn.Name = "tTSDataGridViewTextBoxColumn";
            this.tTSDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTSDataGridViewTextBoxColumn.Width = 63;
            // 
            // tTDataGridViewTextBoxColumn
            // 
            this.tTDataGridViewTextBoxColumn.DataPropertyName = "TT";
            this.tTDataGridViewTextBoxColumn.HeaderText = "الحركة";
            this.tTDataGridViewTextBoxColumn.Name = "tTDataGridViewTextBoxColumn";
            this.tTDataGridViewTextBoxColumn.ReadOnly = true;
            this.tTDataGridViewTextBoxColumn.Width = 62;
            // 
            // currencyIdDataGridViewTextBoxColumn
            // 
            this.currencyIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn.DataSource = this.currencyBindingSource;
            this.currencyIdDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyIdDataGridViewTextBoxColumn.Name = "currencyIdDataGridViewTextBoxColumn";
            this.currencyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.currencyIdDataGridViewTextBoxColumn.Width = 63;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 61;
            // 
            // runningTotalDataGridViewTextBoxColumn
            // 
            this.runningTotalDataGridViewTextBoxColumn.DataPropertyName = "RunningTotal";
            this.runningTotalDataGridViewTextBoxColumn.HeaderText = "الرصيد الجاري";
            this.runningTotalDataGridViewTextBoxColumn.Name = "runningTotalDataGridViewTextBoxColumn";
            this.runningTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.runningTotalDataGridViewTextBoxColumn.Width = 98;
            // 
            // DeclarationColumn
            // 
            this.DeclarationColumn.DataPropertyName = "Declaration";
            this.DeclarationColumn.HeaderText = "البيان";
            this.DeclarationColumn.Name = "DeclarationColumn";
            this.DeclarationColumn.ReadOnly = true;
            this.DeclarationColumn.Width = 58;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Alver.DAL.Transaction);
            // 
            // dgvTotals
            // 
            this.dgvTotals.AllowUserToAddRows = false;
            this.dgvTotals.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTotals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTotals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "N5";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotals.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTotals.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTotals.Location = new System.Drawing.Point(3, 462);
            this.dgvTotals.Name = "dgvTotals";
            this.dgvTotals.ReadOnly = true;
            this.dgvTotals.Size = new System.Drawing.Size(716, 50);
            this.dgvTotals.TabIndex = 58;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AllowItemReorder = true;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigator1.BindingSource = this.transactionBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.CountItemFormat = "من أصل {0}";
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstbtn,
            this.prevbtn,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.nextbtn,
            this.lastbtn,
            this.toolStripSeparator3,
            this.editobjectbtn,
            this.toolStripSeparator4,
            this.deletebtn,
            this.toolStripSeparator5,
            this.savebtn,
            this.toolStripButton8});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 81);
            this.bindingNavigator1.MoveFirstItem = this.firstbtn;
            this.bindingNavigator1.MoveLastItem = this.lastbtn;
            this.bindingNavigator1.MoveNextItem = this.nextbtn;
            this.bindingNavigator1.MovePreviousItem = this.prevbtn;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(716, 27);
            this.bindingNavigator1.TabIndex = 34;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 24);
            this.toolStripLabel1.Text = "من أصل {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // firstbtn
            // 
            this.firstbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.firstbtn.Image = ((System.Drawing.Image)(resources.GetObject("firstbtn.Image")));
            this.firstbtn.Name = "firstbtn";
            this.firstbtn.RightToLeftAutoMirrorImage = true;
            this.firstbtn.Size = new System.Drawing.Size(24, 24);
            this.firstbtn.Text = "Move first";
            // 
            // prevbtn
            // 
            this.prevbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prevbtn.Image = ((System.Drawing.Image)(resources.GetObject("prevbtn.Image")));
            this.prevbtn.Name = "prevbtn";
            this.prevbtn.RightToLeftAutoMirrorImage = true;
            this.prevbtn.Size = new System.Drawing.Size(24, 24);
            this.prevbtn.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // nextbtn
            // 
            this.nextbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nextbtn.Image = ((System.Drawing.Image)(resources.GetObject("nextbtn.Image")));
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.RightToLeftAutoMirrorImage = true;
            this.nextbtn.Size = new System.Drawing.Size(24, 24);
            this.nextbtn.Text = "Move next";
            // 
            // lastbtn
            // 
            this.lastbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lastbtn.Image = ((System.Drawing.Image)(resources.GetObject("lastbtn.Image")));
            this.lastbtn.Name = "lastbtn";
            this.lastbtn.RightToLeftAutoMirrorImage = true;
            this.lastbtn.Size = new System.Drawing.Size(24, 24);
            this.lastbtn.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // editobjectbtn
            // 
            this.editobjectbtn.Image = global::Alver.Properties.Resources.edit;
            this.editobjectbtn.Name = "editobjectbtn";
            this.editobjectbtn.RightToLeftAutoMirrorImage = true;
            this.editobjectbtn.Size = new System.Drawing.Size(60, 24);
            this.editobjectbtn.Text = "تعديل";
            this.editobjectbtn.Click += new System.EventHandler(this.editobjectbtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            this.toolStripSeparator4.Visible = false;
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::Alver.Properties.Resources.Delete;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeftAutoMirrorImage = true;
            this.deletebtn.Size = new System.Drawing.Size(89, 24);
            this.deletebtn.Text = "حذف الحركة";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Alver.Properties.Resources.print;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(131, 24);
            this.savebtn.Text = "طباعة إشعار مطابقة";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اكسلToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.toolStripButton8.Image = global::Alver.Properties.Resources.export;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(71, 24);
            this.toolStripButton8.Text = "تصدير";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.onlypurchases);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.onlyWithdraw);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.onlytransfers);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.onlycuts);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.onlydeposites);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.onlyloans);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.onlypayments);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.onlysales);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 78);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تصفية النتائج";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "فواتير الشراء";
            // 
            // onlypurchases
            // 
            this.onlypurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlypurchases.AnimationInterval = 2;
            this.onlypurchases.AnimationStep = 15;
            this.onlypurchases.Location = new System.Drawing.Point(124, 22);
            this.onlypurchases.Name = "onlypurchases";
            this.onlypurchases.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlypurchases.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlypurchases.Size = new System.Drawing.Size(50, 19);
            this.onlypurchases.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-1, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "سحب/إيداع الأرباح فقط";
            // 
            // onlyWithdraw
            // 
            this.onlyWithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlyWithdraw.AnimationInterval = 2;
            this.onlyWithdraw.AnimationStep = 15;
            this.onlyWithdraw.Location = new System.Drawing.Point(124, 46);
            this.onlyWithdraw.Name = "onlyWithdraw";
            this.onlyWithdraw.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyWithdraw.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyWithdraw.Size = new System.Drawing.Size(50, 19);
            this.onlyWithdraw.TabIndex = 33;
            this.onlyWithdraw.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "تحويل الرصيد فقط";
            // 
            // onlytransfers
            // 
            this.onlytransfers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlytransfers.AnimationInterval = 2;
            this.onlytransfers.AnimationStep = 15;
            this.onlytransfers.Location = new System.Drawing.Point(317, 46);
            this.onlytransfers.Name = "onlytransfers";
            this.onlytransfers.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlytransfers.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlytransfers.Size = new System.Drawing.Size(50, 19);
            this.onlytransfers.TabIndex = 31;
            this.onlytransfers.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 30;
            this.label8.Text = "قص الرصيد فقط";
            // 
            // onlycuts
            // 
            this.onlycuts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlycuts.AnimationInterval = 2;
            this.onlycuts.AnimationStep = 15;
            this.onlycuts.Location = new System.Drawing.Point(317, 21);
            this.onlycuts.Name = "onlycuts";
            this.onlycuts.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlycuts.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlycuts.Size = new System.Drawing.Size(50, 19);
            this.onlycuts.TabIndex = 29;
            this.onlycuts.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "الامانات فقط";
            // 
            // onlydeposites
            // 
            this.onlydeposites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlydeposites.AnimationInterval = 2;
            this.onlydeposites.AnimationStep = 15;
            this.onlydeposites.Location = new System.Drawing.Point(472, 46);
            this.onlydeposites.Name = "onlydeposites";
            this.onlydeposites.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlydeposites.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlydeposites.Size = new System.Drawing.Size(50, 19);
            this.onlydeposites.TabIndex = 27;
            this.onlydeposites.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "الديون فقط";
            // 
            // onlyloans
            // 
            this.onlyloans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlyloans.AnimationInterval = 2;
            this.onlyloans.AnimationStep = 15;
            this.onlyloans.Location = new System.Drawing.Point(472, 21);
            this.onlyloans.Name = "onlyloans";
            this.onlyloans.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyloans.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyloans.Size = new System.Drawing.Size(50, 19);
            this.onlyloans.TabIndex = 25;
            this.onlyloans.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "الدفعات فقط";
            // 
            // onlypayments
            // 
            this.onlypayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlypayments.AnimationInterval = 2;
            this.onlypayments.AnimationStep = 15;
            this.onlypayments.Location = new System.Drawing.Point(650, 46);
            this.onlypayments.Name = "onlypayments";
            this.onlypayments.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlypayments.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlypayments.Size = new System.Drawing.Size(50, 19);
            this.onlypayments.TabIndex = 23;
            this.onlypayments.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "فواتير البيع";
            // 
            // onlysales
            // 
            this.onlysales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlysales.AnimationInterval = 2;
            this.onlysales.AnimationStep = 15;
            this.onlysales.Location = new System.Drawing.Point(650, 21);
            this.onlysales.Name = "onlysales";
            this.onlysales.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlysales.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlysales.Size = new System.Drawing.Size(50, 19);
            this.onlysales.TabIndex = 3;
            this.onlysales.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.onlyremittances_CheckedChanged);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTransactions";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب تفصيلي";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTransactions_FormClosing);
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ComboBox accountcb;
        private System.Windows.Forms.CheckBox accountchkb;
        private System.Windows.Forms.CheckBox currencycheckBox;
        private System.Windows.Forms.ComboBox currencycomboBox;
        private System.Windows.Forms.BindingSource accountsInfoBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private JCS.ToggleSwitch onlytransfers;
        private System.Windows.Forms.Label label8;
        private JCS.ToggleSwitch onlycuts;
        private System.Windows.Forms.Label label5;
        private JCS.ToggleSwitch onlydeposites;
        private System.Windows.Forms.Label label6;
        private JCS.ToggleSwitch onlyloans;
        private System.Windows.Forms.Label label4;
        private JCS.ToggleSwitch onlypayments;
        private System.Windows.Forms.Label label3;
        private JCS.ToggleSwitch onlysales;
        private System.Windows.Forms.DataGridView dgvTotals;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton8;
        private System.Windows.Forms.ToolStripMenuItem اكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton editobjectbtn;
        private System.Windows.Forms.Label label9;
        private JCS.ToggleSwitch onlyWithdraw;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runningTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeclarationColumn;
        private System.Windows.Forms.ToolStripButton firstbtn;
        private System.Windows.Forms.ToolStripButton prevbtn;
        private System.Windows.Forms.ToolStripButton nextbtn;
        private System.Windows.Forms.ToolStripButton lastbtn;
        private System.Windows.Forms.Label label10;
        private JCS.ToggleSwitch onlypurchases;
    }
}