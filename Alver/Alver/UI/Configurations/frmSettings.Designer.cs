namespace Alver.UI.Configuration
{
    partial class frmSettings
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
            System.Windows.Forms.Label accountantLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label helperLabel;
            System.Windows.Forms.Label logoIdLabel;
            System.Windows.Forms.Label managerLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.emailaddresstb = new System.Windows.Forms.TextBox();
            this.accountantphonetb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.logopb = new System.Windows.Forms.PictureBox();
            this.titlelbl = new System.Windows.Forms.TextBox();
            this.mottolbl = new System.Windows.Forms.TextBox();
            this.managerlbl = new System.Windows.Forms.TextBox();
            this.accountantlbl = new System.Windows.Forms.TextBox();
            this.managerphonetb = new System.Windows.Forms.TextBox();
            this.addresslbl = new System.Windows.Forms.TextBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            accountantLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            helperLabel = new System.Windows.Forms.Label();
            logoIdLabel = new System.Windows.Forms.Label();
            managerLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // accountantLabel
            // 
            accountantLabel.AutoSize = true;
            accountantLabel.Location = new System.Drawing.Point(546, 22);
            accountantLabel.Name = "accountantLabel";
            accountantLabel.Size = new System.Drawing.Size(65, 15);
            accountantLabel.TabIndex = 0;
            accountantLabel.Text = "اسم الشركة:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(546, 55);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(70, 15);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "شعار الشركة:";
            // 
            // helperLabel
            // 
            helperLabel.AutoSize = true;
            helperLabel.Location = new System.Drawing.Point(546, 85);
            helperLabel.Name = "helperLabel";
            helperLabel.Size = new System.Drawing.Size(90, 15);
            helperLabel.TabIndex = 4;
            helperLabel.Text = "اسم مدير الشركة:";
            // 
            // logoIdLabel
            // 
            logoIdLabel.AutoSize = true;
            logoIdLabel.Location = new System.Drawing.Point(44, 17);
            logoIdLabel.Name = "logoIdLabel";
            logoIdLabel.Size = new System.Drawing.Size(68, 15);
            logoIdLabel.TabIndex = 6;
            logoIdLabel.Text = "لوغو الشركة:";
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Location = new System.Drawing.Point(546, 114);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new System.Drawing.Size(78, 15);
            managerLabel.TabIndex = 8;
            managerLabel.Text = "اسم المحاسب:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(334, 85);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(42, 15);
            phoneLabel.TabIndex = 14;
            phoneLabel.Text = "الهاتف:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(546, 143);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(73, 15);
            titleLabel.TabIndex = 16;
            titleLabel.Text = "عنوان الشركة:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(334, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 15);
            label1.TabIndex = 20;
            label1.Text = "الهاتف:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(546, 172);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(88, 15);
            label2.TabIndex = 22;
            label2.Text = "البريد الالكتروني:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(860, 343);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.SplitterWidth = 20;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(182, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Alver.Properties.Resources.settings;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "بيانات الشركة";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(658, 343);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.emailaddresstb);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.accountantphonetb);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.logopb);
            this.tabPage1.Controls.Add(accountantLabel);
            this.tabPage1.Controls.Add(this.titlelbl);
            this.tabPage1.Controls.Add(addressLabel);
            this.tabPage1.Controls.Add(this.mottolbl);
            this.tabPage1.Controls.Add(helperLabel);
            this.tabPage1.Controls.Add(this.managerlbl);
            this.tabPage1.Controls.Add(logoIdLabel);
            this.tabPage1.Controls.Add(managerLabel);
            this.tabPage1.Controls.Add(this.accountantlbl);
            this.tabPage1.Controls.Add(phoneLabel);
            this.tabPage1.Controls.Add(this.managerphonetb);
            this.tabPage1.Controls.Add(titleLabel);
            this.tabPage1.Controls.Add(this.addresslbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(650, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "بيانات الشركة";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // emailaddresstb
            // 
            this.emailaddresstb.Location = new System.Drawing.Point(173, 169);
            this.emailaddresstb.Name = "emailaddresstb";
            this.emailaddresstb.Size = new System.Drawing.Size(367, 23);
            this.emailaddresstb.TabIndex = 23;
            // 
            // accountantphonetb
            // 
            this.accountantphonetb.Location = new System.Drawing.Point(173, 111);
            this.accountantphonetb.Name = "accountantphonetb";
            this.accountantphonetb.Size = new System.Drawing.Size(155, 23);
            this.accountantphonetb.TabIndex = 21;
            this.accountantphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(8, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "حفظ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logopb
            // 
            this.logopb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logopb.Location = new System.Drawing.Point(8, 35);
            this.logopb.Name = "logopb";
            this.logopb.Size = new System.Drawing.Size(158, 157);
            this.logopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopb.TabIndex = 18;
            this.logopb.TabStop = false;
            this.logopb.DoubleClick += new System.EventHandler(this.logopb_DoubleClick);
            // 
            // titlelbl
            // 
            this.titlelbl.Location = new System.Drawing.Point(385, 19);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(155, 23);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mottolbl
            // 
            this.mottolbl.Location = new System.Drawing.Point(385, 52);
            this.mottolbl.Name = "mottolbl";
            this.mottolbl.Size = new System.Drawing.Size(155, 23);
            this.mottolbl.TabIndex = 3;
            this.mottolbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // managerlbl
            // 
            this.managerlbl.Location = new System.Drawing.Point(385, 82);
            this.managerlbl.Name = "managerlbl";
            this.managerlbl.Size = new System.Drawing.Size(155, 23);
            this.managerlbl.TabIndex = 5;
            this.managerlbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // accountantlbl
            // 
            this.accountantlbl.Location = new System.Drawing.Point(385, 111);
            this.accountantlbl.Name = "accountantlbl";
            this.accountantlbl.Size = new System.Drawing.Size(155, 23);
            this.accountantlbl.TabIndex = 9;
            this.accountantlbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // managerphonetb
            // 
            this.managerphonetb.Location = new System.Drawing.Point(173, 82);
            this.managerphonetb.Name = "managerphonetb";
            this.managerphonetb.Size = new System.Drawing.Size(155, 23);
            this.managerphonetb.TabIndex = 15;
            this.managerphonetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addresslbl
            // 
            this.addresslbl.Location = new System.Drawing.Point(173, 140);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(367, 23);
            this.addresslbl.TabIndex = 17;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(Alver.DAL.Company);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 343);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(876, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(876, 382);
            this.Name = "frmSettings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الإعدادت";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logopb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox titlelbl;
        private System.Windows.Forms.TextBox mottolbl;
        private System.Windows.Forms.TextBox managerlbl;
        private System.Windows.Forms.TextBox accountantlbl;
        private System.Windows.Forms.TextBox managerphonetb;
        private System.Windows.Forms.TextBox addresslbl;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.PictureBox logopb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox accountantphonetb;
        private System.Windows.Forms.TextBox emailaddresstb;
    }
}