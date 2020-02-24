namespace Alver.UI.Accounts.Transactions
{
    partial class frmTransaction
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
            System.Windows.Forms.Label wageAmountLabel;
            System.Windows.Forms.Label wageCurrencyIdLabel;
            System.Windows.Forms.Label fullnameLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label currencyIdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.declarationtb = new System.Windows.Forms.TextBox();
            this.amountnud = new System.Windows.Forms.NumericUpDown();
            this.currencyIdcb = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.amountLabel1 = new System.Windows.Forms.Label();
            this.currencyIdLabel1 = new System.Windows.Forms.Label();
            this.accountlbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            wageAmountLabel = new System.Windows.Forms.Label();
            wageCurrencyIdLabel = new System.Windows.Forms.Label();
            fullnameLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            currencyIdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountnud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wageAmountLabel
            // 
            wageAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            wageAmountLabel.AutoSize = true;
            wageAmountLabel.Location = new System.Drawing.Point(131, 29);
            wageAmountLabel.Name = "wageAmountLabel";
            wageAmountLabel.Size = new System.Drawing.Size(39, 15);
            wageAmountLabel.TabIndex = 19;
            wageAmountLabel.Text = "المبلغ:";
            // 
            // wageCurrencyIdLabel
            // 
            wageCurrencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            wageCurrencyIdLabel.AutoSize = true;
            wageCurrencyIdLabel.Location = new System.Drawing.Point(261, 29);
            wageCurrencyIdLabel.Name = "wageCurrencyIdLabel";
            wageCurrencyIdLabel.Size = new System.Drawing.Size(74, 15);
            wageCurrencyIdLabel.TabIndex = 21;
            wageCurrencyIdLabel.Text = "عملة العمولة:";
            // 
            // fullnameLabel
            // 
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new System.Drawing.Point(295, 64);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new System.Drawing.Size(41, 15);
            fullnameLabel.TabIndex = 31;
            fullnameLabel.Text = "التاريخ:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(295, 128);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(39, 15);
            amountLabel.TabIndex = 29;
            amountLabel.Text = "المبلغ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(295, 96);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(41, 15);
            currencyIdLabel.TabIndex = 27;
            currencyIdLabel.Text = "العملة:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(295, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(48, 15);
            idLabel.TabIndex = 25;
            idLabel.Text = "الحساب:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(311, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 15);
            label1.TabIndex = 23;
            label1.Text = "البيان:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.declarationtb);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(wageAmountLabel);
            this.groupBox1.Controls.Add(this.amountnud);
            this.groupBox1.Controls.Add(this.currencyIdcb);
            this.groupBox1.Controls.Add(wageCurrencyIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 246);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملة/المبلغ";
            // 
            // declarationtb
            // 
            this.declarationtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationtb.Location = new System.Drawing.Point(8, 106);
            this.declarationtb.Multiline = true;
            this.declarationtb.Name = "declarationtb";
            this.declarationtb.Size = new System.Drawing.Size(344, 134);
            this.declarationtb.TabIndex = 24;
            this.declarationtb.WordWrap = false;
            // 
            // amountnud
            // 
            this.amountnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountnud.DecimalPlaces = 3;
            this.amountnud.Location = new System.Drawing.Point(8, 52);
            this.amountnud.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.amountnud.Minimum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            -2147483648});
            this.amountnud.Name = "amountnud";
            this.amountnud.Size = new System.Drawing.Size(169, 23);
            this.amountnud.TabIndex = 20;
            // 
            // currencyIdcb
            // 
            this.currencyIdcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdcb.DataSource = this.currencyBindingSource;
            this.currencyIdcb.DisplayMember = "CurrencyName";
            this.currencyIdcb.FormattingEnabled = true;
            this.currencyIdcb.Location = new System.Drawing.Point(183, 52);
            this.currencyIdcb.Name = "currencyIdcb";
            this.currencyIdcb.Size = new System.Drawing.Size(169, 23);
            this.currencyIdcb.TabIndex = 22;
            this.currencyIdcb.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // datelbl
            // 
            this.datelbl.Location = new System.Drawing.Point(21, 64);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(268, 23);
            this.datelbl.TabIndex = 32;
            this.datelbl.Text = "label1";
            // 
            // amountLabel1
            // 
            this.amountLabel1.Location = new System.Drawing.Point(21, 128);
            this.amountLabel1.Name = "amountLabel1";
            this.amountLabel1.Size = new System.Drawing.Size(268, 23);
            this.amountLabel1.TabIndex = 30;
            this.amountLabel1.Text = "label1";
            // 
            // currencyIdLabel1
            // 
            this.currencyIdLabel1.Location = new System.Drawing.Point(21, 96);
            this.currencyIdLabel1.Name = "currencyIdLabel1";
            this.currencyIdLabel1.Size = new System.Drawing.Size(268, 23);
            this.currencyIdLabel1.TabIndex = 28;
            this.currencyIdLabel1.Text = "label1";
            // 
            // accountlbl
            // 
            this.accountlbl.Location = new System.Drawing.Point(21, 32);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(268, 23);
            this.accountlbl.TabIndex = 26;
            this.accountlbl.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(amountLabel);
            this.groupBox2.Controls.Add(this.amountLabel1);
            this.groupBox2.Controls.Add(this.datelbl);
            this.groupBox2.Controls.Add(this.currencyIdLabel1);
            this.groupBox2.Controls.Add(fullnameLabel);
            this.groupBox2.Controls.Add(idLabel);
            this.groupBox2.Controls.Add(currencyIdLabel);
            this.groupBox2.Controls.Add(this.accountlbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 164);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الحركة";
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
            this.toolStripSeparator3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 439);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(385, 27);
            this.bindingNavigator2.TabIndex = 36;
            // 
            // savebtn
            // 
            this.savebtn.Image = global::Alver.Properties.Resources.save;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(54, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 466);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 505);
            this.Name = "frmTransaction";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل حركة";
            this.Load += new System.EventHandler(this.frmWage_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWage_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountnud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown amountnud;
        private System.Windows.Forms.ComboBox currencyIdcb;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label amountLabel1;
        private System.Windows.Forms.Label currencyIdLabel1;
        private System.Windows.Forms.Label accountlbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.BindingSource currencyBindingSource;
        private System.Windows.Forms.TextBox declarationtb;
    }
}