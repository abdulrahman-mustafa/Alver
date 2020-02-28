namespace Alver.UI.Items
{
    partial class frmItemsOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemsOverview));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.رقمالمادةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.اسمالمادةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.العملةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.سعرشراءالواحدةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.تكلفة_الشراء = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.مجموع_المبيعات = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.الربحالمتوقعDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vSTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accounts_InfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshdatabtn = new System.Windows.Forms.ToolStripButton();
            this.SearchBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.exportbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.excelexportbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pdfexportbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printbtn = new System.Windows.Forms.ToolStripButton();
            this.dgvTotals = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sortgb = new System.Windows.Forms.GroupBox();
            this.desccb = new System.Windows.Forms.RadioButton();
            this.aseccb = new System.Windows.Forms.RadioButton();
            this.sortcb = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_InfoBindingNavigator)).BeginInit();
            this.accounts_InfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.sortgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(732, 407);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.accounts_InfoBindingNavigator);
            this.tabPage2.Controls.Add(this.dgvTotals);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(724, 369);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "الكميات";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.رقمالمادةDataGridViewTextBoxColumn,
            this.اسمالمادةDataGridViewTextBoxColumn,
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn,
            this.العملةDataGridViewTextBoxColumn,
            this.سعرشراءالواحدةDataGridViewTextBoxColumn,
            this.تكلفة_الشراء,
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn,
            this.مجموع_المبيعات,
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn,
            this.الربحالمتوقعDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.vSTOCKBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(3, 30);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(718, 292);
            this.dgv.TabIndex = 3;
            this.dgv.ColumnNameChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dgv_ColumnNameChanged);
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            this.dgv.DoubleClick += new System.EventHandler(this.printbtn_Click);
            // 
            // رقمالمادةDataGridViewTextBoxColumn
            // 
            this.رقمالمادةDataGridViewTextBoxColumn.DataPropertyName = "رقم_المادة";
            this.رقمالمادةDataGridViewTextBoxColumn.HeaderText = "رقم المادة";
            this.رقمالمادةDataGridViewTextBoxColumn.Name = "رقمالمادةDataGridViewTextBoxColumn";
            this.رقمالمادةDataGridViewTextBoxColumn.ReadOnly = true;
            this.رقمالمادةDataGridViewTextBoxColumn.Visible = false;
            this.رقمالمادةDataGridViewTextBoxColumn.Width = 77;
            // 
            // اسمالمادةDataGridViewTextBoxColumn
            // 
            this.اسمالمادةDataGridViewTextBoxColumn.DataPropertyName = "اسم_المادة";
            this.اسمالمادةDataGridViewTextBoxColumn.HeaderText = "اسم المادة";
            this.اسمالمادةDataGridViewTextBoxColumn.Name = "اسمالمادةDataGridViewTextBoxColumn";
            this.اسمالمادةDataGridViewTextBoxColumn.ReadOnly = true;
            this.اسمالمادةDataGridViewTextBoxColumn.Width = 84;
            // 
            // عددالكروزاتالمتوفرةDataGridViewTextBoxColumn
            // 
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn.DataPropertyName = "عدد_الكروزات_المتوفرة";
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn.HeaderText = "عدد الكروزات المتوفرة";
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn.Name = "عددالكروزاتالمتوفرةDataGridViewTextBoxColumn";
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn.ReadOnly = true;
            this.عددالكروزاتالمتوفرةDataGridViewTextBoxColumn.Width = 138;
            // 
            // العملةDataGridViewTextBoxColumn
            // 
            this.العملةDataGridViewTextBoxColumn.DataPropertyName = "العملة";
            this.العملةDataGridViewTextBoxColumn.DataSource = this.currencyBindingSource;
            this.العملةDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.العملةDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.العملةDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.العملةDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.العملةDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.العملةDataGridViewTextBoxColumn.Name = "العملةDataGridViewTextBoxColumn";
            this.العملةDataGridViewTextBoxColumn.ReadOnly = true;
            this.العملةDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.العملةDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.العملةDataGridViewTextBoxColumn.ValueMember = "Id";
            this.العملةDataGridViewTextBoxColumn.Width = 63;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // سعرشراءالواحدةDataGridViewTextBoxColumn
            // 
            this.سعرشراءالواحدةDataGridViewTextBoxColumn.DataPropertyName = "سعر_شراء_الواحدة";
            this.سعرشراءالواحدةDataGridViewTextBoxColumn.HeaderText = "سعر شراء الواحدة";
            this.سعرشراءالواحدةDataGridViewTextBoxColumn.Name = "سعرشراءالواحدةDataGridViewTextBoxColumn";
            this.سعرشراءالواحدةDataGridViewTextBoxColumn.ReadOnly = true;
            this.سعرشراءالواحدةDataGridViewTextBoxColumn.Width = 116;
            // 
            // تكلفة_الشراء
            // 
            this.تكلفة_الشراء.DataPropertyName = "تكلفة_الشراء";
            this.تكلفة_الشراء.HeaderText = "تكلفة الشراء";
            this.تكلفة_الشراء.Name = "تكلفة_الشراء";
            this.تكلفة_الشراء.ReadOnly = true;
            this.تكلفة_الشراء.Width = 89;
            // 
            // سعرمبيعالواحدةDataGridViewTextBoxColumn
            // 
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn.DataPropertyName = "سعر_مبيع_الواحدة";
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn.HeaderText = "سعر مبيع الواحدة";
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn.Name = "سعرمبيعالواحدةDataGridViewTextBoxColumn";
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn.ReadOnly = true;
            this.سعرمبيعالواحدةDataGridViewTextBoxColumn.Width = 117;
            // 
            // مجموع_المبيعات
            // 
            this.مجموع_المبيعات.DataPropertyName = "مجموع_المبيعات";
            this.مجموع_المبيعات.HeaderText = "مجموع المبيعات";
            this.مجموع_المبيعات.Name = "مجموع_المبيعات";
            this.مجموع_المبيعات.ReadOnly = true;
            this.مجموع_المبيعات.Width = 112;
            // 
            // هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn
            // 
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn.DataPropertyName = "هامش_الربح_في_القطعة_الواحدة";
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn.HeaderText = "هامش الربح في القطعة الواحدة";
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn.Name = "هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn";
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn.ReadOnly = true;
            this.هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn.Width = 186;
            // 
            // الربحالمتوقعDataGridViewTextBoxColumn
            // 
            this.الربحالمتوقعDataGridViewTextBoxColumn.DataPropertyName = "الربح_المتوقع";
            this.الربحالمتوقعDataGridViewTextBoxColumn.HeaderText = "الربح المتوقع";
            this.الربحالمتوقعDataGridViewTextBoxColumn.Name = "الربحالمتوقعDataGridViewTextBoxColumn";
            this.الربحالمتوقعDataGridViewTextBoxColumn.ReadOnly = true;
            this.الربحالمتوقعDataGridViewTextBoxColumn.Width = 95;
            // 
            // vSTOCKBindingSource
            // 
            this.vSTOCKBindingSource.DataSource = typeof(Alver.DAL.V_STOCK);
            // 
            // accounts_InfoBindingNavigator
            // 
            this.accounts_InfoBindingNavigator.AddNewItem = null;
            this.accounts_InfoBindingNavigator.AutoSize = false;
            this.accounts_InfoBindingNavigator.BindingSource = this.vSTOCKBindingSource;
            this.accounts_InfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accounts_InfoBindingNavigator.CountItemFormat = "من أصل {0}";
            this.accounts_InfoBindingNavigator.DeleteItem = null;
            this.accounts_InfoBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accounts_InfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.refreshdatabtn,
            this.SearchBox,
            this.toolStripLabel3,
            this.exportbtn,
            this.printbtn});
            this.accounts_InfoBindingNavigator.Location = new System.Drawing.Point(3, 4);
            this.accounts_InfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accounts_InfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accounts_InfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accounts_InfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accounts_InfoBindingNavigator.Name = "accounts_InfoBindingNavigator";
            this.accounts_InfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accounts_InfoBindingNavigator.Size = new System.Drawing.Size(718, 26);
            this.accounts_InfoBindingNavigator.TabIndex = 6;
            this.accounts_InfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 23);
            this.bindingNavigatorCountItem.Text = "من أصل {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 26);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 23);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // refreshdatabtn
            // 
            this.refreshdatabtn.BackColor = System.Drawing.Color.LightYellow;
            this.refreshdatabtn.Image = global::Alver.Properties.Resources.refresh;
            this.refreshdatabtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshdatabtn.Name = "refreshdatabtn";
            this.refreshdatabtn.Size = new System.Drawing.Size(63, 23);
            this.refreshdatabtn.Text = "تحديث";
            this.refreshdatabtn.Click += new System.EventHandler(this.refreshdatabtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchBox.AutoSize = false;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(200, 23);
            this.SearchBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(39, 23);
            this.toolStripLabel3.Text = "البحث:";
            // 
            // exportbtn
            // 
            this.exportbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelexportbtn,
            this.pdfexportbtn});
            this.exportbtn.Image = global::Alver.Properties.Resources.export;
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(71, 23);
            this.exportbtn.Text = "تصدير";
            // 
            // excelexportbtn
            // 
            this.excelexportbtn.Image = global::Alver.Properties.Resources.xls;
            this.excelexportbtn.Name = "excelexportbtn";
            this.excelexportbtn.Size = new System.Drawing.Size(105, 26);
            this.excelexportbtn.Text = "اكسل";
            this.excelexportbtn.Click += new System.EventHandler(this.excelexportbtn_Click);
            // 
            // pdfexportbtn
            // 
            this.pdfexportbtn.Image = global::Alver.Properties.Resources.pdf;
            this.pdfexportbtn.Name = "pdfexportbtn";
            this.pdfexportbtn.Size = new System.Drawing.Size(105, 26);
            this.pdfexportbtn.Text = "PDF";
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.Aquamarine;
            this.printbtn.Name = "printbtn";
            this.printbtn.RightToLeftAutoMirrorImage = true;
            this.printbtn.Size = new System.Drawing.Size(111, 19);
            this.printbtn.Text = "طباعة إشعار مطابقة";
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
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
            this.dgvTotals.Location = new System.Drawing.Point(3, 322);
            this.dgvTotals.Name = "dgvTotals";
            this.dgvTotals.ReadOnly = true;
            this.dgvTotals.Size = new System.Drawing.Size(718, 43);
            this.dgvTotals.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sortgb);
            this.splitContainer1.Panel1.Controls.Add(this.sortcb);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(959, 407);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 8;
            // 
            // sortgb
            // 
            this.sortgb.Controls.Add(this.desccb);
            this.sortgb.Controls.Add(this.aseccb);
            this.sortgb.Enabled = false;
            this.sortgb.Location = new System.Drawing.Point(12, 38);
            this.sortgb.Name = "sortgb";
            this.sortgb.Size = new System.Drawing.Size(184, 90);
            this.sortgb.TabIndex = 59;
            this.sortgb.TabStop = false;
            // 
            // desccb
            // 
            this.desccb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.desccb.AutoSize = true;
            this.desccb.Checked = true;
            this.desccb.Location = new System.Drawing.Point(51, 26);
            this.desccb.Name = "desccb";
            this.desccb.Size = new System.Drawing.Size(127, 19);
            this.desccb.TabIndex = 57;
            this.desccb.TabStop = true;
            this.desccb.Text = "من الأعلى إلى الأدنى";
            this.desccb.UseVisualStyleBackColor = true;
            // 
            // aseccb
            // 
            this.aseccb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aseccb.AutoSize = true;
            this.aseccb.Location = new System.Drawing.Point(51, 56);
            this.aseccb.Name = "aseccb";
            this.aseccb.Size = new System.Drawing.Size(127, 19);
            this.aseccb.TabIndex = 57;
            this.aseccb.Text = "من الأدنى إلى الأعلى";
            this.aseccb.UseVisualStyleBackColor = true;
            // 
            // sortcb
            // 
            this.sortcb.AutoSize = true;
            this.sortcb.Location = new System.Drawing.Point(155, 12);
            this.sortcb.Name = "sortcb";
            this.sortcb.Size = new System.Drawing.Size(41, 19);
            this.sortcb.TabIndex = 58;
            this.sortcb.Text = "فرز";
            this.sortcb.UseVisualStyleBackColor = true;
            this.sortcb.CheckedChanged += new System.EventHandler(this.sortcb_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Alver.Properties.Resources.getdata;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 30);
            this.button1.TabIndex = 56;
            this.button1.Text = "جلب";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "تكلفة_الشراء";
            this.dataGridViewTextBoxColumn1.HeaderText = "تكلفة الشراء";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "مجموع_المبيعات";
            this.dataGridViewTextBoxColumn2.HeaderText = "مجموع المبيعات";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 102;
            // 
            // frmItemsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 407);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmItemsOverview";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كميات المواد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmClientsOverview_Load);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vSTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_InfoBindingNavigator)).EndInit();
            this.accounts_InfoBindingNavigator.ResumeLayout(false);
            this.accounts_InfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.sortgb.ResumeLayout(false);
            this.sortgb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridView dgvTotals;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton aseccb;
        private System.Windows.Forms.RadioButton desccb;
        private System.Windows.Forms.CheckBox sortcb;
        private System.Windows.Forms.GroupBox sortgb;
        private System.Windows.Forms.DataGridViewTextBoxColumn مجموعسعرالشراءDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مجموعسعرالبيعDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vSTOCKBindingSource;
        private System.Windows.Forms.BindingNavigator accounts_InfoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton refreshdatabtn;
        private System.Windows.Forms.ToolStripTextBox SearchBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripDropDownButton exportbtn;
        private System.Windows.Forms.ToolStripMenuItem excelexportbtn;
        private System.Windows.Forms.ToolStripMenuItem pdfexportbtn;
        private System.Windows.Forms.ToolStripButton printbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn رقمالمادةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn اسمالمادةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn عددالكروزاتالمتوفرةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn العملةDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعرشراءالواحدةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn تكلفة_الشراء;
        private System.Windows.Forms.DataGridViewTextBoxColumn سعرمبيعالواحدةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn مجموع_المبيعات;
        private System.Windows.Forms.DataGridViewTextBoxColumn هامشالربحفيالقطعةالواحدةDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn الربحالمتوقعDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}