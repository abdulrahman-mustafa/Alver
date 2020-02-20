namespace Alver.UI.Funds.Transactions
{
    partial class frmFundTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFundTransaction));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.declarationtb = new System.Windows.Forms.TextBox();
            this.amountnud = new System.Windows.Forms.NumericUpDown();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
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
            wageAmountLabel.Location = new System.Drawing.Point(129, 29);
            wageAmountLabel.Name = "wageAmountLabel";
            wageAmountLabel.Size = new System.Drawing.Size(49, 20);
            wageAmountLabel.TabIndex = 19;
            wageAmountLabel.Text = "المبلغ:";
            // 
            // wageCurrencyIdLabel
            // 
            wageCurrencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            wageCurrencyIdLabel.AutoSize = true;
            wageCurrencyIdLabel.Location = new System.Drawing.Point(260, 29);
            wageCurrencyIdLabel.Name = "wageCurrencyIdLabel";
            wageCurrencyIdLabel.Size = new System.Drawing.Size(95, 20);
            wageCurrencyIdLabel.TabIndex = 21;
            wageCurrencyIdLabel.Text = "عملة العمولة:";
            // 
            // fullnameLabel
            // 
            fullnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fullnameLabel.AutoSize = true;
            fullnameLabel.Location = new System.Drawing.Point(272, 64);
            fullnameLabel.Name = "fullnameLabel";
            fullnameLabel.Size = new System.Drawing.Size(51, 20);
            fullnameLabel.TabIndex = 31;
            fullnameLabel.Text = "التاريخ:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(272, 128);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(49, 20);
            amountLabel.TabIndex = 29;
            amountLabel.Text = "المبلغ:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new System.Drawing.Point(272, 96);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new System.Drawing.Size(52, 20);
            currencyIdLabel.TabIndex = 27;
            currencyIdLabel.Text = "العملة:";
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(272, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(61, 20);
            idLabel.TabIndex = 25;
            idLabel.Text = "الحساب:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(310, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 20);
            label1.TabIndex = 25;
            label1.Text = "البيان:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.declarationtb);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(wageAmountLabel);
            this.groupBox1.Controls.Add(this.amountnud);
            this.groupBox1.Controls.Add(this.currencyComboBox);
            this.groupBox1.Controls.Add(wageCurrencyIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 246);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "العملة/المبلغ";
            // 
            // declarationtb
            // 
            this.declarationtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationtb.Location = new System.Drawing.Point(7, 106);
            this.declarationtb.Multiline = true;
            this.declarationtb.Name = "declarationtb";
            this.declarationtb.Size = new System.Drawing.Size(344, 134);
            this.declarationtb.TabIndex = 26;
            this.declarationtb.WordWrap = false;
            // 
            // amountnud
            // 
            this.amountnud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountnud.DecimalPlaces = 3;
            this.amountnud.Location = new System.Drawing.Point(6, 53);
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
            this.amountnud.Size = new System.Drawing.Size(168, 27);
            this.amountnud.TabIndex = 20;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyComboBox.DataSource = this.currencyBindingSource;
            this.currencyComboBox.DisplayMember = "CurrencyName";
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(181, 52);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(168, 28);
            this.currencyComboBox.TabIndex = 22;
            this.currencyComboBox.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(DAL.Currency);
            // 
            // datelbl
            // 
            this.datelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datelbl.Location = new System.Drawing.Point(95, 64);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(171, 23);
            this.datelbl.TabIndex = 32;
            this.datelbl.Text = "label1";
            // 
            // amountLabel1
            // 
            this.amountLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel1.Location = new System.Drawing.Point(95, 128);
            this.amountLabel1.Name = "amountLabel1";
            this.amountLabel1.Size = new System.Drawing.Size(171, 23);
            this.amountLabel1.TabIndex = 30;
            this.amountLabel1.Text = "label1";
            // 
            // currencyIdLabel1
            // 
            this.currencyIdLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyIdLabel1.Location = new System.Drawing.Point(95, 96);
            this.currencyIdLabel1.Name = "currencyIdLabel1";
            this.currencyIdLabel1.Size = new System.Drawing.Size(171, 23);
            this.currencyIdLabel1.TabIndex = 28;
            this.currencyIdLabel1.Text = "label1";
            // 
            // accountlbl
            // 
            this.accountlbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountlbl.Location = new System.Drawing.Point(95, 32);
            this.accountlbl.Name = "accountlbl";
            this.accountlbl.Size = new System.Drawing.Size(171, 23);
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
            this.groupBox2.Size = new System.Drawing.Size(361, 164);
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
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 431);
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
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(63, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // frmFundTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 458);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(325, 505);
            this.Name = "frmFundTransaction";
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
        private System.Windows.Forms.ComboBox currencyComboBox;
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