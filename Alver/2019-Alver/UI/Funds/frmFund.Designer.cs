namespace Alver.UI.Funds
{
    partial class frmFund
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
            System.Windows.Forms.Label senderIdLabel;
            System.Windows.Forms.Label fatherLabel;
            System.Windows.Forms.Label countryNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFund));
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.infogroupBox = new System.Windows.Forms.GroupBox();
            this.balancenud = new System.Windows.Forms.NumericUpDown();
            this.notestextBox = new System.Windows.Forms.TextBox();
            this.fundComboBox = new System.Windows.Forms.ComboBox();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label1 = new System.Windows.Forms.Label();
            senderIdLabel = new System.Windows.Forms.Label();
            fatherLabel = new System.Windows.Forms.Label();
            countryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.infogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balancenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(240, 126);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 15);
            label1.TabIndex = 44;
            label1.Text = "الملاحظات:";
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(240, 25);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(54, 15);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الصندوق:";
            // 
            // fatherLabel
            // 
            fatherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fatherLabel.AutoSize = true;
            fatherLabel.Location = new System.Drawing.Point(240, 93);
            fatherLabel.Name = "fatherLabel";
            fatherLabel.Size = new System.Drawing.Size(43, 15);
            fatherLabel.TabIndex = 38;
            fatherLabel.Text = "الرصيد:";
            // 
            // countryNameLabel
            // 
            countryNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            countryNameLabel.AutoSize = true;
            countryNameLabel.Location = new System.Drawing.Point(240, 59);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(41, 15);
            countryNameLabel.TabIndex = 35;
            countryNameLabel.Text = "العملة:";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.CountItemFormat = "من أصل {0}";
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addbtn,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.savebtn});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 234);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(325, 27);
            this.bindingNavigator2.TabIndex = 36;
            // 
            // addbtn
            // 
            this.addbtn.Image = global::Alver.Properties.Resources.Add;
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(61, 24);
            this.addbtn.Text = "إضافة";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Image = global::Alver.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(54, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // infogroupBox
            // 
            this.infogroupBox.Controls.Add(this.balancenud);
            this.infogroupBox.Controls.Add(label1);
            this.infogroupBox.Controls.Add(this.notestextBox);
            this.infogroupBox.Controls.Add(this.fundComboBox);
            this.infogroupBox.Controls.Add(senderIdLabel);
            this.infogroupBox.Controls.Add(fatherLabel);
            this.infogroupBox.Controls.Add(countryNameLabel);
            this.infogroupBox.Controls.Add(this.currencyComboBox);
            this.infogroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infogroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infogroupBox.Location = new System.Drawing.Point(0, 0);
            this.infogroupBox.Name = "infogroupBox";
            this.infogroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infogroupBox.Size = new System.Drawing.Size(325, 195);
            this.infogroupBox.TabIndex = 37;
            this.infogroupBox.TabStop = false;
            this.infogroupBox.Text = "بيانات الصندوق";
            // 
            // balancenud
            // 
            this.balancenud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balancenud.BackColor = System.Drawing.SystemColors.Control;
            this.balancenud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.balancenud.DecimalPlaces = 4;
            this.balancenud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.balancenud.Location = new System.Drawing.Point(14, 91);
            this.balancenud.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.balancenud.Name = "balancenud";
            this.balancenud.Size = new System.Drawing.Size(220, 23);
            this.balancenud.TabIndex = 2;
            this.balancenud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.balancenud.ThousandsSeparator = true;
            // 
            // notestextBox
            // 
            this.notestextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notestextBox.BackColor = System.Drawing.SystemColors.Control;
            this.notestextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.notestextBox.Location = new System.Drawing.Point(14, 123);
            this.notestextBox.Multiline = true;
            this.notestextBox.Name = "notestextBox";
            this.notestextBox.Size = new System.Drawing.Size(220, 66);
            this.notestextBox.TabIndex = 3;
            // 
            // fundComboBox
            // 
            this.fundComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fundComboBox.BackColor = System.Drawing.Color.Honeydew;
            this.fundComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fundComboBox.FormattingEnabled = true;
            this.fundComboBox.Location = new System.Drawing.Point(14, 22);
            this.fundComboBox.Name = "fundComboBox";
            this.fundComboBox.Size = new System.Drawing.Size(220, 23);
            this.fundComboBox.TabIndex = 0;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.currencyComboBox.DataSource = this.currencyBindingSource;
            this.currencyComboBox.DisplayMember = "CurrencyName";
            this.currencyComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currencyComboBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(14, 56);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(220, 23);
            this.currencyComboBox.TabIndex = 1;
            this.currencyComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // frmFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(325, 261);
            this.Controls.Add(this.infogroupBox);
            this.Controls.Add(this.bindingNavigator2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmFund";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة صندوق";
            this.Load += new System.EventHandler(this.frmOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFund_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.infogroupBox.ResumeLayout(false);
            this.infogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balancenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.GroupBox infogroupBox;
        private System.Windows.Forms.TextBox notestextBox;
        private System.Windows.Forms.ComboBox fundComboBox;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.NumericUpDown balancenud;
    }
}
