namespace Alver.UI.Bills.BillReports
{
    partial class frmBillSlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillSlip));
            this.exitbtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CurrencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BillSlip_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSlip_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitbtn.Location = new System.Drawing.Point(0, 470);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(300, 30);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "تــــــــــــــــــــــم";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alver.UI.Bills.BillReports.BillSlip.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(300, 470);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // CurrencyBindingSource
            // 
            this.CurrencyBindingSource.DataSource = typeof(Alver.DAL.Currency);
            // 
            // BillSlip_ResultBindingSource
            // 
            this.BillSlip_ResultBindingSource.DataSource = typeof(Alver.DAL.BillSlip_Result);
            // 
            // frmBillSlip
            // 
            this.AcceptButton = this.exitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 500);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.exitbtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBillSlip";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إشعار مطابقة رصيد";
            this.Load += new System.EventHandler(this.frmClientConformity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BillSlip_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CurrencyBindingSource;
        private System.Windows.Forms.BindingSource BillSlip_ResultBindingSource;
    }
}
