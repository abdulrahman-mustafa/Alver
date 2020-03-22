namespace Alver.UI.Bills
{
    partial class pos
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
            System.Windows.Forms.Label exchangeDateLabel;
            System.Windows.Forms.Label declarationLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label label11;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pos));
            this.billLinesDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.billtypecb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.billdatedtp = new System.Windows.Forms.DateTimePicker();
            this.declarationtb = new System.Windows.Forms.TextBox();
            this.currencycb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyBS = new System.Windows.Forms.BindingSource(this.components);
            this.billLineBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.barcodecb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemcb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearbilllinesbtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sumtotalsnud = new System.Windows.Forms.NumericUpDown();
            this.totalnud = new System.Windows.Forms.NumericUpDown();
            this.discountnud = new System.Windows.Forms.NumericUpDown();
            this.remainedquantitylbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ratenud = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            exchangeDateLabel = new System.Windows.Forms.Label();
            declarationLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billLinesDgv)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLineBS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumtotalsnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).BeginInit();
            this.SuspendLayout();
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
            this.idDataGridViewTextBoxColumn,
            this.billIdDataGridViewTextBoxColumn,
            this.itemIdDataGridViewTextBoxColumn,
            this.unitIdDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.billLinesDgv.DataSource = this.billLineBS;
            this.billLinesDgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.billLinesDgv.Location = new System.Drawing.Point(219, 118);
            this.billLinesDgv.MultiSelect = false;
            this.billLinesDgv.Name = "billLinesDgv";
            this.billLinesDgv.RowTemplate.Height = 30;
            this.billLinesDgv.Size = new System.Drawing.Size(702, 177);
            this.billLinesDgv.TabIndex = 9;
            this.billLinesDgv.VirtualMode = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(label11);
            this.panel1.Controls.Add(this.ratenud);
            this.panel1.Controls.Add(this.currencycb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.billdatedtp);
            this.panel1.Controls.Add(exchangeDateLabel);
            this.panel1.Controls.Add(declarationLabel);
            this.panel1.Controls.Add(this.declarationtb);
            this.panel1.Controls.Add(this.billtypecb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 63);
            this.panel1.TabIndex = 10;
            // 
            // billtypecb
            // 
            this.billtypecb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billtypecb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.billtypecb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.billtypecb.BackColor = System.Drawing.Color.LightCyan;
            this.billtypecb.DisplayMember = "CurrencyName";
            this.billtypecb.Enabled = false;
            this.billtypecb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.billtypecb.FormattingEnabled = true;
            this.billtypecb.Items.AddRange(new object[] {
            "بيع",
            "مرتجع"});
            this.billtypecb.Location = new System.Drawing.Point(729, 3);
            this.billtypecb.Name = "billtypecb";
            this.billtypecb.Size = new System.Drawing.Size(115, 23);
            this.billtypecb.TabIndex = 52;
            this.billtypecb.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "نوع الفاتورة";
            // 
            // billdatedtp
            // 
            this.billdatedtp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billdatedtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.billdatedtp.Location = new System.Drawing.Point(554, 3);
            this.billdatedtp.Name = "billdatedtp";
            this.billdatedtp.RightToLeftLayout = true;
            this.billdatedtp.Size = new System.Drawing.Size(92, 23);
            this.billdatedtp.TabIndex = 56;
            // 
            // exchangeDateLabel
            // 
            exchangeDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            exchangeDateLabel.AutoSize = true;
            exchangeDateLabel.Location = new System.Drawing.Point(652, 6);
            exchangeDateLabel.Name = "exchangeDateLabel";
            exchangeDateLabel.Size = new System.Drawing.Size(41, 15);
            exchangeDateLabel.TabIndex = 54;
            exchangeDateLabel.Text = "التاريخ:";
            // 
            // declarationLabel
            // 
            declarationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            declarationLabel.AutoSize = true;
            declarationLabel.Location = new System.Drawing.Point(483, 6);
            declarationLabel.Name = "declarationLabel";
            declarationLabel.Size = new System.Drawing.Size(36, 15);
            declarationLabel.TabIndex = 53;
            declarationLabel.Text = "البيان:";
            // 
            // declarationtb
            // 
            this.declarationtb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationtb.Location = new System.Drawing.Point(3, 3);
            this.declarationtb.Name = "declarationtb";
            this.declarationtb.Size = new System.Drawing.Size(474, 23);
            this.declarationtb.TabIndex = 55;
            // 
            // currencycb
            // 
            this.currencycb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencycb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.currencycb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.currencycb.BackColor = System.Drawing.Color.LightCyan;
            this.currencycb.DataSource = this.currencyBS;
            this.currencycb.DisplayMember = "CurrencyName";
            this.currencycb.Enabled = false;
            this.currencycb.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currencycb.FormattingEnabled = true;
            this.currencycb.Location = new System.Drawing.Point(729, 32);
            this.currencycb.Name = "currencycb";
            this.currencycb.Size = new System.Drawing.Size(115, 23);
            this.currencycb.TabIndex = 58;
            this.currencycb.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(850, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "العملة:";
            // 
            // currencyBS
            // 
            this.currencyBS.DataSource = typeof(Alver.DAL.Currency);
            // 
            // billLineBS
            // 
            this.billLineBS.DataSource = typeof(Alver.DAL.BillLine);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.remainedquantitylbl);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.barcodecb);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.itemcb);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 31);
            this.panel2.TabIndex = 11;
            // 
            // barcodecb
            // 
            this.barcodecb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodecb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.barcodecb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.barcodecb.BackColor = System.Drawing.Color.LightCyan;
            this.barcodecb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.barcodecb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barcodecb.FormattingEnabled = true;
            this.barcodecb.Location = new System.Drawing.Point(697, 4);
            this.barcodecb.Name = "barcodecb";
            this.barcodecb.Size = new System.Drawing.Size(150, 23);
            this.barcodecb.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(853, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 55;
            this.label10.Text = "الباركود:";
            // 
            // itemcb
            // 
            this.itemcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.itemcb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.itemcb.BackColor = System.Drawing.Color.LightCyan;
            this.itemcb.DisplayMember = "ItemName";
            this.itemcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemcb.FormattingEnabled = true;
            this.itemcb.Location = new System.Drawing.Point(496, 4);
            this.itemcb.Name = "itemcb";
            this.itemcb.Size = new System.Drawing.Size(150, 23);
            this.itemcb.TabIndex = 54;
            this.itemcb.ValueMember = "Id";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 53;
            this.label5.Text = "المادة:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.clearbilllinesbtn);
            this.panel3.Location = new System.Drawing.Point(13, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 176);
            this.panel3.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "BillId";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemIdDataGridViewTextBoxColumn
            // 
            this.itemIdDataGridViewTextBoxColumn.DataPropertyName = "ItemId";
            this.itemIdDataGridViewTextBoxColumn.HeaderText = "المادة";
            this.itemIdDataGridViewTextBoxColumn.Name = "itemIdDataGridViewTextBoxColumn";
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "الواحدة";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "الكمية";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // currencyIdDataGridViewTextBoxColumn
            // 
            this.currencyIdDataGridViewTextBoxColumn.DataPropertyName = "CurrencyId";
            this.currencyIdDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyIdDataGridViewTextBoxColumn.Name = "currencyIdDataGridViewTextBoxColumn";
            this.currencyIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "السعر الافرادي";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "الاجمالي";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // clearbilllinesbtn
            // 
            this.clearbilllinesbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearbilllinesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbilllinesbtn.Image = global::Alver.Properties.Resources.trash;
            this.clearbilllinesbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearbilllinesbtn.Location = new System.Drawing.Point(3, 3);
            this.clearbilllinesbtn.Name = "clearbilllinesbtn";
            this.clearbilllinesbtn.Size = new System.Drawing.Size(192, 30);
            this.clearbilllinesbtn.TabIndex = 49;
            this.clearbilllinesbtn.Text = "تفريغ الفاتورة";
            this.clearbilllinesbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbilllinesbtn.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sumtotalsnud);
            this.panel4.Controls.Add(label4);
            this.panel4.Controls.Add(this.totalnud);
            this.panel4.Controls.Add(label9);
            this.panel4.Controls.Add(this.discountnud);
            this.panel4.Controls.Add(amountLabel);
            this.panel4.Location = new System.Drawing.Point(219, 302);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 33);
            this.panel4.TabIndex = 13;
            // 
            // sumtotalsnud
            // 
            this.sumtotalsnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sumtotalsnud.DecimalPlaces = 2;
            this.sumtotalsnud.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.sumtotalsnud.Location = new System.Drawing.Point(422, 4);
            this.sumtotalsnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.sumtotalsnud.Name = "sumtotalsnud";
            this.sumtotalsnud.ReadOnly = true;
            this.sumtotalsnud.Size = new System.Drawing.Size(120, 25);
            this.sumtotalsnud.TabIndex = 49;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(133, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(95, 15);
            label4.TabIndex = 48;
            label4.Text = "الإجمالي الصافي :";
            // 
            // totalnud
            // 
            this.totalnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalnud.DecimalPlaces = 2;
            this.totalnud.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.totalnud.Location = new System.Drawing.Point(3, 4);
            this.totalnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.totalnud.Name = "totalnud";
            this.totalnud.ReadOnly = true;
            this.totalnud.Size = new System.Drawing.Size(120, 25);
            this.totalnud.TabIndex = 45;
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(552, 9);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(54, 15);
            label9.TabIndex = 47;
            label9.Text = "الإجمالي :";
            // 
            // discountnud
            // 
            this.discountnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.discountnud.DecimalPlaces = 2;
            this.discountnud.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.discountnud.Location = new System.Drawing.Point(238, 4);
            this.discountnud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.discountnud.Name = "discountnud";
            this.discountnud.Size = new System.Drawing.Size(120, 25);
            this.discountnud.TabIndex = 46;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(368, 9);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(44, 15);
            amountLabel.TabIndex = 44;
            amountLabel.Text = "الحسم :";
            // 
            // remainedquantitylbl
            // 
            this.remainedquantitylbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remainedquantitylbl.AutoSize = true;
            this.remainedquantitylbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.remainedquantitylbl.Location = new System.Drawing.Point(330, 8);
            this.remainedquantitylbl.Name = "remainedquantitylbl";
            this.remainedquantitylbl.Size = new System.Drawing.Size(14, 15);
            this.remainedquantitylbl.TabIndex = 58;
            this.remainedquantitylbl.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(399, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 15);
            this.label13.TabIndex = 57;
            this.label13.Text = "الكمية المتبقية:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(652, 35);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(69, 15);
            label11.TabIndex = 60;
            label11.Text = "سعر الصرف:";
            // 
            // ratenud
            // 
            this.ratenud.DecimalPlaces = 3;
            this.ratenud.Location = new System.Drawing.Point(554, 33);
            this.ratenud.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ratenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ratenud.Name = "ratenud";
            this.ratenud.ReadOnly = true;
            this.ratenud.Size = new System.Drawing.Size(92, 23);
            this.ratenud.TabIndex = 59;
            this.ratenud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ratenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 30);
            this.button1.TabIndex = 50;
            this.button1.Text = "ترحيل الفاتورة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 30);
            this.button2.TabIndex = 51;
            this.button2.Text = "ترحيل وطباعة الفاتورة";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 419);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.billLinesDgv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "pos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "نقطة البيع";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.billLinesDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billLineBS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumtotalsnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratenud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView billLinesDgv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox billtypecb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker billdatedtp;
        private System.Windows.Forms.TextBox declarationtb;
        private System.Windows.Forms.ComboBox currencycb;
        private System.Windows.Forms.BindingSource currencyBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource billLineBS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox barcodecb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox itemcb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button clearbilllinesbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown sumtotalsnud;
        private System.Windows.Forms.NumericUpDown totalnud;
        private System.Windows.Forms.NumericUpDown discountnud;
        private System.Windows.Forms.Label remainedquantitylbl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown ratenud;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}