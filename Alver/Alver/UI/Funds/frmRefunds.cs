using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;
using Alver.DAL;
using Alver.Misc;

namespace Alver.UI.Funds
{
    public partial class frmRefunds : Form
    {
        dbEntities db;
        Payment _payment;
        public frmRefunds(Payment Payment)
        {
            InitializeComponent();
            _payment = Payment == null ? (new Payment()) : Payment;
        }
        private void frmPayments_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            db.Users.Load();
            db.Currencies.Load();
            db.Accounts.Load();
            db.Payments.Load();
            db.Funds.Load();
            usersUserBindingSource.DataSource = db.Users.ToList();
            fundBindingSource.DataSource = db.Funds.ToList();
            currencyBindingSource.DataSource = db.Currencies.ToList();
            currencyBindingSource1.DataSource = db.Currencies.ToList();
            Misc.Utilities.SearchableComboBox(currencyComboBox);
        }
        private void payments_OperationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dgv.EndEdit();
            CheckChanges();
            Misc.Utilities.SaveChanges(ref db, this);
            Retrive();
        }

        private void CheckChanges()
        {
            foreach (Payment item in paymentsOperationBindingSource.List)
            {
                try
                {
                    if (item != null)
                    {
                        try
                        {
                            EntityState _state = db.Entry(item).State;
                            if (_state == EntityState.Modified)
                            {
                                var originalValues = db.Entry(item).OriginalValues;
                                var currentValues = db.Entry(item).CurrentValues;
                                ItemChanged(originalValues, currentValues, item.GUID.Value);
                                item.LUD = DateTime.Now;
                            }
                        }
                        catch (Exception ex) { }
                    }
                }
                catch (Exception ex) { }
            }//END foreach
        }

        private void ItemChanged(DbPropertyValues originalValues, DbPropertyValues currentValues, Guid _guid)
        {
            foreach (string propertyName in originalValues.PropertyNames)
            {
                var original = originalValues[propertyName];
                var current = currentValues[propertyName];
                if (!Equals(original, current))
                {
                    //TransactionsOperations.UpdateFundTransactions(ref db, originalValues, currentValues, _guid);
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
            catch (Exception ex) { }
        }
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult _ConfirmationDialog = MessageBox.Show("هل انت متأكد من تنفيذ العملية؟، لن تتمكن من التراجع عن تنفيذ العملية!", "تنبيه", MessageBoxButtons.YesNo);
            if (_ConfirmationDialog != DialogResult.Yes)
                return;
            try
            {
                if (paymentsOperationBindingSource.Count <= 0)
                    return;
                Payment _payment = paymentsOperationBindingSource.Current as Payment;
                if (_payment != null && paymentsOperationBindingSource.Count > 0)
                {
                    int _accountId = _payment.AccountId.Value;
                    int _currencyId = _payment.CurrencyId.Value;
                    decimal _amount = _payment.Amount.Value;
                    TransactionsOperations.DeleteTransactions(_payment.GUID.Value, _currencyId, _accountId,0, TransactionsOperations.TT.FOO);
                    db.Payments.Remove(_payment);
                    paymentsOperationBindingSource.RemoveCurrent();
                    db.SaveChanges();
                    Retrive();
                    MessageBox.Show("تم الحذف بنجاح");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            if (!fromFundchkbox.Checked || !toFundchkbox.Checked)
            {
                DGVTotals();
                //dgvTotals.Visible = true;
            }
            else
            {
                //dgvTotals.Visible = false;
            }
        }

        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            //dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void Retrive()
        {
            DateTime _from, _to;
            int _currencyId = 0;
            string _fromFund = null, _toFund = null;
            if (FromDateTimePicker.Checked)
            {
                _from = FromDateTimePicker.Value;
            }
            else
            {
                _from = FromDateTimePicker.MinDate;
            }
            _to = ToDateTimePicker.Value;
            if (currencychkbox.Checked)
            {
                _currencyId = (int)currencyComboBox.SelectedValue;
            }
            if (toFundchkbox.Checked)
            {
                _toFund = Misc.Utilities.PaymentType.تغذية_صندوق.ToString();
            }
            if (fromFundchkbox.Checked)
            {
                _fromFund = Misc.Utilities.PaymentType.سحب_من_صندوق.ToString();
            }
            Search(_from, _to, _currencyId, _fromFund, _toFund);
        }

        private void Search(DateTime _from, DateTime _to, int _currencyId, string _fromFund, string _toFund)
        {
            LoadData();
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
            _query = _query.Where(x =>
                      (x.PaymentType == _fromFund && _fromFund != null) ||
                      (x.PaymentType == _toFund && _toFund != null)
            ).ToList();
            if (_currencyId != 0)
            {
                _query = _query.Where(x =>
                (x.CurrencyId == _currencyId)
              ).ToList();
            }
            paymentsOperationBindingSource.DataSource = _query.ToList();
            ColorizeDgv();
        }

        private void ColorizeDgv()
        {
            int _index = paymentTypeDataGridViewTextBoxColumn.Index;
            Misc.Utilities.ColorizeStringForeColorDGV(dgv, _index, "سحب_من_صندوق");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            currencyComboBox.Enabled = currencychkbox.Checked;
        }

        private void currencychkbox_CheckedChanged(object sender, EventArgs e)
        {
            currencyComboBox.Enabled = currencychkbox.Checked;
        }

        private void editobjectbtn_Click(object sender, EventArgs e)
        {
            Payment _object = paymentsOperationBindingSource.Current as Payment;
            if (_object != null)
            {
                frmRefund frm = new frmRefund(_object);
                frm._purpose = "edit";
                frm.Text = "تعديل";
                frm.ControlsEnable(true);
                frm.InitFormForEdit(_object);
                frm.addbtn.Visible = false;
                frm.ShowDialog();
                db.SaveChanges();
                Retrive();
            }
        }

        private void frmRefunds_FormClosing(object sender, FormClosingEventArgs e)
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
