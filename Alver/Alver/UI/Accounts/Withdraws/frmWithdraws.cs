using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.UI.Accounts.Withdraws
{
    public partial class frmWithdraws : Form
    {
        public frmWithdraws()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                db.Accounts.AsNoTracking().Load();
                db.Users.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                currencyBindingSource1.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                accountsInfoBindingSource.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
                accountsInfoBindingSource1.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().AsQueryable().ToList();
                usersUserBindingSource.DataSource = db.Users.AsNoTracking().AsQueryable().ToList();
            }
        }
        private void frmTransactions_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
                accountsInfoBindingSource.DataSource = db.Accounts.Where(x => x.Deactivated == false && x.Hidden == false).AsNoTracking().ToList().AsQueryable();
            }
            Misc.Utilities.SearchableComboBox(accountcb);
            Misc.Utilities.SearchableComboBox(currencycomboBox);
        }
        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            DGVTotals();
            ColorizeDgv();
        }
        private void Retrive()
        {
            this.Cursor = Cursors.WaitCursor;
            LoadData();
            int _currencyId = 0;
            int _accountId = 0;
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
            if (currencycheckBox.Checked)
            {
                _currencyId = (int)currencycomboBox.SelectedValue;
            }
            if (accountchkb.Checked)
            {
                _accountId = (int)accountcb.SelectedValue;
            }
            GrandSearch(_from, _to, _currencyId, _accountId);
            this.Cursor = Cursors.Default;
        }
        private IQueryable<Withdraw> GrandSearch(DateTime _from, DateTime _to, int _currencyId, int _accountId)
        {
            IQueryable<Withdraw> _query;// = new IQueryable<Remittances_Operation>;
            using (dbEntities db = new dbEntities())
            {
                _query = db.Withdraws as IQueryable<Withdraw>;
                if (_from.Year == _to.Year && _from.Month == _to.Month)
                {
                    _query = db.Withdraws.Where(
                            x => ((x.WithdrawDate.Value.Year >= _from.Year && x.WithdrawDate.Value.Year <= _to.Year) &&
                                (x.WithdrawDate.Value.Month >= _from.Month && x.WithdrawDate.Value.Month <= _to.Month) &&
                                (x.WithdrawDate.Value.Day >= _from.Day && x.WithdrawDate.Value.Day <= _to.Day))
                        ).AsQueryable();

                }
                else if (_from.Year != _to.Year)
                {
                    _query = db.Withdraws.Where(
                        x => x.WithdrawDate.Value.Year >= _from.Year && x.WithdrawDate.Value.Year <= _to.Year
                        ).AsQueryable();
                }
                else if (_from.Year == _to.Year && _from.Month != _to.Month)
                {
                    _query = db.Withdraws.Where(
                        x => ((x.WithdrawDate.Value.Year >= _from.Year && x.WithdrawDate.Value.Year <= _to.Year) &&
                        (x.WithdrawDate.Value.Month >= _from.Month && x.WithdrawDate.Value.Month <= _to.Month))
                        ).AsQueryable();
                }
                if (_accountId != 0)
                {
                    _query = _query.Where(x => x.AccountId == _accountId);
                }
                if (_currencyId != 0)
                {
                    _query = _query.Where(x => x.CurrencyId == _currencyId);
                }
                if (gaincb.Checked && !losscb.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.Direction == Misc.Utilities.WithdrawDirections.سحب_أرباح.ToString()
                        );
                }
                else if (losscb.Checked && !gaincb.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.Direction == Misc.Utilities.WithdrawDirections.إيداع_أرباح.ToString()
                        );
                }
                _query = _query.OrderBy(x => x.WithdrawDate);
                withdrawBindingSource.DataSource = _query.ToList();
            }
            return _query;
        }
        private void accountchkb_CheckedChanged(object sender, EventArgs e)
        {
            accountcb.Enabled = accountchkb.Checked;
        }
        private void currencycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currencycomboBox.Enabled = currencycheckBox.Checked;
        }
        private void ColorizeDgv()
        {
            int _index1 = amountDataGridViewTextBoxColumn.Index;
            dgv.ColorizeDecimalDGVCell(_index1);
            //int _index3 = amountDataGridViewTextBoxColumn1.Index;
            //int _index4 = runningtotalDataGridViewTextBoxColumn1.Index;
            //dgv2.ColorizeDecimalDGVTwoCells(_index3, _index4);
        }
        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void frmTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv.DataSource = null;
        }
        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            try
            {
                Withdraw _withdraw = withdrawBindingSource.Current as Withdraw;
                long _withdrawId = _withdraw.Id;
                int _accountId = _withdraw.AccountId.Value;
                int _currencyId = _withdraw.CurrencyId.Value;
                if (_withdraw != null)
                {
                    string _msg = "هل انت متأكد من حذف الحركة، لن يمكنك التراجع عن العملية؟";
                    DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.RightAlign);
                    if (_ConfirmationDialog == DialogResult.Yes)
                    {
                        using (dbEntities db = new dbEntities())
                        {

                            db.Withdraws.Remove(db.Withdraws.Find(_withdrawId));
                            db.SaveChanges();
                            TransactionsFuncs.DeleteTransactions(_withdraw.GUID.Value, _currencyId, _accountId,0, TransactionsFuncs.TT.FOO);
                            TransactionsFuncs.ClientsRunningTotals(_accountId);
                            MessageBox.Show("تم الحذف بنجاح");
                            Retrive();
                            ColorizeDgv();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }

            deletebtn.Enabled = true;
        }
    }
}
