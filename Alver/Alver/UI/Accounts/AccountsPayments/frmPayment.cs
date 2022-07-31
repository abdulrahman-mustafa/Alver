using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Accounts.AccountsPayments
{
    public partial class frmPayment : Form
    {
        //dbEntities db;
        private Payment _payment;

        private Currency _currency;
        private Account _account;

        public frmPayment(Account Payment)
        {
            InitializeComponent();
            //_payment = Payment == null ? (new Payments_Operation()) : Payment;
        }

        private void frmNewPayment_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlsEnable(false);
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                //db.Payments_Operation.AsNoTracking().Load();
                db.Accounts.AsNoTracking().Load();
                db.Currencies.AsNoTracking().Load();
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                currencyBindingSource.DataSource = db.Currencies.Where(x=>x.Id==1).AsNoTracking().ToList().AsQueryable();
            }
            MISC.Utilities.SearchableComboBox(clientComboBox);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void InitTransactions()
        {
            int _accId = (int)clientComboBox.SelectedValue;
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _amount = amountNumericUpDown.Value;
            string _declaration = string.Format("{0} الوكيل: {1} {2}", _payment.PaymentType.ToString(), clientComboBox.Text.Trim(), _payment.Declaration);
            if (fromClientRadioButton.Checked)
            {
                TransactionsFuncs.InsertClientTransaction(_accId, _currencyId, _amount, TransactionsFuncs.TT.PAY, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.PYI, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
            }
            else if (toClientRadioButton.Checked)
            {
                TransactionsFuncs.InsertClientTransaction(_accId, _currencyId, _amount, TransactionsFuncs.TT.PID, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.PYO, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
            }
        }

        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        User _user = Properties.Settings.Default.LoggedInUser;
                        //_payment = new Payments_Operation();
                        _payment.User = _user;
                        _payment.Account = _account;
                        _payment.Currency = _currency;
                        db.Set<Payment>().Add(_payment);
                        db.Entry(_account).State = EntityState.Detached;
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

        private void PrepareItem()
        {
            bool _payed = payedcheckBox.Checked;
            bool _locked = false;
            int Id = (int)clientComboBox.SelectedValue;
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            Guid _guid = Guid.NewGuid();
            using (dbEntities db = new dbEntities(0))
            {
                _currency = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                _account = db.Accounts.FirstOrDefault(x => x.Id == Id);

                if (fromClientRadioButton.Checked)
                {
                    _payment = new Payment()
                    {
                        PaymentType = MISC.Utilities.PaymentType.دفعة_من_وكيل.ToString(),
                        PaymentDate = operationDateDateTimePicker.Value,
                        CurrencyId = (int)currencyIdComboBox.SelectedValue,
                        Amount = amountNumericUpDown.Value,
                        Declaration = declarationTextBox.Text,
                        AccountId = Id,
                        Account = _account,
                        Locked = _locked,
                        LUD = DateTime.Now,
                        Payed = false,
                        UserId = Properties.Settings.Default.LoggedInUser.Id,
                        Flag = string.Empty,
                        Hidden = false,
                        GUID = _guid,
                        PROTECTED = false
                    };
                }
                else if (toClientRadioButton.Checked)
                {
                    _payment = new Payment()
                    {
                        PaymentType = MISC.Utilities.PaymentType.دفعة_لوكيل.ToString(),
                        PaymentDate = operationDateDateTimePicker.Value,
                        CurrencyId = (int)currencyIdComboBox.SelectedValue,
                        Amount = amountNumericUpDown.Value,
                        Declaration = declarationTextBox.Text,
                        AccountId = Id,
                        Account = _account,
                        Locked = _locked,
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

        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities(0);
            //db.Configuration.ProxyCreationEnabled = false;
            //_payment = new Payments_Operation();
            //LoadData();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            ControlsEnable(true);
        }

        private bool CheckPaymentAmount()
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
            try
            {
                if (!CheckPaymentAmount())
                    return;
                PrepareItem();
                //if (!Validator.VCFundFound(_payment.AccountId.Value, _payment.CurrencyId.Value))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة المبلغ لدى الوكيل المرسل، يرجى إنشاء صندوق للوكيل بنفس عملة المبلغ اولاً", "تنبيه");
                //    return;
                //}
                //else if (!Validator.VFundFound(_payment.CurrencyId.Value))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة المبلغ، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
                //    return;
                //}
                //else if (toClientRadioButton.Checked)
                //{
                //    if (!Validator.VFundBalance(_payment.CurrencyId.Value, _payment.Amount.Value))
                //    {
                //        MessageBox.Show("لا يمكن تسليم المبلغ للوكيل الرصيد في الصندوق غير كاف", "تنبيه");
                //        return;
                //    }
                //}
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
        }

        private void addClientpb_Click(object sender, EventArgs e)
        {
            (new frmAddAccount()).ShowDialog();
            LoadData();
        }

        private void frmPayment_KeyDown(object sender, KeyEventArgs e)
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