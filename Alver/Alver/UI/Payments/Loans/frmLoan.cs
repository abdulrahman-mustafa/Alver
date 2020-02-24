using Alver.DAL;
using Alver.Misc;
using Alver.UI.Accounts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Payments.Loans
{
    public partial class frmLoan : Form
    {
        //dbEntities db;
        Payment _payment;
        Currency _currency;
        Account _client;
        public frmLoan(Payment Payment)
        {
            InitializeComponent();
            _payment = Payment == null ? (new Payment()) : Payment;
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
                db.Currencies.AsNoTracking().Load();
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
            }
            Misc.Utilities.SearchableComboBox(clientComboBox);
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("{0}: {1}", _payment.PaymentType.ToString(), declarationTextBox.Text.Trim());
            int _accountId = (int)clientComboBox.SelectedValue;
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _amount = amountNumericUpDown.Value;
            if (inFundRadioButton.Checked)
            {
                TransactionsOperations.InsertClientTransaction(_accountId, _currencyId, _amount, TransactionsOperations.TT.LNF, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                TransactionsOperations.InsertFundTransaction(_currencyId, _amount, TransactionsOperations.TT.LNI, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
            }
            else if (outFundRadioButton.Checked)
            {
                TransactionsOperations.InsertClientTransaction(_accountId, _currencyId, _amount, TransactionsOperations.TT.LNT, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                TransactionsOperations.InsertFundTransaction(_currencyId, _amount, TransactionsOperations.TT.LNO, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
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
                        _payment.User = _user;
                        _payment.Account = _client;
                        _payment.Currency = _currency;
                        db.Set<Payment>().Add(_payment);
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
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
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
                    if (inFundRadioButton.Checked)
                    {
                        _payment = new Payment()
                        {
                            PaymentType = Misc.Utilities.PaymentTransactionType.دين_مقبوض.ToString(),
                            PaymentDate = operationDateDateTimePicker.Value,
                            CurrencyId = _currencyId,
                            Amount = amountNumericUpDown.Value,
                            Declaration = declarationTextBox.Text,
                            AccountId = (int)clientComboBox.SelectedValue,
                            Locked = false,
                            LUD = DateTime.Now,
                            Payed = false,
                            UserId = Properties.Settings.Default.LoggedInUser.Id,
                            Flag = string.Empty,
                            Hidden = false,
                            GUID = _guid,
                            PROTECTED = false
                        };
                    }
                    else if (outFundRadioButton.Checked)
                    {
                        _payment = new Payment()
                        {
                            PaymentType = Misc.Utilities.PaymentTransactionType.دين_مدفوع.ToString(),
                            PaymentDate = operationDateDateTimePicker.Value,
                            CurrencyId = _currencyId,
                            Amount = amountNumericUpDown.Value,
                            Declaration = declarationTextBox.Text,
                            AccountId = (int)clientComboBox.SelectedValue,
                            Locked = false,
                            LUD = DateTime.Now,
                            Payed = false,
                            UserId = Properties.Settings.Default.LoggedInUser.Id,
                            Flag = string.Empty,
                            Hidden = false,
                            GUID = _guid,
                            PROTECTED = false
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكد من من القيم المدخلة وحاول مجدداً");
                _result = false;
            }
            return _result;
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            ControlsEnable(true);
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            //_payment = new Payment();
            //LoadData();
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
        private bool CheckLoanAmount()
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
        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!CheckLoanAmount())
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
        private void addClientpb_Click(object sender, EventArgs e)
        {
            (new frmAddAccount()).ShowDialog();
            LoadData();
        }
        private void frmClientLoan_KeyDown(object sender, KeyEventArgs e)
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
