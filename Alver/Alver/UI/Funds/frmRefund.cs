using Alver.DAL;
using Alver.MISC;
using Alver.UI.Accounts;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Funds
{
    public partial class frmRefund : Form
    {
        Payment _orginalObject;
        public string _purpose = "add";
        dbEntities db;
        Payment _payment;
        Currency _currency;
        public frmRefund(Payment Payment)
        {
            InitializeComponent();
            _payment = Payment == null ? (new Payment()) : Payment;
        }
        public void InitFormForEdit(Payment payment)
        {
            LoadData();

            operationDateDateTimePicker.Value = payment.PaymentDate.Value;
            currencyIdComboBox.SelectedValue = payment.CurrencyId.Value;
            amountNumericUpDown.Value = payment.Amount.Value;
            if (payment.PaymentType == MISC.Utilities.PaymentType.تغذية_صندوق.ToString())
            {
                refundRadioButton.Checked = true;
                withdrawRadioButton.Checked = false;
            }
            else
            {
                refundRadioButton.Checked = false;
                withdrawRadioButton.Checked = true;
            }
            fundComboBox.SelectedValue = payment.AccountId.Value;
            declarationTextBox.Text = payment.Declaration;
        }
        private void frmNewPayment_Load(object sender, EventArgs e)
        {
            if (_purpose == "add")
            {
                ControlsEnable(false);
            }
            if (_purpose == "edit")
            {
                _orginalObject = _payment;
            }
            amountNumericUpDown.Focus();
        }
        public void LoadData()
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Transactions.Load();
            db.Accounts.Load();
            db.AccountFunds.Load();
            db.Currencies.Load();
            fundBindingSource.DataSource = db.Funds.ToList();
            //paymentsOperationBindingSource.DataSource = db.Payment.ToList();
            currencyBindingSource.DataSource = db.Currencies.ToList();
            MISC.Utilities.SearchableComboBox(fundComboBox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void Edit()
        {
            EditItem();
            InitTransactions();
            MISC.Utilities.SaveChanges(ref db, this);
        }
        private void Save()
        {
            InitTransactions();
            db.Payments.Add(_payment);
            MISC.Utilities.SaveChanges(ref db, this);
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("{0}: {1}", _payment.PaymentType.ToString(), _payment.Declaration.ToString());
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _amount = amountNumericUpDown.Value;
            if (refundRadioButton.Checked)
            {
                TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.FDI, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
            }
            else if (withdrawRadioButton.Checked)
            {
                TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.FDO, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
            }
            if (_purpose == "edit")
            {
                if (_orginalObject.PaymentType == MISC.Utilities.PaymentType.تغذية_صندوق.ToString())
                {
                    TransactionsFuncs.InsertFundTransaction(_orginalObject.CurrencyId.Value, _orginalObject.Amount.Value, TransactionsFuncs.TT.DDT, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                }
                else if (_orginalObject.PaymentType == MISC.Utilities.PaymentType.سحب_من_صندوق.ToString())
                {
                    TransactionsFuncs.InsertFundTransaction(_orginalObject.CurrencyId.Value, _orginalObject.Amount.Value, TransactionsFuncs.TT.RFD, _payment.PaymentDate.Value, _payment.GUID.Value, _declaration);
                }
            }
        }
        public void ControlsEnable(bool _enable)
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
        private int PrepareItem()
        {
            try
            {
                int _fundId = (int)fundComboBox.SelectedValue;
                Fund _fund = new Fund();
                _fund = db.Funds.FirstOrDefault(x => x.Id == _fundId);
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                decimal _amount = amountNumericUpDown.Value;
                if (refundRadioButton.Checked)
                {
                    _payment = new Payment()
                    {
                        PaymentType = MISC.Utilities.PaymentType.تغذية_صندوق.ToString(),
                        PaymentDate = operationDateDateTimePicker.Value,
                        CurrencyId = _currencyId,
                        Amount = _amount,
                        Declaration = declarationTextBox.Text,
                        AccountId = _fundId,
                        Locked = false,
                        LUD = DateTime.Now,
                        Payed = true,
                        Hidden = false,
                        Flag = "",
                        UserId = Properties.Settings.Default.LoggedInUser.Id,
                        GUID = Guid.NewGuid()
                    };
                }
                else if (withdrawRadioButton.Checked)
                {
                    _payment = new Payment()
                    {
                        PaymentType = MISC.Utilities.PaymentType.سحب_من_صندوق.ToString(),
                        PaymentDate = operationDateDateTimePicker.Value,
                        CurrencyId = _currencyId,
                        Amount = _amount,
                        Declaration = declarationTextBox.Text,
                        AccountId = _fundId,
                        Locked = false,
                        LUD = DateTime.Now,
                        Payed = true,
                        Hidden = false,
                        Flag = "",
                        UserId = Properties.Settings.Default.LoggedInUser.Id,
                        GUID = Guid.NewGuid()

                    };
                }
                _currency = db.Currencies.FirstOrDefault(x => x.Id == _payment.CurrencyId);
                _payment.Currency = _currency;
                return db.Payments.Add(_payment).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        private void EditItem()
        {
            try
            {
                int _fundId = (int)fundComboBox.SelectedValue;
                Fund _fund = new Fund();
                _fund = db.Funds.FirstOrDefault(x => x.Id == _fundId);
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                decimal _amount = amountNumericUpDown.Value;
                if (refundRadioButton.Checked)
                {
                    _payment.PaymentType = MISC.Utilities.PaymentType.تغذية_صندوق.ToString();
                    _payment.PaymentDate = operationDateDateTimePicker.Value;
                    _payment.CurrencyId = _currencyId;
                    _payment.Amount = _amount;
                    _payment.Declaration = declarationTextBox.Text;
                    _payment.AccountId = _fundId;
                    _payment.Locked = false;
                    _payment.LUD = DateTime.Now;
                    _payment.Payed = true;
                    _payment.Hidden = false;
                    _payment.Flag = "";
                    _payment.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    _payment.GUID = Guid.NewGuid();
                }
                else if (withdrawRadioButton.Checked)
                {
                    _payment.PaymentType = MISC.Utilities.PaymentType.سحب_من_صندوق.ToString();
                    _payment.PaymentDate = operationDateDateTimePicker.Value;
                    _payment.CurrencyId = _currencyId;
                    _payment.Amount = _amount;
                    _payment.Declaration = declarationTextBox.Text;
                    _payment.AccountId = _fundId;
                    _payment.Locked = false;
                    _payment.LUD = DateTime.Now;
                    _payment.Payed = true;
                    _payment.Hidden = false;
                    _payment.Flag = "";
                    _payment.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    _payment.GUID = Guid.NewGuid();
                }
                _currency = db.Currencies.FirstOrDefault(x => x.Id == _payment.CurrencyId);
                _payment.Currency = _currency;
                //return db.Payment.Add(_payment).Id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lockedCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void fundTitleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addNew()
        {
            if (db != null)
            {
                db.Dispose();
            }
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            _payment = new Payment();
            LoadData();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            addNew();
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
            return _result;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareItem();

                if (!CheckPaymentAmount())
                    return;
                //else if (!Validator.VFundFound(_payment.CurrencyId.Value))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة المبلغ، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
                //    return;
                //}
                //else if (withdrawRadioButton.Checked)
                //{
                //    if (!Validator.VFundBalance(_payment.CurrencyId.Value, _payment.Amount.Value))
                //    {
                //        MessageBox.Show("لا يمكن سحب المبلغ الرصيد في الصندوق غير كاف", "تنبيه");
                //        return;
                //    }
                //}
                if (_purpose == "edit")
                {
                    Edit();
                    Close();
                }
                else if (_purpose == "add")
                {
                    Save();
                    ControlsEnable(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void addClientpb_Click(object sender, EventArgs e)
        {
            (new frmAccounts(null)).ShowDialog();
            LoadData();
        }
        private void currencyIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                fundBindingSource.DataSource = db.Funds.Where(x => x.CurrencyId == _currencyId).ToList();
            }
            catch (Exception ex) { }
        }
        private void frmRefund_KeyDown(object sender, KeyEventArgs e)
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
