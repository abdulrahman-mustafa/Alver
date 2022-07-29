
namespace Alver.UI.Setup
{
    partial class frmCompanies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companyBS = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mottoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountantPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiddenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTECTEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.mottoDataGridViewTextBoxColumn,
            this.managerDataGridViewTextBoxColumn,
            this.managerPhoneDataGridViewTextBoxColumn,
            this.accountantDataGridViewTextBoxColumn,
            this.accountantPhoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.logoIdDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.hiddenDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.lUDDataGridViewTextBoxColumn,
            this.pROTECTEDDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.companyBS;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // companyBS
            // 
            this.companyBS.DataSource = typeof(Alver.DAL.Company);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.addbtn;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bindingNavigator2.BindingSource = this.companyBS;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.CountItemFormat = "من أصل {0}";
            this.bindingNavigator2.DeleteItem = this.deletebtn;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.addbtn,
            this.toolStripSeparator4,
            this.deletebtn,
            this.toolStripSeparator5,
            this.savebtn});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton1;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton4;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton3;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton2;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator2.TabIndex = 35;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::Alver.Properties.Resources.addrow;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(72, 24);
            this.addbtn.Text = "إضافة";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 24);
            this.toolStripLabel1.Text = "من أصل {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::Alver.Properties.Resources.deleterow;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeftAutoMirrorImage = true;
            this.deletebtn.Size = new System.Drawing.Size(65, 24);
            this.deletebtn.Text = "حذف";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Move previous";
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Move last";
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
            this.savebtn.Size = new System.Drawing.Size(126, 24);
            this.savebtn.Text = "حفظ التعديلات";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Alver.DAL.User);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "اسم الشركة";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // mottoDataGridViewTextBoxColumn
            // 
            this.mottoDataGridViewTextBoxColumn.DataPropertyName = "Motto";
            this.mottoDataGridViewTextBoxColumn.HeaderText = "شعار الشركة";
            this.mottoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mottoDataGridViewTextBoxColumn.Name = "mottoDataGridViewTextBoxColumn";
            this.mottoDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerDataGridViewTextBoxColumn
            // 
            this.managerDataGridViewTextBoxColumn.DataPropertyName = "Manager";
            this.managerDataGridViewTextBoxColumn.HeaderText = "المدير";
            this.managerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerDataGridViewTextBoxColumn.Name = "managerDataGridViewTextBoxColumn";
            this.managerDataGridViewTextBoxColumn.Width = 125;
            // 
            // managerPhoneDataGridViewTextBoxColumn
            // 
            this.managerPhoneDataGridViewTextBoxColumn.DataPropertyName = "ManagerPhone";
            this.managerPhoneDataGridViewTextBoxColumn.HeaderText = "هاتف المدير";
            this.managerPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.managerPhoneDataGridViewTextBoxColumn.Name = "managerPhoneDataGridViewTextBoxColumn";
            this.managerPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountantDataGridViewTextBoxColumn
            // 
            this.accountantDataGridViewTextBoxColumn.DataPropertyName = "Accountant";
            this.accountantDataGridViewTextBoxColumn.HeaderText = "المحاسب";
            this.accountantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountantDataGridViewTextBoxColumn.Name = "accountantDataGridViewTextBoxColumn";
            this.accountantDataGridViewTextBoxColumn.Width = 125;
            // 
            // accountantPhoneDataGridViewTextBoxColumn
            // 
            this.accountantPhoneDataGridViewTextBoxColumn.DataPropertyName = "AccountantPhone";
            this.accountantPhoneDataGridViewTextBoxColumn.HeaderText = "هاتف المحاسب";
            this.accountantPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.accountantPhoneDataGridViewTextBoxColumn.Name = "accountantPhoneDataGridViewTextBoxColumn";
            this.accountantPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "العنوان";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Visible = false;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // logoIdDataGridViewTextBoxColumn
            // 
            this.logoIdDataGridViewTextBoxColumn.DataPropertyName = "LogoId";
            this.logoIdDataGridViewTextBoxColumn.HeaderText = "LogoId";
            this.logoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logoIdDataGridViewTextBoxColumn.Name = "logoIdDataGridViewTextBoxColumn";
            this.logoIdDataGridViewTextBoxColumn.Visible = false;
            this.logoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "البريد الالكتروني";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.DataSource = this.userBindingSource;
            this.userIdDataGridViewTextBoxColumn.DisplayMember = "UserName";
            this.userIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn.ValueMember = "Id";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            this.gUIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hiddenDataGridViewTextBoxColumn
            // 
            this.hiddenDataGridViewTextBoxColumn.DataPropertyName = "Hidden";
            this.hiddenDataGridViewTextBoxColumn.HeaderText = "Hidden";
            this.hiddenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hiddenDataGridViewTextBoxColumn.Name = "hiddenDataGridViewTextBoxColumn";
            this.hiddenDataGridViewTextBoxColumn.Visible = false;
            this.hiddenDataGridViewTextBoxColumn.Width = 125;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.Visible = false;
            this.flagDataGridViewTextBoxColumn.Width = 125;
            // 
            // lUDDataGridViewTextBoxColumn
            // 
            this.lUDDataGridViewTextBoxColumn.DataPropertyName = "LUD";
            this.lUDDataGridViewTextBoxColumn.HeaderText = "LUD";
            this.lUDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lUDDataGridViewTextBoxColumn.Name = "lUDDataGridViewTextBoxColumn";
            this.lUDDataGridViewTextBoxColumn.Visible = false;
            this.lUDDataGridViewTextBoxColumn.Width = 125;
            // 
            // pROTECTEDDataGridViewTextBoxColumn
            // 
            this.pROTECTEDDataGridViewTextBoxColumn.DataPropertyName = "PROTECTED";
            this.pROTECTEDDataGridViewTextBoxColumn.HeaderText = "PROTECTED";
            this.pROTECTEDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROTECTEDDataGridViewTextBoxColumn.Name = "pROTECTEDDataGridViewTextBoxColumn";
            this.pROTECTEDDataGridViewTextBoxColumn.Visible = false;
            this.pROTECTEDDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.Visible = false;
            this.imageDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator2);
            this.Name = "frmCompanies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الشركات";
            this.Load += new System.EventHandler(this.frmCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource companyBS;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mottoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountantPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTECTEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
    }
}