
using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Alver.Misc.Utilities;

namespace Alver.UI.Bills
{
    public partial class frmSell : Form
    {
        dbEntities db;

        #region Init
        public frmSell()
        {
            InitializeComponent();
        }
        private void frmExchange_Load(object sender, EventArgs e)
        {
            LoadData();
            barcodecb.Focus();
        }
        private void LoadData()
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            BillBS.ResetBindings(false);
            billLinesBS.ResetBindings(false);
            db.Accounts.Load();
            db.Bills.Load();
            db.BillLines.Load();
            db.Currencies.Load();
            db.Items.Load();
            db.Units.Load();
            db.Users.Load();
            unitBindingSource.DataSource = db.Units.ToList();
            unitBS.DataSource = db.Units.ToList();
            itemBindingSource.DataSource = db.Items.ToList();
            itemBS.DataSource = db.Items.ToList();
            accountBS.DataSource = db.Accounts.ToList();
            BillBS.DataSource = db.Bills.Where(x=>x.BillType==BillType.بيع.ToString()).ToList();
            billLinesBS.DataSource = BillBS;
            currencyBS.DataSource = db.Currencies.ToList();
            currencyBindingSource.DataSource = db.Currencies.ToList();
            userBindingSource.DataSource = db.Users.ToList();
            BillBS.ResetBindings(false);
            billLinesBS.ResetBindings(false);
            billLinesDgv.DataSource = null;
            billLinesDgv.DataSource = billLinesBS;
            billLinesDgv.Update();
            billLinesDgv.Refresh();
            //EnableControls();
        }
        private void currencyExchangeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        #endregion   Init

