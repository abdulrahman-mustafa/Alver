using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Accounts.Withdraws
{
    public partial class frmWithdraw : Form
    {
        Withdraw _withdraw;
        Currency _currency;
        Account _client;
        public frmWithdraw(Withdraw withdraw)
        {
            InitializeComponent();
            _withdraw = withdraw == null ? (new Withdraw()) : withdraw;
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Accounts.AsNoTracking().Load();
                db.Currencies.AsNoTracking().Load();
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
            }
            MISC.Utilities.SearchableComboBox(clientComboBox);
        }
        private void ControlsEnable(bool _enable)
        {
            operationDateDateTimePicker.Value = DateTime.Now;
            declarationTextBox.Enabled = _enable;
            declarationTextBox.Clear();
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            amountNumericUpDown.Value = amountNumericUpDown.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlsEnable(false);
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            ControlsEnable(true);
        }
        private bool CheckAmount()
        {
            bool _result = true;
            if (amountNumericUpDown.Value == 0)
            {
                MessageBox.Show("الرجاء التأكد من قيمة المبلغ، لا يجب ان يكون المبلغ 0");
                amountNumericUpDown.Focus();
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
        private bool PrepareItem()
        {
            bool _result = true;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Guid _guid = Guid.NewGuid();

                    int Id = (int)clientComboBox.SelectedValue;
                    _client = db.Accounts.FirstOrDefault(x => x.Id == Id);
                    int _currencyId = (int)currencyIdComboBox.SelectedValue;
                    _currency = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);

                    _withdraw = new Withdraw();
                    _withdraw.WithdrawDate = operationDateDateTimePicker.Value;
                    _withdraw.CurrencyId = _currencyId;
                    _withdraw.Amount = amountNumericUpDown.Value;
                    _withdraw.Declaration = declarationTextBox.Text;
                    _withdraw.AccountId = (int)clientComboBox.SelectedValue;
                    _withdraw.Locked = false;
                    _withdraw.LUD = DateTime.Now;
                    _withdraw.Payed = false;
                    _withdraw.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    _withdraw.Flag = string.Empty;
                    _withdraw.Hidden = false;
                    _withdraw.GUID = _guid;
                    _withdraw.PROTECTED = false;

                    if (gaincb.Checked)
                    {
                        _withdraw.Direction = MISC.Utilities.WithdrawDirections.سحب_أرباح.ToString();
                    }
                    else if (losscb.Checked)
                    {
                        _withdraw.Direction = MISC.Utilities.WithdrawDirections.إيداع_أرباح.ToString();
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("تأكد من من القيم المدخلة وحاول مجدداً");
                _result = false;
            }
            return _result;
        }
        private void InitTransactions()
        {
            int _accountId = (int)clientComboBox.SelectedValue;
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _amount = amountNumericUpDown.Value;
            string _declaration = string.Format("{0} الوكيل: {1} {2}", _withdraw.Direction, clientComboBox.Text.Trim(), _withdraw.Declaration);
            if (gaincb.Checked)
            {
                TransactionsFuncs.InsertClientTransaction(_accountId, _currencyId, _amount, TransactionsFuncs.TT.GIN, _withdraw.WithdrawDate.Value, _withdraw.GUID.Value, _declaration);
            }
            else if (losscb.Checked)
            {
                TransactionsFuncs.InsertClientTransaction(_accountId, _currencyId, _amount, TransactionsFuncs.TT.LOS, _withdraw.WithdrawDate.Value, _withdraw.GUID.Value, _declaration);
            }
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
                        _withdraw.User = _user;
                        _withdraw.Account = _client;
                        _withdraw.Currency = _currency;
                        db.Set<Withdraw>().Add(_withdraw);
                        db.Entry(_client).State = EntityState.Detached;
                        db.Entry(_currency).State = EntityState.Detached;
                        db.Entry(_user).State = EntityState.Detached;
                        db.SaveChanges();
                        InitTransactions();
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                    scope.Complete();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!CheckAmount())
                return;
            if (!PrepareItem())
                return;
            //if (!Validator.VCFundFound(_payment.BorrowerId.Value, _payment.CurrencyId.Value))
            //{
            //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الدين لدى الوكيل المرسل، يرجى إنشاء صندوق للوكيل بنفس عملة الدين اولاً", "تنبيه");
            //    return;
            //}
            //else if (!Validator.VFundFound(_payment.CurrencyId.Value))
            //{
            //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الدين، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
            //    return;
            //}
            //else if (outFundRadioButton.Checked)
            //{
            //    if (!Validator.VFundBalance(_payment.CurrencyId.Value, _payment.Amount.Value))
            //    {
            //        MessageBox.Show("لا يمكن تسليم الدين للوكيل الرصيد في الصندوق غير كاف", "تنبيه");
            //        return;
            //    }
            //}
            Save();
            ControlsEnable(false);
        }
        private void frmWithdraw_KeyDown(object sender, KeyEventArgs e)
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
        private void addClientpb_Click(object sender, EventArgs e)
        {
            (new frmAddAccount()).ShowDialog();
            LoadData();
        }
    }
}
