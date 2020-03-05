using Alver.DAL;
using Alver.MISC;
using Alver.UI.Bills.BillReports;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.Utilities;

namespace Alver.UI.Bills
{
    public partial class frmBillMangement : Form
    {
        #region Variables

        private bool _sellBillschk = false,
            _purchaseBillschk = false,
            _checkedoutBillschk = false,
            _nonecheckedBillschk = false,
            _billIdchk = false,
            _itemIdchk = false;

        #endregion Variables

        #region Init

        public frmBillMangement()
        {
            InitializeComponent();
        }

        private void frmIncomes_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                db.Bills.AsNoTracking().Load();
                db.Items.AsNoTracking().Load();
                //db.Items.AsNoTracking().Load();
                billIdBS.DataSource = db.Bills.AsNoTracking().AsQueryable().ToList();
                itemIdBS.DataSource = db.Items.AsNoTracking().AsQueryable().ToList();
            }
        }

        #endregion Init

        #region Funcs

        private void PrintBillSlip(bool _silent = false)
        {
            int _billId, _userId;
            _billId = (BillsBS.Current as Bill).Id;
            _userId = Properties.Settings.Default.LoggedInUser.Id;
            frmBillSlip frm = new frmBillSlip(_billId, _userId, _silent);
            frm.ShowDialog();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                BillLinesBS.DataSource = BillsBS;
                billlinebasecurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                billbasecurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                billforeigncurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                billlineforeigncurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                billuserBS.DataSource = db.Users.AsQueryable().AsNoTracking().ToList();
                billlineuserBS.DataSource = db.Users.AsQueryable().AsNoTracking().ToList();
                billlineunitBS.DataSource = db.Units.AsQueryable().AsNoTracking().ToList();
                billlineitemBS.DataSource = db.Items.AsQueryable().AsNoTracking().ToList();
            }
        }

        //_from, _to, _billId, _itemId,  _sellBill, _PurchaseBill, _checkedout, _nonecheckedout
        private IQueryable<Bill> GrandSearch(DateTime _from, DateTime _to, int _billId, int _itemId, string _sellBill, string _PurchaseBill, bool _checkedout, bool _nonecheckedout)
        {
            IQueryable<Bill> _query = null;// = new IQueryable<Remittances_Operation>;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _query = db.Bills as IQueryable<Bill>;
                    if (_from.Year == _to.Year && _from.Month == _to.Month)
                    {
                        _query = db.Bills.Where(
                                x => ((x.BillDate.Value.Year >= _from.Year && x.BillDate.Value.Year <= _to.Year) &&
                                    (x.BillDate.Value.Month >= _from.Month && x.BillDate.Value.Month <= _to.Month) &&
                                    (x.BillDate.Value.Day >= _from.Day && x.BillDate.Value.Day <= _to.Day)
                                    ) &&
                            (
                                (x.BillType == _sellBill && _sellBill != null) ||
                                (x.BillType == _PurchaseBill && _PurchaseBill != null)
                            )
                            ).Include(x => x.BillLines).AsQueryable();
                    }
                    else if (_from.Year != _to.Year)
                    {
                        _query = db.Bills.Where(
                            x => x.BillDate.Value.Year >= _from.Year && x.BillDate.Value.Year <= _to.Year &&
                            (
                                (x.BillType == _sellBill && _sellBill != null) ||
                                (x.BillType == _PurchaseBill && _PurchaseBill != null)
                            )
                            ).Include(x => x.BillLines).AsQueryable();
                    }
                    else if (_from.Year == _to.Year && _from.Month != _to.Month)
                    {
                        _query = db.Bills.Where(
                            x => ((x.BillDate.Value.Year >= _from.Year && x.BillDate.Value.Year <= _to.Year) &&
                            (x.BillDate.Value.Month >= _from.Month && x.BillDate.Value.Month <= _to.Month)) &&
                            (
                                (x.BillType == _sellBill && _sellBill != null) ||
                                (x.BillType == _PurchaseBill && _PurchaseBill != null)
                            )
                            ).Include(x => x.BillLines).AsQueryable();
                    }
                    if (_checkedout && !_nonecheckedout)
                    {
                        _query = _query.Where(x => x.CheckedOut == true);
                    }
                    else if (!_checkedout && _nonecheckedout)
                    {
                        _query = _query.Where(x => x.CheckedOut == false);
                    }
                    if (_billId != 0)
                    {
                        _query = _query.Where(x => x.Id == _billId);
                    }
                    if (_itemId != 0)
                    {
                        _query = _query.Where(x => x.CurrencyId == _itemId);
                    }

                    BillsBS.DataSource = _query.ToList();
                }
                //LoadData();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }

            return _query;
        }

        private void InitChecks()
        {
            _billIdchk = billidchkbox.Checked;
            _itemIdchk = itemchkbox.Checked;
            _sellBillschk = sellbillchkbox.Checked;
            _purchaseBillschk = purchasebillchkbox.Checked;
            _checkedoutBillschk = billcheckedoutchkbox.Checked;
            _nonecheckedBillschk = nonetcheckedoutbillchkbox.Checked;
        }

        private void Retrive()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LoadData();
                DateTime _from, _to;
                string _sellBill = null, _PurchaseBill = null;// _outer = null;
                int _billId = 0;
                int _itemId = 0;//, _accountId = 0;//, _fromClient = 0, _toClient = 0;
                InitChecks();
                if (FromDateTimePicker.Checked)
                {
                    _from = FromDateTimePicker.Value;
                }
                else
                {
                    _from = DateTime.MinValue;
                }
                _to = ToDateTimePicker.Value;

                if (_billIdchk)
                {
                    _billId = (int)billidcb.SelectedValue;
                }
                if (_itemIdchk)
                {
                    _itemId = (int)itemcb.SelectedValue;
                }
                if (_sellBillschk && _purchaseBillschk)
                {
                    _sellBill = BillType.بيع.ToString();
                    _PurchaseBill = BillType.شراء.ToString();
                }
                else if (_sellBillschk)
                {
                    _sellBill = BillType.بيع.ToString();
                }
                else if (_purchaseBillschk)
                {
                    _PurchaseBill = BillType.شراء.ToString();
                }
                GrandSearch(_from, _to, _billId, _itemId, _sellBill, _PurchaseBill, _checkedoutBillschk, _nonecheckedBillschk);
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        #endregion Funcs

        #region Form Events

        //DGVs
        private void billsdgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        //CHECKBOXES
        private void sellbillchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _sellBillschk = sellbillchkbox.Checked;
        }

        private void billidchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _billIdchk = billidchkbox.Checked;
            billidcb.Enabled = billidchkbox.Checked;
        }

        private void purchasebillchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _purchaseBillschk = purchasebillchkbox.Checked;
        }

        private void billcheckedoutchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _checkedoutBillschk = billcheckedoutchkbox.Checked;
        }

        private void notcheckedoutbillchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _nonecheckedBillschk = nonetcheckedoutbillchkbox.Checked;
        }

        private void itemchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _itemIdchk = itemchkbox.Checked;
            itemcb.Enabled = itemchkbox.Checked;
        }

        #endregion Form Events

        #region Buttons Clicks

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Retrive();
        }

        #endregion Buttons Clicks
    }
}