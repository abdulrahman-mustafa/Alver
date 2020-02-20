namespace Alver.UI.Users
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.users_UserBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.users_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.adduserbtn = new System.Windows.Forms.ToolStripButton();
            this.changepasswordbtn = new System.Windows.Forms.ToolStripButton();
            this.deleteuserbtn = new System.Windows.Forms.ToolStripButton();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.exportbtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.اكسلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingNavigator)).BeginInit();
            this.users_UserBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // users_UserBindingNavigator
            // 
            this.users_UserBindingNavigator.AddNewItem = null;
            this.users_UserBindingNavigator.BindingSource = this.users_UserBindingSource;
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
            this.adduserbtn,
            this.changepasswordbtn,
            this.deleteuserbtn,
            this.savebtn,
            this.exportbtn});
            this.users_UserBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.users_UserBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.users_UserBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.users_UserBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.users_UserBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.users_UserBindingNavigator.Name = "users_UserBindingNavigator";
            this.users_UserBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.users_UserBindingNavigator.Size = new System.Drawing.Size(907, 27);
            this.users_UserBindingNavigator.TabIndex = 0;
            this.users_UserBindingNavigator.Text = "bindingNavigator1";
            // 
            // users_UserBindingSource
            // 
            this.users_UserBindingSource.DataSource = typeof(Alver.DAL.User);
            this.users_UserBindingSource.CurrentChanged += new System.EventHandler(this.UserBindingSource_CurrentChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(87, 24);
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
            // adduserbtn
            // 
            this.adduserbtn.Name = "adduserbtn";
            this.adduserbtn.RightToLeftAutoMirrorImage = true;
            this.adduserbtn.Size = new System.Drawing.Size(109, 24);
            this.adduserbtn.Text = "إضافة مستخدم";
            this.adduserbtn.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // changepasswordbtn
            // 
            this.changepasswordbtn.Name = "changepasswordbtn";
            this.changepasswordbtn.RightToLeftAutoMirrorImage = true;
            this.changepasswordbtn.Size = new System.Drawing.Size(118, 24);
            this.changepasswordbtn.Text = "تغيير كلمة المرور";
            this.changepasswordbtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // deleteuserbtn
            // 
            this.deleteuserbtn.Name = "deleteuserbtn";
            this.deleteuserbtn.RightToLeftAutoMirrorImage = true;
            this.deleteuserbtn.Size = new System.Drawing.Size(111, 24);
            this.deleteuserbtn.Text = "حذف المستخدم";
            this.deleteuserbtn.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // savebtn
            // 
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(106, 24);
            this.savebtn.Text = "حفظ التعديلات";
            this.savebtn.Click += new System.EventHandler(this.UserBindingNavigatorSaveItem_Click);
            // 
            // exportbtn
            // 
            this.exportbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اكسلToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.exportbtn.Name = "exportbtn";
            this.exportbtn.Size = new System.Drawing.Size(62, 24);
            this.exportbtn.Text = "تصدير";
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
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.usernameColumn,
            this.passwordColumn,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgv.DataSource = this.users_UserBindingSource;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv.GridColor = System.Drawing.SystemColors.Control;
            this.dgv.Location = new System.Drawing.Point(0, 27);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 26;
            this.dgv.Size = new System.Drawing.Size(907, 450);
            this.dgv.TabIndex = 1;
            this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoleId";
            this.dataGridViewTextBoxColumn2.DataSource = this.roleBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "RoleTitle";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn2.DisplayStyleForCurrentCellOnly = true;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = "نوع المستخدم";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "Id";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(Alver.DAL.Role);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn5.HeaderText = "الاسم";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // usernameColumn
            // 
            this.usernameColumn.DataPropertyName = "UserName";
            this.usernameColumn.HeaderText = "اسم المستخدم";
            this.usernameColumn.Name = "usernameColumn";
            // 
            // passwordColumn
            // 
            this.passwordColumn.DataPropertyName = "Password";
            this.passwordColumn.HeaderText = "كلمة المرور";
            this.passwordColumn.Name = "passwordColumn";
            this.passwordColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LoginAttempts";
            this.dataGridViewTextBoxColumn6.HeaderText = "LoginAttempts";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Locked";
            this.dataGridViewTextBoxColumn7.HeaderText = "Locked";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CD";
            this.dataGridViewTextBoxColumn10.HeaderText = "CD";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LLD";
            this.dataGridViewTextBoxColumn11.HeaderText = "تاريخ آخر دخول";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 477);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.users_UserBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمون";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingNavigator)).EndInit();
            this.users_UserBindingNavigator.ResumeLayout(false);
            this.users_UserBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users_UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource users_UserBindingSource;
        private System.Windows.Forms.BindingNavigator users_UserBindingNavigator;
        private System.Windows.Forms.ToolStripButton adduserbtn;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton deleteuserbtn;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.ToolStripButton changepasswordbtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.ToolStripDropDownButton exportbtn;
        private System.Windows.Forms.ToolStripMenuItem اكسلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
    }
}