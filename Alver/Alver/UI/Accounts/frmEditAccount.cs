using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts
{
    public partial class frmEditAccount : Form
    {
        private dbEntities database = new dbEntities();
        private List<Account> _accounts;
        private int _accountId = 0;

        public frmEditAccount(int AccountId)
        {
            if (AccountId < 1)
            {
                MessageBox.Show("حدث خطأ اثناء جلب بيانات الحساب، حاول مرة أخرى");
                this.Close();
            }
            else
            {
                _accountId = AccountId;
            }
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {
            database.Accounts.Load();
            _accounts = new List<Account>();
            _accounts = database.Accounts.Where(x => x.Id != _accountId).ToList();
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    db.Currencies.AsNoTracking().AsQueryable().Load();
                    db.AccountGroups.AsNoTracking().AsQueryable().Load();
                    currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                    accountGroupBindingSource.DataSource = db.AccountGroups.AsNoTracking().AsQueryable().ToList();
                    MISC.Utilities.SearchableComboBox(accountcb);

                    Account _account = db.Accounts.Find(_accountId);
                    if (_account != null)
                    {
                        accountcb.Text = _account.FullName;
                        fatherTextBox.Text = _account.Father;
                        motherTextBox.Text = _account.Mother;
                        idNumberMaskedTextBox.Text = _account.IdNumber;
                        phoneMaskedTextBox.Text = _account.Phone;
                        addressTextBox.Text = _account.Address;
                        notestextBox.Text = _account.Declaration;
                        accountgroupcb.SelectedValue = _account.AccountGroupId.Value;
                        countryNameComboBox.SelectedValue = _account.CountryId.Value;
                        cityNameComboBox.SelectedValue = _account.CityId.Value;
                        isActiveCheckBox.Checked = _account.Deactivated.Value;

                        List<AccountFund> _funds = db.AccountFunds.Where(x => x.AccountId == _accountId).ToList();
                        if (_funds != null)
                        {
                            accountsFundBindingSource.DataSource = _funds;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void Save()
        {
            try
            {
                int _groupId = 0;
                if (accountgroupcb.SelectedValue != null)
                {
                    _groupId = (int)accountgroupcb.SelectedValue;
                }
                using (dbEntities db = new dbEntities())
                {
                    Account _account = db.Accounts.Find(_accountId);

                    _account.FullName = accountcb.Text.Trim();
                    _account.Father = fatherTextBox.Text.Trim();
                    _account.Mother = motherTextBox.Text.Trim();
                    _account.IdNumber = idNumberMaskedTextBox.Text.Trim();
                    _account.CountryId = 0;
                    _account.CityId = 0;
                    _account.Phone = phoneMaskedTextBox.Text.Trim();
                    _account.Address = addressTextBox.Text.Trim();
                    _account.LUD = DateTime.Now;
                    //_account.GUID = Guid.NewGuid();
                    _account.Flag = string.Empty;
                    _account.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    //Users_User = Properties.Settings.Default.LoggedInUser;
                    _account.Hidden = false;
                    _account.Deactivated = isActiveCheckBox.Checked;
                    _account.Declaration = notestextBox.Text.Trim();
                    //Navigation properties
                    _account.AccountGroupId = _groupId;
                    _account.PROTECTED = false;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void accounts_FundDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private bool CheckValues()
        {
            bool _result = true;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    if (string.IsNullOrWhiteSpace(accountcb.Text.Trim()))
                    {
                        MessageBox.Show("الرجاء التأكد من اسم الحساب، لا يجب ان يكون اسم الحساب فارغاً");
                        accountcb.Focus();
                        _result = false;
                    }
                    else if (_accounts.Any(x => x.FullName.ToLower().Trim() == accountcb.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("اسم الحساب موجود من قبل، يرجى اختيار اسم آخر");
                        accountcb.Focus();
                        _result = false;
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            return _result;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues())
                    return;
                if (!PrepareFund())
                    return;
                //db.Entry(_client).State = EntityState.Modified;
                Save();
                dgv.DataSource = null;
                MSGs.SaveMessage();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private bool PrepareFund()
        {
            bool _result = true;
            if (_accountId > 0)
            {
                Validate();
                dgv.EndEdit();
                accountsFundBindingSource.EndEdit();
                var _funds = accountsFundBindingSource.List;
                try
                {
                    foreach (AccountFund _fund in _funds)
                    {
                        if (_fund.Balance.Value < 0)
                        {
                            throw new Exception("لا يمكن ان يكون رصيد الصندوق سالب");
                        }
                    }
                    foreach (AccountFund _fund in _funds)
                    {
                        using (dbEntities db = new dbEntities())
                        {
                            AccountFund _Fund = db.AccountFunds.Find(_fund.Id);
                            _Fund.Balance = _fund.Balance.Value;
                            _Fund.BalanceDirection = _fund.BalanceDirection;
                            _Fund.LUD = DateTime.Now;
                            db.SaveChanges();
                        }
                        TransactionsFuncs.UpdateClientOpeningBalance(_fund, _fund.Balance.Value);
                    }
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                    _result = false;
                }
            }
            return _result;
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void frmClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}