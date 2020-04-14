using Alver.DAL;
using Alver.MISC;
using Alver.UI.Bills.BillReports;
using DAL.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.Utilities;

namespace Alver.UI.Bills
{
    public partial class frmSell : Form
    {
        private dbEntities db;
        private int BILLID = 0;

        #region Init

        public frmSell(int billid = 0)
        {
            InitializeComponent();
            BILLID = billid;
        }

        private void frmExchange_Load(object sender, EventArgs e)
        {
            if (CheckRecords())
            {
                LoadData();
                barcodecb.Focus();
                if (BILLID > 0)
                {
                    Bill _tempBill = (new dbEntities(0)).Bills.Find(BILLID);
                    if (_tempBill != null)
                    {
                        BillBS.Position = BillBS.IndexOf(_tempBill);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }

        private void LoadData()
        {
            db = new dbEntities(0);
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
            BillBS.DataSource = db.Bills.Where(x => x.BillType == BillType.بيع.ToString()).ToList();
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
            barcodecb.Focus();
        }

        private void currencyExchangeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        #endregion Init

        #region Methods

        private bool CheckRecords()
        {
            bool _result = true;
            using (dbEntities db = new dbEntities(0))
            {
                if (db.Items.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة مواد بعد، لا يمكنك إضافة فاتورة");
                    _result = false;
                }
                else if (db.CurrencyBulletins.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة اسعار الصرف بعد، لا يمكنك إضافة فاتورة");
                    _result = false;
                }
            }
            return _result;
        }

        private void RetreiveItemById()
        {
            try
            {
                int _itemId = 0, _unitId = 0, _currencyId = 0;
                decimal _roundedExchangedValue = 0, _exchangedValue = 0;
                if (itemcb.SelectedValue != null)
                    _ = int.TryParse(itemcb.SelectedValue.ToString(), out _itemId);
                if (unitcb.SelectedValue != null)
                    _ = int.TryParse(unitcb.SelectedValue.ToString(), out _unitId);
                //if (currencycb.SelectedValue != null)
                //    _ = int.TryParse(currencycb.SelectedValue.ToString(), out _currencyId);
                if (_itemId != 0)
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        _currencyId = db.Items.Find(_itemId).CurrencyId.Value;
                        currencycb.SelectedValue = _currencyId;
                        if (db.Items.Find(_itemId).Barcode != null)
                        {
                            barcodecb.Text = db.Items.Find(_itemId).Barcode;
                        }
#pragma warning disable CS0472 // The result of the expression is always 'true' since a value of type 'decimal' is never equal to 'null' of type 'decimal?'
                        decimal _salePrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice.Value != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
#pragma warning restore CS0472 // The result of the expression is always 'true' since a value of type 'decimal' is never equal to 'null' of type 'decimal?'
                        pricenud.Value = _salePrice >= 1 ? _salePrice : 1;

                        _exchangedValue = pricenud.Value * ratenud.Value;
                        _roundedExchangedValue = CurrencyExchangeFuncs.RoundExchange(_exchangedValue);
                        exchangedpricenud.Value = _roundedExchangedValue >= exchangedpricenud.Minimum ? _roundedExchangedValue : exchangedpricenud.Minimum;
                        decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);

                        remainedquantitylbl.Text = _remainedQuantity.ToString();
                        quantitynud.Maximum = _remainedQuantity;
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void RetreiveItemByBarcode()
        {
            try
            {
                string _barcode = barcodecb.Text;
                int _itemId = 0, _unitId = 0;
                decimal _roundedExchangedValue = 0, _exchangedValue = 0;
                if (unitcb.SelectedValue != null)
                    _ = int.TryParse(unitcb.SelectedValue.ToString(), out _unitId);
                if (barcodecb.Text != string.Empty)
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        if (db.Items.Where(x => x.Barcode == _barcode).Count() > 0)
                        {
                            _itemId = db.Items.FirstOrDefault(x => x.Barcode == _barcode).Id;
                            itemcb.SelectedValue = _itemId;
#pragma warning disable CS0472 // The result of the expression is always 'true' since a value of type 'decimal' is never equal to 'null' of type 'decimal?'
                            decimal _salePrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice.Value != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
#pragma warning restore CS0472 // The result of the expression is always 'true' since a value of type 'decimal' is never equal to 'null' of type 'decimal?'
                            pricenud.Value = _salePrice >= 1 ? _salePrice : 1;
                            //exchangedpricenud.Value = pricenud.Value * ratenud.Value;
                            _exchangedValue = pricenud.Value * ratenud.Value;
                            _roundedExchangedValue = CurrencyExchangeFuncs.RoundExchange(_exchangedValue);
                            exchangedpricenud.Value = _roundedExchangedValue >= exchangedpricenud.Minimum ? _roundedExchangedValue : exchangedpricenud.Minimum;
                            decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);
                            remainedquantitylbl.Text = _remainedQuantity.ToString();
                            quantitynud.Maximum = _remainedQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private bool CheckAttributes()
        {
            bool _result = true;

            try
            {
                if (!payedchkbox.Checked && accountcb.SelectedValue == null)
                {
                    MessageBox.Show("لا يمكن إضافة فاتورة بدون اسم الزبون، الرجاء اختيار زبون اولاً");
                    accountcb.Focus();
                    _result = false;
                }
                else if (billLinesBS.Count < 1)
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

        private void Reload()
        {
            db.Dispose();
            LoadData();
            billLinesDgv.Refresh();
        }

        //private void ControlsEnable(bool _enable)
        //{
        //    billdatedtp.Value = DateTime.Now;
        //    addbillbtn.Enabled = !_enable;
        //    chechprintbillbtn.Enabled = _enable;
        //    checkbillbtn.Enabled = _enable;
        //    editbillbtn.Enabled = _enable;
        //    sumtotalsnud.Value = sumtotalsnud.Minimum;
        //    totalnud.Value = totalnud.Minimum;
        //    discountnud.Value = discountnud.Minimum;
        //}
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
                bill.Cashout = false;
                bill.CheckedOut = false;
                db.SaveChanges();
                //Reload();
                payedchkbox.Checked = true;
                exchangebillchkbox.Checked = true;
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
                Bill _bill = BillBS.Current as Bill;
                Guid _guid = Guid.NewGuid();

                BillLine _billLine = new BillLine();
                decimal _quantity = 1, _price = 0, _exchangedPrice = 0, _discount = 0;
                int _itemId = 0, _unitId = 0, _currencyId = 0, userid = 0, _foreignCurrencyId = 2;
                string _declaration = string.Empty;

                _currencyId = (int)currencycb.SelectedValue;
                DateTime _billDate = DateTime.Now;
                string _billType = BillType.بيع.ToString();
                _itemId = (int)itemcb.SelectedValue;
                _unitId = (int)unitcb.SelectedValue;
                _quantity = quantitynud.Value;
                _price = pricenud.Value;
                _exchangedPrice = exchangedpricenud.Value;
                _discount = discountnud.Value;

                Currency _currency, _foreignCurrency;
                _currency = db.Currencies.FirstOrDefault(x => x.Id == _currencyId);
                _foreignCurrency = db.Currencies.FirstOrDefault(x => x.Id == _foreignCurrencyId);

                userid = Properties.Settings.Default.LoggedInUser.Id;
                if (_quantity <= 0)
                {
                    MessageBox.Show("لا يمكن اضافة قلم بكمية صفرية يرجى تعديل الكمية");
                    quantitynud.Focus();
                    //return;
                }
                else
                {
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
                        _billLine.ForeginCurrencyId = _foreignCurrencyId;
                        _billLine.Price = Math.Round(_price, 2);
                        _billLine.Quantity = _quantity;
                        _billLine.TotalPrice = Math.Round(_quantity * _price, 2);
                        _billLine.Exchanged = true;
                        _billLine.Rate = ratenud.Value;
                        _billLine.ExchangedAmount = _exchangedPrice;
                        _billLine.ExchangedTotalAmount = Math.Round(_quantity * _exchangedPrice, 2);

                        _billLine.Hidden = false;
                        _billLine.Flag = string.Empty;
                        _billLine.LUD = DateTime.Now;
                        _billLine.GUID = _guid;
                        _billLine.UserId = userid;
                        _billLine.PROTECTED = false;
                        //Navigation Properties
                        _billLine.Currency = _currency;
                        _billLine.Currency1 = _foreignCurrency;
                        _billLine.Bill = _bill;
                        //db.CurrencyExchangeOperations.Attach(_exo);
                        _bill.BillLines.Add(_billLine);
                        db.Entry(_currency).State = EntityState.Unchanged;
                        db.Entry(_foreignCurrency).State = EntityState.Unchanged;
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

        private void calcSumTotals()
        {
            try
            {
                decimal _sumtotals = 0;
                _sumtotals = billLinesDgv.ColumnSum(totalpriceColumn.Index);//, currencyIdColumn.Index);
                //_sumtotals = billLinesDgv.ColumnSum(totalpriceColumn.Index, currencyIdColumn.Index);
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
                decimal _roundedTotalExchangedValue = 0;

                _sumtotals = sumtotalsnud.Value;
                _discount = discountnud.Value;
                _total = _sumtotals - _discount;
                totalnud.Value = _total;

                _roundedTotalExchangedValue = CurrencyExchangeFuncs.RoundExchange(_total * ratenud.Value);
                syrTotalnud.Value = _roundedTotalExchangedValue >= syrTotalnud.Minimum ? _roundedTotalExchangedValue : syrTotalnud.Minimum;

                //syrTotalnud.Value = _total * ratenud.Value;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
                discountnud.Value = 0;
                totalnud.Value = sumtotalsnud.Value;
            }
        }

        private void SearchByBillId()
        {
            try
            {
                if (billIdcb.SelectedValue == null)
                {
                    MessageBox.Show("الفاتورة غير موجودة الرجاءالتأكد من الرقم");
                    billIdcb.Focus();
                }
                else
                {
                    int _billId = (int)billIdcb.SelectedValue;
                    //if (db.Bills.Where(x => x.Id == _billId && x.BillType == BillType.شراء.ToString()).Count() > 1)
                    //{
                    Bill _bill = db.Bills.Find(_billId);
                    if (_bill != null)
                    {
                        BillBS.Position = BillBS.IndexOf(_bill);
                    }
                    //BillBS.Find("Id",_billId)
                    //}
                    //else
                    //{
                    //    BillBS.DataSource = db.Bills.Where(x => x.BillType == BillType.شراء.ToString()).ToList();
                    //}
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void QuantityChanged()
        {
            try
            {
                decimal _totalusd = 0, _totalsyp = 0;
                _totalusd = quantitynud.Value * pricenud.Value;
                _totalsyp = quantitynud.Value * exchangedpricenud.Value;

                totallineudslbl.Text = Math.Round(_totalusd, 2).ToString();
                totallinesyplbl.Text = CurrencyExchangeFuncs.RoundExchange(_totalsyp).ToString();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void PriceChanged()
        {
            try
            {
                if (currencycb.SelectedValue != null)
                    if ((int)currencycb.SelectedValue == 1)
                    {
                        decimal _totalsyp = 0;
                        _totalsyp = ratenud.Value * pricenud.Value;
                        exchangedpricenud.Value = CurrencyExchangeFuncs.RoundExchange(_totalsyp);
                    }
                    else if ((int)currencycb.SelectedValue == 2)
                    {
                        decimal _totalusd = 0;
                        _totalusd = ratenud.Value * pricenud.Value;
                        exchangedpricenud.Value = _totalusd;
                    }
            }
            catch (Exception ex)
            {
                //MSGs.ErrorMessage(ex);
            }
        }

        private void ForeignPriceChanged()
        {
            try
            {
                decimal _price = 0, _exchangedPrice = 0, _rate = 0;
                _exchangedPrice = exchangedpricenud.Value;
                _rate = ratenud.Value;
                _price = _exchangedPrice / _rate;
                pricenud.Value = _price;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        #endregion Methods

        #region Events

        private void pricenud_ValueChanged(object sender, EventArgs e)
        {
            PriceChanged();
        }

        private void billIdcb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchByBillId();
            }
        }

        private void printbillslipbtn_Click(object sender, EventArgs e)
        {
            PrintBillSlip();
        }

        private void barcodecb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RetreiveItemByBarcode();
                barcodecb.SelectAll();
            }
        }

        private void quantitynud_ValueChanged(object sender, EventArgs e)
        {
            QuantityChanged();
        }

        private void exchangedpricenud_ValueChanged(object sender, EventArgs e)
        {
            ForeignPriceChanged();
        }

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
            if (BillBS.List.Count <= 0)
            {
                MessageBox.Show("يجب  اضافة فاتورة اولاً");
                return;
            }
            if (CheckAttributes() == true)
            {
                if (BillBS.List.Count > 0)
                {
                    try
                    {
                        //ControlsEnable(false);
                        Bill _bill = BillBS.Current as Bill;
                        int _billId = _bill.Id;

                        using (dbEntities db = new dbEntities(0))
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
                            bill.CheckedOut = true;
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
                            string _account = "بيع نقدي";
                            if (!payedchkbox.Checked)
                            {
                                _account = accountcb.Text.Trim();
                            }

                            string _declaration = string.Format("فاتورة بيع - الزبون {0} - رقم الفاتورة {1} - مقدار الحسم {2}",
                        _account,
                        _bill.Id.ToString(),
                        discountnud.Value.ToString());
                            db.SaveChanges();

                            Guid _guid = bill.GUID.Value;
                            TransactionsFuncs.DeleteTransactions(_guid);
                            foreach (BillLine _billLine in bill.BillLines)
                            {
                                TransactionsFuncs.DeleteTransactions(_billLine.GUID.Value);
                            }
                            if (bill.BillType == BillType.بيع.ToString())
                            {
                                foreach (BillLine _billLine in bill.BillLines)
                                {
                                    TransactionsFuncs.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsFuncs.TT.BLS, _billLine.LUD.Value, _billLine.GUID.Value, _declaration);
                                }
                                if (payedchkbox.Checked)
                                {
                                    if (exchangebillchkbox.Checked)
                                    {
                                        TransactionsFuncs.InsertFundTransaction(bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsFuncs.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                    else
                                    {
                                        TransactionsFuncs.InsertFundTransaction(bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsFuncs.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                }
                                else
                                {
                                    if (exchangebillchkbox.Checked)
                                    {
                                        TransactionsFuncs.InsertClientTransaction(bill.AccountId.Value, bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsFuncs.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                    else
                                    {
                                        TransactionsFuncs.InsertClientTransaction(bill.AccountId.Value, bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsFuncs.TT.BLS, bill.LUD.Value, _guid, _declaration);
                                    }
                                }
                            }
                            else if (bill.BillType == BillType.شراء.ToString())
                            {
                                foreach (BillLine _billLine in bill.BillLines)
                                {
                                    TransactionsFuncs.InsertItemTransaction(_billLine.ItemId.Value, _billLine.UnitId.Value, _billLine.Quantity.Value, TransactionsFuncs.TT.BLP, _billLine.LUD.Value, _billLine.GUID.Value, _declaration);
                                }
                                if (exchangebillchkbox.Checked)
                                {
                                    TransactionsFuncs.InsertFundTransaction(bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsFuncs.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                }
                                else
                                {
                                    TransactionsFuncs.InsertFundTransaction(bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsFuncs.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                }
                                if (!payedchkbox.Checked)
                                {
                                    if (exchangebillchkbox.Checked)
                                    {
                                        TransactionsFuncs.InsertClientTransaction(bill.AccountId.Value, bill.ForeginCurrencyId.Value, bill.ExchangedAmount.Value, TransactionsFuncs.TT.BLP, bill.LUD.Value, _guid, _declaration);
                                    }
                                    else
                                    {
                                        TransactionsFuncs.InsertClientTransaction(bill.AccountId.Value, bill.CurrencyId.Value, bill.TotalAmount.Value, TransactionsFuncs.TT.BLP, bill.LUD.Value, _guid, _declaration);
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
                discountnud.Value = 0;
                barcodecb.Focus();
            }
            LoadData();
        }

        private void billLinesBS_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
            calcSumTotals();
        }

        private void itemcb_SelectedValueChanged(object sender, EventArgs e)
        {
            RetreiveItemById();
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
            RateChanged();
        }

        private void RateChanged()
        {
            try
            {
                //exchangedpricenud.Value = ratenud.Value * pricenud.Value;
                decimal _roundedExchangedValue = 0, _roundedTotalExchangedValue = 0, _exchangedValue = 0, _exchangedTotalValue = 0;
                _exchangedValue = pricenud.Value * ratenud.Value;
                _roundedExchangedValue = CurrencyExchangeFuncs.RoundExchange(_exchangedValue);
                exchangedpricenud.Value = _roundedExchangedValue >= exchangedpricenud.Minimum ? _roundedExchangedValue : exchangedpricenud.Minimum;
                _exchangedTotalValue = ratenud.Value * totalnud.Value;
                _roundedTotalExchangedValue = CurrencyExchangeFuncs.RoundExchange(_exchangedTotalValue);
                syrTotalnud.Value = _roundedTotalExchangedValue >= syrTotalnud.Minimum ? _roundedTotalExchangedValue : syrTotalnud.Minimum;
            }
            catch (Exception ex)
            {
                MessageBox.Show("لم يتم إضافة سعر تصريف ....");
            }
        }

        private void unitcb_SelectedValueChanged(object sender, EventArgs e)
        {
            RetreiveItemById();
        }

        private void chechprintbillbtn_Click(object sender, EventArgs e)
        {
            checkbillbtn_Click(null, null);
            PrintBillSlip(true);
            LoadData();
        }

        private void PrintBillSlip(bool _silent = false)
        {
            int _billId, _userId;
            _billId = (BillBS.Current as Bill).Id;
            _userId = Properties.Settings.Default.LoggedInUser.Id;
            frmBillSlip frm = new frmBillSlip(_billId, _userId, _silent);
            frm.ShowDialog();
        }

        private void adddgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeCells();
        }

        private void addcebtn_Click(object sender, EventArgs e)
        {
            //ControlsEnable(false);
            try
            {
                RetreiveItemById();
                discountnud.Value = discountnud.Minimum;
                accountcb.SelectedValue = 1;
                InsertBill();
                RetriveExchangeRate();
                payedchkbox.Checked = exchangebillchkbox.Checked = true;
                billdatedtp.Value = DateTime.Now;
                barcodecb.Focus();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void RetriveExchangeRate()
        {
            decimal _SYP = 0;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    if (db.CurrencyBulletins.Where(x => x.CurrencyId == 2).ToList().Count() > 0)
                    {
                        _SYP = db.CurrencyBulletins
                        .OrderByDescending(x => x.RateDate)
                        .First(x => x.CurrencyId == 2)
                        .Rate.Value;
                    }
                }
                ratenud.Value = _SYP >= 1 ? _SYP : 1;
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
                barcodecb.Focus();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void discountnud_ValueChanged_1(object sender, EventArgs e)
        {
            DiscountChanged();
        }

        private void DiscountChanged()
        {
            try
            {
                if (discountnud.Value >= sumtotalsnud.Value)
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
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
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
                    BillsFuncs.DeleteBillLine(_billLine);
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
            billIdcb.DataSource = null;
            BillBS = null;
            billLinesBS = null;
            billLinesDgv.DataSource = null;
        }

        #endregion Events

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

        #endregion DGV

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
                        BillsFuncs.DeleteBill((BillBS.Current as Bill).Id);
                        Reload();
                        barcodecb.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
                deletebillbtn.Enabled = true;
                barcodecb.Focus();
            }
        }

        #endregion Delete
    }
}