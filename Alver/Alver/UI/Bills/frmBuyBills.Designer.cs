namespace Alver.UI.Bills
{
    partial class frmBuyBills
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
            System.Windows.Forms.Label declarationLabel;
            System.Windows.Forms.Label exchangeDateLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuyBills));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.billLinesDgv = new System.Windows.Forms.DataGridView();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIdColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billLinesBS = new System.Windows.Forms.BindingSource(this.components);
            this.BillBS = new System.Windows.Forms.BindingSource(this.components);
            this.BillLineBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deletebilllinebtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currencycb = new System.Windows.Forms.ComboBox();
            this.currencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.addbilllinebtn = new System.Windows.Forms.Button();
            this.pricenud = new System.Windows.Forms.NumericUpDown();
            this.quantitynud = new System.Windows.Forms.NumericUpDown();
            this.unitcb = new System.Windows.Forms.ComboBox();
            this.unitBS = new System.Windows.Forms.BindingSource(this.components);
            this.itemcb = new System.Windows.Forms.ComboBox();
            this.itemBS = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.accountcb = new System.Windows.Forms.ComboBox();
            this.accountBS = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.billdatedtp = new System.Windows.Forms.DateTimePicker();
            this.declarationtb = new System.Windows.Forms.TextBox();
            this.BillBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.addbillbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deletebillbtn = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sumtotalsnud = new System.Windows.Forms.NumericUpDown();
            this.totalnud = new System.Windows.Forms.NumericUpDown();
            this.discountnud = new System.Windows.Forms.NumericUpDown();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.checkbillbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.chechprintbillbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            declarationLabel = new System.Windows.Forms.Label();
            exchangeDateLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillLineBN)).BeginInit();
            this.BillLineBN.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBS)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBN)).BeginInit();
            this.BillBN.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumtotalsnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(597, 3);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(62, 15);
            declarationLabel.TabIndex = 4;
            declarationLabel.Text = "الملاحظات:";
            // 
            // exchangeDateLabel
            // 
            exchangeDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            exchangeDateLabel.AutoSize = true;
            exchangeDateLabel.Location = new System.Drawing.Point(745, 3);
            exchangeDateLabel.Name = "exchangeDateLabel";
            exchangeDateLabel.Size = new System.Drawing.Size(41, 15);
            exchangeDateLabel.TabIndex = 5;
            exchangeDateLabel.Text = "التاريخ:";
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(-355, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 15);
            label3.TabIndex = 42;
            label3.Text = "المبلع:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(160, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(92, 15);
            label4.TabIndex = 41;
            label4.Text = "الإجمالي الصافي:";
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(893, 20);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(51, 15);
            label9.TabIndex = 39;
            label9.Text = "الإجمالي:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(634, 20);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(41, 15);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "الحسم:";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.billLinesDgv);
            this.tabPage1.Controls.Add(this.BillLineBN);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(955, 217);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الاقلام";
            // 
            // billLinesDgv
            // 
            this.billLinesDgv.AllowUserToAddRows = false;
            this.billLinesDgv.AllowUserToDeleteRows = false;
            this.billLinesDgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.billLinesDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billLinesDgv.AutoGenerateColumns = false;
            this.billLinesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billLinesDgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.billLinesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billLinesDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIdDataGridViewTextBoxColumn,
            this.unitIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.currencyIdColumn,
            this.priceColumn,
            this.totalpriceColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.billLinesDgv.DataSource = this.billLinesBS;
            this.billLinesDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billLinesDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.billLinesDgv.Location = new System.Drawing.Point(3, 30);
            this.billLinesDgv.MultiSelect = false;
            this.billLinesDgv.Name = "billLinesDgv";
            this.billLinesDgv.ReadOnly = true;
            this.billLinesDgv.Size = new System.Drawing.Size(949, 184);
            this.billLinesDgv.TabIndex = 8;
            this.billLinesDgv.VirtualMode = true;
            this.billLinesDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.adddgv_DataBindingComplete);
            this.billLinesDgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.currencyExchangeDataGridView_DataError);
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.itemBindingSource;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "ItemName";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "المادة";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(Alver.DAL.Item);
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.DataSource = this.unitBindingSource;
            this.unitIdDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.unitIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "الواحدة";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            this.unitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(Alver.DAL.Unit);
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currencyIdColumn
            // 
            this.currencyIdColumn.DataPropertyName = "CurrencyId";
            this.currencyIdColumn.DataSource = this.currencyBindingSource;
            this.currencyIdColumn.DisplayMember = "CurrencyName";
            this.currencyIdColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.currencyIdColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdColumn.HeaderText = "العملة";
            this.currencyIdColumn.Name = "currencyIdColumn";
            this.currencyIdColumn.ReadOnly = true;
            this.currencyIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdColumn.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // priceColumn
            // 
            this.priceColumn.DataPropertyName = "Price";
            this.priceColumn.HeaderText = "سعر الواحدة";
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            // 
            // totalpriceColumn
            // 
            this.totalpriceColumn.DataPropertyName = "TotalPrice";
            this.totalpriceColumn.HeaderText = "السعر الاجمالي";
            this.totalpriceColumn.Name = "totalpriceColumn";
            this.totalpriceColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.DataSource = this.userBindingSource;
            this.userIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.userIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Alver.DAL.User);
            // 
            // billLinesBS
            // 
            this.billLinesBS.DataMember = "BillLines";
            this.billLinesBS.DataSource = this.BillBS;
            this.billLinesBS.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.billLinesBS_ListChanged);
            // 
            // BillBS
            // 
            this.BillBS.DataSource = typeof(Alver.DAL.Bill);
            this.BillBS.CurrentChanged += new System.EventHandler(this.BillBS_CurrentChanged);
            // 
            // BillLineBN
            // 
            this.BillLineBN.AddNewItem = null;
            this.BillLineBN.BindingSource = this.billLinesBS;
            this.BillLineBN.CountItem = this.bindingNavigatorCountItem;
            this.BillLineBN.CountItemFormat = "من أصل {0}";
            this.BillLineBN.DeleteItem = null;
            this.BillLineBN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BillLineBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripSeparator5,
            this.deletebilllinebtn});
            this.BillLineBN.Location = new System.Drawing.Point(3, 3);
            this.BillLineBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.BillLineBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.BillLineBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.BillLineBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.BillLineBN.Name = "BillLineBN";
            this.BillLineBN.PositionItem = this.bindingNavigatorPositionItem;
            this.BillLineBN.Size = new System.Drawing.Size(949, 27);
            this.BillLineBN.TabIndex = 2;
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // deletebilllinebtn
            // 
            this.deletebilllinebtn.Name = "deletebilllinebtn";
            this.deletebilllinebtn.RightToLeftAutoMirrorImage = true;
            this.deletebilllinebtn.Size = new System.Drawing.Size(69, 24);
            this.deletebilllinebtn.Text = "حذف الحركة";
            this.deletebilllinebtn.Click += new System.EventHandler(this.dceobtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(257, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 151);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 250);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.ItemSize = new System.Drawing.Size(257, 25);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(963, 151);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.BillBN);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(955, 118);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "فواتير البيع";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 36);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel3.Controls.Add(this.currencycb);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.addbilllinebtn);
            this.panel3.Controls.Add(this.pricenud);
            this.panel3.Controls.Add(this.quantitynud);
            this.panel3.Controls.Add(this.unitcb);
            this.panel3.Controls.Add(this.itemcb);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.Snow;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 36);
            this.panel3.TabIndex = 41;
            // 
            // currencycb
            // 
            this.currencycb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.currencycb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currencycb.BackColor = System.Drawing.Color.LemonChiffon;
            this.currencycb.DataSource = this.currencyBS;
            this.currencycb.DisplayMember = "CurrencyName";
            this.currencycb.FormattingEnabled = true;
            this.currencycb.Location = new System.Drawing.Point(299, 6);
            this.currencycb.Name = "currencycb";
            this.currencycb.Size = new System.Drawing.Size(100, 23);
            this.currencycb.TabIndex = 50;
            this.currencycb.ValueMember = "Id";
            // 
            // currencyBS
            // 
            this.currencyBS.DataSource = typeof(Alver.DAL.Currency);
            this.currencyBS.CurrentChanged += new System.EventHandler(this.currencyBindingSource_CurrentChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 49;
            this.label1.Text = "العملة:";
            // 
            // addbilllinebtn
            // 
            this.addbilllinebtn.BackColor = System.Drawing.Color.Coral;
            this.addbilllinebtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addbilllinebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbilllinebtn.Location = new System.Drawing.Point(0, 0);
            this.addbilllinebtn.Name = "addbilllinebtn";
            this.addbilllinebtn.Size = new System.Drawing.Size(84, 36);
            this.addbilllinebtn.TabIndex = 48;
            this.addbilllinebtn.Text = "إضافة";
            this.addbilllinebtn.UseVisualStyleBackColor = false;
            this.addbilllinebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pricenud
            // 
            this.pricenud.Location = new System.Drawing.Point(121, 6);
            this.pricenud.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.pricenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pricenud.Name = "pricenud";
            this.pricenud.Size = new System.Drawing.Size(100, 23);
            this.pricenud.TabIndex = 47;
            this.pricenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantitynud
            // 
            this.quantitynud.Location = new System.Drawing.Point(448, 6);
            this.quantitynud.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.quantitynud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitynud.Name = "quantitynud";
            this.quantitynud.Size = new System.Drawing.Size(100, 23);
            this.quantitynud.TabIndex = 46;
            this.quantitynud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // unitcb
            // 
            this.unitcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.unitcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.unitcb.BackColor = System.Drawing.Color.LemonChiffon;
            this.unitcb.DataSource = this.unitBS;
            this.unitcb.DisplayMember = "Title";
            this.unitcb.FormattingEnabled = true;
            this.unitcb.Location = new System.Drawing.Point(596, 6);
            this.unitcb.Name = "unitcb";
            this.unitcb.Size = new System.Drawing.Size(100, 23);
            this.unitcb.TabIndex = 45;
            this.unitcb.ValueMember = "Id";
            // 
            // unitBS
            // 
            this.unitBS.DataSource = typeof(Alver.DAL.Unit);
            // 
            // itemcb
            // 
            this.itemcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemcb.BackColor = System.Drawing.Color.LemonChiffon;
            this.itemcb.DataSource = this.itemBS;
            this.itemcb.DisplayMember = "ItemName";
            this.itemcb.FormattingEnabled = true;
            this.itemcb.Location = new System.Drawing.Point(749, 6);
            this.itemcb.Name = "itemcb";
            this.itemcb.Size = new System.Drawing.Size(150, 23);
            this.itemcb.TabIndex = 44;
            this.itemcb.ValueMember = "Id";
            // 
            // itemBS
            // 
            this.itemBS.DataSource = typeof(Alver.DAL.Item);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "سعر الواحدة:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "الكمية:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(700, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "الواحدة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(903, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "المادة:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.accountcb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.billdatedtp);
            this.panel2.Controls.Add(exchangeDateLabel);
            this.panel2.Controls.Add(declarationLabel);
            this.panel2.Controls.Add(this.declarationtb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(949, 51);
            this.panel2.TabIndex = 9;
            // 
            // accountcb
            // 
            this.accountcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.accountcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.accountcb.BackColor = System.Drawing.Color.LemonChiffon;
            this.accountcb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.BillBS, "AccountId", true));
            this.accountcb.DataSource = this.accountBS;
            this.accountcb.DisplayMember = "FullName";
            this.accountcb.FormattingEnabled = true;
            this.accountcb.Location = new System.Drawing.Point(789, 21);
            this.accountcb.Name = "accountcb";
            this.accountcb.Size = new System.Drawing.Size(150, 23);
            this.accountcb.TabIndex = 46;
            this.accountcb.ValueMember = "Id";
            // 
            // accountBS
            // 
            this.accountBS.DataSource = typeof(Alver.DAL.Account);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(903, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "الزبون:";
            // 
            // billdatedtp
            // 
            this.billdatedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billdatedtp.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BillBS, "BillDate", true));
            this.billdatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billdatedtp.Location = new System.Drawing.Point(660, 21);
            this.billdatedtp.Name = "billdatedtp";
            this.billdatedtp.RightToLeftLayout = true;
            this.billdatedtp.Size = new System.Drawing.Size(123, 23);
            this.billdatedtp.TabIndex = 6;
            // 
            // declarationtb
            // 
            this.declarationtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BillBS, "Declaration", true));
            this.declarationtb.Location = new System.Drawing.Point(5, 21);
            this.declarationtb.Name = "declarationtb";
            this.declarationtb.Size = new System.Drawing.Size(649, 23);
            this.declarationtb.TabIndex = 5;
            // 
            // BillBN
            // 
            this.BillBN.AddNewItem = null;
            this.BillBN.BindingSource = this.BillBS;
            this.BillBN.CountItem = this.toolStripLabel1;
            this.BillBN.CountItemFormat = "من أصل {0}";
            this.BillBN.DeleteItem = null;
            this.BillBN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BillBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.toolStripSeparator8,
            this.addbillbtn,
            this.toolStripSeparator4,
            this.deletebillbtn});
            this.BillBN.Location = new System.Drawing.Point(3, 3);
            this.BillBN.MoveFirstItem = this.toolStripButton4;
            this.BillBN.MoveLastItem = this.toolStripButton7;
            this.BillBN.MoveNextItem = this.toolStripButton6;
            this.BillBN.MovePreviousItem = this.toolStripButton5;
            this.BillBN.Name = "BillBN";
            this.BillBN.PositionItem = this.toolStripTextBox1;
            this.BillBN.Size = new System.Drawing.Size(949, 27);
            this.BillBN.TabIndex = 4;
            this.BillBN.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 24);
            this.toolStripLabel1.Text = "من أصل {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton4.Text = "Move first";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton5.Text = "Move previous";
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
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton6.Text = "Move next";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton7.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // addbillbtn
            // 
            this.addbillbtn.Name = "addbillbtn";
            this.addbillbtn.RightToLeftAutoMirrorImage = true;
            this.addbillbtn.Size = new System.Drawing.Size(105, 24);
            this.addbillbtn.Text = "إضافة فاتورة جديدة";
            this.addbillbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbillbtn.Click += new System.EventHandler(this.addcebtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // deletebillbtn
            // 
            this.deletebillbtn.Name = "deletebillbtn";
            this.deletebillbtn.RightToLeftAutoMirrorImage = true;
            this.deletebillbtn.Size = new System.Drawing.Size(203, 24);
            this.deletebillbtn.Text = "حذف الفاتورة مع جميع الاقلام التابعة لها";
            this.deletebillbtn.Click += new System.EventHandler(this.dcebtn_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OpreationDate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn1.HeaderText = "التاريخ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 109;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BaseAmount";
            this.dataGridViewTextBoxColumn2.HeaderText = "المبلغ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 106;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Rate";
            this.dataGridViewTextBoxColumn3.HeaderText = "سعر الصرف";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 110;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SubAmount";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "المبلغ الناتج";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "المبلغ المقرب";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 122;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sumtotalsnud);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.totalnud);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.discountnud);
            this.groupBox1.Controls.Add(amountLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 47);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الإجماليات";
            // 
            // sumtotalsnud
            // 
            this.sumtotalsnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sumtotalsnud.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BillBS, "BillAmount", true));
            this.sumtotalsnud.DecimalPlaces = 3;
            this.sumtotalsnud.Location = new System.Drawing.Point(716, 16);
            this.sumtotalsnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.sumtotalsnud.Name = "sumtotalsnud";
            this.sumtotalsnud.ReadOnly = true;
            this.sumtotalsnud.Size = new System.Drawing.Size(167, 23);
            this.sumtotalsnud.TabIndex = 43;
            // 
            // totalnud
            // 
            this.totalnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalnud.DecimalPlaces = 3;
            this.totalnud.Location = new System.Drawing.Point(6, 16);
            this.totalnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalnud.Name = "totalnud";
            this.totalnud.ReadOnly = true;
            this.totalnud.Size = new System.Drawing.Size(148, 23);
            this.totalnud.TabIndex = 10;
            // 
            // discountnud
            // 
            this.discountnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountnud.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.BillBS, "DiscountAmount", true));
            this.discountnud.DecimalPlaces = 3;
            this.discountnud.Location = new System.Drawing.Point(461, 16);
            this.discountnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.discountnud.Name = "discountnud";
            this.discountnud.Size = new System.Drawing.Size(167, 23);
            this.discountnud.TabIndex = 10;
            this.discountnud.ValueChanged += new System.EventHandler(this.discountnud_ValueChanged_1);
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
            this.savebtn,
            this.toolStripSeparator7,
            this.toolStripSeparator9,
            this.checkbillbtn,
            this.toolStripSeparator6,
            this.chechprintbillbtn,
            this.toolStripSeparator10});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 448);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(963, 25);
            this.bindingNavigator2.TabIndex = 41;
            // 
            // savebtn
            // 
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(111, 22);
            this.savebtn.Text = "تعديل بيانات الفاتورة";
            this.savebtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // checkbillbtn
            // 
            this.checkbillbtn.Name = "checkbillbtn";
            this.checkbillbtn.RightToLeftAutoMirrorImage = true;
            this.checkbillbtn.Size = new System.Drawing.Size(78, 22);
            this.checkbillbtn.Text = "ترحيل الفاتورة";
            this.checkbillbtn.Click += new System.EventHandler(this.checkbillbtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // chechprintbillbtn
            // 
            this.chechprintbillbtn.Name = "chechprintbillbtn";
            this.chechprintbillbtn.RightToLeftAutoMirrorImage = true;
            this.chechprintbillbtn.Size = new System.Drawing.Size(117, 22);
            this.chechprintbillbtn.Text = "ترحيل وطباعة الفاتورة";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // frmBuyBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 473);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.tabControl2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBuyBills";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فواتير البيع";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExchange_FormClosing);
            this.Load += new System.EventHandler(this.frmExchange_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillLineBN)).EndInit();
            this.BillLineBN.ResumeLayout(false);
            this.BillLineBN.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillBN)).EndInit();
            this.BillBN.ResumeLayout(false);
            this.BillBN.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumtotalsnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.BindingSource currencyBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn toCurrencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator BillLineBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource BillBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker billdatedtp;
        private System.Windows.Forms.TextBox declarationtb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView billLinesDgv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource billLinesBS;
        private System.Windows.Forms.BindingNavigator BillBN;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton addbillbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton deletebillbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox currencycb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbilllinebtn;
        private System.Windows.Forms.NumericUpDown pricenud;
        private System.Windows.Forms.NumericUpDown quantitynud;
        private System.Windows.Forms.ComboBox unitcb;
        private System.Windows.Forms.ComboBox itemcb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox accountcb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource accountBS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown sumtotalsnud;
        private System.Windows.Forms.NumericUpDown totalnud;
        private System.Windows.Forms.NumericUpDown discountnud;
        private System.Windows.Forms.BindingSource unitBS;
        private System.Windows.Forms.BindingSource itemBS;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdColumn;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton checkbillbtn;
        private System.Windows.Forms.ToolStripButton chechprintbillbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton deletebilllinebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}