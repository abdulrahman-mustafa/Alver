namespace Alver.UI.Accounts
{
    partial class frmAccountsGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountsGroups));
            this.payments_ExpenseCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declarationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.firstbtn = new System.Windows.Forms.ToolStripButton();
            this.prevbtn = new System.Windows.Forms.ToolStripButton();
            this.nextbtn = new System.Windows.Forms.ToolStripButton();
            this.lastbtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payments_ExpenseCategoryDataGridView
            // 
            this.payments_ExpenseCategoryDataGridView.AllowUserToAddRows = false;
            this.payments_ExpenseCategoryDataGridView.AllowUserToDeleteRows = false;
            this.payments_ExpenseCategoryDataGridView.AllowUserToOrderColumns = true;
            this.payments_ExpenseCategoryDataGridView.AutoGenerateColumns = false;
            this.payments_ExpenseCategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payments_ExpenseCategoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.payments_ExpenseCategoryDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.payments_ExpenseCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payments_ExpenseCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupTitle,
            this.declarationDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn});
            this.payments_ExpenseCategoryDataGridView.DataSource = this.accountGroupBindingSource;
            this.payments_ExpenseCategoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payments_ExpenseCategoryDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.payments_ExpenseCategoryDataGridView.Location = new System.Drawing.Point(0, 27);
            this.payments_ExpenseCategoryDataGridView.Name = "payments_ExpenseCategoryDataGridView";
            this.payments_ExpenseCategoryDataGridView.Size = new System.Drawing.Size(680, 390);
            this.payments_ExpenseCategoryDataGridView.TabIndex = 1;
            this.payments_ExpenseCategoryDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.payments_ExpenseCategoryDataGridView_DataError);
            // 
            // GroupTitle
            // 
            this.GroupTitle.DataPropertyName = "GroupTitle";
            this.GroupTitle.HeaderText = "اسم المجموعة";
            this.GroupTitle.Name = "GroupTitle";
            // 
            // declarationDataGridViewTextBoxColumn
            // 
            this.declarationDataGridViewTextBoxColumn.DataPropertyName = "Declaration";
            this.declarationDataGridViewTextBoxColumn.HeaderText = "البيان";
            this.declarationDataGridViewTextBoxColumn.Name = "declarationDataGridViewTextBoxColumn";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.DataSource = this.userBindingSource;
            this.userIdDataGridViewTextBoxColumn.DisplayMember = "FullName";
            this.userIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.userIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Alver.DAL.User);
            // 
            // accountGroupBindingSource
            // 
            this.accountGroupBindingSource.DataSource = typeof(Alver.DAL.AccountGroup);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.addbtn;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigator1.BindingSource = this.accountGroupBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.CountItemFormat = "من أصل {0}";
            this.bindingNavigator1.DeleteItem = this.deletebtn;
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
            this.addbtn,
            this.toolStripSeparator4,
            this.deletebtn,
            this.toolStripSeparator5,
            this.savebtn});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.firstbtn;
            this.bindingNavigator1.MoveLastItem = this.lastbtn;
            this.bindingNavigator1.MoveNextItem = this.nextbtn;
            this.bindingNavigator1.MovePreviousItem = this.prevbtn;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(680, 27);
            this.bindingNavigator1.TabIndex = 34;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::Alver.Properties.Resources.addgroup;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(61, 24);
            this.addbtn.Text = "إضافة";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(66, 24);
            this.toolStripLabel1.Text = "من أصل {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::Alver.Properties.Resources.trash;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeftAutoMirrorImage = true;
            this.deletebtn.Size = new System.Drawing.Size(56, 24);
            this.deletebtn.Text = "حذف";
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Alver.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(103, 24);
            this.savebtn.Text = "حفظ التعديلات";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
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
            // frmAccountsGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 417);
            this.Controls.Add(this.payments_ExpenseCategoryDataGridView);
            this.Controls.Add(this.bindingNavigator1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountsGroups";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مجموعات الوكلاء";
            this.Load += new System.EventHandler(this.frmExpensessCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payments_ExpenseCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView payments_ExpenseCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn declarationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource accountGroupBindingSource;
        private System.Windows.Forms.ToolStripButton firstbtn;
        private System.Windows.Forms.ToolStripButton prevbtn;
        private System.Windows.Forms.ToolStripButton nextbtn;
        private System.Windows.Forms.ToolStripButton lastbtn;
    }
}