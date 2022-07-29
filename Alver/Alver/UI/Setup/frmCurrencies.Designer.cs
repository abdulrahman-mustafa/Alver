
namespace Alver.UI.Setup
{
    partial class frmCurrencies
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
            this.bnCurrencies = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencySymbolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseCurrencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.exchangeRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiddenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTECTEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnCurrencies)).BeginInit();
            this.bnCurrencies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCurrencies
            // 
            this.bnCurrencies.AddNewItem = this.addbtn;
            this.bnCurrencies.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnCurrencies.BindingSource = this.currencyBindingSource;
            this.bnCurrencies.CountItem = this.toolStripLabel1;
            this.bnCurrencies.CountItemFormat = "من أصل {0}";
            this.bnCurrencies.DeleteItem = this.deletebtn;
            this.bnCurrencies.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnCurrencies.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnCurrencies.Location = new System.Drawing.Point(0, 0);
            this.bnCurrencies.MoveFirstItem = this.toolStripButton1;
            this.bnCurrencies.MoveLastItem = this.toolStripButton4;
            this.bnCurrencies.MoveNextItem = this.toolStripButton3;
            this.bnCurrencies.MovePreviousItem = this.toolStripButton2;
            this.bnCurrencies.Name = "bnCurrencies";
            this.bnCurrencies.PositionItem = this.toolStripTextBox1;
            this.bnCurrencies.Size = new System.Drawing.Size(800, 31);
            this.bnCurrencies.TabIndex = 35;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::Alver.Properties.Resources.addrow;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(72, 28);
            this.addbtn.Text = "إضافة";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 28);
            this.toolStripLabel1.Text = "من أصل {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // deletebtn
            // 
            this.deletebtn.Image = global::Alver.Properties.Resources.deleterow;
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.RightToLeftAutoMirrorImage = true;
            this.deletebtn.Size = new System.Drawing.Size(65, 28);
            this.deletebtn.Text = "حذف";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "Move first";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton2.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
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
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton3.Text = "Move next";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton4.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Alver.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(126, 28);
            this.savebtn.Text = "حفظ التعديلات";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToOrderColumns = true;
            this.dgvCurrencies.AutoGenerateColumns = false;
            this.dgvCurrencies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrencies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCurrencies.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.currencyNameDataGridViewTextBoxColumn,
            this.currencySymbolDataGridViewTextBoxColumn,
            this.currencyCodeDataGridViewTextBoxColumn,
            this.baseCurrencyDataGridViewTextBoxColumn,
            this.exchangeRateDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.gUIDDataGridViewTextBoxColumn,
            this.hiddenDataGridViewTextBoxColumn,
            this.flagDataGridViewTextBoxColumn,
            this.lUDDataGridViewTextBoxColumn,
            this.pROTECTEDDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dgvCurrencies.DataSource = this.currencyBindingSource;
            this.dgvCurrencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrencies.GridColor = System.Drawing.SystemColors.Control;
            this.dgvCurrencies.Location = new System.Drawing.Point(0, 31);
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.RowHeadersWidth = 51;
            this.dgvCurrencies.Size = new System.Drawing.Size(800, 419);
            this.dgvCurrencies.TabIndex = 36;
            this.dgvCurrencies.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCurrencies_DataError);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencyNameDataGridViewTextBoxColumn
            // 
            this.currencyNameDataGridViewTextBoxColumn.DataPropertyName = "CurrencyName";
            this.currencyNameDataGridViewTextBoxColumn.HeaderText = "العملة";
            this.currencyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyNameDataGridViewTextBoxColumn.Name = "currencyNameDataGridViewTextBoxColumn";
            // 
            // currencySymbolDataGridViewTextBoxColumn
            // 
            this.currencySymbolDataGridViewTextBoxColumn.DataPropertyName = "CurrencySymbol";
            this.currencySymbolDataGridViewTextBoxColumn.HeaderText = "رمز العملة";
            this.currencySymbolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencySymbolDataGridViewTextBoxColumn.Name = "currencySymbolDataGridViewTextBoxColumn";
            // 
            // currencyCodeDataGridViewTextBoxColumn
            // 
            this.currencyCodeDataGridViewTextBoxColumn.DataPropertyName = "CurrencyCode";
            this.currencyCodeDataGridViewTextBoxColumn.HeaderText = "كود العملة";
            this.currencyCodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.currencyCodeDataGridViewTextBoxColumn.Name = "currencyCodeDataGridViewTextBoxColumn";
            // 
            // baseCurrencyDataGridViewTextBoxColumn
            // 
            this.baseCurrencyDataGridViewTextBoxColumn.DataPropertyName = "BaseCurrency";
            this.baseCurrencyDataGridViewTextBoxColumn.HeaderText = "العملة الاساس";
            this.baseCurrencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baseCurrencyDataGridViewTextBoxColumn.Name = "baseCurrencyDataGridViewTextBoxColumn";
            this.baseCurrencyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baseCurrencyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // exchangeRateDataGridViewTextBoxColumn
            // 
            this.exchangeRateDataGridViewTextBoxColumn.DataPropertyName = "ExchangeRate";
            this.exchangeRateDataGridViewTextBoxColumn.HeaderText = "سعر الصرف";
            this.exchangeRateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.exchangeRateDataGridViewTextBoxColumn.Name = "exchangeRateDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Visible = false;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.DataSource = this.userBindingSource;
            this.userIdDataGridViewTextBoxColumn.DisplayMember = "UserName";
            this.userIdDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.userIdDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userIdDataGridViewTextBoxColumn.HeaderText = "المستخدم";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.userIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Alver.DAL.User);
            // 
            // gUIDDataGridViewTextBoxColumn
            // 
            this.gUIDDataGridViewTextBoxColumn.DataPropertyName = "GUID";
            this.gUIDDataGridViewTextBoxColumn.HeaderText = "GUID";
            this.gUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gUIDDataGridViewTextBoxColumn.Name = "gUIDDataGridViewTextBoxColumn";
            this.gUIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // hiddenDataGridViewTextBoxColumn
            // 
            this.hiddenDataGridViewTextBoxColumn.DataPropertyName = "Hidden";
            this.hiddenDataGridViewTextBoxColumn.HeaderText = "Hidden";
            this.hiddenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hiddenDataGridViewTextBoxColumn.Name = "hiddenDataGridViewTextBoxColumn";
            this.hiddenDataGridViewTextBoxColumn.Visible = false;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "Flag";
            this.flagDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.Visible = false;
            // 
            // lUDDataGridViewTextBoxColumn
            // 
            this.lUDDataGridViewTextBoxColumn.DataPropertyName = "LUD";
            this.lUDDataGridViewTextBoxColumn.HeaderText = "LUD";
            this.lUDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lUDDataGridViewTextBoxColumn.Name = "lUDDataGridViewTextBoxColumn";
            this.lUDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROTECTEDDataGridViewTextBoxColumn
            // 
            this.pROTECTEDDataGridViewTextBoxColumn.DataPropertyName = "PROTECTED";
            this.pROTECTEDDataGridViewTextBoxColumn.HeaderText = "PROTECTED";
            this.pROTECTEDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pROTECTEDDataGridViewTextBoxColumn.Name = "pROTECTEDDataGridViewTextBoxColumn";
            this.pROTECTEDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.Visible = false;
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // frmCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCurrencies);
            this.Controls.Add(this.bnCurrencies);
            this.Name = "frmCurrencies";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملات";
            this.Load += new System.EventHandler(this.frmCurrencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnCurrencies)).EndInit();
            this.bnCurrencies.ResumeLayout(false);
            this.bnCurrencies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnCurrencies;
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
        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencySymbolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baseCurrencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exchangeRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTECTEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}