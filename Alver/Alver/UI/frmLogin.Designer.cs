namespace Alver.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.backPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.frontleftpanel = new System.Windows.Forms.Panel();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.leftPanel.SuspendLayout();
            this.frontleftpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.backPanel.Controls.Add(this.label3);
            this.backPanel.Controls.Add(this.pictureBox2);
            this.backPanel.Controls.Add(this.label2);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backPanel.Location = new System.Drawing.Point(317, 372);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(496, 139);
            this.backPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(144, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "جميع الحقوق محفوظة لصالح المبرمج";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Alver.Properties.Resources.loginlock;
            this.pictureBox2.Location = new System.Drawing.Point(181, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "برمجة وتصميم: عبدالرحمن مصطفى";
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.Aqua;
            this.leftPanel.Controls.Add(this.frontleftpanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(317, 511);
            this.leftPanel.TabIndex = 1;
            // 
            // frontleftpanel
            // 
            this.frontleftpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.frontleftpanel.Controls.Add(this.cancelbtn);
            this.frontleftpanel.Controls.Add(this.label1);
            this.frontleftpanel.Controls.Add(this.label4);
            this.frontleftpanel.Controls.Add(this.loginbtn);
            this.frontleftpanel.Controls.Add(this.pictureBox1);
            this.frontleftpanel.Controls.Add(this.passwordtb);
            this.frontleftpanel.Controls.Add(this.usernametb);
            this.frontleftpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.frontleftpanel.Location = new System.Drawing.Point(7, 0);
            this.frontleftpanel.Name = "frontleftpanel";
            this.frontleftpanel.Size = new System.Drawing.Size(310, 511);
            this.frontleftpanel.TabIndex = 2;
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.FlatAppearance.BorderSize = 0;
            this.cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbtn.Location = new System.Drawing.Point(91, 395);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(134, 52);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "خروج";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(75, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "تسجيل الدخول";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(185, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "البيانات الافتراضية:\r\nاسم المستخدم: المدير\r\nكلمة المرور: 12345";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginbtn.FlatAppearance.BorderSize = 0;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Location = new System.Drawing.Point(91, 337);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(134, 52);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "دخول";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Alver.Properties.Resources.loginlock;
            this.pictureBox1.Location = new System.Drawing.Point(111, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.passwordtb.Location = new System.Drawing.Point(35, 269);
            this.passwordtb.Multiline = true;
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(239, 40);
            this.passwordtb.TabIndex = 1;
            this.passwordtb.Text = "0";
            this.passwordtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernametb
            // 
            this.usernametb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.usernametb.Location = new System.Drawing.Point(35, 223);
            this.usernametb.Multiline = true;
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(239, 40);
            this.usernametb.TabIndex = 0;
            this.usernametb.Text = "0";
            this.usernametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(526, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = "ALVER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(529, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "لنقاط البيع";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(813, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.frontleftpanel.ResumeLayout(false);
            this.frontleftpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel frontleftpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}