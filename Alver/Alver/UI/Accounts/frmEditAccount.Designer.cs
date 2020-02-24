namespace Alver.UI.Accounts
{
    partial class frmEditAccount
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idNumberLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label senderIdLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label fatherLabel;
            System.Windows.Forms.Label cityNameLabel;
            System.Windows.Forms.Label motherLabel;
            System.Windows.Forms.Label countryNameLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAccount));
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.infogroupBox = new System.Windows.Forms.GroupBox();
            this.accountgroupcb = new System.Windows.Forms.ComboBox();
            this.accountGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notestextBox = new System.Windows.Forms.TextBox();
            this.accountcb = new System.Windows.Forms.ComboBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fatherTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.motherTextBox = new System.Windows.Forms.TextBox();
            this.cityNameComboBox = new System.Windows.Forms.ComboBox();
            this.countryNameComboBox = new System.Windows.Forms.ComboBox();
            this.accountsFundBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fundgroupBox = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.fundTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDirectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            label1 = new System.Windows.Forms.Label();
            idNumberLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            senderIdLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            fatherLabel = new System.Windows.Forms.Label();
            cityNameLabel = new System.Windows.Forms.Label();
            motherLabel = new System.Windows.Forms.Label();
            countryNameLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.infogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource)).BeginInit();
            this.fundgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(355, 229);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 44;
            label1.Text = "الملاحظات:";
            // 
            // idNumberLabel
            // 
            idNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idNumberLabel.AutoSize = true;
            idNumberLabel.Location = new System.Drawing.Point(355, 163);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new System.Drawing.Size(74, 15);
            idNumberLabel.TabIndex = 42;
            idNumberLabel.Text = "الرقم الوطني:";
            // 
            // phoneLabel
            // 
            phoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(156, 131);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(42, 15);
            phoneLabel.TabIndex = 40;
            phoneLabel.Text = "الهاتف:";
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(355, 25);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(37, 15);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الاسم:";
            // 
            // addressLabel
            // 
            addressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(355, 196);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(45, 15);
            addressLabel.TabIndex = 37;
            addressLabel.Text = "العنوان:";
            // 
            // fatherLabel
            // 
            fatherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fatherLabel.AutoSize = true;
            fatherLabel.Location = new System.Drawing.Point(355, 97);
            fatherLabel.Name = "fatherLabel";
            fatherLabel.Size = new System.Drawing.Size(31, 15);
            fatherLabel.TabIndex = 38;
            fatherLabel.Text = "الاب:";
            // 
            // cityNameLabel
            // 
            cityNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            cityNameLabel.AutoSize = true;
            cityNameLabel.Location = new System.Drawing.Point(156, 97);
            cityNameLabel.Name = "cityNameLabel";
            cityNameLabel.Size = new System.Drawing.Size(44, 15);
            cityNameLabel.TabIndex = 36;
            cityNameLabel.Text = "المدينة:";
            // 
            // motherLabel
            // 
            motherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            motherLabel.AutoSize = true;
            motherLabel.Location = new System.Drawing.Point(355, 130);
            motherLabel.Name = "motherLabel";
            motherLabel.Size = new System.Drawing.Size(27, 15);
            motherLabel.TabIndex = 39;
            motherLabel.Text = "الام:";
            // 
            // countryNameLabel
            // 
            countryNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            countryNameLabel.AutoSize = true;
            countryNameLabel.Location = new System.Drawing.Point(156, 63);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(39, 15);
            countryNameLabel.TabIndex = 35;
            countryNameLabel.Text = "الدولة:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(355, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(66, 15);
            label2.TabIndex = 46;
            label2.Text = "نوع التعامل:";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
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
            this.savebtn});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 482);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(440, 27);
            this.bindingNavigator2.TabIndex = 36;
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Alver.Properties.Resources.saveuser;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(54, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // infogroupBox
            // 
            this.infogroupBox.Controls.Add(label2);
            this.infogroupBox.Controls.Add(this.accountgroupcb);
            this.infogroupBox.Controls.Add(label1);
            this.infogroupBox.Controls.Add(this.notestextBox);
            this.infogroupBox.Controls.Add(this.accountcb);
            this.infogroupBox.Controls.Add(this.isActiveCheckBox);
            this.infogroupBox.Controls.Add(idNumberLabel);
            this.infogroupBox.Controls.Add(phoneLabel);
            this.infogroupBox.Controls.Add(senderIdLabel);
            this.infogroupBox.Controls.Add(this.phoneMaskedTextBox);
            this.infogroupBox.Controls.Add(this.idNumberMaskedTextBox);
            this.infogroupBox.Controls.Add(addressLabel);
            this.infogroupBox.Controls.Add(this.fatherTextBox);
            this.infogroupBox.Controls.Add(this.addressTextBox);
            this.infogroupBox.Controls.Add(fatherLabel);
            this.infogroupBox.Controls.Add(cityNameLabel);
            this.infogroupBox.Controls.Add(this.motherTextBox);
            this.infogroupBox.Controls.Add(this.cityNameComboBox);
            this.infogroupBox.Controls.Add(motherLabel);
            this.infogroupBox.Controls.Add(countryNameLabel);
            this.infogroupBox.Controls.Add(this.countryNameComboBox);
            this.infogroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infogroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infogroupBox.Location = new System.Drawing.Point(0, 0);
            this.infogroupBox.Name = "infogroupBox";
            this.infogroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infogroupBox.Size = new System.Drawing.Size(440, 259);
            this.infogroupBox.TabIndex = 37;
            this.infogroupBox.TabStop = false;
            this.infogroupBox.Text = "بيانات الحساب";
            // 
            // accountgroupcb
            // 
            this.accountgroupcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountgroupcb.DataSource = this.accountGroupBindingSource;
            this.accountgroupcb.DisplayMember = "GroupTitle";
            this.accountgroupcb.FormattingEnabled = true;
            this.accountgroupcb.Location = new System.Drawing.Point(217, 60);
            this.accountgroupcb.Name = "accountgroupcb";
            this.accountgroupcb.Size = new System.Drawing.Size(132, 23);
            this.accountgroupcb.TabIndex = 45;
            this.accountgroupcb.ValueMember = "Id";
            // 
            // accountGroupBindingSource
            // 
            this.accountGroupBindingSource.DataSource = typeof(Alver.DAL.AccountGroup);
            // 
            // notestextBox
            // 
            this.notestextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notestextBox.Location = new System.Drawing.Point(18, 226);
            this.notestextBox.Name = "notestextBox";
            this.notestextBox.Size = new System.Drawing.Size(331, 23);
            this.notestextBox.TabIndex = 9;
            // 
            // accountcb
            // 
            this.accountcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountcb.BackColor = System.Drawing.Color.Honeydew;
            this.accountcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountcb.FormattingEnabled = true;
            this.accountcb.Location = new System.Drawing.Point(18, 22);
            this.accountcb.Name = "accountcb";
            this.accountcb.Size = new System.Drawing.Size(331, 23);
            this.accountcb.TabIndex = 0;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isActiveCheckBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.isActiveCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.isActiveCheckBox.Location = new System.Drawing.Point(18, 160);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(132, 24);
            this.isActiveCheckBox.TabIndex = 8;
            this.isActiveCheckBox.Text = "غير نشط؟";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(18, 128);
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(132, 23);
            this.phoneMaskedTextBox.TabIndex = 6;
            // 
            // idNumberMaskedTextBox
            // 
            this.idNumberMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idNumberMaskedTextBox.Location = new System.Drawing.Point(217, 160);
            this.idNumberMaskedTextBox.Name = "idNumberMaskedTextBox";
            this.idNumberMaskedTextBox.Size = new System.Drawing.Size(132, 23);
            this.idNumberMaskedTextBox.TabIndex = 3;
            // 
            // fatherTextBox
            // 
            this.fatherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fatherTextBox.Location = new System.Drawing.Point(217, 94);
            this.fatherTextBox.Name = "fatherTextBox";
            this.fatherTextBox.Size = new System.Drawing.Size(132, 23);
            this.fatherTextBox.TabIndex = 1;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextBox.Location = new System.Drawing.Point(18, 193);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(331, 23);
            this.addressTextBox.TabIndex = 7;
            // 
            // motherTextBox
            // 
            this.motherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.motherTextBox.Location = new System.Drawing.Point(217, 127);
            this.motherTextBox.Name = "motherTextBox";
            this.motherTextBox.Size = new System.Drawing.Size(132, 23);
            this.motherTextBox.TabIndex = 2;
            // 
            // cityNameComboBox
            // 
            this.cityNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cityNameComboBox.FormattingEnabled = true;
            this.cityNameComboBox.Location = new System.Drawing.Point(18, 94);
            this.cityNameComboBox.Name = "cityNameComboBox";
            this.cityNameComboBox.Size = new System.Drawing.Size(132, 23);
            this.cityNameComboBox.TabIndex = 5;
            // 
            // countryNameComboBox
            // 
            this.countryNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countryNameComboBox.FormattingEnabled = true;
            this.countryNameComboBox.Location = new System.Drawing.Point(18, 60);
            this.countryNameComboBox.Name = "countryNameComboBox";
            this.countryNameComboBox.Size = new System.Drawing.Size(132, 23);
            this.countryNameComboBox.TabIndex = 4;
            // 
            // accountsFundBindingSource
            // 
            this.accountsFundBindingSource.DataSource = typeof(Alver.DAL.AccountFund);
            // 
            // fundgroupBox
            // 
            this.fundgroupBox.Controls.Add(this.dgv);
            this.fundgroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fundgroupBox.Location = new System.Drawing.Point(0, 259);
            this.fundgroupBox.Name = "fundgroupBox";
            this.fundgroupBox.Size = new System.Drawing.Size(440, 223);
            this.fundgroupBox.TabIndex = 38;
            this.fundgroupBox.TabStop = false;
            this.fundgroupBox.Text = "الصناديق الافتتاحية للحساب";
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
            this.fundTitleDataGridViewTextBoxColumn,
            this.currencyIdDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.balanceDirectionDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.accountsFundBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(3, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(434, 201);
            this.dgv.TabIndex = 46;
            // 
            // fundTitleDataGridViewTextBoxColumn
            // 
            this.fundTitleDataGridViewTextBoxColumn.DataPropertyName = "FundTitle";
            this.fundTitleDataGridViewTextBoxColumn.HeaderText = "الصندوق";
            this.fundTitleDataGridViewTextBoxColumn.Name = "fundTitleDataGridViewTextBoxColumn";
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
            this.currencyIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.currencyIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.currencyIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "الرصيد";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // balanceDirectionDataGridViewTextBoxColumn
            // 
            this.balanceDirectionDataGridViewTextBoxColumn.DataPropertyName = "BalanceDirection";
            this.balanceDirectionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.balanceDirectionDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.balanceDirectionDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceDirectionDataGridViewTextBoxColumn.HeaderText = "لنا / لكم";
            this.balanceDirectionDataGridViewTextBoxColumn.Items.AddRange(new object[] {
            "لنا",
            "لكم"});
            this.balanceDirectionDataGridViewTextBoxColumn.Name = "balanceDirectionDataGridViewTextBoxColumn";
            this.balanceDirectionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.balanceDirectionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(440, 509);
            this.Controls.Add(this.fundgroupBox);
            this.Controls.Add(this.infogroupBox);
            this.Controls.Add(this.bindingNavigator2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditAccount";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل الحساب";
            this.Load += new System.EventHandler(this.frmOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClient_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.infogroupBox.ResumeLayout(false);
            this.infogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsFundBindingSource)).EndInit();
            this.fundgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.GroupBox infogroupBox;
        private System.Windows.Forms.TextBox notestextBox;
        private System.Windows.Forms.ComboBox accountcb;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox idNumberMaskedTextBox;
        private System.Windows.Forms.TextBox fatherTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox motherTextBox;
        private System.Windows.Forms.ComboBox cityNameComboBox;
        private System.Windows.Forms.ComboBox countryNameComboBox;
        private System.Windows.Forms.BindingSource accountsFundBindingSource;
        private System.Windows.Forms.GroupBox fundgroupBox;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn currencyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn balanceDirectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox accountgroupcb;
        private System.Windows.Forms.BindingSource accountGroupBindingSource;
    }
}
