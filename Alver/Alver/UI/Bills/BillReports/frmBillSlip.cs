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

        private string _accountName = "", _billAmount = "0", _billType = "";
        private DateTime _billDate = DateTime.Now;
        private int _billId = 0, _userId = 0, _currencyId = 0, _billLinesCount = 0;

        private bool _silentPrinting = false;

        public frmBillSlip(int BillId, int UserId, bool SilentPrinting = false)
        {
            try
            {
                InitializeComponent();
                _billId = BillId;
                _userId = UserId;
                using (dbEntities db = new dbEntities(0))
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
                    _billAmount = db.Bills.Find(_billId).TotalAmount.Value.ToString();
                    _billDate = db.Bills.Find(_billId).BillDate.Value;
                    _billType = db.Bills.Find(_billId).BillType;
                    _currencyId = db.Bills.Find(_billId).CurrencyId.Value;
                }
                _billLinesCount = (new dbEntities(0)).Bills.Find(_billId).BillLines.Count;

                _silentPrinting = SilentPrinting;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void frmClientConformity_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Currencies.Load();

                BillSlip_ResultBindingSource.DataSource = db.BillSlip(_billId).ToList();
                CurrencyBindingSource.DataSource = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                //this.reportViewer1.LocalReport.ReportEmbeddedResource = @"Alver.UI.Bills.BillReports.BillSlip.rdlc";
                ReportParameter[] parameters = new ReportParameter[5];
                parameters[0] = new ReportParameter("AccountName", _accountName);
                parameters[1] = new ReportParameter("BillId", _billId.ToString());
                parameters[2] = new ReportParameter("BillDate", _billDate.ToString());
                parameters[3] = new ReportParameter("BillAmount", _billAmount);
                parameters[4] = new ReportParameter("BillType", _billType);
                this.reportViewer1.LocalReport.SetParameters(parameters);
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