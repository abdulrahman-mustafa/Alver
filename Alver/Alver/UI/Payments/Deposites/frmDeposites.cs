using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Payments.Deposites
{
    public partial class frmDeposites : Form
    {
        private dbEntities db;
        private Payment _payment;

        public frmDeposites(Payment Payment)
        {
            InitializeComponent();
            _payment = Payment == null ? (new Payment()) : Payment;
        }

        private void frmPayments_Load(object sender, EventArgs e)
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            db.Currencies.Load();
            db.Accounts.Load();
            db.Payments.Load();
            db.Users.Load();
            userBindingSource.DataSource = db.Users.ToList();
            currencyBindingSource.DataSource = db.Currencies.ToList();
            accountsInfoBindingSource.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
            accountsInfoBindingSource1.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
            MISC.Utilities.SearchableComboBox(clientComboBox);
        }

        private void payments_OperationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //dgv.EndEdit();
            //CheckChanges();
            //db.SaveChanges();
            //MSGs.SaveMessage();
            //Retrive();
        }

        private void CheckChanges()
        {
            foreach (Payment item in paymentsTransactionBindingSource.List)
            {
                try
                {
                    if (item != null)
                    {
                        try
                        {
                            if (db.Entry(item).State == EntityState.Modified)
                            {
                                var originalValues = db.Entry(item).OriginalValues;
                                var currentValues = db.Entry(item).CurrentValues;
                                ItemChanged(originalValues, currentValues, item);
                                item.LUD = DateTime.Now;
                            }
                        }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                        catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                    }
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            }//END foreach
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

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (_payment != null && paymentsTransactionBindingSource.Count > 0)
        //        {
        //            if (!Validator.VCFundFound(_payment.BorrowerId.Value, _payment.CurrencyId.Value))
        //            {
        //                MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الامانة لدى الوكيل المرسل، يرجى إنشاء صندوق للوكيل بنفس عملة الامانة اولاً", "تنبيه");
        //                return;
        //            }
        //            else if (_payment.Direction == Utilities.PaymentTransactionType.أمانة_مسلمة.ToString())
        //            {
        //                if (!Validator.VFundFound(_payment.CurrencyId.Value))
        //                {
        //                    MessageBox.Show("لا يوجد صندوق اساسي موافق لعملة الامانة، يرجى إنشاء صندوق مكتب اولاً", "تنبيه");
        //                    return;
        //                }
        //                else if (!Validator.VFundBalance(_payment.CurrencyId.Value, _payment.Amount.Value))
        //                {
        //                    MessageBox.Show("لا يمكن تسليم الأمانة للوكيل الرصيد في الصندوق غير كاف", "تنبيه");
        //                    return;
        //                }
        //            }
        //            _payment.Payed = true;
        //            _payment.PayDate = DateTime.Now;
        //            db.SaveChanges();
        //            Retrive();
        //            MessageBox.Show("تم رد الأمانة بنجاح");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حدث خطأ أثناء رد الأمانة");
        //    }
        //}

        private void payments_OperationDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void paymentsTransactionBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                _payment = paymentsTransactionBindingSource.Current as Payment;

                if (_payment != null && _payment.Payed != null)
                {
                    //toolStripButton1.Enabled = !_payment.Payed.Value;
                }
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
            if (paymentsTransactionBindingSource.Count <= 0)
                return;
            bindingNavigatorDeleteItem.Enabled = false;
            try
            {
                _payment = paymentsTransactionBindingSource.Current as Payment;
                int _paymentId = _payment.Id;
                if (_payment != null && paymentsTransactionBindingSource.Count > 0)
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        _payment = db.Payments.Find(_paymentId);
                        int _accountId = _payment.AccountId.Value;
                        int _currencyId = _payment.CurrencyId.Value;
                        decimal _amount = _payment.Amount.Value;
                        TransactionsFuncs.DeleteTransactions(_payment.GUID.Value, _currencyId, _accountId, 0, TransactionsFuncs.TT.FOO);
                        TransactionsFuncs.ClientsRunningTotals(_accountId);
                        TransactionsFuncs.FundsRunningTotals(_currencyId);
                        db.Payments.Remove(_payment);
                        paymentsTransactionBindingSource.RemoveCurrent();
                        db.SaveChanges();
                    }
                    MessageBox.Show("تم الحذف بنجاح");
                    Retrive();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ أثناء حذف الأمانة");
            }
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            if ((inDepositecb.Checked && outDepositecb.Checked) || (!inDepositecb.Checked && !outDepositecb.Checked))
            {
                dgvTotals.Visible = false;
            }
            else
            {
                DGVTotals();
                dgvTotals.Visible = true;
            }
            //DGVTotals();
        }

        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void Retrive()
        {
            LoadData();
            int _clientId = 0;
            bool _inDeposite = false, _outDeposite = false;
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
            if (clientcb.Checked)
            {
                _clientId = (int)clientComboBox.SelectedValue;
            }
            _inDeposite = inDepositecb.Checked;
            _outDeposite = outDepositecb.Checked;
            Search(_clientId, _inDeposite, _outDeposite, _from, _to);
            ColorizeDgv();
        }

        private void Search(int _clientId, bool _inDeposite, bool _outDeposite, DateTime _from, DateTime _to)
        {
            var _query = new System.Collections.Generic.List<Payment>();
            if (_from.Year == _to.Year && _from.Month == _to.Month)
            {
                _query = db.Payments.Where(
                    x =>
                    (x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year) &&
                    (x.PaymentDate.Value.Month >= _from.Month && x.PaymentDate.Value.Month <= _to.Month) &&
                    (x.PaymentDate.Value.Day >= _from.Day && x.PaymentDate.Value.Day <= _to.Day)
                    ).ToList();
            }
            else if (_from.Year != _to.Year)
            {
                _query = db.Payments.Where(
                    x =>
                    (x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year)
                    ).ToList();
            }
            else if (_from.Year == _to.Year && _from.Month != _to.Month)
            {
                _query = db.Payments.Where(
                    x =>
                    (x.PaymentDate.Value.Year >= _from.Year && x.PaymentDate.Value.Year <= _to.Year) &&
                    (x.PaymentDate.Value.Month >= _from.Month && x.PaymentDate.Value.Month <= _to.Month)
                    ).ToList();
            }
            if (_inDeposite && !_outDeposite)
            {
                _query = _query.Where(x =>
                  x.PaymentType == MISC.Utilities.PaymentTransactionType.أمانة_مسلمة.ToString()
                ).ToList();
            }
            else if (!_inDeposite && _outDeposite)
            {
                _query = _query.Where(x =>
                  x.PaymentType == MISC.Utilities.PaymentTransactionType.أمانة_مستلمة.ToString()
                ).ToList();
            }
            else
            {
                _query = _query.Where(x =>
                  x.PaymentType == MISC.Utilities.PaymentTransactionType.أمانة_مستلمة.ToString() ||
                  x.PaymentType == MISC.Utilities.PaymentTransactionType.أمانة_مسلمة.ToString()
                ).ToList();
            }
            if (_clientId != 0)
            {
                _query = _query.Where(x =>
                  x.AccountId == _clientId
                ).ToList();
            }
            paymentsTransactionBindingSource.DataSource = _query.ToList();
        }

        private void ColorizeDgv()
        {
            //int _index = payedDataGridViewTextBoxColumn.Index;
            //Misc.Utilities.ColorizeForeFontStringDGV(dgv, _index, Misc.Utilities.PaymentTransactionType.أمانة_مسلمة.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void clientcb_CheckedChanged(object sender, EventArgs e)
        {
            clientComboBox.Enabled = clientcb.Checked;
        }

        private void frmDeposites_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv.DataSource = null;
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }
    }
}