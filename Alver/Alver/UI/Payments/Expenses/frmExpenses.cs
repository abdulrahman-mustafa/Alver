﻿using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmExpenses : Form
    {
        dbEntities db;
        Expens _expensess;
        public frmExpenses()
        {
            InitializeComponent();
        }

        private void frmExpensesses_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;

            db.Currencies.Load();
            db.Expenses.Load();
            db.ExpenseCategories.Load();
            db.Funds.Load();
            paymentsExpenseCategoryBindingSource1.DataSource = db.ExpenseCategories.ToList();
            paymentsExpenseCategoryBindingSource.DataSource = db.ExpenseCategories.ToList();
            currencyBindingSource.DataSource = db.Currencies.Where(x => x.Id == 1).ToList();
            fundBindingSource.DataSource = db.Funds.ToList();
            MISC.Utilities.SearchableComboBox(expenseCategoryComboBox);
        }

        private void payments_ExpenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            dgv.EndEdit();
            //CheckChanges();
            db.SaveChanges();
            MSGs.SaveMessage();
            Retrive();
        }
        private void CheckChanges()
        {
            foreach (Expens item in payments_ExpenseBindingSource.List)
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
        private void ItemChanged(DbPropertyValues originalValues, DbPropertyValues currentValues, Expens item)
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
        private void payments_ExpenseDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult _ConfirmationDialog = MessageBox.Show("هل انت متأكد من تنفيذ العملية؟، لن تتمكن من التراجع عن تنفيذ العملية!", "تنبيه", MessageBoxButtons.YesNo);
            if (_ConfirmationDialog != DialogResult.Yes)
                return;
            if (payments_ExpenseBindingSource.Count <= 0)
                return;
            bindingNavigatorDeleteItem.Enabled = false;
            try
            {
                if (_expensess != null)
                {
                    int _currencyId = _expensess.CurrencyId.Value;
                    decimal _amount = _expensess.Amount.Value;
                    TransactionsFuncs.DeleteTransactions(_expensess.GUID.Value, _currencyId);

                    TransactionsFuncs.FundsRunningTotals(_currencyId); db.Expenses.Remove(_expensess);
                    payments_ExpenseBindingSource.RemoveCurrent();
                    MessageBox.Show("تم الحفظ بنجاح");
                }

            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void payments_ExpenseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _expensess = payments_ExpenseBindingSource.Current as Expens;
            if (payments_ExpenseBindingSource.Count < 1)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
            else
            {
                bindingNavigatorDeleteItem.Enabled = true;
            }
        }

        private void payments_ExpenseDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Retrive();
                DGVTotals();
            }
            catch (Exception Ex)
            {
                MSGs.ErrorMessage(Ex);
            }
        }
        private void DGVTotals()
        {
            int _currencyIndex = dataGridViewTextBoxColumn4.Index;
            int _amountIndex = dataGridViewTextBoxColumn5.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void Retrive()
        {
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
            int Id = 0;
            if (expenseCategoryComboBox.SelectedValue != null)
                Id = (int)expenseCategoryComboBox.SelectedValue;
            if (_from.Year == _to.Year && _from.Month == _to.Month)
            {
                if (radioButton3.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year &&
                    (x.ExpenseDate.Value.Month >= _from.Month && x.ExpenseDate.Value.Month <= _to.Month) &&
                    (x.ExpenseDate.Value.Day >= _from.Day && x.ExpenseDate.Value.Day <= _to.Day)
                    ).ToList();
                }
                else if (radioButton1.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year &&
                    (x.ExpenseDate.Value.Month >= _from.Month && x.ExpenseDate.Value.Month <= _to.Month) &&
                    (x.ExpenseDate.Value.Day >= _from.Day && x.ExpenseDate.Value.Day <= _to.Day)
                    && x.CategoryId == Id
                    ).ToList();
                }
            }
            else if (_from.Year != _to.Year)
            {
                if (radioButton3.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year
                    ).ToList();
                }
                else if (radioButton1.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year
                    && x.CategoryId == Id
                    ).ToList();
                }
            }
            else if (_from.Year == _to.Year && _from.Month != _to.Month)
            {
                if (radioButton3.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year &&
                    (x.ExpenseDate.Value.Month >= _from.Month && x.ExpenseDate.Value.Month <= _to.Month)
                    ).ToList();
                }
                else if (radioButton1.Checked)
                {
                    payments_ExpenseBindingSource.DataSource = db.Expenses.Where(
                    x => x.ExpenseDate.Value.Year >= _from.Year && x.ExpenseDate.Value.Year <= _to.Year &&
                    (x.ExpenseDate.Value.Month >= _from.Month && x.ExpenseDate.Value.Month <= _to.Month)
                    && x.CategoryId == Id
                    ).ToList();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            expenseCategoryComboBox.Enabled = radioButton1.Checked;
        }

        private void frmExpensesses_FormClosing(object sender, FormClosingEventArgs e)
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
