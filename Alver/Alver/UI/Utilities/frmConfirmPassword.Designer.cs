namespace Alver.UI.Utilities
{
    partial class frmConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmPassword));
            this.newPasstb = new System.Windows.Forms.MaskedTextBox();
            this.renewPasstb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPasstb
            // 
            this.newPasstb.Location = new System.Drawing.Point(12, 79);
            this.newPasstb.Name = "newPasstb";
            this.newPasstb.PasswordChar = '*';
            this.newPasstb.Size = new System.Drawing.Size(283, 27);
            this.newPasstb.TabIndex = 2;
            this.newPasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newPasstb.UseSystemPasswordChar = true;
            // 
            // renewPasstb
            // 
            this.renewPasstb.Location = new System.Drawing.Point(12, 144);
            this.renewPasstb.Name = "renewPasstb";
            this.renewPasstb.PasswordChar = '*';
            this.renewPasstb.Size = new System.Drawing.Size(283, 27);
            this.renewPasstb.TabIndex = 3;
            this.renewPasstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.renewPasstb.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "كلمة المرور:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "أعد كتابة كلمة المرور:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(158, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Location = new System.Drawing.Point(36, 245);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(101, 35);
            this.btnLogIn.TabIndex = 15;
            this.btnLogIn.Text = "تأكيد";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.usernamelbl.Location = new System.Drawing.Point(12, 9);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(244, 20);
            this.usernamelbl.TabIndex = 17;
            this.usernamelbl.Text = "ادخل كلمة سر المسؤول لتأكيد العملية";
            // 
            // frmConfirmPassword
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(303, 287);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.renewPasstb);
            this.Controls.Add(this.newPasstb);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmConfirmPassword";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغيير كلمة المرور";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox newPasstb;
        private System.Windows.Forms.MaskedTextBox renewPasstb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label usernamelbl;
    }
}