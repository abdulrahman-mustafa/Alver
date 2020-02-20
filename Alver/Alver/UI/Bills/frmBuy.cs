using Alver.DAL;
using Alver.Misc;
using Alver.UI.Accounts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Bills
{
    public partial class frmBuy : Form
    {
        //dbEntities db;
        Bill _bill;
        BillLine _itemList;
        Account _client;
        public frmBuy(Bill Bill)
        {
            InitializeComponent();
            _bill = Bill == null ? (new Bill()) : Bill;
        }
        private void frmNewPayment_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlsEnable(false);
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Accounts.AsNoTracking().Load();
                db.Units.AsNoTracking().Load();
                db.Items.AsNoTracking().Load();
                
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                unitBindingSource.DataSource = db.Units.AsNoTracking().ToList().AsQueryable();
                unitBindingSource1.DataSource = db.Units.AsNoTracking().ToList().AsQueryable();
                itemBindingSource.DataSource = db.Items.AsNoTracking().ToList().AsQueryable();
                itemBindingSource1.DataSource = db.Items.AsNoTracking().ToList().AsQueryable();
                billLinesBindingSource.DataSource = db.BillLines.AsNoTracking().AsQueryable().ToList();
            }
            Misc.Utilities.SearchableComboBox(clientComboBox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("{0}: {1}", _bill.BillType.ToString(), _bill.Declaration);
            int _accountId = (int)clientComboBox.SelectedValue;
            int _currencyId = 2;// (int)currencyIdComboBox.SelectedValue;
            decimal _amount = discountamountnud.Value;

            TransactionsOperations.InsertClientTransaction(_accountId, _currencyId, _amount, TransactionsOperations.TT.DTT, _bill.BillDate.Value, _bill.GUID.Value, _declaration);
            TransactionsOperations.InsertFundTransaction(_currencyId, _amount, TransactionsOperations.TT.DTO, _bill.BillDate.Value, _bill.GUID.Value, _declaration);
            TransactionsOperations.ClientsRunningTotals(_accountId);
        }
        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities())
                    {
                        User _user = Properties.Settings.Default.LoggedInUser;
                        _bill.User = _user;
                        _bill.Account = _client;
                        //_bill.Currency = _currency;
                        db.Set<Bill>().Add(_bill);
                        db.Entry(_client).State = EntityState.Detached;
                        db.Entry(_user).State = EntityState.Detached;
                        db.SaveChanges();
                        InitTransactions();
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
        }
        private void ControlsEnable(bool _enable)
        {
            operationDateDateTimePicker.Value = DateTime.Now;
            declarationTextBox.Enabled = _enable;
            declarationTextBox.Clear();
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            discountamountnud.Value = discountamountnud.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void PrepareItem()
        {
            using (dbEntities db = new dbEntities())
            {
                Guid _guid = Guid.NewGuid();
                int Id = (int)clientComboBox.SelectedValue;
                _client = db.Accounts.FirstOrDefault(x => x.Id == Id);

                _bill = new Bill()
                {
                    BillType = Misc.Utilities.BillType.شراء.ToString(),
                    BillDate = operationDateDateTimePicker.Value,
                    AccountId = (int)clientComboBox.SelectedValue,
                    DiscountAmount = discountamountnud.Value,
                    BillAmount = billAmountnud.Value,
                    TotalAmount = totalAmountnud.Value,

                    Declaration = declarationTextBox.Text,
                    LUD = DateTime.Now,
                    UserId = Properties.Settings.Default.LoggedInUser.Id,
                    Flag = string.Empty,
                    Hidden = false,
                    GUID = _guid,
                    PROTECTED = false
                };

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            _bill = new Bill();
            LoadData();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            ControlsEnable(true);
        }
        private bool CheckDepositeAmount()
        {
            bool _result = true;
            if (itemBindingSource.Count == 0)
            {
                MessageBox.Show("الرجاء إضافة مواد إلى السند للاستمرار");
                discountamountnud.Focus();
                _result = false;
            }
            else if (accountsInfoBindingSource.Count <= 0)
            {
                MessageBox.Show("لم يتم إضافة وكلاء بعد للاستمرار يرجى إضافة وكيل واحد على الاقل.");
                clientComboBox.Focus();
                _result = false;
            }
            return _result;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!CheckDepositeAmount())
                return;
            PrepareItem();

            //if (!Validator.VCFundFound(_payment.BorrowerId.Value, _payment.CurrencyId.Value))
            //{
            //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الامانة لدى الوكيل المرسل، يرجى إنشاء صندوق للوكيل بنفس عملة الامانة اولاً", "تنبيه");
            //    return;
            //}
            //else if (!Validator.VFundFound(_payment.CurrencyId.Value))
            //{
            //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الامانة، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
            //    return;
            //}
            //else if (outDepositeRadioButton.Checked)
            //{

            //    if (!Validator.VFundBalance(_payment.CurrencyId.Value, _payment.Amount.Value))
            //    {
            //        MessageBox.Show("لا يمكن تسليم الأمانة للوكيل الرصيد في الصندوق غير كاف", "تنبيه");
            //        return;
            //    }
            //}
            Save();
            ControlsEnable(false);
        }
        private void addClientpb_Click(object sender, EventArgs e)
        {
            (new frmClient()).ShowDialog();
            LoadData();
        }

        private void frmClientDeposite_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addbtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }

        private void billLinesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void itemcb_TextChanged(object sender, EventArgs e)
        {
        }

        private void AutoCompleteItemsCB()
        {
            try
            {
                string _keyword = itemcb.Text.Trim();
                if (_keyword.Length > 1)
                {
                    using (dbEntities db = new dbEntities())
                    {
                        AutoCompleteStringCollection _list = new AutoCompleteStringCollection();
                        var _items = db.Items.Where(x => x.ItemName.Contains(_keyword)).AsQueryable().AsNoTracking().ToList();
                        foreach (var item in _items)
                        {
                            _list.Add(item.ItemName);
                        }
                        itemcb.AutoCompleteCustomSource = _list;
                    }

                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            addItemToBill();
        }

        private void addItemToBill()
        {
            try
            {
                int _itemId = (int)itemcb.SelectedValue;
                int _unitId = (int)unitcb.SelectedValue;
                decimal _quantity = quantitynud.Value;
                decimal _price = pricenud.Value;

                BillLine _line = new BillLine()
                {
                    ItemId = _itemId,
                    UnitId = _unitId,
                    Quantity = _quantity,
                    Price = _price,
                    TotalPrice = (_price * _quantity)
                    //UserId
                };
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
    }
}
