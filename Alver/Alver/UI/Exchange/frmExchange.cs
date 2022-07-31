using Alver.DAL;
using Alver.MISC;
using DAL.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.TransactionsFuncs;
using static Alver.MISC.Utilities;

namespace Alver.UI.Exchange
{
    public partial class frmExchange : Form
    {
        private dbEntities db;
        private System.Collections.Generic.List<long> _deletedIds = new System.Collections.Generic.List<long>();

        #region Init

        public frmExchange()
        {
            InitializeComponent();
        }

        private void frmExchange_Load(object sender, EventArgs e)
        {
            LoadData();
            dgv.Rows.Add();
        }

        private void LoadData()
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;
            currencyExchangeBindingSource.ResetBindings(false);
            currencyExchangeOperationsBindingSource.ResetBindings(false);
            db.CurrencyExchanges.Load();
            db.CurrencyExchangeOperations.Load();
            db.Currencies.Load();
            currencyExchangeBindingSource.DataSource = db.CurrencyExchanges.ToList();
            currencyExchangeOperationsBindingSource.DataSource = currencyExchangeBindingSource;
            currencyBindingSource.DataSource = db.Currencies.ToList();
            currencyBindingSource1.DataSource = db.Currencies.ToList();
            currencyBindingSource2.DataSource = db.Currencies.ToList();
            currencyBindingSource3.DataSource = db.Currencies.ToList();
            currencyExchangeBindingSource.ResetBindings(false);
            currencyExchangeOperationsBindingSource.ResetBindings(false);
            adddgv.DataSource = null;
            adddgv.DataSource = currencyExchangeOperationsBindingSource;
            adddgv.Update();
            adddgv.Refresh();
            EnableControls();
        }

        private void currencyExchangeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        #endregion Init

        #region Methods

