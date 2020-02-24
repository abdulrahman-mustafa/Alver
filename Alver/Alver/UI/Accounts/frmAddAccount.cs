using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts
{
    public partial class frmAddAccount : Form
    {
        dbEntities db;
        Account _client;
        public frmAddAccount()
        {
            InitializeComponent();
        }
        private void frmOut_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            ControlsEnable(false);
        }
        private void LoadData()
        {
            db.Currencies.AsNoTracking().AsQueryable().Load();
            db.AccountGroups.AsNoTracking().AsQueryable().Load();
            currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
            accountGroupBindingSource.DataSource = db.AccountGroups.AsNoTracking().AsQueryable().ToList();
            Misc.Utilities.SearchableComboBox(clientComboBox);
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            ClearForm();
            LoadData();
        }

        private void ClearForm()
        {
            clientComboBox.Text = string.Empty;
            fatherTextBox.Text = string.Empty;
            motherTextBox.Text = string.Empty;
            idNumberMaskedTextBox.Text = string.Empty;
            phoneMaskedTextBox.Text = string.Empty;
            addressTextBox.Text = string.Empty;
            notestextBox.Text = string.Empty;
        }

        private void PrepareItem()
        {
            try
            {
                int _groupId = 0;
                if (clientclasscb.SelectedValue != null)
                {
                    _groupId = (int)clientclasscb.SelectedValue;
                }
                _client = new Account()
                {

                    FullName = clientComboBox.Text.Trim(),
                    Father = fatherTextBox.Text.Trim(),
                    Mother = motherTextBox.Text.Trim(),
                    IdNumber = idNumberMaskedTextBox.Text.Trim(),
                    CountryId = 0,
                    CityId = 0,
                    Phone = phoneMaskedTextBox.Text.Trim(),
                    Address = addressTextBox.Text.Trim(),
                    LUD = DateTime.Now,
                    GUID = Guid.NewGuid(),
                    Flag = string.Empty,
                    UserId = Properties.Settings.Default.LoggedInUser.Id,
                    //Users_User = Properties.Settings.Default.LoggedInUser,
                    Hidden = false,
                    Deactivated = isActiveCheckBox.Checked,
                    Declaration = notestextBox.Text.Trim(),
                    //Navigation properties
                    AccountGroupId = _groupId,
                    PROTECTED = false
                };
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void GetValuesFromForm()
        {

            _client.AccountGroupId = 1;// Misc.Utilities.AccountGroup.وكيل_حوالات.ToString();
            _client.FullName = clientComboBox.Text.Trim();
            _client.Father = fatherTextBox.Text.Trim();
            _client.Mother = motherTextBox.Text.Trim();
            _client.IdNumber = idNumberMaskedTextBox.Text.Trim();
            _client.CountryId = 0;// (int)countryNameComboBox.SelectedValue;
            _client.CityId = 0;// (int)cityNameComboBox.SelectedValue;
            _client.Phone = phoneMaskedTextBox.Text.Trim();
            _client.Address = addressTextBox.Text.Trim();
            _client.LUD = DateTime.Now;
            _client.GUID = Guid.NewGuid();
            _client.Flag = string.Empty;
            _client.UserId = Properties.Settings.Default.LoggedInUser.Id;
            //_client.Users_User = Properties.Settings.Default.LoggedInUser;
            _client.Hidden = false;
            _client.Deactivated = isActiveCheckBox.Checked;
            _client.Declaration = notestextBox.Text.Trim();
            //Navigation properties
        }

        private void ControlsEnable(bool _enable)
        {
            savebtn.Enabled = _enable;
            saveprintbtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void accounts_FundDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
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
                if (string.IsNullOrWhiteSpace(clientComboBox.Text.Trim()))
                {
                    MessageBox.Show("الرجاء التأكد من اسم الوكيل، لا يجب ان يكون اسم الوكيل فارغاً");
                    clientComboBox.Focus();
                    _result = false;
                }
                else if (db.Accounts.Any(x => x.FullName.ToLower().Trim() == clientComboBox.Text.ToLower().Trim()))
                {
                    MessageBox.Show("اسم الوكيل موجود من قبل، يرجى اختيار اسم آخر");
                    clientComboBox.Focus();
                    _result = false;
                }
            }
            catch (Exception ex) { }
            return _result;
        }
        private bool CheckLaterValues()
        {
            bool _result = true;
            try
            {
                if (string.IsNullOrWhiteSpace(clientComboBox.Text.Trim()))
                {
                    MessageBox.Show("الرجاء التأكد من اسم الوكيل، لا يجب ان يكون اسم الوكيل فارغاً");
                    clientComboBox.Focus();
                    _result = false;
                }
                else if (db.Accounts.Where(x => x.FullName.ToLower().Trim() == clientComboBox.Text.ToLower().Trim()).ToList().Count > 1)
                {
                    MessageBox.Show("اسم الوكيل موجود من قبل، يرجى اختيار اسم آخر");
                    clientComboBox.Focus();
                    _result = false;
                }
            }
            catch (Exception ex) { }
            return _result;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckLaterValues())
                    return;
                if (!PrepareFund())
                    return;
                //db.Entry(_client).State = EntityState.Modified;
                db.Accounts.Attach(_client);
                Misc.Utilities.SaveChanges(ref db, this);
                dgv.DataSource = null;
                ControlsEnable(false);
            }
            catch (Exception ex) { }
        }

        private bool PrepareFund()
        {
            bool _result = true;
            int _clientId = _client.Id;
            if (_clientId > 0)
            {
                Validate();
                dgv.EndEdit();
                accountsFundBindingSource.EndEdit();
                var ff = db.AccountFunds.Where(x => x.AccountId == _clientId).ToList();
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
                        TransactionsOperations.InsertClientOpeningBalance(ref db, _fund, "رصيد افتتاحي");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _result = false; ;
                }
            }
            return _result;
        }

        private bool CreateBaseFunds()
        {
            bool _result = true;
            try
            {
                int _clientId = _client.Id;
                if (_clientId > 0)
                {
                    int _fundsCount = db.AccountFunds.Where(x => x.AccountId == _clientId).Count();
                    if (_fundsCount == 0)
                    {
                        db.CreateClientFunds(_clientId);
                        List<AccountFund> _funds = db.AccountFunds.Where(x => x.AccountId == _clientId).ToList();
                        accountsFundBindingSource.DataSource = _funds;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("تم حفظ بيانات الوكيل بنجاح، لكن حدث خطأ اثناء إضافة الصناديق");
                _result = false;
            }
            return _result;
        }

        private void saveprintbtn_Click(object sender, EventArgs e)
        {
            try
            {
                dgv.DataSource = accountsFundBindingSource;
                //infogroupBox.Enabled = false;
                if (!CheckValues())
                    return;
                PrepareItem();
                db.Accounts.Add(_client);
                db.SaveChanges();
                if (!CreateBaseFunds())
                    return;
                saveprintbtn.Enabled = !saveprintbtn.Enabled;
                MessageBox.Show("بامكانك تعديل الارصدة الافتتاحية والضغط على زر حفظ ليتم حفظ جميع التعديلات");
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void frmClient_KeyDown(object sender, KeyEventArgs e)
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
