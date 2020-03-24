using Alver.DAL;
using Alver.MISC;
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
        private bool _exchanged = false;

        private string _accountName = "";

        private int _billId = 0, _userId = 0, _currencyId = 0, _billLinesCount = 0;

        private bool _silentPrinting = false;

        public frmBillSlip(int BillId, int UserId, bool SilentPrinting = false)
        {
            try
            {
                InitializeComponent();
                _billId = BillId;
                _userId = UserId;
                using (dbEntities db = new dbEntities())
                {
                    int _accountId = db.Bills.Find(_billId).AccountId.Value;
                    if (_accountId == 0)
                    {
                        _accountName = "نقدي";
                    }
                    else
                    {
                        _accountName = db.Accounts.Find(_accountId).FullName;
                    }
                }
                _exchanged = (new dbEntities()).Bills.Find(_billId).Exchanged.Value;
                _billLinesCount = (new dbEntities()).Bills.Find(_billId).BillLines.Count;
                if (_exchanged)
                {
                    if ((new dbEntities()).Bills.Find(_billId).ForeginCurrencyId != null)
                    {
                        _currencyId = (new dbEntities()).Bills.Find(_billId).ForeginCurrencyId.Value;
                    }
                    else
                    {
                        _currencyId = 2;
                    }
                }
                else
                {
                    _currencyId = 1;
                }
                _silentPrinting = SilentPrinting;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void frmClientConformity_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                db.Images.Load();
                db.Bills.Load();
                db.Currencies.Load();
                db.Companies.Load();
                db.Users.Load();

                ImageBindingSource.DataSource = db.Images.Find(1);
                BillBindingSource.DataSource = db.Bills.FirstOrDefault(x => x.Id == _billId);
                CompanyBindingSource.DataSource = db.Companies.FirstOrDefault(x => x.Id == 1);
                UserBindingSource.DataSource = db.Users.FirstOrDefault(x => x.Id == _userId);
                BillSlip_ResultBindingSource.DataSource = db.BillSlip(_billId).ToList();
                CurrencyBindingSource.DataSource = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                if (_exchanged)
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = @"Alver.UI.Bills.BillReports.SYPBillSlip.rdlc";
                }
                else
                {
                    this.reportViewer1.LocalReport.ReportEmbeddedResource = @"Alver.UI.Bills.BillReports.USDBillSlip.rdlc";
                }
                ReportParameter _para = new ReportParameter("AccountName", _accountName);
                this.reportViewer1.LocalReport.SetParameters(_para);
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