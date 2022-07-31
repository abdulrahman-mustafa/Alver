using Alver.DAL;
using Alver.MISC;
using Alver.UI.Bills.BillReports;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.Utilities;
using static Alver.MISC.BillsFuncs;

namespace Alver.UI.Bills
{
    public partial class frmBillMangement : Form
    {
        #region Variables

        private bool _sellBillschk = false,
            _purchaseBillschk = false,
            _discardBillschk=false,
            _checkedoutBillschk = false,
            _nonecheckedBillschk = false,
            _billIdchk = false,
            _itemIdchk = false,
            _accountchk = false,
            _currencychk = false;

        #endregion Variables

        #region Init

        public frmBillMangement()
        {
            InitializeComponent();
        }

        private void frmIncomes_Load(object sender, EventArgs e)
        {
            if (BillsCount()<=0)
            {
                MessageBox.Show("لم يتم اضافة اي فاتورة بعد");
                this.Close();
            }
            //using (dbEntities db = new dbEntities(0))
            //{
            //    db.Bills.AsNoTracking().Load();
            //    db.Items.AsNoTracking().Load();
            //    db.Accounts.AsNoTracking().Load();
            //    //db.Items.AsNoTracking().Load();
            //    billIdBS.DataSource = db.Bills.AsNoTracking().AsQueryable().ToList();
            //    itemIdBS.DataSource = db.Items.AsNoTracking().AsQueryable().ToList();
            //    accountBindingSource1.DataSource = db.Accounts.AsNoTracking().AsQueryable().ToList();
            //}
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
            using (dbEntities db = new dbEntities(0))
            {
                //db.Accounts.Load();
                accountBindingSource.DataSource = db.Accounts.ToList();
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
        private IQueryable<Bill> GrandSearch(DateTime _from, DateTime _to, int _billId, int _itemId, int _accountId,int _currencyId, string _sellBill, string _PurchaseBill,string _discardBill, bool _checkedout, bool _nonecheckedout)
        {
            IQueryable<Bill> _query = null;// = new IQueryable<Remittances_Operation>;
            try
            {
                using (dbEntities db = new dbEntities(0))
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
                                (x.BillType == _PurchaseBill && _PurchaseBill != null)  ||
                                (x.BillType == _discardBill && _discardBill != null)
                            )
                            ).Include(x => x.BillLines).AsQueryable();
                    }
                    else if (_from.Year != _to.Year)
                    {
                        _query = db.Bills.Where(
                            x => x.BillDate.Value.Year >= _from.Year && x.BillDate.Value.Year <= _to.Year &&
                            (
                                (x.BillType == _sellBill && _sellBill != null) ||
                                (x.BillType == _PurchaseBill && _PurchaseBill != null) ||
                                (x.BillType == _discardBill && _discardBill != null)
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
                                (x.BillType == _PurchaseBill && _PurchaseBill != null) ||
                                (x.BillType == _discardBill && _discardBill != null)
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
                    if (_currencyId != 0)
                    {
                        _query = _query.Where(x => x.CurrencyId == _currencyId);
                    }
                    if (_accountId != 0)
                    {
                        _query = _query.Where(x => x.AccountId == _accountId);
                    }
                    if (_itemId!=0)
                    {
                        _query = _query.Where(x => x.BillLines.Where(z => z.ItemId == _itemId).Any());
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
            _currencychk = currencychkbox.Checked;
            _itemIdchk = itemchkbox.Checked;
            _sellBillschk = sellbillchkbox.Checked;
            _purchaseBillschk = purchasebillchkbox.Checked;
            _discardBillschk = discardbillchkbox.Checked;
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
                string _sellBill = null, _PurchaseBill = null,_discardBill=null;// _outer = null;
                int _billId = 0;
                int _accountId = 0;
                int _currencyId = 0;
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
                if (_accountchk)
                {
                    _accountId = (int)accountcb.SelectedValue;
                }
                if (_currencychk)
                {
                    _currencyId = (int)currencycb.SelectedValue;
                }
                if (_sellBillschk)
                {
                    _sellBill = BillType.بيع.ToString();
                }
                if (_purchaseBillschk)
                {
                    _PurchaseBill = BillType.شراء.ToString();
                }
                if (_discardBillschk)
                {
                    _discardBill = BillType.مرتجع.ToString();
                }
                GrandSearch(_from, _to, _billId, _itemId, _accountId,_currencyId, _sellBill, _PurchaseBill,_discardBill, _checkedoutBillschk, _nonecheckedBillschk);
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
        

        private void deletebillbtn_Click(object sender, EventArgs e)
        {
            try
            {
                deletebillbtn.Enabled = false;
                try
                {
                    if (MessageBox.Show("سيتم حذف الفاتورة وكافة الاقلام التابعة لها. هل انت متأكد؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        BillsFuncs.DeleteBill((BillsBS.Current as Bill).Id);
                        searchbtn_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
                deletebillbtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void printbillslipbtn_Click(object sender, EventArgs e)
        {
            PrintBillSlip(false);
        }

        private void printbillbtn_Click(object sender, EventArgs e)
        {
            PrintBillSlip(true);
        }

        private void editbillbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bill _tempBill = (BillsBS.Current as Bill);
                if (_tempBill != null)
                {
                    int _billid = _tempBill.Id;
                    if (_billid > 0)
                    {
                        if (_tempBill.BillType == BillType.بيع.ToString())
                        {
                            (new frmSell(_billid)).ShowDialog();
                        }
                        else if (_tempBill.BillType == BillType.شراء.ToString())
                        {
                            (new frmPurchase_NOTUSED(_billid)).ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void sellbillchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _sellBillschk = sellbillchkbox.Checked;
        }

        private void billidchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _billIdchk = billidchkbox.Checked;
            billidcb.Enabled = billidchkbox.Checked;
            if (_billIdchk)
            {
                billIdBS.DataSource = (new dbEntities(0)).Bills.AsQueryable().AsNoTracking().ToList();
            }
            else
            {
                billIdBS.DataSource = null;
            }
        }

        private void discardbillchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _discardBillschk = discardbillchkbox.Checked;

        }

        private void ترحيلالفاتورةدفعقيمةالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ترحيلالفاتورةدفعقيمةالفاتورةToolStripMenuItem.Enabled = false;
                try
                {
                        BillsFuncs.CashoutBill((BillsBS.Current as Bill).Id);
                        searchbtn_Click(null, null);
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
                ترحيلالفاتورةدفعقيمةالفاتورةToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void currencychkbox_CheckedChanged(object sender, EventArgs e)
        {
            _currencychk = currencychkbox.Checked;
            currencycb.Enabled = currencychkbox.Checked;
            if (_currencychk)
            {
                currencyBindingSource.DataSource = (new dbEntities(0)).Currencies.Where(x=>x.Id==1||x.Id==2).AsQueryable().AsNoTracking().ToList();
            }
            else
            {
                currencyBindingSource.DataSource = null;
            }
        }

        private void accountchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _accountchk = accountchkbox.Checked;
            accountcb.Enabled = accountchkbox.Checked;
            if (_accountchk)
            {
                accountBindingSource1.DataSource = (new dbEntities(0)).Accounts.AsQueryable().AsNoTracking().ToList();
            }
            else
            {
                accountBindingSource1.DataSource = null;
            }
        }
        private void itemchkbox_CheckedChanged(object sender, EventArgs e)
        {
            _itemIdchk = itemchkbox.Checked;
            itemcb.Enabled = itemchkbox.Checked;
            if (_itemIdchk)
            {
                itemIdBS.DataSource = (new dbEntities(0)).Items.AsQueryable().AsNoTracking().ToList();
            }
            else
            {
                itemIdBS.DataSource = null;
            }
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

        

        #endregion Form Events

        #region Buttons Clicks

        private void searchbtn_Click(object sender, EventArgs e)
        {
            Retrive();
        }

        #endregion Buttons Clicks
    }
}