using Alver.DAL;
using Alver.Misc;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Accounts.Transfers
{
    public partial class frmTransfer : Form
    {
        //dbEntities db;
        Currency _currency;
        Account _client;
        AccountFund _fromFund, _toFund;
        Transfer _transfer;
        public frmTransfer(Transfer Trans)
        {
            InitializeComponent();
            _transfer = Trans == null ? (new Transfer()) : Trans;
        }
        private void frmTransferFunds_Load(object sender, EventArgs e)
        {
            displayer.Controls[0].Visible = false;
            LoadData();
            ControlsEnable(false);
        }
        private void ControlsEnable(bool _enable)
        {
            operationDateDateTimePicker.Value = DateTime.Now;
            declarationTextBox.Clear();
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            amountNumericUpDown.Value = amountNumericUpDown.Minimum;
            displayer.Value = displayer.Minimum;
            ratenud.Value = ratenud.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                db.AccountFunds.AsNoTracking().Load();
                db.Accounts.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                accountsFundBindingSource1.DataSource = accountsInfoBindingSource;
                accountsFundBindingSource2.DataSource = accountsInfoBindingSource;
            }
            Misc.Utilities.SearchableComboBox(clientComboBox);

        }
        private void transferClientFundBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _transfer = transferClientFundBindingSource.Current as Transfer;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void addNew()
        {
            //db.Dispose();
            //_transfer = new Transfer();
            //LoadData();
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
                        _transfer.User = _user;
                        _transfer.AccountFund = _fromFund;
                        _transfer.AccountFund1 = _toFund;
                        _transfer.Account = _client;
                        _transfer.Account1 = _client;
                        _transfer.Currency = _currency;
                        db.Set<Transfer>().Add(_transfer);
                        db.Entry(_currency).State = EntityState.Detached;
                        db.Entry(_fromFund).State = EntityState.Detached;
                        db.Entry(_toFund).State = EntityState.Detached;
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
            { MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح"); }
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("قص رصيد مبلغ {0} من صندوق: {1} إلى صندوق: {2} بسعر صرف {3} ",
                amountNumericUpDown.Value.ToString()
                , FromFundcomboBox.Text.ToString()
                , ToFundcomboBox.Text.Trim()
                , ratenud.Value.ToString());

            int _accountId = (int)clientComboBox.SelectedValue;
            int _toCurrencyId = (accountsFundBindingSource2.Current as AccountFund).CurrencyId.Value;
            decimal _toAmount = displayer.Value;
            int _fromCurrencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _fromAmount = amountNumericUpDown.Value;
            TransactionsOperations.InsertClientTransaction(_accountId, _fromCurrencyId, _fromAmount, TransactionsOperations.TT.CTF, _transfer.TransferDate.Value, _transfer.GUID.Value, _declaration);
            TransactionsOperations.InsertClientTransaction(_accountId, _toCurrencyId, _toAmount, TransactionsOperations.TT.CTT, _transfer.TransferDate.Value, _transfer.GUID.Value, _declaration, _fromCurrencyId);
        }
        private void PrepareItem()
        {
            try
            {
                _transfer = new Transfer();
                Guid _guid = Guid.NewGuid();
                int _clientId = (int)clientComboBox.SelectedValue;
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                int _fromFundId = (int)FromFundcomboBox.SelectedValue;
                int _toFundId = (int)ToFundcomboBox.SelectedValue;

                using (dbEntities db = new dbEntities())
                {
                    _currency = db.Currencies.Find(_currencyId);
                    _client = db.Accounts.Find(_clientId);
                    _fromFund = db.AccountFunds.Find(_fromFundId);
                    _toFund = db.AccountFunds.Find(_toFundId);
                }

                _transfer.CurrencyId = _currencyId;
                _transfer.ClientFrom = _clientId;
                _transfer.ClientTo = _clientId;
                _transfer.FundFrom = _fromFundId;
                _transfer.FundTo = _toFundId;
                _transfer.TransferDate = operationDateDateTimePicker.Value;
                _transfer.FromAmount = amountNumericUpDown.Value;
                _transfer.ToAmount = displayer.Value;
                _transfer.Factor = radioButton2.Checked;
                _transfer.Rate = ratenud.Value;
                _transfer.Declaration = declarationTextBox.Text.Trim();
                _transfer.LUD = DateTime.Now;
                _transfer.UserId = Properties.Settings.Default.LoggedInUser.Id;
                _transfer.Hidden = false;
                _transfer.Flag = string.Empty;
                _transfer.GUID = _guid;
                _transfer.PROTECTED = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }
        private void ExchangeMoney()
        {
            try
            {
                decimal _result = 0;
                if (radioButton2.Checked)
                {
                    _result = amountNumericUpDown.Value * ratenud.Value;
                }
                else
                {
                    _result = amountNumericUpDown.Value / ratenud.Value;
                }
                //resultnumericUpDown.Value = _result;
                displayer.Value = _result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("المبلغ غير صحيح");
            }
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            //addNew();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            ControlsEnable(true);
        }
        private bool CheckTransferAmount()
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
            //if (amountNumericUpDown.Value > 1)
            //{
            //    MessageBox.Show("Amount is larger than the balance in the specified fund");
            //    amountNumericUpDown.Focus();
            //    _result = false;
            //}
            return _result;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckTransferAmount())
                    return;
                PrepareItem();
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء الحفظ");
            }
        }
        private void currencyIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    int accId = (int)clientComboBox.SelectedValue;
                    int currId = (int)currencyIdComboBox.SelectedValue;
                    accountsFundBindingSource1.DataSource = db.AccountFunds.FirstOrDefault(x => x.AccountId == accId && x.CurrencyId == currId);
                    FromFundcomboBox.SelectedValue = db.AccountFunds.FirstOrDefault(x => x.AccountId == accId && x.CurrencyId == currId).Id;
                }
            }
            catch (Exception ex) { }
        }

        private void frmTransfer_KeyDown(object sender, KeyEventArgs e)
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

        private void FromFundcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    int accId = (int)clientComboBox.SelectedValue;
                    int accFundId = (int)FromFundcomboBox.SelectedValue;
                    int currId = (int)currencyIdComboBox.SelectedValue;
                    accountsFundBindingSource2.DataSource = db.AccountFunds.Where(x => x.AccountId == accId && x.CurrencyId == currId && x.Id != accFundId).ToList();
                }

            }
            catch (Exception ex) { }
        }
    }
}
