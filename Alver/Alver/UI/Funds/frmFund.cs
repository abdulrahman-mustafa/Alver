using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Funds
{
    public partial class frmFund : Form
    {
        Currency _currency;
        Fund _fund;
        string _purpose = "add";
        public frmFund()
        {
            InitializeComponent();
        }
        private void frmOut_Load(object sender, EventArgs e)
        {
            ControlsEnable(false);
            LoadData();
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().AsQueryable().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
            }
            Misc.Utilities.SearchableComboBox(fundComboBox);
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            ClearForm();
            //LoadData();
        }
        private void ClearForm()
        {
            fundComboBox.Text = string.Empty;
            balancenud.Value = 0;
            notestextBox.Text = string.Empty;
        }
        private void PrepareItem()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _currency = db.Currencies.FirstOrDefault(x => x.Id == (int)currencyComboBox.SelectedValue);
                }
                _fund = new Fund()
                {
                    FundTitle = fundComboBox.Text.Trim(),
                    Balance = balancenud.Value,
                    BalanceDirection = "لنا",
                    CurrencyId = (int)currencyComboBox.SelectedValue,
                    LUD = DateTime.Now,
                    GUID = Guid.NewGuid(),
                    Flag = string.Empty,
                    UserId = Properties.Settings.Default.LoggedInUser.Id,
                    Hidden = false,
                    Declaration = notestextBox.Text.Trim(),
                    //Navigation properties
                    User = Properties.Settings.Default.LoggedInUser,
                    Currency = _currency
                };
            }
            catch (Exception ex) { }
        }
        private void ControlsEnable(bool _enable)
        {
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            addNew();
            ControlsEnable(true);
        }
        private bool CheckValues()
        {
            bool _result = true;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    if (string.IsNullOrWhiteSpace(fundComboBox.Text.Trim()))
                    {
                        MessageBox.Show("الرجاء التأكد من اسم الصندوق، لا يجب ان يكون اسم الصندوق فارغاً");
                        fundComboBox.Focus();
                        _result = false;
                    }
                    else if (db.Funds.Any(x => x.FundTitle.ToLower().Trim() == fundComboBox.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("اسم الضندالصندوقوق موجود من قبل، يرجى اختيار اسم آخر");
                        fundComboBox.Focus();
                        _result = false;
                    }
                    else if (balancenud.Value < 0)
                    {
                        MessageBox.Show("لا يمكن ان يكون رصيد الصندوق سالب");
                        balancenud.Focus();
                        _result = false;
                    }
                }
            }
            catch (Exception ex) { }
            return _result;
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
                        _fund.Currency = _currency;
                        _fund.User = _user;
                        db.Set<Fund>().Add(_fund);
                        // use the following statement so that Childs won't be inserted
                        db.Entry(_fund).State = EntityState.Detached;
                        db.Entry(_currency).State = EntityState.Detached;
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
                MessageBox.Show("حدث خطأ داخلي سيتم التراجع عن الحفظ");
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues())
                    return;
                PrepareItem();
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ اثناء إضافة الصندوق", "تنبيه");
            }
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("رصيد افتتاحي");
            int _currencyId = (int)currencyComboBox.SelectedValue;
            decimal _balance = balancenud.Value;
            using (dbEntities db = new dbEntities())
            {
                if (_purpose == "edit")
                {
                    FundTransaction _trans = db.FundTransactions.FirstOrDefault(x => x.CurrencyId == _currencyId && x.GUID == _fund.GUID.Value && x.TT == TransactionsOperations.TT.OPN.ToString());
                    _trans.Amount = _balance;
                    _trans.CurrencyId = _currencyId;
                    db.SaveChanges();
                }
                else if (_purpose == "add")
                {
                    TransactionsOperations.InsertFundOpeningBalance(_fund, _declaration);
                }
            }
        }
        private void frmFund_KeyDown(object sender, KeyEventArgs e)
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
    }
}
