using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Alver.DAL;
using Alver.Misc;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmExpense : Form
    {
        //dbEntities db;
        Expense _expensess;
        Currency _currency;
        ExpenseCategory _category;
        //Fund _fund;
        public frmExpense(Expense Expensess)
        {
            InitializeComponent();
            _expensess = Expensess == null ? (new Expense()) : Expensess;
        }
        private void frmExpensess_Load(object sender, EventArgs e)
        {
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            LoadData();
            ControlsEnable(false);
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                db.ExpenseCategories.AsNoTracking().Load();

                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                paymentsExpenseCategoryBindingSource.DataSource = db.ExpenseCategories.AsNoTracking().AsQueryable().ToList();
            }
            Misc.Utilities.SearchableComboBox(categoryComboBox);
        }
        private void InitTransactions()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    string _declaration = string.Format("مصروف - {0}", categoryComboBox.Text.Trim());
                    Guid _guid = _expensess.GUID.Value;
                    int _currencyId = (int)currencyIdComboBox.SelectedValue;
                    decimal _amount = amountNumericUpDown.Value;
                    TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.EXS, _expensess.ExpenseDate.Value, _guid, _declaration);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي سيتم التراجع عن الحفظ");
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
                        //_expensess.Fund = _fund;
                        _expensess.Currency = _currency;
                        _expensess.ExpenseCategory = _category;
                        _expensess.User = _user;
                        db.Set<Expense>().Add(_expensess);
                        // use the following statement so that Childs won't be inserted
                        //db.Entry(_fund).State = EntityState.Detached;
                        db.Entry(_category).State = EntityState.Detached;
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
        private void PrepareItem()
        {
            try
            {
                //ExpensessCategory();
                //ExpensessCurrency();
                //ExpensessFund();
                int _categoryId = (int)categoryComboBox.SelectedValue;
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                //int _fundId = (int)currencyIdComboBox.SelectedValue;
                using (dbEntities db = new dbEntities())
                {
                    _category = db.ExpenseCategories.FirstOrDefault(x => x.Id == _categoryId);
                    _currency = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                    //_fund = db.Funds.FirstOrDefault(x => x.CurrencyId == _fundId);
                }
                _expensess = new Expense();

                _expensess.ExpenseDate = expenseDateDateTimePicker.Value;
                //_expensess.FundId = _fund.Id;
                _expensess.Amount = amountNumericUpDown.Value;
                _expensess.CurrencyId = _currency.Id;
                _expensess.CategoryId = _category.Id;
                _expensess.Declaration = notesTextBox.Text;
                _expensess.LUD = DateTime.Now;
                _expensess.UserId = Properties.Settings.Default.LoggedInUser.Id;
                _expensess.Flag = "";
                _expensess.Hidden = false;
                _expensess.GUID = Guid.NewGuid();
                _expensess.PROTECTED = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }
        private void ExpensessCategory()
        {
            try
            {
                int Id = (int)categoryComboBox.SelectedValue;
                using (dbEntities db = new dbEntities())
                {
                    _category = db.ExpenseCategories.FirstOrDefault(x => x.Id == Id);
                }
            }
            catch (Exception ex)
            {

            }

        }
        private void ExpensessCurrency()
        {
            try
            {
                int Id = (int)currencyIdComboBox.SelectedValue;
                using (dbEntities db = new dbEntities())
                {
                    _currency = db.Currencies.FirstOrDefault(x => x.Id == Id);
                }
            }
            catch (Exception ex)
            {
            }

        }
        //private void ExpensessFund()
        //{
        //    try
        //    {
        //        using (dbEntities db = new dbEntities())
        //        {
        //            int Id = (int)currencyIdComboBox.SelectedValue;
        //            _fund = db.Funds.FirstOrDefault(x => x.CurrencyId == Id);
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}
        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            //LoadData();
            currencyBindingSource.Position = 1;
            ControlsEnable(true);
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            //_expensess = new Payments_Expense();
            //LoadData();
            //currencyBindingSource.Position = 1;
        }
        private void ControlsEnable(bool _enable)
        {
            expenseDateDateTimePicker.Value = DateTime.Now;
            notesTextBox.Clear();
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            amountNumericUpDown.Value = amountNumericUpDown.Minimum;
            groupBox1.Enabled = _enable;
        }
        private bool CheckExpensessAmount()
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
                if (!CheckExpensessAmount())
                    return;
                PrepareItem();
                //else if (!Validator.VFundFound(_expensess.CurrencyId.Value))
                //{
                //    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة المصروف، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
                //    return;
                //}
                //else if (!Validator.VFundBalance(_expensess.CurrencyId.Value, _expensess.Amount.Value))
                //{
                //    MessageBox.Show("لا يمكن تصريف المبلغ الرصيد في الصندوق غير كاف", "تنبيه");
                //    return;
                //}
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }
        private void frmExpensess_KeyDown(object sender, KeyEventArgs e)
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
