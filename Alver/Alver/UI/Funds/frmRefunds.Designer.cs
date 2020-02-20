namespace Alver.UI.Funds
{
    partial class frmRefunds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRefunds));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.payments_OperationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.paymentsOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editobjectbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.payments_OperationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.اكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declarationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lockedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.usersUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fromFundchkbox = new System.Windows.Forms.CheckBox();
            this.currencychkbox = new System.Windows.Forms.CheckBox();
            this.toFundchkbox = new System.Windows.Forms.CheckBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.payments_OperationBindingNavigator)).BeginInit();
            this.payments_OperationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // payments_OperationBindingNavigator
            // 
            this.payments_OperationBindingNavigator.AddNewItem = null;
            this.payments_OperationBindingNavigator.BindingSource = this.paymentsOperationBindingSource;
            this.payments_OperationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.payments_OperationBindingNavigator.CountItemFormat = "من أصل {0}";
            this.payments_OperationBindingNavigator.DeleteItem = null;
            this.payments_OperationBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.payments_OperationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.editobjectbtn,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.payments_OperationBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.toolStripDropDownButton1});
            this.payments_OperationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.payments_OperationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.payments_OperationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.payments_OperationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.payments_OperationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.payments_OperationBindingNavigator.Name = "payments_OperationBindingNavigator";
            this.payments_OperationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.payments_OperationBindingNavigator.Size = new System.Drawing.Size(865, 27);
            this.payments_OperationBindingNavigator.TabIndex = 0;
            this.payments_OperationBindingNavigator.Text = "bindingNavigator1";
            // 
            // paymentsOperationBindingSource
            // 
            this.paymentsOperationBindingSource.DataSource = typeof(DAL.Payment);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(83, 24);
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
            // editobjectbtn
            // 
            this.editobjectbtn.Image = ((System.Drawing.Image)(resources.GetObject("editobjectbtn.Image")));
            this.editobjectbtn.Name = "editobjectbtn";
            this.editobjectbtn.RightToLeftAutoMirrorImage = true;
            this.editobjectbtn.Size = new System.Drawing.Size(70, 24);
            this.editobjectbtn.Text = "تعديل";
            this.editobjectbtn.Visible = false;
            this.editobjectbtn.Click += new System.EventHandler(this.editobjectbtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(65, 24);
            this.bindingNavigatorDeleteItem.Text = "حذف";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // payments_OperationBindingNavigatorSaveItem
            // 
            this.payments_OperationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("payments_OperationBindingNavigatorSaveItem.Image")));
            this.payments_OperationBindingNavigatorSaveItem.Name = "payments_OperationBindingNavigatorSaveItem";
            this.payments_OperationBindingNavigatorSaveItem.Size = new System.Drawing.Size(126, 24);
            this.payments_OperationBindingNavigatorSaveItem.Text = "حفظ التعديلات";
            this.payments_OperationBindingNavigatorSaveItem.Visible = false;
            this.payments_OperationBindingNavigatorSaveItem.Click += new System.EventHandler(this.payments_OperationBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(89, 24);
            this.toolStripButton1.Text = "رد الأمانة";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اكسلToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(82, 24);
            this.toolStripDropDownButton1.Text = "تصدير";
            // 
            // اكسلToolStripMenuItem
            // 
            this.اكسلToolStripMenuItem.Name = "اكسلToolStripMenuItem";
            this.اكسلToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.اكسلToolStripMenuItem.Text = "اكسل";
            this.اكسلToolStripMenuItem.Click += new System.EventHandler(this.اكسلToolStripMenuItem_Click);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.declarationDataGridViewTextBoxColumn,
            this.payedDataGridViewTextBoxColumn,
            this.lockedDataGridViewTextBoxColumn,
            this.lUDDataGridViewTextBoxColumn,
            this.UserId});
            this.dgv.DataSource = this.paymentsOperationBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(865, 485);
            this.dgv.TabIndex = 1;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.payments_OperationDataGridView_DataError);
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentDateDataGridViewTextBoxColumn.Width = 77;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.paymentTypeDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "نوع الدفعة";
            this.paymentTypeDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "تغذية_صندوق",
            "سحب_من_صندوق"});
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.paymentTypeDataGridViewTextBoxColumn.Width = 106;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.DataSource = this.fundBindingSource;
            this.accountIdDataGridViewTextBoxColumn.DisplayMember = "FundTitle";
            this.accountIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.accountIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.accountIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "الصندوق";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accountIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accountIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.accountIdDataGridViewTextBoxColumn.Width = 94;
            // 
            // fundBindingSource
            // 
            this.fundBindingSource.DataSource = typeof(DAL.Fund);
            // 
            // currencyIdDataGridViewTextBoxColumn
            // 
            this.currencyIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn.DataSource = this.currencyBindingSource;
            this.currencyIdDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyIdDataGridViewTextBoxColumn.Name = "currencyIdDataGridViewTextBoxColumn";
            this.currencyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.currencyIdDataGridViewTextBoxColumn.Width = 78;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(DAL.Currency);
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 75;
            // 
            // declarationDataGridViewTextBoxColumn
            // 
            this.declarationDataGridViewTextBoxColumn.DataPropertyName = "Declaration";
            this.declarationDataGridViewTextBoxColumn.HeaderText = "البيان";
            this.declarationDataGridViewTextBoxColumn.Name = "declarationDataGridViewTextBoxColumn";
            this.declarationDataGridViewTextBoxColumn.ReadOnly = true;
            this.declarationDataGridViewTextBoxColumn.Width = 71;
            // 
            // payedDataGridViewTextBoxColumn
            // 
            this.payedDataGridViewTextBoxColumn.DataPropertyName = "Payed";
            this.payedDataGridViewTextBoxColumn.HeaderText = "Payed";
            this.payedDataGridViewTextBoxColumn.Name = "payedDataGridViewTextBoxColumn";
            this.payedDataGridViewTextBoxColumn.ReadOnly = true;
            this.payedDataGridViewTextBoxColumn.Visible = false;
            this.payedDataGridViewTextBoxColumn.Width = 77;
            // 
            // lockedDataGridViewTextBoxColumn
            // 
            this.lockedDataGridViewTextBoxColumn.DataPropertyName = "Locked";
            this.lockedDataGridViewTextBoxColumn.HeaderText = "Locked";
            this.lockedDataGridViewTextBoxColumn.Name = "lockedDataGridViewTextBoxColumn";
            this.lockedDataGridViewTextBoxColumn.ReadOnly = true;
            this.lockedDataGridViewTextBoxColumn.Visible = false;
            this.lockedDataGridViewTextBoxColumn.Width = 85;
            // 
            // lUDDataGridViewTextBoxColumn
            // 
            this.lUDDataGridViewTextBoxColumn.DataPropertyName = "LUD";
            this.lUDDataGridViewTextBoxColumn.HeaderText = "LUD";
            this.lUDDataGridViewTextBoxColumn.Name = "lUDDataGridViewTextBoxColumn";
            this.lUDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lUDDataGridViewTextBoxColumn.Visible = false;
            this.lUDDataGridViewTextBoxColumn.Width = 66;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.DataSource = this.usersUserBindingSource;
            this.UserId.DisplayMember = "FullName";
            this.UserId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.UserId.DisplayStyleForCurrentCellOnly = true;
            this.UserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserId.HeaderText = "المستخدم";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.ValueMember = "Id";
            this.UserId.Width = 77;
            // 
            // usersUserBindingSource
            // 
            this.usersUserBindingSource.DataSource = typeof(DAL.User);
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
            this.splitContainer1.Panel1.Controls.Add(this.fromFundchkbox);
            this.splitContainer1.Panel1.Controls.Add(this.currencychkbox);
            this.splitContainer1.Panel1.Controls.Add(this.toFundchkbox);
            this.splitContainer1.Panel1.Controls.Add(this.currencyComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.FromDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.ToDateTimePicker);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Panel2.Controls.Add(this.payments_OperationBindingNavigator);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1060, 512);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 8;
            // 
            // fromFundchkbox
            // 
            this.fromFundchkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fromFundchkbox.AutoSize = true;
            this.fromFundchkbox.Checked = true;
            this.fromFundchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fromFundchkbox.Location = new System.Drawing.Point(20, 149);
            this.fromFundchkbox.Name = "fromFundchkbox";
            this.fromFundchkbox.Size = new System.Drawing.Size(153, 24);
            this.fromFundchkbox.TabIndex = 33;
            this.fromFundchkbox.Text = "حركات السحب فقط";
            this.fromFundchkbox.UseVisualStyleBackColor = true;
            // 
            // currencychkbox
            // 
            this.currencychkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencychkbox.AutoSize = true;
            this.currencychkbox.Location = new System.Drawing.Point(63, 201);
            this.currencychkbox.Name = "currencychkbox";
            this.currencychkbox.Size = new System.Drawing.Size(110, 24);
            this.currencychkbox.TabIndex = 32;
            this.currencychkbox.Text = "تحديد العملة";
            this.currencychkbox.UseVisualStyleBackColor = true;
            this.currencychkbox.CheckedChanged += new System.EventHandler(this.currencychkbox_CheckedChanged);
            // 
            // toFundchkbox
            // 
            this.toFundchkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toFundchkbox.AutoSize = true;
            this.toFundchkbox.Checked = true;
            this.toFundchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toFundchkbox.Location = new System.Drawing.Point(21, 119);
            this.toFundchkbox.Name = "toFundchkbox";
            this.toFundchkbox.Size = new System.Drawing.Size(152, 24);
            this.toFundchkbox.TabIndex = 31;
            this.toFundchkbox.Text = "حركات التغذية فقط";
            this.toFundchkbox.UseVisualStyleBackColor = true;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.currencyComboBox.DataSource = this.currencyBindingSource1;
            this.currencyComboBox.DisplayMember = "CurrencyName";
            this.currencyComboBox.Enabled = false;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(20, 231);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(153, 28);
            this.currencyComboBox.TabIndex = 30;
            this.currencyComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource1
            // 
            this.currencyBindingSource1.DataSource = typeof(DAL.Currency);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(16, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 30);
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
            this.label2.Location = new System.Drawing.Point(105, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "إلى تاريخ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "من تاريخ:";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(16, 32);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.RightToLeftLayout = true;
            this.FromDateTimePicker.ShowCheckBox = true;
            this.FromDateTimePicker.Size = new System.Drawing.Size(157, 27);
            this.FromDateTimePicker.TabIndex = 18;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(16, 86);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.RightToLeftLayout = true;
            this.ToDateTimePicker.Size = new System.Drawing.Size(157, 27);
            this.ToDateTimePicker.TabIndex = 19;
            // 
            // frmRefunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 512);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRefunds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل حركات الصندوق";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRefunds_FormClosing);
            this.Load += new System.EventHandler(this.frmPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payments_OperationBindingNavigator)).EndInit();
            this.payments_OperationBindingNavigator.ResumeLayout(false);
            this.payments_OperationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymentsOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersUserBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingNavigator payments_OperationBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton payments_OperationBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.BindingSource paymentsOperationBindingSource;
        private System.Windows.Forms.BindingSource fundBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource1;
        private System.Windows.Forms.CheckBox toFundchkbox;
        private System.Windows.Forms.CheckBox currencychkbox;
        private System.Windows.Forms.CheckBox fromFundchkbox;
        private System.Windows.Forms.BindingSource usersUserBindingSource;
        private System.Windows.Forms.ToolStripButton editobjectbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem اكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declarationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserId;
    }
}