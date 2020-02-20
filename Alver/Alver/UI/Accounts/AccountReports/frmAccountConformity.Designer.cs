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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountConformity));
            this.Accounts_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientGrand_ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exitbtn = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrand_ResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Accounts_InfoBindingSource
            // 
            this.Accounts_InfoBindingSource.DataSource = typeof(DAL.Account);
            // 
            // ClientGrand_ResultBindingSource
            // 
            this.ClientGrand_ResultBindingSource.DataSource = typeof(DAL.SP_ClientGrand_Result);
            // 
            // exitbtn
            // 
            this.exitbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitbtn.Location = new System.Drawing.Point(0, 570);
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
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Accounts_InfoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.ClientGrand_ResultBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Al_Barakat.PL.Client.ClientReports.ClientConformity.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(400, 570);
            this.reportViewer1.TabIndex = 3;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // frmClientConformity
            // 
            this.AcceptButton = this.exitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.exitbtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientConformity";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إشعار مطابقة رصيد";
            this.Load += new System.EventHandler(this.frmClientConformity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Accounts_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGrand_ResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.BindingSource Accounts_InfoBindingSource;
        private System.Windows.Forms.BindingSource ClientGrand_ResultBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
