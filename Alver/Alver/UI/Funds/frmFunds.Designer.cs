
namespace Alver.UI.Funds
{
    partial class frmFunds
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
            this.Fundsdgv = new System.Windows.Forms.DataGridView();
            this.fundstimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotals = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fundsdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Fundsdgv
            // 
            this.Fundsdgv.AllowUserToAddRows = false;
            this.Fundsdgv.AllowUserToDeleteRows = false;
            this.Fundsdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Fundsdgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Fundsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fundsdgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Fundsdgv.GridColor = System.Drawing.Color.Coral;
            this.Fundsdgv.Location = new System.Drawing.Point(0, 34);
            this.Fundsdgv.MultiSelect = false;
            this.Fundsdgv.Name = "Fundsdgv";
            this.Fundsdgv.ReadOnly = true;
            this.Fundsdgv.RowHeadersVisible = false;
            this.Fundsdgv.RowHeadersWidth = 51;
            this.Fundsdgv.RowTemplate.Height = 24;
            this.Fundsdgv.Size = new System.Drawing.Size(606, 150);
            this.Fundsdgv.TabIndex = 3;
            // 
            // fundstimer
            // 
            this.fundstimer.Interval = 1000;
            this.fundstimer.Tick += new System.EventHandler(this.fundstimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "الرصيد العام";
            // 
            // lblTotals
            // 
            this.lblTotals.AutoSize = true;
            this.lblTotals.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotals.Location = new System.Drawing.Point(122, 4);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(40, 27);
            this.lblTotals.TabIndex = 5;
            this.lblTotals.Text = "0.0";
            // 
            // frmFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(606, 184);
            this.Controls.Add(this.lblTotals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fundsdgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFunds";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الارصدة";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFunds_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Fundsdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Fundsdgv;
        private System.Windows.Forms.Timer fundstimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotals;
    }
}