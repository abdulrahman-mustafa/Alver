using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts.Transfers
{
    public partial class frmTransfers : Form
    {
        dbEntities db;
        Transfer _transfer;
        public frmTransfers()
        {
            InitializeComponent();
        }

        private void frmIncomes_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
        }

        private void LoadData()
        {
            db.Transfers.Load();
            db.Currencies.Load();
            db.Accounts.Load();
            db.AccountFunds.Load();
            accountsInfoBindingSource.DataSource = db.Accounts.Where(x => x.Deactivated == false).ToList();
            accountsInfoBindingSource1.DataSource = db.Accounts.Where(x => x.Deactivated == false).ToList();
            accountsInfoBindingSource2.DataSource = db.Accounts.Where(x => x.Deactivated == false).ToList();
            accountsFundBindingSource.DataSource = accountsInfoBindingSource;
            accountsFundBindingSource1.DataSource = accountsInfoBindingSource1;
            currencyBindingSource.DataSource = db.Currencies.ToList();
            MISC.Utilities.SearchableComboBox(clientComboBox);
        }

        private void remittances_OperationDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void Retrive()
        {
            LoadData();
            int _clientId = 0;
            DateTime _from, _to;
            bool _cut = false, _transfer = false;
            if (FromDateTimePicker.Checked)
            {
                _from = FromDateTimePicker.Value;
            }
            else
            {
                _from = FromDateTimePicker.MinDate;
            }
            _to = ToDateTimePicker.Value;
            if (clientrb.Checked)
            {
                _clientId = (int)clientComboBox.SelectedValue;
            }
            _cut = cutrb.Checked;
            _transfer = transferrb.Checked;
            Search(_clientId, _from, _to, _cut, _transfer);
            RemittanceDGV();
        }

        private void Search(int _clientId, DateTime _from, DateTime _to, bool _cut, bool _transfer)
        {
            var _query = new System.Collections.Generic.List<Transfer>();
            if (_from.Year == _to.Year && _from.Month == _to.Month)
            {
                _query = db.Transfers.Where(
                    x =>
                    (x.TransferDate.Value.Year >= _from.Year && x.TransferDate.Value.Year <= _to.Year) &&
                    (x.TransferDate.Value.Month >= _from.Month && x.TransferDate.Value.Month <= _to.Month) &&
                    (x.TransferDate.Value.Day >= _from.Day && x.TransferDate.Value.Day <= _to.Day)
                    ).ToList();
            }
            else if (_from.Year != _to.Year)
            {
                _query = db.Transfers.Where(
                    x =>
                    (x.TransferDate.Value.Year >= _from.Year && x.TransferDate.Value.Year <= _to.Year)
                    ).ToList();
            }
            else if (_from.Year == _to.Year && _from.Month != _to.Month)
            {
                _query = db.Transfers.Where(
                    x =>
                    (x.TransferDate.Value.Year >= _from.Year && x.TransferDate.Value.Year <= _to.Year) &&
                    (x.TransferDate.Value.Month >= _from.Month && x.TransferDate.Value.Month <= _to.Month)
                    ).ToList();
            }
            if (_cut && !_transfer)
            {
                _query = _query.Where(x =>
                x.ClientFrom == x.ClientTo
                ).ToList();
            }
            else if (!_cut && _transfer)
            {
                _query = _query.Where(x =>
                x.ClientFrom != x.ClientTo
                ).ToList();
            }
            if (_clientId != 0)
            {
                _query = _query.Where(x =>
                  x.ClientTo == _clientId ||
                  x.ClientFrom == _clientId
                ).ToList();
            }
            transferClientFundBindingSource.DataSource = _query.ToList();
        }

        private void remittances_OperationBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _transfer = transferClientFundBindingSource.Current as Transfer;
        }

        private void remittances_OperationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            MISC.Utilities.SaveChanges(ref db, this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            DGVTotals();
        }
        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = fromAmountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void RemittanceDGV()
        {
            int _index = rateDataGridViewTextBoxColumn.Index;
            MISC.Utilities.ColorizeDecimalDGV(dgv, _index);
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            DialogResult _ConfirmationDialog = MessageBox.Show("هل انت متأكد من تنفيذ العملية؟، لن تتمكن من التراجع عن تنفيذ العملية!", "تنبيه", MessageBoxButtons.YesNo);
            if (_ConfirmationDialog != DialogResult.Yes)
                return;
            _transfer = transferClientFundBindingSource.Current as Transfer;
            if (_transfer != null && transferClientFundBindingSource.Count <= 0)
                return;
            int _transferId = _transfer.Id;
            bindingNavigatorDeleteItem.Enabled = false;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _transfer = db.Transfers.Find(_transferId);
                    decimal _fromAmount = _transfer.FromAmount.Value;
                    decimal _toAmount = _transfer.ToAmount.Value;

                    int _fromCurrencyId = _transfer.CurrencyId.Value;

                    int _fromAccountId = _transfer.ClientFrom.Value;
                    TransactionsFuncs.DeleteTransactions(_transfer.GUID.Value, _fromCurrencyId, _fromAccountId);
                    if (_transfer.ClientTo == _transfer.ClientFrom)
                    {
                        int _toAccountId = _transfer.ClientTo.Value;
                        int _toCurrencyId = db.AccountFunds.FirstOrDefault(x => x.Id == _transfer.FundTo).CurrencyId.Value;
                        TransactionsFuncs.DeleteTransactions(_transfer.GUID.Value, _toCurrencyId, _toAccountId);
                    }
                    db.Transfers.Remove(_transfer);
                    transferClientFundBindingSource.RemoveCurrent();
                    db.SaveChanges();
                    TransactionsFuncs.ClientsRunningTotals(_transfer.ClientTo.Value);
                    TransactionsFuncs.ClientsRunningTotals(_transfer.ClientFrom.Value);
                }
                MessageBox.Show("تم الحذف بنجاح");
                Retrive();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ داخلي اثناء الحذف");
            }
            bindingNavigatorDeleteItem.Enabled = true;
        }

        private void remittances_OperationBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            dgv.EndEdit();
            CheckChanges();
            MISC.Utilities.SaveChanges(ref db, this);
            Retrive();
            RemittanceDGV();
        }
        private void CheckChanges()
        {
            foreach (Transfer item in transferClientFundBindingSource.List)
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

        private void ItemChanged(DbPropertyValues originalValues, DbPropertyValues currentValues, Transfer item)
        {
            foreach (string propertyName in originalValues.PropertyNames)
            {
                var original = originalValues[propertyName];
                var current = currentValues[propertyName];
                if (!Equals(original, current))
                {
                    //TransactionsOperations.UpdateFundTransactions(ref db, originalValues, currentValues, item.GUID.Value);
                    //TransactionsOperations.UpdateTransactions(ref db, originalValues, currentValues, item.TransferDate.Value, item.GUID.Value);
                    break;
                }
            }
        }
        private void remittances_OperationDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                decimal rate = 1, baseAmount = 0, subAmount = 0;
                bool factor = true;//*
                _transfer = transferClientFundBindingSource.Current as Transfer;

                baseAmount = decimal.Parse(dgvCell(fromAmountDataGridViewTextBoxColumn.Index));
                factor = bool.Parse(dgv.CurrentRow.Cells[factorDataGridViewTextBoxColumn.Index].FormattedValue.ToString());
                rate = decimal.Parse(dgvCell(rateDataGridViewTextBoxColumn.Index));

                subAmount = factor ? (baseAmount * rate) : (baseAmount / rate);
                dgv.CurrentRow.Cells[toAmountDataGridViewTextBoxColumn.Index].Value = Math.Round(subAmount, 2);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }
        private string dgvCell(int index)
        {
            if (dgv.CurrentRow != null)
            {
                return dgv.CurrentRow.Cells[index].FormattedValue == null ? "" : dgv.CurrentRow.Cells[index].FormattedValue.ToString();
            }
            else
            {
                return "";
            }
        }

        private void transferClientFundBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            _transfer = transferClientFundBindingSource.Current as Transfer;
        }

        private void transferrb_CheckedChanged(object sender, EventArgs e)
        {
            rateDataGridViewTextBoxColumn.Visible = !transferrb.Checked;
            toAmountDataGridViewTextBoxColumn.Visible = !transferrb.Checked;
        }

        private void balncecutrb_CheckedChanged(object sender, EventArgs e)
        {
            rateDataGridViewTextBoxColumn.Visible = cutrb.Checked;
            toAmountDataGridViewTextBoxColumn.Visible = cutrb.Checked;
        }

        private void alloperationsrb_CheckedChanged(object sender, EventArgs e)
        {
            rateDataGridViewTextBoxColumn.Visible = true;
            toAmountDataGridViewTextBoxColumn.Visible = true;
        }

        private void frmTransfers_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv.DataSource = null;
        }

        private void clientrb_CheckedChanged(object sender, EventArgs e)
        {
            clientComboBox.Enabled = clientrb.Checked;
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }
    }
}
