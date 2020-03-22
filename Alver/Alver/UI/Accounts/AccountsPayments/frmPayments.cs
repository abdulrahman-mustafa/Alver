using Alver.DAL;
using Alver.MISC;

#pragma warning disable CS0105 // The using directive for 'Alver.MISC' appeared previously in this namespace
using Alver.MISC;
#pragma warning restore CS0105 // The using directive for 'Alver.MISC' appeared previously in this namespace

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts.AccountsPayments
{
    public partial class frmPayments : Form
    {
        //dbEntities db;
        private Payment _payment;

        public frmPayments(Payment Payment)
        {
            InitializeComponent();
            _payment = Payment == null ? (new Payment()) : Payment;
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                db.Accounts.AsNoTracking().Load();
                db.Payments.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                CurrencybindingSource1.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                usersUserBindingSource.DataSource = db.Users.AsNoTracking().AsQueryable().ToList();
                accountsInfoBindingSource.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
                accountsInfoBindingSource1.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
            }
            MISC.Utilities.SearchableComboBox(accountcombobox);
        }

        private void payments_OperationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //dgv.EndEdit();
            //CheckChanges();
            //Utilities.SaveChanges(ref db, this);
            //Retrive();
        }

        private void CheckChanges()
        {
            //foreach (Payment item in paymentsOperationBindingSource.List)
            //{
            //    try
            //    {
            //        if (item != null)
            //        {
            //            try
            //            {
            //                if (db.Entry(item).State == EntityState.Modified)
            //                {
            //                    var originalValues = db.Entry(item).OriginalValues;
            //                    var currentValues = db.Entry(item).CurrentValues;
            //                    ItemChanged(originalValues, currentValues, item);
            //                    item.LUD = DateTime.Now;
            //                }
            //            }
            //            catch (Exception ex) { }
            //        }
            //    }
            //    catch (Exception ex) { }
            //}//END foreach
        }

        private void ItemChanged(DbPropertyValues originalValues, DbPropertyValues currentValues, Payment item)
        {
            foreach (string propertyName in originalValues.PropertyNames)
            {
                var original = originalValues[propertyName];
                var current = currentValues[propertyName];
                if (!Equals(original, current))
                {
                    //TransactionsOperations.UpdateFundTransactions(ref db, originalValues, currentValues, item.GUID.Value);
                    //TransactionsOperations.UpdateTransactions(ref db, originalValues, currentValues, item.PaymentDate.Value, item.GUID.Value);
                    break;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (_payment != null&&paymentsOperationBindingSource.Count>0)
            //    {
            //        _payment.Payed = true;
            //        _payment.PayDate = DateTime.Now;
            //        db.SaveChanges();
            //        Retrive();
            //        MessageBox.Show("تم رد الأمانة بنجاح");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("حدث خطأ أثناء رد الأمانة");
            //}
        }

        private void payments_OperationDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void paymentsOperationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                _payment = paymentsOperationBindingSource.Current as Payment;

                //if (_payment != null && _payment.Payed != null)
                //{
                //    toolStripButton1.Enabled = !_payment.Payed.Value;
                //}
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult _ConfirmationDialog = MessageBox.Show("هل انت متأكد من تنفيذ العملية؟، لن تتمكن من التراجع عن تنفيذ العملية!", "تنبيه", MessageBoxButtons.YesNo);
            if (_ConfirmationDialog != DialogResult.Yes)
                return;
            if (paymentsOperationBindingSource.Count <= 0)
                return;
            try
            {
                _payment = paymentsOperationBindingSource.Current as Payment;
                int _paymentId = _payment.Id;

                if (_payment != null && paymentsOperationBindingSource.Count > 0)
                {
                    using (dbEntities db = new dbEntities())
                    {
                        _payment = db.Payments.Find(_paymentId);
                        int _accountId = _payment.AccountId.Value;
                        int _currencyId = _payment.CurrencyId.Value;
                        decimal _amount = _payment.Amount.Value;
                        TransactionsFuncs.DeleteTransactions(_payment.GUID.Value, _currencyId, _accountId);
                        TransactionsFuncs.ClientsRunningTotals(_accountId);
                        TransactionsFuncs.FundsRunningTotals(_currencyId);
                        db.Payments.Remove(_payment);
                        paymentsOperationBindingSource.RemoveCurrent();
                        db.SaveChanges();
                    }
                    Retrive();
                    MessageBox.Show("تم الحذف بنجاح");
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ أثناء الحذف");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            DGVTotals();
        }

        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void Retrive()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                LoadData();
                DateTime _from, _to;
                if (FromDateTimePicker.Checked)
                {
                    _from = FromDateTimePicker.Value;
                }
                else
                {
                    _from = FromDateTimePicker.MinDate;
                }
                _to = ToDateTimePicker.Value;
                string _fromClient = null, _toClient = null;
                if (fromclientcb.Checked)
                {
                    _fromClient = MISC.Utilities.PaymentType.دفعة_من_وكيل.ToString();
                }
                if (toclientcb.Checked)
                {
                    _toClient = MISC.Utilities.PaymentType.دفعة_لوكيل.ToString();
                }
                int _accountId = 0;
                if (accountcb.Checked)
                {
                    _accountId = (int)accountcombobox.SelectedValue;
                }
                int _currencyId = 0;
                if (currencycheckBox.Checked)
                {
                    _currencyId = (int)currencycomboBox.SelectedValue;
                }

                //paymentsOperationBindingSource.DataSource = db.Payment.Where(
                //x => (x.PaymentType == Utilities.PaymentType.دفعة_لوكيل.ToString() ||
                //x.PaymentType == Utilities.PaymentType.دفعة_من_وكيل.ToString()) &&
                //x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year &&
                //(x.PaymentDate.Value.Month >= _from.Month && x.PaymentDate.Value.Month <= _to.Month) &&
                //(x.PaymentDate.Value.Day >= _from.Day && x.PaymentDate.Value.Day <= _to.Day)
                //).ToList();
                GrandSearch(_from, _to, _currencyId, _accountId, _fromClient, _toClient);
                ColorizeDgv();
                this.Cursor = Cursors.Default;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }

        private IQueryable<Payment> GrandSearch(DateTime _from, DateTime _to, int _currencyId, int _accountId, string _fromClient, string _toClient)
        {
            IQueryable<Payment> _query;// = new IQueryable<Remittances_Operation>;
            using (dbEntities db = new dbEntities())
            {
                _query = db.Payments as IQueryable<Payment>;
                if (_from.Year == _to.Year && _from.Month == _to.Month)
                {
                    _query = db.Payments.Where(
                            x => ((x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year) &&
                                (x.PaymentDate.Value.Month >= _from.Month && x.PaymentDate.Value.Month <= _to.Month) &&
                                (x.PaymentDate.Value.Day >= _from.Day && x.PaymentDate.Value.Day <= _to.Day))

                        ).AsQueryable();
                }
                else if (_from.Year != _to.Year)
                {
                    _query = db.Payments.Where(
                        x => x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year
                        ).AsQueryable();
                }
                else if (_from.Year == _to.Year && _from.Month != _to.Month)
                {
                    _query = db.Payments.Where(
                        x => ((x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year) &&
                        (x.PaymentDate.Value.Month >= _from.Month && x.PaymentDate.Value.Month <= _to.Month))
                        ).AsQueryable();
                }
                if (_currencyId != 0)
                {
                    _query = _query.Where(x => x.CurrencyId == _currencyId);
                }
                if (_accountId != 0)
                {
                    _query = _query.Where(x => x.AccountId == _accountId);
                }
                _query = _query.Where(x =>
                                  (x.PaymentType == _fromClient && _fromClient != null) ||
                                  (x.PaymentType == _toClient && _toClient != null));
                paymentsOperationBindingSource.DataSource = _query.ToList();
            }
            //LoadData();
            return _query;
        }

        private void ColorizeDgv()
        {
            int _index = paymentTypeDataGridViewTextBoxColumn.Index;
            MISC.Utilities.ColorizeStringDGV(dgv, _index, "دفعة_لعميل");
        }

        private void frmPayments_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv.DataSource = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }

        private void currencycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currencycomboBox.Enabled = currencycheckBox.Checked;
        }

        private void accountcb_CheckedChanged(object sender, EventArgs e)
        {
            accountcombobox.Enabled = accountcb.Checked;
        }
    }
}