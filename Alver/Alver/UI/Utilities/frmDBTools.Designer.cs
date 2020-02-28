namespace Alver.UI.Utilities
{
    partial class frmDBTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBTools));
            this.serverscb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getserversbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.databasescb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.useridtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.sqlauthenticationrb = new System.Windows.Forms.RadioButton();
            this.windowsauthenticationrb = new System.Windows.Forms.RadioButton();
            this.testconnectionbtn = new System.Windows.Forms.Button();
            this.createdatabasebtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.databasenametb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.browsebtn = new System.Windows.Forms.Button();
            this.pathtb = new System.Windows.Forms.TextBox();
            this.execscriptbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.connectionstringtb = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverscb
            // 
            this.serverscb.FormattingEnabled = true;
            this.serverscb.Location = new System.Drawing.Point(75, 16);
            this.serverscb.Name = "serverscb";
            this.serverscb.Size = new System.Drawing.Size(121, 23);
            this.serverscb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // getserversbtn
            // 
            this.getserversbtn.Location = new System.Drawing.Point(202, 15);
            this.getserversbtn.Name = "getserversbtn";
            this.getserversbtn.Size = new System.Drawing.Size(106, 23);
            this.getserversbtn.TabIndex = 2;
            this.getserversbtn.Text = "Get Servers";
            this.getserversbtn.UseVisualStyleBackColor = true;
            this.getserversbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Databases:";
            // 
            // databasescb
            // 
            this.databasescb.FormattingEnabled = true;
            this.databasescb.Location = new System.Drawing.Point(75, 45);
            this.databasescb.Name = "databasescb";
            this.databasescb.Size = new System.Drawing.Size(121, 23);
            this.databasescb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Databases";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // useridtb
            // 
            this.useridtb.Location = new System.Drawing.Point(75, 124);
            this.useridtb.Name = "useridtb";
            this.useridtb.ReadOnly = true;
            this.useridtb.Size = new System.Drawing.Size(121, 23);
            this.useridtb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(75, 153);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.ReadOnly = true;
            this.passwordtb.Size = new System.Drawing.Size(121, 23);
            this.passwordtb.TabIndex = 8;
            // 
            // sqlauthenticationrb
            // 
            this.sqlauthenticationrb.AutoSize = true;
            this.sqlauthenticationrb.Location = new System.Drawing.Point(75, 99);
            this.sqlauthenticationrb.Name = "sqlauthenticationrb";
            this.sqlauthenticationrb.Size = new System.Drawing.Size(163, 19);
            this.sqlauthenticationrb.TabIndex = 10;
            this.sqlauthenticationrb.Text = "SQL Server Authentication";
            this.sqlauthenticationrb.UseVisualStyleBackColor = true;
            this.sqlauthenticationrb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // windowsauthenticationrb
            // 
            this.windowsauthenticationrb.AutoSize = true;
            this.windowsauthenticationrb.Checked = true;
            this.windowsauthenticationrb.Location = new System.Drawing.Point(75, 74);
            this.windowsauthenticationrb.Name = "windowsauthenticationrb";
            this.windowsauthenticationrb.Size = new System.Drawing.Size(156, 19);
            this.windowsauthenticationrb.TabIndex = 11;
            this.windowsauthenticationrb.TabStop = true;
            this.windowsauthenticationrb.Text = "Windows Authentication";
            this.windowsauthenticationrb.UseVisualStyleBackColor = true;
            // 
            // testconnectionbtn
            // 
            this.testconnectionbtn.Location = new System.Drawing.Point(75, 182);
            this.testconnectionbtn.Name = "testconnectionbtn";
            this.testconnectionbtn.Size = new System.Drawing.Size(121, 23);
            this.testconnectionbtn.TabIndex = 12;
            this.testconnectionbtn.Text = "Test Connection";
            this.testconnectionbtn.UseVisualStyleBackColor = true;
            this.testconnectionbtn.Click += new System.EventHandler(this.testconnectionbtn_Click);
            // 
            // createdatabasebtn
            // 
            this.createdatabasebtn.Location = new System.Drawing.Point(172, 51);
            this.createdatabasebtn.Name = "createdatabasebtn";
            this.createdatabasebtn.Size = new System.Drawing.Size(121, 23);
            this.createdatabasebtn.TabIndex = 15;
            this.createdatabasebtn.Text = "Create Database";
            this.createdatabasebtn.UseVisualStyleBackColor = true;
            this.createdatabasebtn.Click += new System.EventHandler(this.createdatabasebtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Database Name:";
            // 
            // databasenametb
            // 
            this.databasenametb.Location = new System.Drawing.Point(108, 22);
            this.databasenametb.Name = "databasenametb";
            this.databasenametb.Size = new System.Drawing.Size(185, 23);
            this.databasenametb.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.databasenametb);
            this.groupBox1.Controls.Add(this.createdatabasebtn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create new database";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.browsebtn);
            this.groupBox2.Controls.Add(this.pathtb);
            this.groupBox2.Controls.Add(this.execscriptbtn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 83);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Execute script";
            // 
            // browsebtn
            // 
            this.browsebtn.Location = new System.Drawing.Point(262, 21);
            this.browsebtn.Name = "browsebtn";
            this.browsebtn.Size = new System.Drawing.Size(31, 23);
            this.browsebtn.TabIndex = 16;
            this.browsebtn.Text = "...";
            this.browsebtn.UseVisualStyleBackColor = true;
            this.browsebtn.Click += new System.EventHandler(this.browsebtn_Click);
            // 
            // pathtb
            // 
            this.pathtb.Location = new System.Drawing.Point(82, 22);
            this.pathtb.Name = "pathtb";
            this.pathtb.Size = new System.Drawing.Size(174, 23);
            this.pathtb.TabIndex = 13;
            // 
            // execscriptbtn
            // 
            this.execscriptbtn.Location = new System.Drawing.Point(172, 54);
            this.execscriptbtn.Name = "execscriptbtn";
            this.execscriptbtn.Size = new System.Drawing.Size(121, 23);
            this.execscriptbtn.TabIndex = 15;
            this.execscriptbtn.Text = "Execute Script";
            this.execscriptbtn.UseVisualStyleBackColor = true;
            this.execscriptbtn.Click += new System.EventHandler(this.execscriptbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Script Path:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.serverscb);
            this.groupBox3.Controls.Add(this.getserversbtn);
            this.groupBox3.Controls.Add(this.testconnectionbtn);
            this.groupBox3.Controls.Add(this.databasescb);
            this.groupBox3.Controls.Add(this.windowsauthenticationrb);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.sqlauthenticationrb);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.useridtb);
            this.groupBox3.Controls.Add(this.passwordtb);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(16, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 216);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.connectionstringtb);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 403);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 110);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connection string";
            // 
            // connectionstringtb
            // 
            this.connectionstringtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectionstringtb.Location = new System.Drawing.Point(3, 19);
            this.connectionstringtb.Name = "connectionstringtb";
            this.connectionstringtb.ReadOnly = true;
            this.connectionstringtb.Size = new System.Drawing.Size(347, 88);
            this.connectionstringtb.TabIndex = 17;
            this.connectionstringtb.Text = "";
            // 
            // frmDBTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 513);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(369, 600);
            this.MinimumSize = new System.Drawing.Size(369, 525);
            this.Name = "frmDBTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL SERVER DATABASE TOOls";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox serverscb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getserversbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox databasescb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox useridtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.RadioButton sqlauthenticationrb;
        private System.Windows.Forms.RadioButton windowsauthenticationrb;
        private System.Windows.Forms.Button testconnectionbtn;
        private System.Windows.Forms.Button createdatabasebtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox databasenametb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browsebtn;
        private System.Windows.Forms.TextBox pathtb;
        private System.Windows.Forms.Button execscriptbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox connectionstringtb;
    }
}