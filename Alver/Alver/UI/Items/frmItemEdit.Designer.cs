namespace Alver.UI.Items
{
    partial class frmItemEdit
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
            System.Windows.Forms.Label idNumberLabel;
            System.Windows.Forms.Label senderIdLabel;
            System.Windows.Forms.Label fatherLabel;
            System.Windows.Forms.Label motherLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemEdit));
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.infogroupBox = new System.Windows.Forms.GroupBox();
            this.currencycb = new System.Windows.Forms.ComboBox();
            this.currencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salepricenud = new System.Windows.Forms.NumericUpDown();
            this.purchasepricenud = new System.Windows.Forms.NumericUpDown();
            this.fundBalancenud = new System.Windows.Forms.NumericUpDown();
            this.itemCategorycb = new System.Windows.Forms.ComboBox();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemcb = new System.Windows.Forms.ComboBox();
            this.declarationcb = new System.Windows.Forms.MaskedTextBox();
            this.barcodecb = new System.Windows.Forms.TextBox();
            this.unitcb = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idNumberLabel = new System.Windows.Forms.Label();
            senderIdLabel = new System.Windows.Forms.Label();
            fatherLabel = new System.Windows.Forms.Label();
            motherLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.infogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salepricenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasepricenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBalancenud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idNumberLabel
            // 
            idNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            idNumberLabel.AutoSize = true;
            idNumberLabel.Location = new System.Drawing.Point(272, 154);
            idNumberLabel.Name = "idNumberLabel";
            idNumberLabel.Size = new System.Drawing.Size(36, 15);
            idNumberLabel.TabIndex = 42;
            idNumberLabel.Text = "البيان:";
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(272, 25);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(37, 15);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الاسم:";
            // 
            // fatherLabel
            // 
            fatherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fatherLabel.AutoSize = true;
            fatherLabel.Location = new System.Drawing.Point(272, 88);
            fatherLabel.Name = "fatherLabel";
            fatherLabel.Size = new System.Drawing.Size(45, 15);
            fatherLabel.TabIndex = 38;
            fatherLabel.Text = "الواحدة:";
            // 
            // motherLabel
            // 
            motherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            motherLabel.AutoSize = true;
            motherLabel.Location = new System.Drawing.Point(272, 121);
            motherLabel.Name = "motherLabel";
            motherLabel.Size = new System.Drawing.Size(46, 15);
            motherLabel.TabIndex = 39;
            motherLabel.Text = "الباركود:";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(272, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 46;
            label2.Text = "الصنف:";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(272, 270);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 15);
            label1.TabIndex = 48;
            label1.Text = "الكمية الاولية:";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(272, 212);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 15);
            label3.TabIndex = 50;
            label3.Text = "سعر الشراء:";
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(272, 241);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 52;
            label4.Text = "سعر المبيع:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(272, 183);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(41, 15);
            label5.TabIndex = 55;
            label5.Text = "العملة:";
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
            this.toolStripSeparator3,
            this.savebtn});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 320);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(358, 25);
            this.bindingNavigator2.TabIndex = 36;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // savebtn
            // 
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(34, 22);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // infogroupBox
            // 
            this.infogroupBox.Controls.Add(label5);
            this.infogroupBox.Controls.Add(this.currencycb);
            this.infogroupBox.Controls.Add(this.salepricenud);
            this.infogroupBox.Controls.Add(label4);
            this.infogroupBox.Controls.Add(this.purchasepricenud);
            this.infogroupBox.Controls.Add(label3);
            this.infogroupBox.Controls.Add(this.fundBalancenud);
            this.infogroupBox.Controls.Add(label1);
            this.infogroupBox.Controls.Add(label2);
            this.infogroupBox.Controls.Add(this.itemCategorycb);
            this.infogroupBox.Controls.Add(this.itemcb);
            this.infogroupBox.Controls.Add(idNumberLabel);
            this.infogroupBox.Controls.Add(senderIdLabel);
            this.infogroupBox.Controls.Add(this.declarationcb);
            this.infogroupBox.Controls.Add(fatherLabel);
            this.infogroupBox.Controls.Add(this.barcodecb);
            this.infogroupBox.Controls.Add(motherLabel);
            this.infogroupBox.Controls.Add(this.unitcb);
            this.infogroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infogroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infogroupBox.Location = new System.Drawing.Point(0, 0);
            this.infogroupBox.Name = "infogroupBox";
            this.infogroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infogroupBox.Size = new System.Drawing.Size(358, 317);
            this.infogroupBox.TabIndex = 37;
            this.infogroupBox.TabStop = false;
            this.infogroupBox.Text = "بيانات المادة";
            // 
            // currencycb
            // 
            this.currencycb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currencycb.DataSource = this.currencyBindingSource;
            this.currencycb.DisplayMember = "CurrencyName";
            this.currencycb.FormattingEnabled = true;
            this.currencycb.Location = new System.Drawing.Point(12, 180);
            this.currencycb.Name = "currencycb";
            this.currencycb.Size = new System.Drawing.Size(254, 23);
            this.currencycb.TabIndex = 54;
            this.currencycb.ValueMember = "Id";
            // 
            // currencyBindingSource
            // 
            this.currencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // salepricenud
            // 
            this.salepricenud.DecimalPlaces = 2;
            this.salepricenud.Location = new System.Drawing.Point(12, 238);
            this.salepricenud.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.salepricenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.salepricenud.Name = "salepricenud";
            this.salepricenud.Size = new System.Drawing.Size(254, 23);
            this.salepricenud.TabIndex = 53;
            this.salepricenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // purchasepricenud
            // 
            this.purchasepricenud.DecimalPlaces = 2;
            this.purchasepricenud.Location = new System.Drawing.Point(12, 209);
            this.purchasepricenud.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.purchasepricenud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.purchasepricenud.Name = "purchasepricenud";
            this.purchasepricenud.Size = new System.Drawing.Size(254, 23);
            this.purchasepricenud.TabIndex = 51;
            this.purchasepricenud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fundBalancenud
            // 
            this.fundBalancenud.DecimalPlaces = 2;
            this.fundBalancenud.Location = new System.Drawing.Point(12, 267);
            this.fundBalancenud.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.fundBalancenud.Name = "fundBalancenud";
            this.fundBalancenud.Size = new System.Drawing.Size(254, 23);
            this.fundBalancenud.TabIndex = 49;
            this.fundBalancenud.Visible = false;
            // 
            // itemCategorycb
            // 
            this.itemCategorycb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCategorycb.DataSource = this.itemCategoryBindingSource;
            this.itemCategorycb.DisplayMember = "Title";
            this.itemCategorycb.FormattingEnabled = true;
            this.itemCategorycb.Location = new System.Drawing.Point(12, 51);
            this.itemCategorycb.Name = "itemCategorycb";
            this.itemCategorycb.Size = new System.Drawing.Size(254, 23);
            this.itemCategorycb.TabIndex = 45;
            this.itemCategorycb.ValueMember = "Id";
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(Alver.DAL.ItemCategory);
            // 
            // itemcb
            // 
            this.itemcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemcb.BackColor = System.Drawing.Color.Honeydew;
            this.itemcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemcb.FormattingEnabled = true;
            this.itemcb.Location = new System.Drawing.Point(12, 22);
            this.itemcb.Name = "itemcb";
            this.itemcb.Size = new System.Drawing.Size(254, 23);
            this.itemcb.TabIndex = 0;
            // 
            // declarationcb
            // 
            this.declarationcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.declarationcb.Location = new System.Drawing.Point(12, 151);
            this.declarationcb.Name = "declarationcb";
            this.declarationcb.Size = new System.Drawing.Size(254, 23);
            this.declarationcb.TabIndex = 3;
            // 
            // barcodecb
            // 
            this.barcodecb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodecb.Location = new System.Drawing.Point(12, 118);
            this.barcodecb.Name = "barcodecb";
            this.barcodecb.Size = new System.Drawing.Size(254, 23);
            this.barcodecb.TabIndex = 2;
            // 
            // unitcb
            // 
            this.unitcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unitcb.DataSource = this.unitBindingSource;
            this.unitcb.DisplayMember = "Title";
            this.unitcb.FormattingEnabled = true;
            this.unitcb.Location = new System.Drawing.Point(12, 85);
            this.unitcb.Name = "unitcb";
            this.unitcb.Size = new System.Drawing.Size(254, 23);
            this.unitcb.TabIndex = 4;
            this.unitcb.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(Alver.DAL.Unit);
            // 
            // frmItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(358, 345);
            this.Controls.Add(this.infogroupBox);
            this.Controls.Add(this.bindingNavigator2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmItemEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل مادة";
            this.Load += new System.EventHandler(this.frmOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClient_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.infogroupBox.ResumeLayout(false);
            this.infogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salepricenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasepricenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fundBalancenud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.GroupBox infogroupBox;
        private System.Windows.Forms.ComboBox itemcb;
        private System.Windows.Forms.MaskedTextBox declarationcb;
        private System.Windows.Forms.TextBox barcodecb;
        private System.Windows.Forms.ComboBox unitcb;
        private System.Windows.Forms.ComboBox itemCategorycb;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.NumericUpDown fundBalancenud;
        private System.Windows.Forms.NumericUpDown salepricenud;
        private System.Windows.Forms.NumericUpDown purchasepricenud;
        private System.Windows.Forms.ComboBox currencycb;
        private System.Windows.Forms.BindingSource currencyBindingSource;
    }
}
