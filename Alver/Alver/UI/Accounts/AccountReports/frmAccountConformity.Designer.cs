namespace Alver.UI.Accounts.AccountReports
{
    partial class frmAccountConformity
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountConformity));
            this.SP_ClientGrand_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ImageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitbtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ClientGrand_ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_ClientGrand_ResultBindingSource
            // 
            this.SP_ClientGrand_ResultBindingSource.DataMember = "SP_ClientGrand_Result";
            // 
            // AccountBindingSource
            // 
            this.AccountBindingSource.DataSource = typeof(Alver.DAL.Account);
            // 
            // CompanyBindingSource
            // 
            this.CompanyBindingSource.DataSource = typeof(Alver.DAL.Company);
            // 
            // ImageBindingSource
            // 
            this.ImageBindingSource.DataSource = typeof(Alver.DAL.Image);
            // 
            // exitbtn
            // 
            this.exitbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitbtn.Location = new System.Drawing.Point(0, 470);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(400, 30);
            this.exitbtn.TabIndex = 2;
            this.exitbtn.Text = "تــــــــــــــــــــــم";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "AccounFunds";
            reportDataSource1.Value = this.SP_ClientGrand_ResultBindingSource;
            reportDataSource2.Name = "AccountDS";
            reportDataSource2.Value = this.AccountBindingSource;
            reportDataSource3.Name = "CompanyInfo";
            reportDataSource3.Value = this.CompanyBindingSource;
            reportDataSource4.Name = "ImageDS";
            reportDataSource4.Value = this.ImageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Alver.UI.Accounts.AccountReports.ClientConformity.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(400, 470);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // frmAccountConformity
            // 
            this.AcceptButton = this.exitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.exitbtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountConformity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إشعار مطابقة رصيد";
            this.Load += new System.EventHandler(this.frmClientConformity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ClientGrand_ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SP_ClientGrand_ResultBindingSource;
        private System.Windows.Forms.BindingSource ImageBindingSource;
        private System.Windows.Forms.BindingSource AccountBindingSource;
        private System.Windows.Forms.BindingSource CompanyBindingSource;
    }
}
