using Alver.DAL;
using Microsoft.Reporting.WinForms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Bills.BillReports
{
    public partial class frmBillSlip : Form
    {
        //dbEntities db;
        int _billId, _userId;
        bool _silentPrinting = false;
        public frmBillSlip(int BillId,int UserId,bool SilentPrinting=false)
        {
            InitializeComponent();
            _billId =BillId;
            _userId = UserId;
            _silentPrinting = SilentPrinting;
        }

        private void frmClientConformity_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                db.Images.Load();
                db.Bills.Load();
                db.Companies.Load();
                db.Users.Load();
                ImageBindingSource.DataSource = db.Images.Find(1);
                BillBindingSource.DataSource = db.Bills.FirstOrDefault(x => x.Id == _billId);
                CompanyBindingSource.DataSource = db.Companies.FirstOrDefault(x => x.Id == 1);
                UserBindingSource.DataSource = db.Users.FirstOrDefault(x => x.Id == _userId);
                BillSlip_ResultBindingSource.DataSource = db.BillSlip(_billId).ToList();
                this.reportViewer1.RefreshReport();
                if (_silentPrinting)
                {
                    this.reportViewer1.LocalReport.Print();
                    this.Close();
                }

            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
