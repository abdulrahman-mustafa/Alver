namespace Alver.UI.Bills
{
    partial class frmBillMangement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillMangement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.itemgb = new System.Windows.Forms.GroupBox();
            this.itemcb = new System.Windows.Forms.ComboBox();
            this.itemIdBS = new System.Windows.Forms.BindingSource(this.components);
            this.itemchkbox = new System.Windows.Forms.CheckBox();
            this.billIdgb = new System.Windows.Forms.GroupBox();
            this.billidcb = new System.Windows.Forms.ComboBox();
            this.billIdBS = new System.Windows.Forms.BindingSource(this.components);
            this.billidchkbox = new System.Windows.Forms.CheckBox();
            this.billcheckedouttypegb = new System.Windows.Forms.GroupBox();
            this.nonetcheckedoutbillchkbox = new System.Windows.Forms.CheckBox();
            this.billcheckedoutchkbox = new System.Windows.Forms.CheckBox();
            this.billtypegb = new System.Windows.Forms.GroupBox();
            this.purchasebillchkbox = new System.Windows.Forms.CheckBox();
            this.sellbillchkbox = new System.Windows.Forms.CheckBox();
            this.dategb = new System.Windows.Forms.GroupBox();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.searchbtn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.billsdgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.billTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billbasecurrencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.billAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreginCurrencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billforeigncurrencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.exchangedAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declarationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billuserBS = new System.Windows.Forms.BindingSource(this.components);
            this.BillsBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTotals = new System.Windows.Forms.DataGridView();
            this.billsBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BillFuncs = new System.Windows.Forms.ToolStripDropDownButton();
            this.addbillbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.editbillbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.deletebillbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printbillslipbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.printbillbtn = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.billlinesdgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billlineitemBS = new System.Windows.Forms.BindingSource(this.components);
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billlineunitBS = new System.Windows.Forms.BindingSource(this.components);
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billlinebasecurrencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangedDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreginCurrencyIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billlineforeigncurrencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.exchangedAmountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exchangedTotalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.billlineuserBS = new System.Windows.Forms.BindingSource(this.components);
            this.BillLinesBS = new System.Windows.Forms.BindingSource(this.components);
            this.billLinesBN = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Payed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ignored = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IgnoreDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Accountgb = new System.Windows.Forms.GroupBox();
            this.accountcb = new System.Windows.Forms.ComboBox();
            this.accountchkbox = new System.Windows.Forms.CheckBox();
            this.accountBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.itemgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemIdBS)).BeginInit();
            this.billIdgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billIdBS)).BeginInit();
            this.billcheckedouttypegb.SuspendLayout();
            this.billtypegb.SuspendLayout();
            this.dategb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billbasecurrencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billforeigncurrencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billuserBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBN)).BeginInit();
            this.billsBN.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billlinesdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineitemBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineunitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlinebasecurrencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineforeigncurrencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineuserBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillLinesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesBN)).BeginInit();
            this.billLinesBN.SuspendLayout();
            this.Accountgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.Accountgb);
            this.splitContainer1.Panel1.Controls.Add(this.itemgb);
            this.splitContainer1.Panel1.Controls.Add(this.billIdgb);
            this.splitContainer1.Panel1.Controls.Add(this.billcheckedouttypegb);
            this.splitContainer1.Panel1.Controls.Add(this.billtypegb);
            this.splitContainer1.Panel1.Controls.Add(this.dategb);
            this.splitContainer1.Panel1.Controls.Add(this.searchbtn);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(1176, 678);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // itemgb
            // 
            this.itemgb.Controls.Add(this.itemcb);
            this.itemgb.Controls.Add(this.itemchkbox);
            this.itemgb.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemgb.Location = new System.Drawing.Point(0, 338);
            this.itemgb.Name = "itemgb";
            this.itemgb.Size = new System.Drawing.Size(190, 69);
            this.itemgb.TabIndex = 56;
            this.itemgb.TabStop = false;
            this.itemgb.Text = "الصنف";
            // 
            // itemcb
            // 
            this.itemcb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.itemcb.DataSource = this.itemIdBS;
            this.itemcb.DisplayMember = "ItemName";
            this.itemcb.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemcb.Enabled = false;
            this.itemcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemcb.FormattingEnabled = true;
            this.itemcb.Location = new System.Drawing.Point(3, 39);
            this.itemcb.Name = "itemcb";
            this.itemcb.Size = new System.Drawing.Size(184, 23);
            this.itemcb.TabIndex = 31;
            this.itemcb.ValueMember = "Id";
            // 
            // itemIdBS
            // 
            this.itemIdBS.DataSource = typeof(Alver.DAL.Item);
            // 
            // itemchkbox
            // 
            this.itemchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemchkbox.Location = new System.Drawing.Point(3, 19);
            this.itemchkbox.Name = "itemchkbox";
            this.itemchkbox.Size = new System.Drawing.Size(184, 20);
            this.itemchkbox.TabIndex = 38;
            this.itemchkbox.Text = "الفواتير التي تحوي المادة:";
            this.itemchkbox.UseVisualStyleBackColor = true;
            this.itemchkbox.CheckedChanged += new System.EventHandler(this.itemchkbox_CheckedChanged);
            // 
            // billIdgb
            // 
            this.billIdgb.Controls.Add(this.billidcb);
            this.billIdgb.Controls.Add(this.billidchkbox);
            this.billIdgb.Dock = System.Windows.Forms.DockStyle.Top;
            this.billIdgb.Location = new System.Drawing.Point(0, 268);
            this.billIdgb.Name = "billIdgb";
            this.billIdgb.Size = new System.Drawing.Size(190, 70);
            this.billIdgb.TabIndex = 55;
            this.billIdgb.TabStop = false;
            this.billIdgb.Text = "رقم الفاتورة";
            // 
            // billidcb
            // 
            this.billidcb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.billidcb.DataSource = this.billIdBS;
            this.billidcb.DisplayMember = "Id";
            this.billidcb.Dock = System.Windows.Forms.DockStyle.Top;
            this.billidcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.billidcb.Enabled = false;
            this.billidcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billidcb.FormattingEnabled = true;
            this.billidcb.Location = new System.Drawing.Point(3, 39);
            this.billidcb.Name = "billidcb";
            this.billidcb.Size = new System.Drawing.Size(184, 23);
            this.billidcb.TabIndex = 31;
            this.billidcb.ValueMember = "Id";
            // 
            // billIdBS
            // 
            this.billIdBS.DataSource = typeof(Alver.DAL.Bill);
            // 
            // billidchkbox
            // 
            this.billidchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.billidchkbox.Location = new System.Drawing.Point(3, 19);
            this.billidchkbox.Name = "billidchkbox";
            this.billidchkbox.Size = new System.Drawing.Size(184, 20);
            this.billidchkbox.TabIndex = 38;
            this.billidchkbox.Text = "البحث برقم الفاتورة:";
            this.billidchkbox.UseVisualStyleBackColor = true;
            this.billidchkbox.CheckedChanged += new System.EventHandler(this.billidchkbox_CheckedChanged);
            // 
            // billcheckedouttypegb
            // 
            this.billcheckedouttypegb.Controls.Add(this.nonetcheckedoutbillchkbox);
            this.billcheckedouttypegb.Controls.Add(this.billcheckedoutchkbox);
            this.billcheckedouttypegb.Dock = System.Windows.Forms.DockStyle.Top;
            this.billcheckedouttypegb.Location = new System.Drawing.Point(0, 183);
            this.billcheckedouttypegb.Name = "billcheckedouttypegb";
            this.billcheckedouttypegb.Size = new System.Drawing.Size(190, 85);
            this.billcheckedouttypegb.TabIndex = 47;
            this.billcheckedouttypegb.TabStop = false;
            this.billcheckedouttypegb.Text = "حالة الفاتورة";
            // 
            // nonetcheckedoutbillchkbox
            // 
            this.nonetcheckedoutbillchkbox.Checked = true;
            this.nonetcheckedoutbillchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nonetcheckedoutbillchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.nonetcheckedoutbillchkbox.Location = new System.Drawing.Point(3, 49);
            this.nonetcheckedoutbillchkbox.Name = "nonetcheckedoutbillchkbox";
            this.nonetcheckedoutbillchkbox.Size = new System.Drawing.Size(184, 30);
            this.nonetcheckedoutbillchkbox.TabIndex = 41;
            this.nonetcheckedoutbillchkbox.Text = "فاتورة غير مرحلة";
            this.nonetcheckedoutbillchkbox.UseVisualStyleBackColor = true;
            this.nonetcheckedoutbillchkbox.CheckedChanged += new System.EventHandler(this.notcheckedoutbillchkbox_CheckedChanged);
            // 
            // billcheckedoutchkbox
            // 
            this.billcheckedoutchkbox.Checked = true;
            this.billcheckedoutchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.billcheckedoutchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.billcheckedoutchkbox.Location = new System.Drawing.Point(3, 19);
            this.billcheckedoutchkbox.Name = "billcheckedoutchkbox";
            this.billcheckedoutchkbox.Size = new System.Drawing.Size(184, 30);
            this.billcheckedoutchkbox.TabIndex = 40;
            this.billcheckedoutchkbox.Text = "فاتورة مرحلة";
            this.billcheckedoutchkbox.UseVisualStyleBackColor = true;
            this.billcheckedoutchkbox.CheckedChanged += new System.EventHandler(this.billcheckedoutchkbox_CheckedChanged);
            // 
            // billtypegb
            // 
            this.billtypegb.Controls.Add(this.purchasebillchkbox);
            this.billtypegb.Controls.Add(this.sellbillchkbox);
            this.billtypegb.Dock = System.Windows.Forms.DockStyle.Top;
            this.billtypegb.Location = new System.Drawing.Point(0, 101);
            this.billtypegb.Name = "billtypegb";
            this.billtypegb.Size = new System.Drawing.Size(190, 82);
            this.billtypegb.TabIndex = 4;
            this.billtypegb.TabStop = false;
            this.billtypegb.Text = "نوع الفاتورة";
            // 
            // purchasebillchkbox
            // 
            this.purchasebillchkbox.Checked = true;
            this.purchasebillchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.purchasebillchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.purchasebillchkbox.Location = new System.Drawing.Point(3, 49);
            this.purchasebillchkbox.Name = "purchasebillchkbox";
            this.purchasebillchkbox.Size = new System.Drawing.Size(184, 30);
            this.purchasebillchkbox.TabIndex = 34;
            this.purchasebillchkbox.Text = "فاتورة شراء";
            this.purchasebillchkbox.UseVisualStyleBackColor = true;
            this.purchasebillchkbox.CheckedChanged += new System.EventHandler(this.purchasebillchkbox_CheckedChanged);
            // 
            // sellbillchkbox
            // 
            this.sellbillchkbox.Checked = true;
            this.sellbillchkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sellbillchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.sellbillchkbox.Location = new System.Drawing.Point(3, 19);
            this.sellbillchkbox.Name = "sellbillchkbox";
            this.sellbillchkbox.Size = new System.Drawing.Size(184, 30);
            this.sellbillchkbox.TabIndex = 35;
            this.sellbillchkbox.Text = "فاتورة بيع";
            this.sellbillchkbox.UseVisualStyleBackColor = true;
            this.sellbillchkbox.CheckedChanged += new System.EventHandler(this.sellbillchkbox_CheckedChanged);
            // 
            // dategb
            // 
            this.dategb.Controls.Add(this.ToDateTimePicker);
            this.dategb.Controls.Add(this.label2);
            this.dategb.Controls.Add(this.FromDateTimePicker);
            this.dategb.Controls.Add(this.label1);
            this.dategb.Dock = System.Windows.Forms.DockStyle.Top;
            this.dategb.Location = new System.Drawing.Point(0, 0);
            this.dategb.Name = "dategb";
            this.dategb.Size = new System.Drawing.Size(190, 101);
            this.dategb.TabIndex = 54;
            this.dategb.TabStop = false;
            this.dategb.Text = "التاريخ";
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTimePicker.Location = new System.Drawing.Point(3, 72);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToDateTimePicker.RightToLeftLayout = true;
            this.ToDateTimePicker.Size = new System.Drawing.Size(184, 23);
            this.ToDateTimePicker.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "إلى تاريخ:";
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTimePicker.Location = new System.Drawing.Point(3, 34);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromDateTimePicker.RightToLeftLayout = true;
            this.FromDateTimePicker.ShowCheckBox = true;
            this.FromDateTimePicker.Size = new System.Drawing.Size(184, 23);
            this.FromDateTimePicker.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "من تاريخ:";
            // 
            // searchbtn
            // 
            this.searchbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbtn.Image = global::Alver.Properties.Resources.getdata;
            this.searchbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbtn.Location = new System.Drawing.Point(14, 636);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(164, 30);
            this.searchbtn.TabIndex = 27;
            this.searchbtn.Text = "جلب";
            this.searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(981, 678);
            this.splitContainer2.SplitterDistance = 439;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 439);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(973, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "الفواتير";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.MintCream;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.billsdgv);
            this.splitContainer3.Panel1.Controls.Add(this.dgvTotals);
            this.splitContainer3.Panel1.Controls.Add(this.billsBN);
            this.splitContainer3.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer3.Size = new System.Drawing.Size(967, 395);
            this.splitContainer3.SplitterDistance = 784;
            this.splitContainer3.TabIndex = 5;
            // 
            // billsdgv
            // 
            this.billsdgv.AllowUserToAddRows = false;
            this.billsdgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.billsdgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.billsdgv.AutoGenerateColumns = false;
            this.billsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.billsdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.billsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.checkedOutDataGridViewTextBoxColumn,
            this.billTypeDataGridViewTextBoxColumn,
            this.accountIdDataGridViewTextBoxColumn,
            this.billDateDataGridViewTextBoxColumn,
            this.cashoutDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.billAmountDataGridViewTextBoxColumn,
            this.discountAmountDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.exchangedDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.foreginCurrencyIdDataGridViewTextBoxColumn,
            this.exchangedAmountDataGridViewTextBoxColumn,
            this.declarationDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.billsdgv.DataSource = this.BillsBS;
            this.billsdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsdgv.GridColor = System.Drawing.SystemColors.Control;
            this.billsdgv.Location = new System.Drawing.Point(0, 25);
            this.billsdgv.Name = "billsdgv";
            this.billsdgv.ReadOnly = true;
            this.billsdgv.RowHeadersVisible = false;
            this.billsdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billsdgv.ShowEditingIcon = false;
            this.billsdgv.ShowRowErrors = false;
            this.billsdgv.Size = new System.Drawing.Size(784, 325);
            this.billsdgv.TabIndex = 3;
            this.billsdgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.billsdgv_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "الرقم";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 56;
            // 
            // checkedOutDataGridViewTextBoxColumn
            // 
            this.checkedOutDataGridViewTextBoxColumn.DataPropertyName = "CheckedOut";
            this.checkedOutDataGridViewTextBoxColumn.HeaderText = "مرحلة؟";
            this.checkedOutDataGridViewTextBoxColumn.Name = "checkedOutDataGridViewTextBoxColumn";
            this.checkedOutDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkedOutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkedOutDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkedOutDataGridViewTextBoxColumn.Width = 67;
            // 
            // billTypeDataGridViewTextBoxColumn
            // 
            this.billTypeDataGridViewTextBoxColumn.DataPropertyName = "BillType";
            this.billTypeDataGridViewTextBoxColumn.HeaderText = "نوع الفاتورة";
            this.billTypeDataGridViewTextBoxColumn.Name = "billTypeDataGridViewTextBoxColumn";
            this.billTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billTypeDataGridViewTextBoxColumn.Width = 88;
            // 
            // accountIdDataGridViewTextBoxColumn
            // 
            this.accountIdDataGridViewTextBoxColumn.DataPropertyName = "AccountId";
            this.accountIdDataGridViewTextBoxColumn.DataSource = this.accountBindingSource;
            this.accountIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.accountIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.accountIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.accountIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountIdDataGridViewTextBoxColumn.HeaderText = "المورد/الزبون";
            this.accountIdDataGridViewTextBoxColumn.Name = "accountIdDataGridViewTextBoxColumn";
            this.accountIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accountIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accountIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.accountIdDataGridViewTextBoxColumn.Width = 97;
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(Alver.DAL.Account);
            // 
            // billDateDataGridViewTextBoxColumn
            // 
            this.billDateDataGridViewTextBoxColumn.DataPropertyName = "BillDate";
            this.billDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.billDateDataGridViewTextBoxColumn.Name = "billDateDataGridViewTextBoxColumn";
            this.billDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.billDateDataGridViewTextBoxColumn.Width = 63;
            // 
            // cashoutDataGridViewTextBoxColumn
            // 
            this.cashoutDataGridViewTextBoxColumn.DataPropertyName = "Cashout";
            this.cashoutDataGridViewTextBoxColumn.HeaderText = "نقدي/آجل";
            this.cashoutDataGridViewTextBoxColumn.Name = "cashoutDataGridViewTextBoxColumn";
            this.cashoutDataGridViewTextBoxColumn.ReadOnly = true;
            this.cashoutDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cashoutDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cashoutDataGridViewTextBoxColumn.Width = 80;
            // 
            // currencyIdDataGridViewTextBoxColumn
            // 
            this.currencyIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn.DataSource = this.billbasecurrencyBS;
            this.currencyIdDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.currencyIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdDataGridViewTextBoxColumn.HeaderText = "العملة الاساس";
            this.currencyIdDataGridViewTextBoxColumn.Name = "currencyIdDataGridViewTextBoxColumn";
            this.currencyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.currencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.currencyIdDataGridViewTextBoxColumn.Width = 103;
            // 
            // billbasecurrencyBS
            // 
            this.billbasecurrencyBS.DataSource = typeof(Alver.DAL.Currency);
            // 
            // billAmountDataGridViewTextBoxColumn
            // 
            this.billAmountDataGridViewTextBoxColumn.DataPropertyName = "BillAmount";
            this.billAmountDataGridViewTextBoxColumn.HeaderText = "قيمة الفاتورة";
            this.billAmountDataGridViewTextBoxColumn.Name = "billAmountDataGridViewTextBoxColumn";
            this.billAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.billAmountDataGridViewTextBoxColumn.Width = 94;
            // 
            // discountAmountDataGridViewTextBoxColumn
            // 
            this.discountAmountDataGridViewTextBoxColumn.DataPropertyName = "DiscountAmount";
            this.discountAmountDataGridViewTextBoxColumn.HeaderText = "الحسم";
            this.discountAmountDataGridViewTextBoxColumn.Name = "discountAmountDataGridViewTextBoxColumn";
            this.discountAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.discountAmountDataGridViewTextBoxColumn.Width = 63;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "القيمة الاجمالية";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalAmountDataGridViewTextBoxColumn.Width = 106;
            // 
            // exchangedDataGridViewTextBoxColumn
            // 
            this.exchangedDataGridViewTextBoxColumn.DataPropertyName = "Exchanged";
            this.exchangedDataGridViewTextBoxColumn.HeaderText = "تم تصريفها؟";
            this.exchangedDataGridViewTextBoxColumn.Name = "exchangedDataGridViewTextBoxColumn";
            this.exchangedDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangedDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exchangedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exchangedDataGridViewTextBoxColumn.Width = 92;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "سعر الصرف";
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Width = 91;
            // 
            // foreginCurrencyIdDataGridViewTextBoxColumn
            // 
            this.foreginCurrencyIdDataGridViewTextBoxColumn.DataPropertyName = "ForeginCurrencyId";
            this.foreginCurrencyIdDataGridViewTextBoxColumn.DataSource = this.billforeigncurrencyBS;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.DisplayMember = "CurrencyName";
            this.foreginCurrencyIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.HeaderText = "العملة الطرف";
            this.foreginCurrencyIdDataGridViewTextBoxColumn.Name = "foreginCurrencyIdDataGridViewTextBoxColumn";
            this.foreginCurrencyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.foreginCurrencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.foreginCurrencyIdDataGridViewTextBoxColumn.Width = 99;
            // 
            // billforeigncurrencyBS
            // 
            this.billforeigncurrencyBS.DataSource = typeof(Alver.DAL.Currency);
            // 
            // exchangedAmountDataGridViewTextBoxColumn
            // 
            this.exchangedAmountDataGridViewTextBoxColumn.DataPropertyName = "ExchangedAmount";
            this.exchangedAmountDataGridViewTextBoxColumn.HeaderText = "مقدار التصريف";
            this.exchangedAmountDataGridViewTextBoxColumn.Name = "exchangedAmountDataGridViewTextBoxColumn";
            this.exchangedAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangedAmountDataGridViewTextBoxColumn.Width = 106;
            // 
            // declarationDataGridViewTextBoxColumn
            // 
            this.declarationDataGridViewTextBoxColumn.DataPropertyName = "Declaration";
            this.declarationDataGridViewTextBoxColumn.HeaderText = "البيان";
            this.declarationDataGridViewTextBoxColumn.Name = "declarationDataGridViewTextBoxColumn";
            this.declarationDataGridViewTextBoxColumn.ReadOnly = true;
            this.declarationDataGridViewTextBoxColumn.Width = 58;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.DataSource = this.billuserBS;
            this.userIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.userIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.userIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.userIdDataGridViewTextBoxColumn.Width = 80;
            // 
            // billuserBS
            // 
            this.billuserBS.DataSource = typeof(Alver.DAL.User);
            // 
            // BillsBS
            // 
            this.BillsBS.DataSource = typeof(Alver.DAL.Bill);
            // 
            // dgvTotals
            // 
            this.dgvTotals.AllowUserToAddRows = false;
            this.dgvTotals.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTotals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTotals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTotals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTotals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Format = "N5";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTotals.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTotals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTotals.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTotals.Location = new System.Drawing.Point(0, 350);
            this.dgvTotals.MultiSelect = false;
            this.dgvTotals.Name = "dgvTotals";
            this.dgvTotals.ReadOnly = true;
            this.dgvTotals.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTotals.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTotals.RowTemplate.DefaultCellStyle.Format = "#,0.###";
            this.dgvTotals.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dgvTotals.RowTemplate.ReadOnly = true;
            this.dgvTotals.Size = new System.Drawing.Size(784, 45);
            this.dgvTotals.TabIndex = 4;
            this.dgvTotals.Visible = false;
            // 
            // billsBN
            // 
            this.billsBN.AddNewItem = null;
            this.billsBN.BindingSource = this.BillsBS;
            this.billsBN.CountItem = this.bindingNavigatorCountItem;
            this.billsBN.DeleteItem = null;
            this.billsBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.BillFuncs});
            this.billsBN.Location = new System.Drawing.Point(0, 0);
            this.billsBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.billsBN.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.billsBN.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.billsBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.billsBN.Name = "billsBN";
            this.billsBN.PositionItem = this.bindingNavigatorPositionItem;
            this.billsBN.Size = new System.Drawing.Size(784, 25);
            this.billsBN.TabIndex = 5;
            this.billsBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BillFuncs
            // 
            this.BillFuncs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbillbtn,
            this.editbillbtn,
            this.deletebillbtn,
            this.printbillslipbtn,
            this.printbillbtn});
            this.BillFuncs.Image = global::Alver.Properties.Resources.itemsettings;
            this.BillFuncs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BillFuncs.Name = "BillFuncs";
            this.BillFuncs.Size = new System.Drawing.Size(104, 22);
            this.BillFuncs.Text = "أدوات الفاتورة";
            // 
            // addbillbtn
            // 
            this.addbillbtn.Image = global::Alver.Properties.Resources.addbill;
            this.addbillbtn.Name = "addbillbtn";
            this.addbillbtn.Size = new System.Drawing.Size(174, 22);
            this.addbillbtn.Text = "إضافة فاتورة";
            // 
            // editbillbtn
            // 
            this.editbillbtn.Image = global::Alver.Properties.Resources.edit;
            this.editbillbtn.Name = "editbillbtn";
            this.editbillbtn.Size = new System.Drawing.Size(174, 22);
            this.editbillbtn.Text = "تعديل الفاتورة";
            this.editbillbtn.Click += new System.EventHandler(this.editbillbtn_Click);
            // 
            // deletebillbtn
            // 
            this.deletebillbtn.Image = global::Alver.Properties.Resources.deletebill;
            this.deletebillbtn.Name = "deletebillbtn";
            this.deletebillbtn.Size = new System.Drawing.Size(174, 22);
            this.deletebillbtn.Text = "حذف الفاتورة";
            this.deletebillbtn.Click += new System.EventHandler(this.deletebillbtn_Click);
            // 
            // printbillslipbtn
            // 
            this.printbillslipbtn.Image = global::Alver.Properties.Resources.print;
            this.printbillslipbtn.Name = "printbillslipbtn";
            this.printbillslipbtn.Size = new System.Drawing.Size(174, 22);
            this.printbillslipbtn.Text = "طباعة إشعار الفاتورة";
            this.printbillslipbtn.Click += new System.EventHandler(this.printbillslipbtn_Click);
            // 
            // printbillbtn
            // 
            this.printbillbtn.Image = global::Alver.Properties.Resources.print;
            this.printbillbtn.Name = "printbillbtn";
            this.printbillbtn.Size = new System.Drawing.Size(174, 22);
            this.printbillbtn.Text = "طباعة الفاتورة";
            this.printbillbtn.Click += new System.EventHandler(this.printbillbtn_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.RightToLeftLayout = true;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(981, 229);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.billlinesdgv);
            this.tabPage2.Controls.Add(this.billLinesBN);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(973, 201);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "اقلام الفاتورة";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // billlinesdgv
            // 
            this.billlinesdgv.AllowUserToAddRows = false;
            this.billlinesdgv.AllowUserToDeleteRows = false;
            this.billlinesdgv.AllowUserToOrderColumns = true;
            this.billlinesdgv.AutoGenerateColumns = false;
            this.billlinesdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.billlinesdgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.billlinesdgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.billlinesdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.billIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.unitIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.exchangedDataGridViewTextBoxColumn1,
            this.rateDataGridViewTextBoxColumn1,
            this.foreginCurrencyIdDataGridViewTextBoxColumn1,
            this.exchangedAmountDataGridViewTextBoxColumn1,
            this.exchangedTotalAmountDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn1});
            this.billlinesdgv.DataSource = this.BillLinesBS;
            this.billlinesdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billlinesdgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.billlinesdgv.GridColor = System.Drawing.SystemColors.Control;
            this.billlinesdgv.Location = new System.Drawing.Point(3, 28);
            this.billlinesdgv.Name = "billlinesdgv";
            this.billlinesdgv.ReadOnly = true;
            this.billlinesdgv.RowHeadersVisible = false;
            this.billlinesdgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.billlinesdgv.Size = new System.Drawing.Size(967, 170);
            this.billlinesdgv.TabIndex = 3;
            this.billlinesdgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.billsdgv_DataError);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 42;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.billIdDataGridViewTextBoxColumn.Visible = false;
            this.billIdDataGridViewTextBoxColumn.Width = 58;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.DataSource = this.billlineitemBS;
            this.itemIdDataGridViewTextBoxColumn.DisplayMember = "ItemName";
            this.itemIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.itemIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.itemIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "المادة";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            this.itemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.itemIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.itemIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // billlineitemBS
            // 
            this.billlineitemBS.DataSource = typeof(Alver.DAL.Item);
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.DataSource = this.billlineunitBS;
            this.unitIdDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.unitIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.unitIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.unitIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "الواحدة";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            this.unitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unitIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unitIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.unitIdDataGridViewTextBoxColumn.Width = 67;
            // 
            // billlineunitBS
            // 
            this.billlineunitBS.DataSource = typeof(Alver.DAL.Unit);
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 62;
            // 
            // currencyIdDataGridViewTextBoxColumn1
            // 
            this.currencyIdDataGridViewTextBoxColumn1.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn1.DataSource = this.billlinebasecurrencyBS;
            this.currencyIdDataGridViewTextBoxColumn1.DisplayMember = "CurrencyName";
            this.currencyIdDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.currencyIdDataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.currencyIdDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyIdDataGridViewTextBoxColumn1.HeaderText = "العملة الاساس";
            this.currencyIdDataGridViewTextBoxColumn1.Name = "currencyIdDataGridViewTextBoxColumn1";
            this.currencyIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.currencyIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.currencyIdDataGridViewTextBoxColumn1.Width = 103;
            // 
            // billlinebasecurrencyBS
            // 
            this.billlinebasecurrencyBS.DataSource = typeof(Alver.DAL.Currency);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "السعر";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 61;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "الاجمالي";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalPriceDataGridViewTextBoxColumn.Width = 73;
            // 
            // exchangedDataGridViewTextBoxColumn1
            // 
            this.exchangedDataGridViewTextBoxColumn1.DataPropertyName = "Exchanged";
            this.exchangedDataGridViewTextBoxColumn1.HeaderText = "تم التصريف";
            this.exchangedDataGridViewTextBoxColumn1.Name = "exchangedDataGridViewTextBoxColumn1";
            this.exchangedDataGridViewTextBoxColumn1.ReadOnly = true;
            this.exchangedDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.exchangedDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.exchangedDataGridViewTextBoxColumn1.Width = 90;
            // 
            // rateDataGridViewTextBoxColumn1
            // 
            this.rateDataGridViewTextBoxColumn1.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn1.HeaderText = "سعر الصرف";
            this.rateDataGridViewTextBoxColumn1.Name = "rateDataGridViewTextBoxColumn1";
            this.rateDataGridViewTextBoxColumn1.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn1.Width = 91;
            // 
            // foreginCurrencyIdDataGridViewTextBoxColumn1
            // 
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.DataPropertyName = "ForeginCurrencyId";
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.DataSource = this.billlineforeigncurrencyBS;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.DisplayMember = "CurrencyName";
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.HeaderText = "العملة الطرف";
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.Name = "foreginCurrencyIdDataGridViewTextBoxColumn1";
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.foreginCurrencyIdDataGridViewTextBoxColumn1.Width = 99;
            // 
            // billlineforeigncurrencyBS
            // 
            this.billlineforeigncurrencyBS.DataSource = typeof(Alver.DAL.Currency);
            // 
            // exchangedAmountDataGridViewTextBoxColumn1
            // 
            this.exchangedAmountDataGridViewTextBoxColumn1.DataPropertyName = "ExchangedAmount";
            this.exchangedAmountDataGridViewTextBoxColumn1.HeaderText = "سعر الواحدة - ل.س";
            this.exchangedAmountDataGridViewTextBoxColumn1.Name = "exchangedAmountDataGridViewTextBoxColumn1";
            this.exchangedAmountDataGridViewTextBoxColumn1.ReadOnly = true;
            this.exchangedAmountDataGridViewTextBoxColumn1.Width = 128;
            // 
            // exchangedTotalAmountDataGridViewTextBoxColumn
            // 
            this.exchangedTotalAmountDataGridViewTextBoxColumn.DataPropertyName = "ExchangedTotalAmount";
            this.exchangedTotalAmountDataGridViewTextBoxColumn.HeaderText = "الاجمالي - ل.س";
            this.exchangedTotalAmountDataGridViewTextBoxColumn.Name = "exchangedTotalAmountDataGridViewTextBoxColumn";
            this.exchangedTotalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.exchangedTotalAmountDataGridViewTextBoxColumn.Width = 109;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn1.DataSource = this.billlineuserBS;
            this.userIdDataGridViewTextBoxColumn1.DisplayMember = "FullName";
            this.userIdDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn1.DisplayStyleForCurrentCellOnly = true;
            this.userIdDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn1.HeaderText = "المستخدم";
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            this.userIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn1.ValueMember = "Id";
            this.userIdDataGridViewTextBoxColumn1.Width = 80;
            // 
            // billlineuserBS
            // 
            this.billlineuserBS.DataSource = typeof(Alver.DAL.User);
            // 
            // BillLinesBS
            // 
            this.BillLinesBS.DataMember = "BillLines";
            this.BillLinesBS.DataSource = this.BillsBS;
            // 
            // billLinesBN
            // 
            this.billLinesBN.AddNewItem = null;
            this.billLinesBN.BindingSource = this.BillLinesBS;
            this.billLinesBN.CountItem = this.bindingNavigatorCountItem1;
            this.billLinesBN.DeleteItem = null;
            this.billLinesBN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5});
            this.billLinesBN.Location = new System.Drawing.Point(3, 3);
            this.billLinesBN.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.billLinesBN.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.billLinesBN.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.billLinesBN.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.billLinesBN.Name = "billLinesBN";
            this.billLinesBN.PositionItem = this.bindingNavigatorPositionItem1;
            this.billLinesBN.Size = new System.Drawing.Size(967, 25);
            this.billLinesBN.TabIndex = 4;
            this.billLinesBN.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // SelectColumn
            // 
            this.SelectColumn.Frozen = true;
            this.SelectColumn.HeaderText = "#";
            this.SelectColumn.Name = "SelectColumn";
            this.SelectColumn.Width = 24;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.Frozen = true;
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Width = 73;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "رقم الإشعار";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            this.IdColumn.Width = 109;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OperationDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "التاريخ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 77;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "نوع الحوالة";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direction.Visible = false;
            this.Direction.Width = 107;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PayeeId";
            this.dataGridViewTextBoxColumn9.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn9.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn9.HeaderText = "المستفيد";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrencyId";
            this.dataGridViewTextBoxColumn4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn4.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn4.HeaderText = "العملة";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn5.HeaderText = "المبلغ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SenderId";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn6.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn6.HeaderText = "المرسل";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.Width = 84;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ClientId";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn7.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn7.HeaderText = "المستقبل";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.Width = 97;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Locked";
            this.dataGridViewTextBoxColumn12.HeaderText = "مقفولة";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 84;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Suspended";
            this.dataGridViewTextBoxColumn13.HeaderText = "معلقة";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn13.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 77;
            // 
            // Payed
            // 
            this.Payed.DataPropertyName = "Payed";
            this.Payed.HeaderText = "مدفوعة";
            this.Payed.Name = "Payed";
            this.Payed.ReadOnly = true;
            this.Payed.Width = 65;
            // 
            // PayDate
            // 
            this.PayDate.DataPropertyName = "PayDate";
            this.PayDate.HeaderText = "تاريخ الدفع";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            this.PayDate.Width = 106;
            // 
            // Ignored
            // 
            this.Ignored.DataPropertyName = "Ignored";
            this.Ignored.HeaderText = "ملغاة";
            this.Ignored.Name = "Ignored";
            this.Ignored.ReadOnly = true;
            this.Ignored.Visible = false;
            this.Ignored.Width = 50;
            // 
            // IgnoreDate
            // 
            this.IgnoreDate.DataPropertyName = "IgnoreDate";
            this.IgnoreDate.HeaderText = "تاريخ الإلغاء";
            this.IgnoreDate.Name = "IgnoreDate";
            this.IgnoreDate.ReadOnly = true;
            this.IgnoreDate.Width = 109;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "LUD";
            this.dataGridViewTextBoxColumn14.HeaderText = "LUD";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn14.Width = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Declaration";
            this.dataGridViewTextBoxColumn10.HeaderText = "البيان";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 71;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.UserId.DefaultCellStyle = dataGridViewCellStyle10;
            this.UserId.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UserId.DisplayStyleForCurrentCellOnly = true;
            this.UserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserId.HeaderText = "المستخدم";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Width = 77;
            // 
            // Accountgb
            // 
            this.Accountgb.Controls.Add(this.accountcb);
            this.Accountgb.Controls.Add(this.accountchkbox);
            this.Accountgb.Dock = System.Windows.Forms.DockStyle.Top;
            this.Accountgb.Location = new System.Drawing.Point(0, 407);
            this.Accountgb.Name = "Accountgb";
            this.Accountgb.Size = new System.Drawing.Size(190, 69);
            this.Accountgb.TabIndex = 57;
            this.Accountgb.TabStop = false;
            this.Accountgb.Text = "المورد/الزبون";
            // 
            // accountcb
            // 
            this.accountcb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.accountcb.DataSource = this.accountBindingSource1;
            this.accountcb.DisplayMember = "FullName";
            this.accountcb.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountcb.Enabled = false;
            this.accountcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountcb.FormattingEnabled = true;
            this.accountcb.Location = new System.Drawing.Point(3, 39);
            this.accountcb.Name = "accountcb";
            this.accountcb.Size = new System.Drawing.Size(184, 23);
            this.accountcb.TabIndex = 31;
            this.accountcb.ValueMember = "Id";
            // 
            // accountchkbox
            // 
            this.accountchkbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountchkbox.Location = new System.Drawing.Point(3, 19);
            this.accountchkbox.Name = "accountchkbox";
            this.accountchkbox.Size = new System.Drawing.Size(184, 20);
            this.accountchkbox.TabIndex = 38;
            this.accountchkbox.Text = "فواتير المورد/الزبون";
            this.accountchkbox.UseVisualStyleBackColor = true;
            this.accountchkbox.CheckedChanged += new System.EventHandler(this.accountchkbox_CheckedChanged);
            // 
            // accountBindingSource1
            // 
            this.accountBindingSource1.DataSource = typeof(Alver.DAL.Account);
            // 
            // frmBillMangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 678);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillMangement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الفواتير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIncomes_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.itemgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemIdBS)).EndInit();
            this.billIdgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billIdBS)).EndInit();
            this.billcheckedouttypegb.ResumeLayout(false);
            this.billtypegb.ResumeLayout(false);
            this.dategb.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.billsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billbasecurrencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billforeigncurrencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billuserBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillsBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsBN)).EndInit();
            this.billsBN.ResumeLayout(false);
            this.billsBN.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billlinesdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineitemBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineunitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlinebasecurrencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineforeigncurrencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billlineuserBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillLinesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesBN)).EndInit();
            this.billLinesBN.ResumeLayout(false);
            this.billLinesBN.PerformLayout();
            this.Accountgb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView billsdgv;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView billlinesdgv;
        private System.Windows.Forms.ComboBox billidcb;
        private System.Windows.Forms.CheckBox purchasebillchkbox;
        private System.Windows.Forms.CheckBox sellbillchkbox;
        private System.Windows.Forms.CheckBox billidchkbox;
        private System.Windows.Forms.GroupBox billtypegb;
        private System.Windows.Forms.GroupBox billcheckedouttypegb;
        private System.Windows.Forms.CheckBox nonetcheckedoutbillchkbox;
        private System.Windows.Forms.CheckBox billcheckedoutchkbox;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView dgvTotals;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Ignored;
        private System.Windows.Forms.DataGridViewTextBoxColumn IgnoreDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn UserId;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn payeeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn senderIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn foreignCurrencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lockedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn suspendedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ignoredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ignoreDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn payedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn receiptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox dategb;
        private System.Windows.Forms.GroupBox itemgb;
        private System.Windows.Forms.ComboBox itemcb;
        private System.Windows.Forms.CheckBox itemchkbox;
        private System.Windows.Forms.GroupBox billIdgb;
        private System.Windows.Forms.BindingSource itemIdBS;
        private System.Windows.Forms.BindingSource billIdBS;
        private System.Windows.Forms.BindingNavigator billsBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator billLinesBN;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource BillsBS;
        private System.Windows.Forms.BindingSource BillLinesBS;
        private System.Windows.Forms.BindingSource billbasecurrencyBS;
        private System.Windows.Forms.BindingSource billforeigncurrencyBS;
        private System.Windows.Forms.BindingSource billuserBS;
        private System.Windows.Forms.BindingSource billlineitemBS;
        private System.Windows.Forms.BindingSource billlineunitBS;
        private System.Windows.Forms.BindingSource billlinebasecurrencyBS;
        private System.Windows.Forms.BindingSource billlineforeigncurrencyBS;
        private System.Windows.Forms.BindingSource billlineuserBS;
        private System.Windows.Forms.ToolStripDropDownButton BillFuncs;
        private System.Windows.Forms.ToolStripMenuItem deletebillbtn;
        private System.Windows.Forms.ToolStripMenuItem printbillslipbtn;
        private System.Windows.Forms.ToolStripMenuItem printbillbtn;
        private System.Windows.Forms.ToolStripMenuItem editbillbtn;
        private System.Windows.Forms.ToolStripMenuItem addbillbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn unitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exchangedDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn foreginCurrencyIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangedAmountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangedTotalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn accountIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cashoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn exchangedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn foreginCurrencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangedAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declarationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Accountgb;
        private System.Windows.Forms.ComboBox accountcb;
        private System.Windows.Forms.CheckBox accountchkbox;
        private System.Windows.Forms.BindingSource accountBindingSource1;
    }
}
