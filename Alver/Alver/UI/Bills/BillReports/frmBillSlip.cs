using Alver.DAL;
using Alver.MISC;
using Microsoft.Reporting.WinForms;
//using Microsoft.Reporting.WinForms;
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

        private string _accountName = "", _billAmount = "0", _billType = "", _billFooter = "",_companyName="";
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
                    _exchanged = db.Bills.Find(_billId).Exchanged.Value;
                    _billAmount = db.Bills.Find(_billId).TotalAmount.Value.ToString();
                    if (_exchanged)
                    {
                        decimal _temp = Convert.ToDecimal(_billAmount);
                        _billAmount = Math.Round(_temp, 0).ToString();
                    }
                    else
                    {
                        decimal _temp = Convert.ToDecimal(_billAmount);
                        _billAmount = Math.Round(_temp, 2).ToString();
                    }
                    _billDate = db.Bills.Find(_billId).BillDate.Value;
                    if (db.Bills.Find(_billId).BillType == MISC.Utilities.BillType.بيع.ToString())
                    {
                        _billType = "فاتورة بيع";
                    }
                    else if (db.Bills.Find(_billId).BillType == MISC.Utilities.BillType.شراء.ToString())
                    {
                        _billType = "فاتورة شراء";
                    }
                    else if (db.Bills.Find(_billId).BillType == MISC.Utilities.BillType.مرتجع.ToString())
                    {
                        _billType = "فاتورة مرتجع";
                    }
                    _currencyId = db.Bills.Find(_billId).CurrencyId.Value;
                    _companyName = db.Companies.Find(1).Title;
                    _billFooter = db.Companies.Find(1).Address
                                    + " - "
                                    + db.Companies.Find(1).ManagerPhone;
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
                //CurrencyBindingSource.DataSource = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                //this.reportViewer1.LocalReport.ReportEmbeddedResource = @"Alver.UI.Bills.BillReports.BillSlip.rdlc";
                ReportParameter[] parameters = new ReportParameter[7];
                //parameters[0] = new ReportParameter("AccountName", _accountName);
                parameters[0] = new ReportParameter("BillId", _billId.ToString());
                parameters[1] = new ReportParameter("BillDate", _billDate.ToString());
                parameters[2] = new ReportParameter("BillAmount", _billAmount);
                parameters[3] = new ReportParameter("BillType", _billType);
                parameters[4] = new ReportParameter("Exchanged", _exchanged.ToString());
                parameters[5] = new ReportParameter("CompanyName", _companyName);
                parameters[6] = new ReportParameter("BillFooter", _billFooter);
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
                if (_silentPrinting)
                {
                    this.reportViewer1.LocalReport.Print();
                    this.Close();
                }
            }
            //this.reportViewer1.RefreshReport();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}