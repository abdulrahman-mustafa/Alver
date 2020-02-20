namespace Alver.UI.Users
{
    partial class frmUser
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label senderIdLabel;
            System.Windows.Forms.Label fatherLabel;
            System.Windows.Forms.Label motherLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.addbtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.savebtn = new System.Windows.Forms.ToolStripButton();
            this.infogroupBox = new System.Windows.Forms.GroupBox();
            this.rolescb = new System.Windows.Forms.ComboBox();
            this.notestextBox = new System.Windows.Forms.TextBox();
            this.fullnametb = new System.Windows.Forms.ComboBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.passwordconfirmtb = new System.Windows.Forms.TextBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            senderIdLabel = new System.Windows.Forms.Label();
            fatherLabel = new System.Windows.Forms.Label();
            motherLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.infogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.addbtn,
            this.toolStripSeparator3,
            this.savebtn});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 270);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(435, 27);
            this.bindingNavigator2.TabIndex = 37;
            // 
            // addbtn
            // 
            this.addbtn.Name = "addbtn";
            this.addbtn.RightToLeftAutoMirrorImage = true;
            this.addbtn.Size = new System.Drawing.Size(72, 24);
            this.addbtn.Text = "إضافة";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // savebtn
            // 
            this.savebtn.Enabled = false;
            this.savebtn.Name = "savebtn";
            this.savebtn.RightToLeftAutoMirrorImage = true;
            this.savebtn.Size = new System.Drawing.Size(63, 24);
            this.savebtn.Text = "حفظ";
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // infogroupBox
            // 
            this.infogroupBox.Controls.Add(this.passwordconfirmtb);
            this.infogroupBox.Controls.Add(label3);
            this.infogroupBox.Controls.Add(label2);
            this.infogroupBox.Controls.Add(this.rolescb);
            this.infogroupBox.Controls.Add(label1);
            this.infogroupBox.Controls.Add(this.notestextBox);
            this.infogroupBox.Controls.Add(this.fullnametb);
            this.infogroupBox.Controls.Add(senderIdLabel);
            this.infogroupBox.Controls.Add(this.usernametb);
            this.infogroupBox.Controls.Add(fatherLabel);
            this.infogroupBox.Controls.Add(this.passwordtb);
            this.infogroupBox.Controls.Add(motherLabel);
            this.infogroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.infogroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infogroupBox.Location = new System.Drawing.Point(0, 0);
            this.infogroupBox.Name = "infogroupBox";
            this.infogroupBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infogroupBox.Size = new System.Drawing.Size(435, 232);
            this.infogroupBox.TabIndex = 38;
            this.infogroupBox.TabStop = false;
            this.infogroupBox.Text = "بيانات المستخدم";
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(311, 63);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 46;
            label2.Text = "نوع المستخدم:";
            // 
            // rolescb
            // 
            this.rolescb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rolescb.DataSource = this.roleBindingSource;
            this.rolescb.DisplayMember = "RoleTitle";
            this.rolescb.FormattingEnabled = true;
            this.rolescb.Location = new System.Drawing.Point(134, 60);
            this.rolescb.Name = "rolescb";
            this.rolescb.Size = new System.Drawing.Size(171, 28);
            this.rolescb.TabIndex = 45;
            this.rolescb.ValueMember = "Id";
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(350, 196);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 20);
            label1.TabIndex = 44;
            label1.Text = "الملاحظات:";
            // 
            // notestextBox
            // 
            this.notestextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notestextBox.Location = new System.Drawing.Point(13, 193);
            this.notestextBox.Name = "notestextBox";
            this.notestextBox.Size = new System.Drawing.Size(292, 27);
            this.notestextBox.TabIndex = 9;
            // 
            // fullnametb
            // 
            this.fullnametb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullnametb.BackColor = System.Drawing.SystemColors.Info;
            this.fullnametb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullnametb.FormattingEnabled = true;
            this.fullnametb.Location = new System.Drawing.Point(13, 26);
            this.fullnametb.Name = "fullnametb";
            this.fullnametb.Size = new System.Drawing.Size(292, 28);
            this.fullnametb.TabIndex = 0;
            // 
            // senderIdLabel
            // 
            senderIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            senderIdLabel.AutoSize = true;
            senderIdLabel.Location = new System.Drawing.Point(331, 29);
            senderIdLabel.Name = "senderIdLabel";
            senderIdLabel.Size = new System.Drawing.Size(47, 20);
            senderIdLabel.TabIndex = 17;
            senderIdLabel.Text = "الاسم:";
            // 
            // usernametb
            // 
            this.usernametb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernametb.Location = new System.Drawing.Point(134, 94);
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(171, 27);
            this.usernametb.TabIndex = 1;
            // 
            // fatherLabel
            // 
            fatherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            fatherLabel.AutoSize = true;
            fatherLabel.Location = new System.Drawing.Point(311, 97);
            fatherLabel.Name = "fatherLabel";
            fatherLabel.Size = new System.Drawing.Size(104, 20);
            fatherLabel.TabIndex = 38;
            fatherLabel.Text = "اسم المستخدم:";
            // 
            // passwordtb
            // 
            this.passwordtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordtb.Location = new System.Drawing.Point(134, 127);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(171, 27);
            this.passwordtb.TabIndex = 2;
            // 
            // motherLabel
            // 
            motherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            motherLabel.AutoSize = true;
            motherLabel.Location = new System.Drawing.Point(311, 130);
            motherLabel.Name = "motherLabel";
            motherLabel.Size = new System.Drawing.Size(83, 20);
            motherLabel.TabIndex = 39;
            motherLabel.Text = "كلمة المرور:";
            // 
            // passwordconfirmtb
            // 
            this.passwordconfirmtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordconfirmtb.Location = new System.Drawing.Point(134, 160);
            this.passwordconfirmtb.Name = "passwordconfirmtb";
            this.passwordconfirmtb.PasswordChar = '*';
            this.passwordconfirmtb.Size = new System.Drawing.Size(171, 27);
            this.passwordconfirmtb.TabIndex = 47;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(311, 163);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 20);
            label3.TabIndex = 48;
            label3.Text = "تأكيد كلمة المرور:";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(DAL.Role);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(435, 297);
            this.Controls.Add(this.infogroupBox);
            this.Controls.Add(this.bindingNavigator2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مستخدم";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.infogroupBox.ResumeLayout(false);
            this.infogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton addbtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton savebtn;
        private System.Windows.Forms.GroupBox infogroupBox;
        private System.Windows.Forms.ComboBox rolescb;
        private System.Windows.Forms.TextBox notestextBox;
        private System.Windows.Forms.ComboBox fullnametb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox passwordconfirmtb;
        private System.Windows.Forms.BindingSource roleBindingSource;
    }
}