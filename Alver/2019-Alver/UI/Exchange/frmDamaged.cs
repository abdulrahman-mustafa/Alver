using SimpleEx.Classes;
using DAL;
using DAL.Classes;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace SimpleEx.PL.BaseFund
{
    public partial class frmDamaged : Form
    {
        MoneyExchange _moneyExchange;
        Fund _toFund, _fromFund;
        Currency _from, _to;
        public frmDamaged(MoneyExchange MoneyEx)
        {
            InitializeComponent();
            _moneyExchange = MoneyEx == null ? (new MoneyExchange()) : MoneyEx;
        }
        private void frmTransferMoney_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlsEnable(false);
        }
        public void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.ToList();
                currencyBindingSource1.DataSource = db.Currencies.ToList();
            }
            Utilities.SearchableComboBox(fromCurrencyComboBox);
            Utilities.SearchableComboBox(toCurrencyComboBox);
        }
        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities())
                    {
                        Users_User _user = Properties.Settings.Default.LoggedInUser;
                        _moneyExchange.Users_User = _user;
                        _moneyExchange.Fund = _fromFund;
                        _moneyExchange.Fund1 = _toFund;
                        _moneyExchange.Currency = _from;
                        _moneyExchange.Currency1 = _to;
                        db.Set<MoneyExchange>().Add(_moneyExchange);
                        db.Entry(_fromFund).State = EntityState.Detached;
                        db.Entry(_toFund).State = EntityState.Detached;
                        db.Entry(_toFund).State = EntityState.Detached;
                        db.Entry(_from).State = EntityState.Detached;
                        db.Entry(_to).State = EntityState.Detached;
                        db.Entry(_user).State = EntityState.Detached;
                        db.SaveChanges();
                        InitTransactions();
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح"); }
        }
        private void InitTransactions()
        {
            string _declaration = string.Format("{0} عملة تالفة", _moneyExchange.Direction.ToString());
            int _baseCurrencyId = _moneyExchange.BaseCurrencyId.Value;
            decimal _baseAmount = _moneyExchange.BaseAmount.Value;
            int _subCurrencyId = _moneyExchange.SubCurrencyId.Value;
            decimal _subAmount = _moneyExchange.SubAmount.Value;
            if (buyradioButton.Checked)
            {
                TransactionsOperations.InsertFundTransaction(_baseCurrencyId, _baseAmount, TransactionsOperations.TT.TNB, _moneyExchange.ExchangeDate.Value, _moneyExchange.GUID.Value, _declaration);
                TransactionsOperations.InsertFundTransaction(_subCurrencyId, _subAmount, TransactionsOperations.TT.TNS, _moneyExchange.ExchangeDate.Value, _moneyExchange.GUID.Value, _declaration);
            }
            else if (sellradioButton.Checked)
            {
                TransactionsOperations.InsertFundTransaction(_baseCurrencyId, _baseAmount, TransactionsOperations.TT.TNS, _moneyExchange.ExchangeDate.Value, _moneyExchange.GUID.Value, _declaration);
                TransactionsOperations.InsertFundTransaction(_subCurrencyId, _subAmount, TransactionsOperations.TT.TNB, _moneyExchange.ExchangeDate.Value, _moneyExchange.GUID.Value, _declaration);
            }

        }
        private void Prepareitem()
        {
            _moneyExchange = new MoneyExchange();
            Guid _guid = Guid.NewGuid();
            int _baseCurrency = (int)fromCurrencyComboBox.SelectedValue;
            int _subCurrency = (int)toCurrencyComboBox.SelectedValue;

            using (dbEntities db = new dbEntities())
            {
                _from = db.Currencies.FirstOrDefault(x => x.Id == _baseCurrency);
                _to = db.Currencies.FirstOrDefault(x => x.Id == _subCurrency);
                _toFund = db.Funds.FirstOrDefault(x => x.CurrencyId == _subCurrency);
                _fromFund = db.Funds.FirstOrDefault(x => x.CurrencyId == _baseCurrency);
            }
            _moneyExchange.Direction = ExDirection();
            _moneyExchange.ExchangeDate = exchangeDateDateTimePicker.Value;
            _moneyExchange.Factor = true;
            _moneyExchange.Rate = 1;
            _moneyExchange.SubAmount = toAmountnumeric.Value;
            _moneyExchange.RoundAmount = 0;
            _moneyExchange.SubCurrencyId = _subCurrency;
            _moneyExchange.BaseAmount = fromamountnumeric.Value;
            _moneyExchange.BaseCurrencyId = _baseCurrency;
            _moneyExchange.Declaration = declarationTextBox.Text.Trim();
            _moneyExchange.SubFundId = _toFund.Id;
            _moneyExchange.BaseFundId = _fromFund.Id;
            _moneyExchange.RoundAmount = toAmountnumeric.Value;
            _moneyExchange.LUD = DateTime.Now;
            _moneyExchange.UserId = Properties.Settings.Default.LoggedInUser.Id;
            _moneyExchange.Hidden = false;
            _moneyExchange.Flag = "";
            _moneyExchange.GUID = _guid;
            _moneyExchange.PROTECTED = false;
        }
        private string ExDirection()
        {
            //return sellradioButton.Checked ? Utilities.ExchangeType.بيع.ToString() : Utilities.ExchangeType.شراء.ToString();
            return sellradioButton.Checked ? "بيع تالف" : "شراء تالف";
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            ControlsEnable(true);
        }
        public void ControlsEnable(bool _enable)
        {
            exchangeDateDateTimePicker.Value = DateTime.Now;
            exchangeDateDateTimePicker.Enabled = _enable;
            declarationTextBox.Clear();
            declarationTextBox.Enabled = _enable;
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            fromamountnumeric.Value = fromamountnumeric.Minimum;
            toAmountnumeric.Value = toAmountnumeric.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
            fromamountnumeric.Focus();
        }
        private bool CheckExchangeAmount()
        {
            bool _result = true;
            if (fromamountnumeric.Value == 0)
            {
                MessageBox.Show("الرجاء التأكد من قيمة المبلغ، لا يجب ان يكون المبلغ 0");
                fromamountnumeric.Focus();
                _result = false;
            }
            else if (toAmountnumeric.Value == 0)
            {
                MessageBox.Show("الرجاء التأكد من قيمة المبلغ، لا يجب ان يكون المبلغ 0");
                toAmountnumeric.Focus();
                _result = false;
            }
            return _result;
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckExchangeAmount())
                    return;
                Prepareitem();
                //var basecurrency = (int)fromCurrencyComboBox.SelectedValue;
                //var subcurrency = (int)toCurrencyComboBox.SelectedValue;
                //var baseAmount = fromamountnumeric.Value;
                //var subAmount = toAmountnumeric.Value;
                //if (!Validator.VFundFound(basecurrency))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق للعملة الاساس، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
                //    return;
                //}
                //else if (!Validator.VFundFound(subcurrency))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق للعملة الطرف، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
                //    return;
                //}
                //else if (sellradioButton.Checked)
                //{
                //    if (!Validator.VFundBalance(basecurrency, baseAmount))
                //    {
                //        MessageBox.Show("لا يمكن بيع المبلغ الرصيد في الصندوق غير كاف", "تنبيه");
                //        return;
                //    }
                //}
                //else if (buyradioButton.Checked)
                //{
                //    if (!Validator.VFundBalance(subcurrency, subAmount))
                //    {
                //        MessageBox.Show("لا يمكن شراء المبلغ الرصيد في الصندوق غير كاف", "تنبيه");
                //        return;
                //    }
                //}
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي أثناء الحفظ");
            }
        }
        private void frmTransferMoney_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addbtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                savebtn_Click(sender, e);
            }
        }
    }
}