        private void ColorizeCells()
        {
            int index = DirectionColumn.Index;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == ExchangeType.بيع.ToString())
                {
                    dgv.Rows[i].Cells[BaseAmountColumn.Index].Style.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    dgv.Rows[i].Cells[BaseAmountColumn.Index].Style.BackColor = System.Drawing.Color.LawnGreen;
                }
            }
            index = directionDataGridViewTextBoxColumn.Index;
            for (int i = 0; i < adddgv.Rows.Count; i++)
            {
                if (adddgv.Rows[i].Cells[index].FormattedValue.ToString() == ExchangeType.بيع.ToString())
                {
                    adddgv.Rows[i].Cells[baseAmountDataGridViewTextBoxColumn.Index].Style.BackColor = System.Drawing.Color.Tomato;
                }
                else
                {
                    adddgv.Rows[i].Cells[baseAmountDataGridViewTextBoxColumn.Index].Style.BackColor = System.Drawing.Color.LawnGreen;
                }
            }
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

        private void InsertExchangeOperation()
        {
            try
            {
                CurrencyExchanx _ex = currencyExchangeBindingSource.Current as CurrencyExchanx;
                CurrencyExchangeOperation _exo = new CurrencyExchangeOperation();
                DateTime _exchangeDate = DateTime.Now;
                decimal rate = 1, baseAmount = 0, subAmount = 0, roundAmount = 0;
                bool factor = true;//*
                int basecurrency = 0, subcurrency = 0, userid = 0;
                Currency _baseCurrency, _subCurrency;
#pragma warning disable CS0168 // The variable 'declaration' is declared but never used
                string direction = string.Empty, declaration;
#pragma warning restore CS0168 // The variable 'declaration' is declared but never used
                var _dir = dgv.CurrentRow.Cells[DirectionColumn.Index].Value;
                if (_dir != null)
                {
                    direction = _dir.ToString();
                }
                basecurrency = int.Parse(dgv.CurrentRow.Cells[BaseCurrencyIdColumn.Index].Value.ToString());
                baseAmount = decimal.Parse(dgvCell(BaseAmountColumn.Index));
                _baseCurrency = db.Currencies.FirstOrDefault(x => x.Id == basecurrency);
                subcurrency = int.Parse(dgv.CurrentRow.Cells[SubCurrencyIdColumn.Index].Value.ToString());
                _subCurrency = db.Currencies.FirstOrDefault(x => x.Id == subcurrency);
                var _fac = dgv.CurrentRow.Cells[FactorColumn.Index].FormattedValue;
                if (_fac != null)
                {
                    factor = _fac.ToString().Trim() == "ضرب";
                }

                rate = decimal.Parse(dgvCell(RateColumn.Index));
                subAmount = factor ? (baseAmount * rate) : (baseAmount / rate);
                roundAmount = CurrencyExchangeFuncs.RoundExchange(subAmount);
                userid = Properties.Settings.Default.LoggedInUser.Id;
                if (basecurrency == subcurrency)
                {
                    MessageBox.Show("لا يمكن ان تكون عملة الشراء مطابقة لعملة البيع");
                    return;
                }
                else
                if (
                                        _ex != null ||
                                        _ex.Id != 0 ||
                                        _dir != null ||
                                        _fac != null ||
                                        baseAmount != 0 ||
                                        subAmount != 0 ||
                                        basecurrency != 0 ||
                                        _baseCurrency != null ||
                                        subcurrency != 0 ||
                                        _subCurrency != null ||
                                        rate > 0)
                {
                    _exo.Direction = direction;
                    _exo.BaseAmount = baseAmount;
                    _exo.BaseCurrencyId = subcurrency;
                    _exo.Currency = _baseCurrency;
                    _exo.SubAmount = Math.Round(subAmount, 2);
                    _exo.RoundAmount = roundAmount;
                    _exo.SubCurrencyId = basecurrency;
                    _exo.Currency1 = _subCurrency;
                    _exo.Rate = rate;
                    _exo.Factor = factor == true ? "ضرب" : "تقسيم";
                    _exo.OpreationDate = _exchangeDate;
                    _exo.Hidden = false;
                    _exo.Flag = string.Empty;
                    _exo.LUD = DateTime.Now;
                    _exo.GUID = Guid.NewGuid();
                    _exo.UserId = userid;
                    _exo.ExchangeId = _ex.Id;
                    //Navigation Properties
                    _exo.CurrencyExchanx = _ex;
                    //db.CurrencyExchangeOperations.Attach(_exo);
                    _ex.CurrencyExchangeOperations.Add(_exo);
                    db.Entry(_baseCurrency).State = EntityState.Unchanged;
                    db.Entry(_subCurrency).State = EntityState.Unchanged;
                    db.Entry(_ex).State = EntityState.Unchanged;
                    db.Entry(_exo).State = EntityState.Added;
                    db.SaveChanges();
                    string _declaration = string.Format("{0} عملة بسعر صرف {1}", _exo.Direction.ToString(), _exo.Rate.ToString());
                    if (_exo.Direction == ExchangeType.بيع.ToString())
                    {
                        TransactionsFuncs.InsertFundTransaction(_exo.BaseCurrencyId.Value, _exo.BaseAmount.Value, TransactionsFuncs.TT.CES, _exo.OpreationDate.Value, _exo.GUID.Value, _declaration);
                        TransactionsFuncs.InsertFundTransaction(_exo.SubCurrencyId.Value, _exo.SubAmount.Value, TransactionsFuncs.TT.CEB, _exo.OpreationDate.Value, _exo.GUID.Value, _declaration);
                    }
                    else if (_exo.Direction == ExchangeType.شراء.ToString())
                    {
                        TransactionsFuncs.InsertFundTransaction(_exo.BaseCurrencyId.Value, _exo.BaseAmount.Value, TransactionsFuncs.TT.CEB, _exo.OpreationDate.Value, _exo.GUID.Value, _declaration);
                        TransactionsFuncs.InsertFundTransaction(_exo.SubCurrencyId.Value, _exo.SubAmount.Value, TransactionsFuncs.TT.CES, _exo.OpreationDate.Value, _exo.GUID.Value, _declaration);
                    }
                    //decimal _exchange = _exo.SubAmount.Value - _exo.RoundAmount.Value;
                    //if (_exo.SubCurrencyId == 2)
                    //    TransactionsOperations.InsertFundTransaction(_exo.SubCurrencyId.Value, _exchange, TransactionsOperations.TT.CED, _exo.OpreationDate.Value, _exo.GUID.Value, _declaration);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال قيم فارغة");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
        }

        private void EnableControls()
        {
            bool _enable;
            if (currencyExchangeBindingSource.Count == 0)
            {
                _enable = false;
            }
            else
            {
                _enable = true;
                //dcebtn.Enabled = true;
                //addcebtn.Enabled = true;
                if (currencyExchangeOperationsBindingSource.Count == 0)
                {
                    //addceobtn.Enabled = true;
                    dceobtn.Enabled = false;
                }
                else
                {
                    //addceobtn.Enabled = true;
                    dceobtn.Enabled = true;
                }
            }
            dcebtn.Enabled = _enable;
            tabControl1.Enabled = _enable;
            panel1.Enabled = _enable;
        }

        #endregion Methods

        #region Buttons Click

        private void frmExchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            adddgv.DataSource = null;
        }

        #endregion Buttons Click

        #region DGV

        private void currencyExchangeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgv.CurrentRow.Cells[dgvaddbtn.Index].Value = "إضافة";
                dgv.CurrentRow.Cells[OpreationDateColumn.Index].Value = DateTime.Now;
                decimal rate = 1, baseAmount = 0, subAmount = 0, roundAmount = 0;
                bool factor = true;//*
                baseAmount = decimal.Parse(dgvCell(BaseAmountColumn.Index));
                factor = dgv.CurrentRow.Cells[FactorColumn.Index].FormattedValue.ToString().Trim() == "ضرب";
                rate = decimal.Parse(dgvCell(RateColumn.Index));

                subAmount = factor ? (baseAmount * rate) : (baseAmount / rate);
                dgv.CurrentRow.Cells[SubAmountColumn.Index].Value = Math.Round(subAmount, 2);
                roundAmount = CurrencyExchangeFuncs.RoundExchange(subAmount);
                dgv.CurrentRow.Cells[RoundColumn.Index].Value = roundAmount;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            if (e.ColumnIndex == DirectionColumn.Index)// RED || GREEN
            {
                ColorizeCells();
            }
        }

        #endregion DGV

        #region SAVE

        private void DeleteCurrencyExchange()
        {
            try
            {
                CurrencyExchanx _ex = currencyExchangeBindingSource.Current as CurrencyExchanx;
                if (_ex != null && _ex.Id != 0)
                {
                    foreach (var item in _ex.CurrencyExchangeOperations)
                    {
                        DeleteCurrencyExchangeOperation(item);
                    }
                    //_ex.CurrencyExchangeOperations.
                    db.CurrencyExchangeOperations.RemoveRange(_ex.CurrencyExchangeOperations);
                    db.CurrencyExchanges.Remove(_ex);
                }
                else if (_ex != null && _ex.Id == 0)
                {
                    //currencyExchangeBindingSource.RemoveCurrent();
                    //db.CurrencyExchanges.Remove(db.CurrencyExchanges.Single(r => r.Id == _ex.Id));
                }
                db.SaveChanges();
                MessageBox.Show("تم حذف العملية بنجاح");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء حذف اليومية ،لم يتم الحذف بنجاح", "حذف يومية", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCurrencyExchangeOperation(CurrencyExchangeOperation _operation)
        {
            try
            {
                if (_operation != null && _operation.Id != 0)
                {
                    //Delete transaction
                    TransactionsFuncs.DeleteTransactions(_operation.GUID.Value);
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ اثناء حذف الحركة");
            }
        }

        #endregion SAVE

        private void Save()

        {
            //CheckDeleted();
            //PrepareList();
            db.SaveChanges();
            MSGs.SaveMessage();
        }

        private void CheckDeleted()
        {
            _deletedIds = _deletedIds.Distinct().ToList();
            _deletedIds.Remove(0);
            foreach (var item in _deletedIds)
            {
                var _operation = db.CurrencyExchangeOperations.FirstOrDefault(x => x.Id == item);
                int _baseCurrencyId = _operation.BaseCurrencyId.Value;
                int _subCurrencyId = _operation.SubCurrencyId.Value;
                if (_operation != null)
                {
                    TransactionsFuncs.DeleteTransactions(_operation.GUID.Value, _baseCurrencyId, 0, 0, TT.FOO);
                    TransactionsFuncs.DeleteTransactions(_operation.GUID.Value, _subCurrencyId, 0, 0, TT.FOO);
                }
            }
        }

        private void dceobtn_Click(object sender, EventArgs e)
        {
            dceobtn.Enabled = false;
            try
            {
                CurrencyExchangeOperation _operation = currencyExchangeOperationsBindingSource.Current as CurrencyExchangeOperation;
                CurrencyExchanx _ex = currencyExchangeBindingSource.Current as CurrencyExchanx;
                DeleteCurrencyExchangeOperation(_operation);
                _ex.CurrencyExchangeOperations.Remove(_operation);
                db.CurrencyExchangeOperations.Remove(_operation);
                db.SaveChanges();
                Reload();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            { }
            dceobtn.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgvaddbtn.Index)
            //{
            //    try
            //    {
            //        dgv.CurrentCell = dgv.Rows[0].Cells[1];
            //    }
            //    catch (Exception)
            //    {
            //    }
            //}
        }

        private void Reload()
        {
            db.Dispose();
            //db = new dbEntities(0);
            //db.Configuration.ProxyCreationEnabled = false;
            LoadData();
            //currencyExchangeBindingSource.ResetBindings(false);
            //currencyExchangeOperationsBindingSource.ResetBindings(false);
            dgv.Refresh();
            adddgv.Refresh();
        }

        private void CurrencyDifferntiate()
        {
            try
            {
                var _currencyTitle = dgvCell(BaseCurrencyIdColumn.Index);
                Currency _curr = db.Currencies.FirstOrDefault(x => x.CurrencyName == _currencyTitle);
                int Id = _curr.Id;
                currencyBindingSource1.DataSource = db.Currencies.Where(x => x.Id != Id).ToList();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrencyDifferntiate();
            if (e.ColumnIndex == dgvaddbtn.Index)
            {
                try
                {
                    currencyExchangeBindingSource.EndEdit();
                    currencyExchangeOperationsBindingSource.EndEdit();
                    dgv.EndEdit();
                    this.Validate();
                    //Code goes here
                    InsertExchangeOperation();
                    Reload();
                    Refocus();
                }
                catch (Exception)
                {
                }
            }
        }

        private void Refocus()
        {
            dgv.CurrentCell = dgv.Rows[0].Cells[1];
        }

        private void adddgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeCells();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Save();
            LoadData();
        }

        private void currencyExchangeBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            EnableControls();
        }

        private void dcebtn_Click(object sender, EventArgs e)
        {
            dcebtn.Enabled = false;
            try
            {
                if (MessageBox.Show("سيتم حذف اليومية وكافة الحركات التابعة لها. هل انت متأكد؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    DeleteCurrencyExchange();
                    Reload();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء حذف اليومية ،لم يتم الحذف بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dcebtn.Enabled = true;
        }

        private void addcebtn_Click(object sender, EventArgs e)
        {
            int userid = Properties.Settings.Default.LoggedInUser.Id;
            var _ex = (CurrencyExchanx)currencyExchangeBindingSource.AddNew();
            _ex.ExchangeDate = exchangeDateDateTimePicker.Value;
            _ex.Declaration = declarationTextBox.Text.Trim();
            _ex.Hidden = false;
            _ex.Flag = string.Empty;
            _ex.LUD = DateTime.Now;
            _ex.GUID = Guid.NewGuid();
            _ex.UserId = userid;
            db.CurrencyExchanges.Attach(_ex);
            db.CurrencyExchanges.Add(_ex);
            db.SaveChanges();
            Reload();
        }

        private void currencyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //int basecurrency = 0;
                //basecurrency = (currencyBindingSource.Current as Currency).Id;
                //currencyBindingSource1.DataSource = db.Currencies.Where(x => x.Id != basecurrency);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        private void currencyBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //OrganizeCurrencies();
        }
    }
}