        #region Methods
        private void Reload()
        {
            db.Dispose();
            LoadData();
            billLinesDgv.Refresh();
        }
        private void ControlsEnable(bool _enable)
        {
            billdatedtp.Value = DateTime.Now;
            addbillbtn.Enabled = !_enable;
            chechprintbillbtn.Enabled = _enable;
            checkbillbtn.Enabled = _enable;
            editbillbtn.Enabled = _enable;
            sumtotalsnud.Value = sumtotalsnud.Minimum;
            totalnud.Value = totalnud.Minimum;
            discountnud.Value = discountnud.Minimum;
        }
        private void ColorizeCells()
        {
            //int index = DirectionColumn.Index;
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{

            //    if (dgv.Rows[i].Cells[index].FormattedValue.ToString() == Utilities.ExchangeType.بيع.ToString())
            //    {
            //        dgv.Rows[i].Cells[BaseAmountColumn.Index].Style.BackColor = System.Drawing.Color.Tomato;
            //    }
            //    else
            //    {
            //        dgv.Rows[i].Cells[BaseAmountColumn.Index].Style.BackColor = System.Drawing.Color.LawnGreen;
            //    }
            //}
            //index = directionDataGridViewTextBoxColumn.Index;
            //for (int i = 0; i < adddgv.Rows.Count; i++)
            //{

            //    if (adddgv.Rows[i].Cells[index].FormattedValue.ToString() == Utilities.ExchangeType.بيع.ToString())
            //    {
            //        adddgv.Rows[i].Cells[baseAmountDataGridViewTextBoxColumn.Index].Style.BackColor = System.Drawing.Color.Tomato;
            //    }
            //    else
            //    {
            //        adddgv.Rows[i].Cells[baseAmountDataGridViewTextBoxColumn.Index].Style.BackColor = System.Drawing.Color.LawnGreen;
            //    }
            //}
        }
        //private string dgvCell(int index)
        //{
        //    if (dgv.CurrentRow != null)
        //    {
        //        return dgv.CurrentRow.Cells[index].FormattedValue == null ? "" : dgv.CurrentRow.Cells[index].FormattedValue.ToString();
        //    }
        //    else
        //    {
        //        return "";
        //    }
        //}
        private void InsertBill()
        {
            try
            {
                //ControlsEnable(true);

                string _billType = BillType.بيع.ToString();
                int userid = Properties.Settings.Default.LoggedInUser.Id;

                var bill = (Bill)BillBS.AddNew();
                bill.BillType = _billType;
                bill.CurrencyId = 0;
                bill.DiscountAmount = 0;
                bill.TotalAmount = 0;
                bill.AccountId = 0;
                bill.BillAmount = 0;
                bill.BillDate = billdatedtp.Value;
                bill.Declaration = declarationtb.Text.Trim();
                bill.Hidden = false;
                bill.Flag = string.Empty;
                bill.LUD = DateTime.Now;
                bill.GUID = Guid.NewGuid();
                bill.PROTECTED = false;
                bill.UserId = userid;
                db.Bills.Attach(bill);
                db.Bills.Add(bill);
                db.SaveChanges();
                Reload();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void InsertBillLine()
        {
            try
            {
                Guid _guid = Guid.NewGuid();

                Bill _bill = BillBS.Current as Bill;
                BillLine _billLine = new BillLine();
                decimal _quantity = 1, _price = 0, _discount = 0;
                int _itemId=0,_unitId=0,_currencyId = 0, userid = 0;
                string _declaration = string.Empty;

                _currencyId = (int)currencycb.SelectedValue;
                DateTime _billDate = DateTime.Now;
                string _billType = BillType.بيع.ToString();
                _itemId= (int)itemcb.SelectedValue;
                _unitId = (int)unitcb.SelectedValue;
                _quantity = quantitynud.Value;
                _price = pricenud.Value;
                _discount = discountnud.Value;

                Currency _currency;
                _currency = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);

                userid = Properties.Settings.Default.LoggedInUser.Id;
                
                if (
                                        _bill != null ||
                                        _bill.Id != 0 ||
                                        _currency != null ||
                                        _itemId != 0 ||
                                        _currencyId != 0 ||
                                        _unitId != 0 ||
                                        _price > 0 ||
                                        _quantity > 0)
                {
                    _billLine.BillId = _bill.Id;
                    _billLine.ItemId = _itemId;
                    _billLine.UnitId = _unitId;
                    _billLine.CurrencyId = _currencyId;
                    _billLine.Price = Math.Round(_price, 2);
                    _billLine.Quantity= _quantity;
                    _billLine.TotalPrice = Math.Round(_quantity * _price, 2);
                    _billLine.Hidden = false;
                    _billLine.Flag = string.Empty;
                    _billLine.LUD = DateTime.Now;
                    _billLine.GUID = _guid;
                    _billLine.UserId = userid;
                    _billLine.PROTECTED = false;
                    //Navigation Properties
                    _billLine.Currency = _currency;
                    _billLine.Bill = _bill;
                    //db.CurrencyExchangeOperations.Attach(_exo);
                    _bill.BillLines.Add(_billLine);
                    db.Entry(_currency).State = EntityState.Unchanged;
                    db.Entry(_bill).State = EntityState.Unchanged;
                    db.Entry(_billLine).State = EntityState.Added;
                    db.SaveChanges();
                    
                    //_declaration = string.Format("فاتورة بيع - الزبون {0} - رقم الفاتورة {1}",
                    //    accountcb.Text.Trim(),
                    //    _bill.Id.ToString());
                    //if (_bill.BillType== BillType.بيع.ToString())
                    //{
                    //    TransactionsOperations.InsertFundTransaction(_billLine.CurrencyId.Value, _billLine.TotalPrice.Value, TransactionsOperations.TT.BLB, _billLine.LUD.Value, _guid, _declaration);
                    //    TransactionsOperations.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsOperations.TT.BLB, _billLine.LUD.Value, _guid, _declaration);
                    //    TransactionsOperations.InsertClientTransaction(_bill.AccountId.Value, _billLine.CurrencyId.Value, _billLine.TotalPrice.Value, TransactionsOperations.TT.BLB,_billLine.LUD.Value, _guid, _declaration);
                    //}
                    //else if (_bill.BillType == BillType.شراء.ToString())
                    //{
                    //    TransactionsOperations.InsertFundTransaction(_billLine.CurrencyId.Value, _billLine.Price.Value, TransactionsOperations.TT.BLS, _billLine.LUD.Value, _billLine.GUID.Value, _declaration);
                    //    TransactionsOperations.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsOperations.TT.BLS, _billLine.LUD.Value, _billLine.GUID.Value, _declaration);
                    //    TransactionsOperations.InsertClientTransaction(_bill.AccountId.Value, _billLine.CurrencyId.Value, _billLine.TotalPrice.Value, TransactionsOperations.TT.BLB, _billLine.LUD.Value, _billLine.GUID.Value, _declaration);
                    //}
                    //db.SaveChanges();
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
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
        }
        private void calcSumTotals()
        {
            try
            {
                decimal _sumtotals = 0;
                _sumtotals = billLinesDgv.ColumnSum(totalpriceColumn.Index);
                sumtotalsnud.Value = _sumtotals;
                CalcGrandTotal();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void CalcGrandTotal()
        {
            try
            {
                decimal _sumtotals = 0, _discount = 0, _total = 0;
                _sumtotals = sumtotalsnud.Value;
                _discount = discountnud.Value;
                _total = _sumtotals - _discount;
                totalnud.Value = _total;
                syrTotalnud.Value = _total * ratenud.Value;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
                discountnud.Value = 0;
                totalnud.Value = sumtotalsnud.Value;
            }
        }
        #endregion

        #region Buttons Click
        private void adddgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeCells();
        }

        private void addcebtn_Click(object sender, EventArgs e)
        {
            //ControlsEnable(false);
            try
            {
                discountnud.Value = discountnud.Minimum;
                accountcb.SelectedValue = 1;
                InsertBill();
                ExchangeRate();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void ExchangeRate()
        {
            decimal _SYP = 0;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _SYP = db.CurrencyBulletins
                        .OrderByDescending(x => x.RateDate)
                        .First(x => x.CurrencyId == 2)
                        .Rate.Value;
                }
                ratenud.Value = _SYP;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void currencyBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //int basecurrency = 0;
                //basecurrency = (currencyBindingSource.Current as Currency).Id;
                //currencyBindingSource1.DataSource = db.Currencies.Where(x => x.Id != basecurrency);
            }
            catch (Exception ex) { }
        }
        private void currencyBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //OrganizeCurrencies();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                InsertBillLine();
                calcSumTotals();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void discountnud_ValueChanged_1(object sender, EventArgs e)
        {
            if (discountnud.Value>=sumtotalsnud.Value)
            {
                //MessageBox.Show("لا يمكن ان تقوم قيمة الحسم اكبر او تساوي قيمة الفاتورة");
                discountnud.Value = discountnud.Minimum;
                discountnud.ForeColor = Color.Red;
            }
            else
            {
                CalcGrandTotal();
                discountnud.ForeColor = Color.Black;
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            
        }
        private void dceobtn_Click(object sender, EventArgs e)
        {
            if (billLinesBS.Count > 0)
            {
                deletebilllinebtn.Enabled = false;
                try
                {
                    BillLine _billLine = billLinesBS.Current as BillLine;
                    Bill _bill = BillBS.Current as Bill;
                 BillsOperations.DeleteBillLine(_billLine);
                    _bill.BillLines.Remove(_billLine);
                    db.BillLines.Remove(_billLine);
                    db.SaveChanges();
                    Reload();
                    calcSumTotals();
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
                deletebilllinebtn.Enabled = true;
            }
        }
        private void frmExchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            billLinesDgv.DataSource = null;
        }
        #endregion

        #region DGV
        //private void currencyExchangeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        dgv.CurrentRow.Cells[dgvaddbtn.Index].Value = "إضافة";
        //        dgv.CurrentRow.Cells[OpreationDateColumn.Index].Value = DateTime.Now;
        //        decimal rate = 1, baseAmount = 0, subAmount = 0, roundAmount = 0;
        //        bool factor = true;//*
        //        baseAmount = decimal.Parse(dgvCell(BaseAmountColumn.Index));
        //        factor = dgv.CurrentRow.Cells[FactorColumn.Index].FormattedValue.ToString().Trim() == "ضرب";
        //        rate = decimal.Parse(dgvCell(RateColumn.Index));

        //        subAmount = factor ? (baseAmount * rate) : (baseAmount / rate);
        //        dgv.CurrentRow.Cells[SubAmountColumn.Index].Value = Math.Round(subAmount, 2);
        //        roundAmount = CurrencyExchangeOperations.RoundExchange(subAmount);
        //        dgv.CurrentRow.Cells[RoundColumn.Index].Value = roundAmount;
        //    }
        //    catch (Exception ex) { }
        //    if (e.ColumnIndex == DirectionColumn.Index)// RED || GREEN
        //    {
        //        ColorizeCells();
        //    }
        //}
        #endregion

        #region Delete
        //private void DeleteBill()
        //{
        //    try
        //    {
        //        Bill _bill = BillBS.Current as Bill;
        //        if (_bill != null && _bill.Id != 0)
        //        {
        //            foreach (var item in _bill.BillLines)
        //            {
        //                DeleteBillLine(item);
        //            }
        //            //_ex.CurrencyExchangeOperations.
        //            db.BillLines.RemoveRange(_bill.BillLines);
        //            db.Bills.Remove(_bill);
        //        }
        //        else if (_bill != null && _bill.Id == 0)
        //        {
        //            //currencyExchangeBindingSource.RemoveCurrent();
        //            //db.CurrencyExchanges.Remove(db.CurrencyExchanges.Single(r => r.Id == _ex.Id));
        //        }
        //        db.SaveChanges();
        //        MessageBox.Show("تم حذف العملية بنجاح");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حصل خطأ أثناء حذف الفاتورة ،لم يتم الحذف بنجاح", "حذف فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void DeleteBillLine(BillLine _operation)
        //{
        //    try
        //    {
        //        if (_operation != null && _operation.Id != 0)
        //        {
        //            //Delete transaction
        //            TransactionsOperations.DeleteTransactions(_operation.GUID.Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حدث خطأ اثناء حذف الحركة");
        //    }
        //}
        private void dcebtn_Click(object sender, EventArgs e)
        {
            if (BillBS.Count > 0)
            {
                deletebillbtn.Enabled = false;
                try
                {
                    if (MessageBox.Show("سيتم حذف الفاتورة وكافة الاقلام التابعة لها. هل انت متأكد؟", "تحذير", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        discountnud.Value = 0;
                       BillsOperations.DeleteBill((BillBS.Current as Bill).Id);
                        Reload();
                    }
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
                deletebillbtn.Enabled = true;
            }
        }
        #endregion

        private void BillBS_CurrentChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Bill _bill = BillBS.Current as Bill;
            //    if (_bill != null)
            //    {
            //        totalnud.Value = _bill.TotalAmount.Value;
            //        discountnud.Value = _bill.DiscountAmount.Value;
            //        sumtotalsnud.Value = totalnud.Value - discountnud.Value;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MSGs.ErrorMessage(ex);
            //}
        }
        private void checkbillbtn_Click(object sender, EventArgs e)
        {
            if (CheckAttributes() == true)
            {
                if (BillBS.Count > 0)
                {
                    try
                    {
                        //ControlsEnable(false);
                        Bill _bill = BillBS.Current as Bill;
                        int _billId = _bill.Id;
                        using (dbEntities db = new dbEntities())
                        {
                            Bill bill = db.Bills.Find(_billId);
                            //TODO: CONVERT CURRENCY TO USD VIA CURRENCY BULLETIN
                            bill.BillType = BillType.بيع.ToString();
                            bill.CurrencyId = 1;
                            bill.ForeginCurrencyId = 2;
                            bill.BillAmount = sumtotalsnud.Value;
                            bill.DiscountAmount = discountnud.Value;
                            bill.TotalAmount = totalnud.Value;
                            bill.BillDate = billdatedtp.Value;
                            bill.Declaration = declarationtb.Text.Trim();
                            if (payedchkbox.Checked)
                            {
                                bill.AccountId = 0;
                                bill.Cashout = true;
                            }
                            else
                            {
                                bill.AccountId = (int)accountcb.SelectedValue;
                                bill.Cashout = false;
                            }
                            if (exchangebillchkbox.Checked)
                            {
                                bill.Exchanged = true;
                            }
                            else
                            {
                                bill.Exchanged = false;
                            }
                            bill.Rate = ratenud.Value;
                            bill.ExchangedAmount = syrTotalnud.Value;

                            db.SaveChanges();
                            string _declaration = string.Format("فاتورة بيع - الزبون {0} - رقم الفاتورة {1} - مقدار الحسم {2}",
                        accountcb.Text.Trim(),
                        _bill.Id.ToString(),
                        discountnud.Value.ToString());

                            Guid _guid = bill.GUID.Value;
                            TransactionsOperations.DeleteTransactions(_guid);
                            if (bill.BillType == BillType.بيع.ToString())
                            {
                                foreach (BillLine _billLine in bill.BillLines)
                                {
                                    TransactionsOperations.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsOperations.TT.BLP, _billLine.LUD.Value, _guid, _declaration);
                                }
                                if (exchangebillchkbox.Checked)
                                {
                                    TransactionsOperations.InsertFundTransaction(bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsOperations.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                }
                                else
                                {
                                    TransactionsOperations.InsertFundTransaction(bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsOperations.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                }
                                if (!payedchkbox.Checked)
                                {
                                    if (exchangebillchkbox.Checked)
                                    {
                                        TransactionsOperations.InsertClientTransaction(bill.AccountId.Value, bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsOperations.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                    }
                                    else
                                    {
                                        TransactionsOperations.InsertClientTransaction(bill.AccountId.Value, bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsOperations.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                    }
                                }
                            }
                            else if (bill.BillType == BillType.شراء.ToString())
                            {
                                foreach (BillLine _billLine in bill.BillLines)
                                {
                                    TransactionsOperations.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsOperations.TT.BLS, _billLine.LUD.Value, _guid, _declaration);
                                }
                                if (exchangebillchkbox.Checked)
                                {
                                    TransactionsOperations.InsertFundTransaction(bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsOperations.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                }
                                else
                                {
                                    TransactionsOperations.InsertFundTransaction(bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsOperations.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                }
                                if (!payedchkbox.Checked)
                                {
                                    if (exchangebillchkbox.Checked)
                                    {
                                        TransactionsOperations.InsertClientTransaction(bill.AccountId.Value, bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsOperations.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                    else
                                    {
                                        TransactionsOperations.InsertClientTransaction(bill.AccountId.Value, bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsOperations.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                }
                            }
                            db.SaveChanges();
                            MSGs.SaveMessage("رقم الفاتورة: " + bill.Id.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MSGs.ErrorMessage(ex);
                    }
                }
            }
        }
        private bool CheckAttributes()
        {
            bool _result = true;

            try
            {
                if (!payedchkbox.Checked && accountcb.SelectedValue==null)
                {
                    MessageBox.Show("لا يمكن إضافة فاتورة بدون اسم الزبون، الرجاء اختيار زبون اولاً");
                    accountcb.Focus();
                    _result = false;
                }
                else if (billLinesBS.Count<1)
                {
                    MessageBox.Show("لا يمكن إضافة فاتورة بدون بدون اقلام بيع، الرجاء إضافة عمليات بيع اولاً");
                    itemcb.Focus();
                    _result = false;
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _result;
        }
        private void billLinesBS_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            calcSumTotals();
        }

        private void itemcb_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int _itemId = 0;
                if(itemcb.SelectedValue!=null)
                _ = int.TryParse(itemcb.SelectedValue.ToString(), out _itemId);
                if (_itemId!=0)
                {
                    using (dbEntities db=new dbEntities())
                    {
                        if (barcodecb.Text==string.Empty&& db.Items.Find(_itemId).Barcode!=null)
                        {
                            barcodecb.Text = db.Items.Find(_itemId).Barcode;
                        }
                        decimal _salePrice = db.Items.Find(_itemId).SalePrice.Value!=null? db.Items.Find(_itemId).SalePrice.Value:0;
                        pricenud.Value = _salePrice;
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void payedchkbox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                accountcb.Enabled = !payedchkbox.Checked;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void exchangebillchkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ratenud_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                syrTotalnud.Value = ratenud.Value * totalnud.Value;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
    }
}
