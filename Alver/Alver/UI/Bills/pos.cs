using Alver.DAL;
using Alver.MISC;
using Alver.Properties;
using Alver.UI.Bills.BillReports;
using Alver.UI.Exchange;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.Utilities;
using static Alver.MISC.BillsFuncs;

namespace Alver.UI.Bills
{
    public partial class POS : Form
    {
        private System.Drawing.Image _trash = Resources.trash;
        private bool _purchaseBills = false;
        #region Init

        public POS()
        {
            InitializeComponent();
        }

        private void pos_Load(object sender, EventArgs e)
        {
            if (PurchaseBillsCount() <= 0)
            {
                MessageBox.Show("لم يتم اضافة اي فاتورة شراء، لا يمكنك البيع لحين اضافة فاتورة شراء");
                _purchaseBills = false;
                this.Close();
            }
            if (BillsFuncs.CheckRecords())
            {
                LoadData();
                RetriveExchangeRate();
                RetriveDailyBillAmount();
                barcodecb.Focus();
            }
            else
            {
                this.Close();
            }
        }

        #endregion Init

        #region Methods
        
        private void BillLineChanged(int _rowIndex, int _columnIndex)
        {
            if (_columnIndex == priceclm.Index || _columnIndex == quantityclm.Index)
            {
                try
                {
                    int _ItemId = (int)dgv.Rows[_rowIndex].Cells[itemidclm.Index].Value;
                    object _value = dgv.Rows[_rowIndex].Cells[_columnIndex].Value;
                    int _quantity = 0;
                    decimal _price = 0, _total = 0;
                    decimal _ItemPrice = 0, _itemTotalPrice = 0;
                    decimal _rate = ratenud.Value;
                    decimal _remainedQuantity = remainedquantitynud.Value;
                    //GET QUANTITY & PRICE
                    if (_columnIndex == quantityclm.Index)
                    {
                        int.TryParse(_value.ToString(), out _quantity);
                        decimal.TryParse(dgv.Rows[_rowIndex].Cells[priceclm.Index].Value.ToString(), out _price);
                    }
                    else if (_columnIndex == priceclm.Index)
                    {
                        decimal.TryParse(_value.ToString(), out _price);
                        int.TryParse(dgv.Rows[_rowIndex].Cells[quantityclm.Index].Value.ToString(), out _quantity);
                    }
                    if (_quantity > _remainedQuantity)
                    {
                        MessageBox.Show("لقد تجاوزت الكمية المتاحة في المخزن");
                        _quantity = (int)_remainedQuantity;
                        //dgv.Rows[_rowIndex].Cells[quantityclm.Index].Value = _quantity;
                    }
                    _total = _price * _quantity;
                   
                    int _position = 0;
                    foreach (BillLine item in billLineBS.List)
                    {
                        if (item.ItemId == _ItemId)
                        {
                            _position = billLineBS.IndexOf(item);
                            billLineBS.Position = _position;
                            break;
                        }
                    }
                    int _itemCurrencyId = (new dbEntities(0)).Items.Find(_ItemId).CurrencyId.Value;
                    _ItemPrice = (new dbEntities(0)).Items.Find(_ItemId).SalePrice.Value;
                    _itemTotalPrice = _ItemPrice * _quantity;
                    (billLineBS.Current as BillLine).Quantity = _quantity;
                    //Check CurrencyId First
                    //IF CurrencyId = 2 Then Calculate price and total depending on rate
                    if (_itemCurrencyId == 1)
                    {
                        if ((int)currencycb.SelectedValue == 1)
                        {
                            //CurrencyId=1
                            (billLineBS.Current as BillLine).Price = Math.Round(_price, 2);
                            (billLineBS.Current as BillLine).TotalPrice = Math.Round(_total, 2);
                            (billLineBS.Current as BillLine).ExchangedAmount = Math.Round(_price * ratenud.Value, 0);
                            (billLineBS.Current as BillLine).ExchangedTotalAmount = Math.Round(_total * ratenud.Value, 0);
                        }
                        else if ((int)currencycb.SelectedValue == 2)
                        {
                            //CurrencyId=1
                            (billLineBS.Current as BillLine).Price = Math.Round(_price / ratenud.Value, 2);
                            (billLineBS.Current as BillLine).TotalPrice = Math.Round(_total / ratenud.Value, 2);
                            (billLineBS.Current as BillLine).ExchangedAmount = Math.Round(_price, 0);
                            (billLineBS.Current as BillLine).ExchangedTotalAmount = Math.Round(_total, 0);
                        }
                    }
                    else if (_itemCurrencyId == 2)
                    {
                        if ((int)currencycb.SelectedValue == 1)
                        {
                            //CurrencyId=1
                            (billLineBS.Current as BillLine).Price = Math.Round(_price, 2);
                            (billLineBS.Current as BillLine).TotalPrice = Math.Round(_total, 2);
                            (billLineBS.Current as BillLine).ExchangedAmount = _ItemPrice;
                            (billLineBS.Current as BillLine).ExchangedTotalAmount = _itemTotalPrice;
                        }
                        else if ((int)currencycb.SelectedValue == 2)
                        {
                            //CurrencyId=1
                            (billLineBS.Current as BillLine).Price = Math.Round(_price / ratenud.Value, 2);
                            (billLineBS.Current as BillLine).TotalPrice = Math.Round(_total / ratenud.Value, 2);
                            (billLineBS.Current as BillLine).ExchangedAmount = Math.Round(_price, 0);
                            (billLineBS.Current as BillLine).ExchangedTotalAmount = Math.Round(_total, 0);
                        }
                    }
                    //CurrencyId=1
                    //(billLineBS.Current as BillLine).Price = _price;
                    //(billLineBS.Current as BillLine).TotalPrice = _total;
                    //CurrencyId=2
                    //(billLineBS.Current as BillLine).ExchangedAmount = _price;
                    //(billLineBS.Current as BillLine).ExchangedTotalAmount = _total;
                    billLineBS.EndEdit();
                    dgv.DataSource = billLineBS;
                    calcSumTotals();
                }
                catch (Exception ex)
                {
                    //MSGs.ErrorMessage(ex);
                }
            }
        }

        private void RetriveDailyBillAmount()
        {
            if (_purchaseBills)
            {
                try
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        var _discard = db.DailyBillAmount((int)currencycb.SelectedValue, DateTime.Now, BillType.مرتجع.ToString()).ToList();
                        totaldicardamountnud.Value = _discard.Count > 0 && _discard[0] != null ? _discard[0].Value : 0;
                        var _sold = db.DailyBillAmount((int)currencycb.SelectedValue, DateTime.Now, BillType.بيع.ToString()).ToList();
                        totalsoldamountnud.Value = _sold.Count > 0 && _sold[0] != null ? _sold[0].Value : 0;
                    }
                }
                catch (Exception ex)
                {
                    MSGs.ErrorMessage(ex);
                }
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
                    else
                    {
                        MessageBox.Show("يجب اولاً ضبط نشرة اسعار الصرف لكل العملات");
                        DialogResult res= (new frmCurrenciesBulletin()).ShowDialog();
                        RetriveExchangeRate();
                    }
                }
                ratenud.Value = _SYP >= 1 ? _SYP : 1;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void LoadData()
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    //db.Currencies.AsNoTracking().AsQueryable().Load();
                    //db.Items.AsNoTracking().AsQueryable().Load();
                    currencyBS.DataSource = db.Currencies.Where(x => x.Id == 1 || x.Id == 2).AsQueryable().AsNoTracking().ToList();
                    itemBS.DataSource = db.Items.AsQueryable().AsNoTracking().ToList();
                    itemBindingSource.DataSource = db.Items.AsQueryable().AsNoTracking().ToList();
                    unitBindingSource.DataSource = db.Units.AsQueryable().AsNoTracking().ToList();
                    billLineBS.List.Clear();
                    billtypecb.SelectedIndex = 0;
                    selltypecb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void NewBill()
        {
            ClearBillLines();
            ClearForm();
            billtypecb.SelectedIndex = 0;
            selltypecb.SelectedIndex = 0;
            dgv.Refresh();
        }

        private void ClearForm()
        {
            billdatedtp.Value = DateTime.Now;
            declarationtb.Clear();
            barcodecb.Text = "";
            itemcb.Text = "";
            billLineBS.List.Clear();
            sumtotalsnud.Value = 0;
            discountnud.Value = 0;
            totalnud.Value = 0;
            barcodecb.Focus();
        }

        private void DeleteLine()
        {
            billLineBS.RemoveCurrent();
            calcSumTotals();
        }

        private void ClearBillLines()
        {
            try
            {
                billLineBS.List.Clear();
                calcSumTotals();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private bool RetreiveItemByBarcode()
        {
            bool _barcodeFound = false;
            try
            {
                string _barcode = barcodecb.Text;
                int _itemId = 0, _unitId = 1;
                decimal _salePrice = 0;
                int _currencyId = 0;
                if (!string.IsNullOrEmpty(barcodecb.Text))
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        if (db.Items.Where(x => x.Barcode == _barcode).Any())
                        {
                            //Barcode Found
                            _barcodeFound = true;
                            _itemId = db.Items.FirstOrDefault(x => x.Barcode == _barcode).Id;
                            itemcb.SelectedValue = _itemId;
                            _salePrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;

                            _currencyId = db.Items.FirstOrDefault(x => x.Id == _itemId).CurrencyId.Value;
                            if (_currencyId == 1)
                            {
                                priceusdnud.Value = _salePrice;
                                pricesypnud.Value = _salePrice * ratenud.Value;
                            }
                            else if (_currencyId == 2)
                            {
                                priceusdnud.Value = _salePrice / ratenud.Value;
                                pricesypnud.Value = _salePrice;
                            }
                            decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);
                            decimal _soldQuantity = 0;
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if ((int)row.Cells[itemidclm.Index].Value == _itemId)
                                {
                                    _soldQuantity = (decimal)dgv.Rows[row.Index].Cells[quantityclm.Index].Value + 1;
                                    break;
                                }
                            }
                            remainedquantitynud.Value = _remainedQuantity;
                            if (billtypecb.Text.Trim() == BillType.بيع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity - _soldQuantity;
                            }
                            else if (billtypecb.Text.Trim() == BillType.مرتجع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity + _soldQuantity;
                            }
                        }
                        else
                        {
                            //Barcode Not Found
                            _barcodeFound = false;
                            MessageBox.Show("لم يتم تعريف الباركود او ربطه باي مادة!!!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _barcodeFound;
        }

        private bool AddBillLine(bool _barcodeRead)
        {
            bool _added = false;
            try
            {
                Guid _guid = Guid.NewGuid();
                BillLine _billLine = new BillLine();
                decimal _quantity = 1, _price = 0, _totalPrice = 0, _exchangedPrice = 0, _discount = 0, _totalExchangedPrice = 0;
                int _itemId = 0, userid = 0;
                string _declaration = string.Empty;
                int _itemCurrencyid=0, _currencyId = 1, _foreignCurrencyId = 2, _unitId = 1;
                bool _exchanged =false;
                DateTime _billDate = DateTime.Now;
                string _billType = billtypecb.Text.Trim() == BillType.بيع.ToString() ? BillType.بيع.ToString() : BillType.مرتجع.ToString();
                _itemId = (int)itemcb.SelectedValue;
                userid = Properties.Settings.Default.LoggedInUser.Id;
                _discount = discountnud.Value;

                int _selectedCurrencyId = (int)currencycb.SelectedValue;
                //Price is always in USD &&&&&& ExchangedPrice is always in SYP
                //They swaped when saving bill
                using (dbEntities db = new dbEntities(0))
                {
                    _itemCurrencyid = db.Items.Find(_itemId).CurrencyId.Value;
                    _currencyId = (int)currencycb.SelectedValue;
                    if (_selectedCurrencyId == 1)
                    {
                        //_currencyId = 1;
                        _foreignCurrencyId = 2;
                        if (_itemCurrencyid == 1)
                        {
                            //CurrencyId  = 1
                            _price = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                            _totalPrice = Math.Round(_quantity * _price, 2);
                            _exchangedPrice = _price * ratenud.Value;
                            _totalExchangedPrice = _quantity * _exchangedPrice;
                        }
                        if (_itemCurrencyid == 2)
                        {
                            //CurrencyId  = 2
                            _exchangedPrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                            _totalExchangedPrice = _quantity * _exchangedPrice;
                            _price = Math.Round(_exchangedPrice / ratenud.Value, 2);
                            _totalPrice = Math.Round(_quantity * _price, 2);
                        }
                    }
                    else if (_selectedCurrencyId == 2)
                    {
                        //_currencyId = 2;
                        _foreignCurrencyId = 1;
                        if (_itemCurrencyid == 1)
                        {
                            //CurrencyId  = 1
                            _price = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                            _totalPrice = Math.Round(_quantity * _price, 2);
                            _exchangedPrice = Math.Round(_price * ratenud.Value,0);
                            _totalExchangedPrice = _quantity * _exchangedPrice;
                        }
                        if (_itemCurrencyid == 2)
                        {
                            //CurrencyId  = 2
                            _exchangedPrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                            _totalExchangedPrice = _quantity * _exchangedPrice;
                            _price = Math.Round(_exchangedPrice / ratenud.Value, 2);
                            _totalPrice = Math.Round(_quantity * _price, 2);
                        }
                    }
                    //_price = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                    //_totalPrice = Math.Round(_quantity * _price, 2);
                    //_exchangedPrice = _price * ratenud.Value;
                    //_totalExchangedPrice = _quantity * _exchangedPrice;

                    bool _exsists = false;
                    int _rowIndex = -1;
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if ((int)row.Cells[itemidclm.Index].Value == _itemId)
                        {
                            _exsists = true;
                            _rowIndex = row.Index;
                            dgv.Rows[_rowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        }
                    }
                    if (_exsists)
                    {
                        decimal _qty = (decimal)dgv.Rows[_rowIndex].Cells[quantityclm.Index].Value;
                        _quantity = ++_qty;
                        if (remainedaftersoldnud.Value > 0)
                        {
                            dgv.Rows[_rowIndex].Cells[quantityclm.Index].Value = _quantity;
                            _exchanged = _selectedCurrencyId != _currencyId;
                            _price = (decimal)dgv.Rows[_rowIndex].Cells[priceclm.Index].Value;
                            _totalPrice = Math.Round(_quantity * _price, 2);
                            dgv.Rows[_rowIndex].Cells[totalclm.Index].Value = _totalPrice;
                            //if (_selectedCurrencyId == 1)
                            //{
                            //    //CurrencyId  = 1
                            //    //_currencyId = 1;
                            //    //_foreignCurrencyId = 2; 
                            //    //_price = (decimal)dgv.Rows[_rowIndex].Cells[priceclm.Index].Value;
                            //    //_totalPrice = Math.Round(_quantity * _price, 2);
                            //    _exchangedPrice = _price * ratenud.Value;
                            //    _totalExchangedPrice = _quantity * _exchangedPrice;
                            //    //dgv.Rows[_rowIndex].Cells[totalclm.Index].Value = _totalPrice;
                            //}
                            //if (_selectedCurrencyId == 2)
                            //{
                            //    //CurrencyId  = 2
                            //    //_currencyId = 2;
                            //    //_foreignCurrencyId = 1;
                            //    //_price = (decimal)dgv.Rows[_rowIndex].Cells[priceclm.Index].Value;
                            //    //_totalPrice = Math.Round(_quantity * _price, 0);
                            //    _exchangedPrice = Math.Round(_price / ratenud.Value, 2);
                            //    _totalExchangedPrice = _quantity * _exchangedPrice;
                            //    //_exchangedPrice = (decimal)dgv.Rows[_rowIndex].Cells[priceclm.Index].Value;
                            //    //_totalExchangedPrice = _quantity * _exchangedPrice;
                            //    //_price = Math.Round(_exchangedPrice / ratenud.Value, 2);
                            //    //_totalPrice = Math.Round(_quantity * _price, 2);
                            //    //dgv.Rows[_rowIndex].Cells[totalclm.Index].Value = _totalPrice;
                            //}
                        }
                        else
                        {
                            MessageBox.Show("لقد تجاوزت الكمية المتاحة في المخزن لا يمكن إضافة القلم");
                            _added = false;
                        }
                        //CALCULATE TOTALS
                    }
                    else if (_itemId != 0)
                    {
                        decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);
                        if (billtypecb.Text.Trim() == BillType.بيع.ToString())
                        {
                            if (_remainedQuantity - _quantity < 0)
                            {
                                MessageBox.Show("لقد تجاوزت الكمية المتاحة في المخزن لا يمكن إضافة القلم");
                                _added = false;
                            }
                        }
                        else
                        {
                            _billLine.ItemId = _itemId;
                            _billLine.UnitId = _unitId;
                            _billLine.CurrencyId = _currencyId;
                            _billLine.ForeginCurrencyId = _foreignCurrencyId;
                            _billLine.Price = Math.Round(_price, 2);
                            _billLine.Quantity = _quantity;
                            _billLine.TotalPrice = _totalPrice;
                            _billLine.Exchanged = _exchanged;
                            _billLine.Rate = ratenud.Value;
                            _billLine.ExchangedAmount = _exchangedPrice;
                            _billLine.ExchangedTotalAmount = _totalExchangedPrice;
                            _billLine.Hidden = false;
                            _billLine.Flag = string.Empty;
                            _billLine.LUD = DateTime.Now;
                            _billLine.GUID = _guid;
                            _billLine.UserId = userid;
                            _billLine.PROTECTED = false;
                            billLineBS.List.Add(_billLine);
                            billLineBS.ResetBindings(false);
                            _added = true;
                        }
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
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
                //MessageBox.Show(ex.Message);
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
            return _added;
        }

        private void calcSumTotals()
        {
            try
            {
                int _sumquantity = 0, _itemscount = 0;
                decimal _sumtotals = 0, _total = 0, _sumprices = 0, _discount = 0, _rate = 1;

                _itemscount = dgv.Rows.Count;
                _sumquantity = (int)dgv.ColumnSum(quantityclm.Index);
                _sumprices = dgv.ColumnSum(priceclm.Index);
                _sumtotals = dgv.ColumnSum(totalclm.Index);
                dgvtotal.DataSource = dgvtotal.POSTotalsDGV(_itemscount, _sumquantity, _sumprices, _sumtotals);
                dgvtotal.Columns[1].HeaderText = "";
                //dgvtotal.Rows[0].Cells[sumquantityclm.Index].Value = _sumquantity;
                //dgvtotal.Rows[0].Cells[sumpricesclm.Index].Value = _sumprices;
                //dgvtotal.Rows[0].Cells[sumtotalsclm.Index].Value = _sumtotals;
                //dgvtotal.Rows[0].Cells[itemscountclm.Index].Value = _itemscount;

                _discount = discountnud.Value;
                _total = _sumtotals - _discount;
                //_rate = ratenud.Value;
                //if ((int)currencycb.SelectedValue == 1)
                //{
                //    _total = _sumtotals - _discount;
                //}
                //else
                //{
                //    _sumtotals = Math.Round(_sumtotals * _rate, 0);
                //    _total = _sumtotals - _discount;
                //}
                sumtotalsnud.Value = _sumtotals;
                totalnud.Value = _total;
                //CalcGrandTotal();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void BarcodeRead()
        {
            try
            {
                if (!string.IsNullOrEmpty(barcodecb.Text))
                {
                    if (RetreiveItemByBarcode())
                    {
                        AddBillLine(true);
                        calcSumTotals();
                        barcodecb.Focus();
                        barcodecb.SelectAll();
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        private void ItemRead()
        {
            try
            {
                if (!string.IsNullOrEmpty(itemcb.Text))
                {
                    if (RetreiveItemById())
                    {
                        
                        AddBillLine(true);
                        calcSumTotals();
                        barcodecb.Focus();
                        barcodecb.SelectAll();
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
                if (string.IsNullOrEmpty(selltypecb.Text.Trim()))
                {
                    MessageBox.Show("يرجى تعيين نوع المبيع أولاً");
                    selltypecb.Focus();
                    _result = false;
                }
                else if (selltypecb.Text.Trim() == "آجل")
                {
                    if (string.IsNullOrEmpty(accountcb.Text.Trim()))
                    {
                        MessageBox.Show("لا يمكن إضافة فاتورة آجلة بدون اسم الزبون، الرجاء اختيار زبون اولاً");
                        accountcb.Focus();
                        _result = false;
                    }
                }
                if (billLineBS.Count < 1)
                {
                    MessageBox.Show("لا يمكن إضافة فاتورة بدون اقلام، الرجاء إضافة اقلام اولاً");
                    barcodecb.Focus();
                    _result = false;
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _result;
        }

        //SaveBillLines
        //1- Add Bill Head
        //2- Assign billLines to Bill By BillId
        //Retrive Daily Amounts
        private int SaveBill()
        {
            int _billId = AddBill();
            if (_billId != 0)
            {
                BillTransactions(_billId);
                SaveBillLines(_billId);
                NewBill();
                MessageBox.Show("تم الحفظ بنجاح");
            }
            return _billId;
        }

        private void BillTransactions(int billId)
        {
            Bill bill = (new dbEntities(0)).Bills.Find(billId);
            Guid _guid = bill.GUID.Value;
            string billType = bill.BillType;
            string _account = selltypecb.Text.Trim() == "نقدي" ? "نقدي" : accountcb.Text.Trim();
            TransactionsFuncs.TT transactionType = TransactionsFuncs.TT.FOO;
            string _declaration = string.Format("فاتورة {3} - الزبون {0} - رقم الفاتورة {1} - مقدار الحسم {2}",
                                                _account,
                                                billId.ToString(),
                                                discountnud.Value.ToString(),
                                                billType);
            if (billType == BillType.بيع.ToString())
            {
                transactionType = TransactionsFuncs.TT.BLS;
            }
            else if (billType == BillType.مرتجع.ToString())
            {
                transactionType = TransactionsFuncs.TT.BLD;
            }
            if (_account == "بيع نقدي")
            {
                TransactionsFuncs.InsertFundTransaction(bill.CurrencyId.Value, bill.TotalAmount.Value, transactionType, bill.LUD.Value, _guid, _declaration);
            }
            else
            {
                TransactionsFuncs.InsertClientTransaction(bill.AccountId.Value, bill.CurrencyId.Value, bill.TotalAmount.Value, transactionType, bill.LUD.Value, _guid, _declaration);
            }
        }

        private int AddBill()
        {
            int _billId = 0;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    Guid _guid = Guid.NewGuid();
                    string billType = billtypecb.Text.Trim();
                    int currencyId = (int)currencycb.SelectedValue;
                    int foreignCurrencyId = currencyId == 1 ? 2 : 1;
                    int accountId = selltypecb.Text.Trim() == "نقدي" ? 0 : (int)accountcb.SelectedValue;
                    bool cashout = accountId == 0 ? true : false;
                    string _account = selltypecb.Text.Trim() == "نقدي" ? "نقدي" : accountcb.Text.Trim();

                    bool exchanged = currencyId == 2 ? true : false;

                    Bill bill = new Bill();
                    bill.BillType = billType;
                    bill.CurrencyId = currencyId;
                    bill.ForeginCurrencyId = foreignCurrencyId;
                    bill.DiscountAmount = discountnud.Value;
                    bill.BillDate = billdatedtp.Value;
                    bill.Declaration = declarationtb.Text.Trim();
                    bill.CheckedOut = cashout;
                    bill.AccountId = accountId;
                    bill.Cashout = cashout;
                    bill.Exchanged = exchanged;
                    bill.Rate = ratenud.Value;
                    ///
                    bill.BillAmount = sumtotalsnud.Value;
                    bill.TotalAmount = totalnud.Value;
                    if (currencyId == 1)
                    {
                        bill.ExchangedAmount = totalnud.Value * ratenud.Value;
                    }
                    else if (currencyId == 2)
                    {
                        bill.ExchangedAmount = Math.Round(totalnud.Value / ratenud.Value, 2);
                    }
                    bill.LUD = DateTime.Now;
                    bill.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    bill.Flag = string.Empty;
                    bill.Hidden = false;
                    bill.GUID = _guid;
                    bill.PROTECTED = false;

                    db.Set<Bill>().Add(bill);
                    db.SaveChanges();
                    _billId = bill.Id;
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
                throw;
            }
            return _billId;
        }

        private void SaveBillLines(int billId)
        {
            //Loop Throug BillLines and invoke SaveBillLine for each object
            foreach (BillLine item in billLineBS.List)
            {
                //SaveBillLine
                SaveBillLine(billId, item);
                BillLinesTransactions(billId, item);
            }
        }

        private void BillLinesTransactions(int billId, BillLine item)
        {
            string billType = billtypecb.Text.Trim();
            string _account = selltypecb.Text.Trim() == "نقدي" ? "بيع نقدي" : accountcb.Text.Trim();
            TransactionsFuncs.TT transactionType = TransactionsFuncs.TT.FOO;
            string _declaration = string.Format("فاتورة {3} - الزبون {0} - رقم الفاتورة {1} - مقدار الحسم {2}",
                                                _account,
                                                billId.ToString(),
                                                discountnud.Value.ToString(),
                                                billType);
            if (billType == BillType.بيع.ToString())
            {
                transactionType = TransactionsFuncs.TT.BLS;
            }
            else if (billType == BillType.مرتجع.ToString())
            {
                transactionType = TransactionsFuncs.TT.BLD;
            }
            TransactionsFuncs.InsertItemTransaction(item.ItemId.Value, item.UnitId.Value, item.Quantity.Value, transactionType, item.LUD.Value, item.GUID.Value, _declaration);
        }

        private void SaveBillLine(int billId, BillLine _billLine)
        {
            Guid _guid = Guid.NewGuid();
            try
            {
                decimal _price, _total, _exprice, _extotal;

                _price = _billLine.Price.Value;
                _total = _billLine.TotalPrice.Value;
                _exprice = _billLine.ExchangedAmount.Value;
                _extotal = _billLine.ExchangedTotalAmount.Value;

                _billLine.BillId = billId;
                if ((int)currencycb.SelectedValue == 1)
                {
                    _billLine.CurrencyId = 1;
                    _billLine.ForeginCurrencyId = 2;
                    _billLine.Exchanged = false;
                }
                else if ((int)currencycb.SelectedValue == 2)
                {
                    _billLine.CurrencyId = 2;
                    _billLine.ForeginCurrencyId = 1;
                    _billLine.Price = _exprice;
                    _billLine.TotalPrice = _extotal;
                    _billLine.ExchangedAmount = _price;
                    _billLine.ExchangedTotalAmount = _total;
                    _billLine.Exchanged = true;
                }
                using (dbEntities db = new dbEntities(0))
                {
                    db.Set<BillLine>().Add(_billLine);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
                throw;
            }
        }

        private void PrintBillSlip(int billId, bool _silent = false)
        {
            int _userId;
            _userId = Settings.Default.LoggedInUser.Id;
            frmBillSlip frm = new frmBillSlip(billId, _userId, _silent);
            frm.ShowDialog();
        }

        #endregion Methods

        #region Events

        private void barcodecb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BarcodeRead();
            }
            e.Handled = true;
        }

        private void currencycb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (currencycb.SelectedValue != null)
            {
                if ((int)currencycb.SelectedValue == 1)
                {
                    //CurrencyId  = 1
                    currencyidclm.DataPropertyName = "CurrencyId";
                    priceclm.DataPropertyName = "Price";
                    totalclm.DataPropertyName = "TotalPrice";
                    priceclm.DefaultCellStyle.Format = "N2";
                    totalclm.DefaultCellStyle.Format = "N2";
                }
                if ((int)currencycb.SelectedValue == 2)
                {
                    //CurrencyId  = 2
                    currencyidclm.DataPropertyName = "ForeginCurrencyId";
                    priceclm.DataPropertyName = "ExchangedAmount";
                    totalclm.DataPropertyName = "ExchangedTotalAmount";
                    priceclm.DefaultCellStyle.Format = "0##";
                    totalclm.DefaultCellStyle.Format = "0##";
                }
                calcSumTotals();
                RetriveDailyBillAmount();
            }
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void dgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int _itemId = -1;
                if (dgv.Rows.Count > 0)
                {
                    _itemId = (int)dgv.Rows[e.RowIndex].Cells[itemidclm.Index].Value;
                    BillLineChanged(e.RowIndex, e.ColumnIndex);

                    if (_itemId != -1)
                    {
                        dgv.Rows
                                .OfType<DataGridViewRow>()
                                 .Where(x => (int)x.Cells[itemidclm.Index].Value == _itemId)
                                 .ToArray<DataGridViewRow>()[0]
                                 .Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void billLineBS_CurrentChanged(object sender, EventArgs e)
        {
            BilllineCurrentChanged();
        }

        private void BilllineCurrentChanged()
        {
            try
            {
                int _itemId = 0, _unitId = 1;
                BillLine _billline = billLineBS.Current as BillLine;
                if (billLineBS.List.Count > 0)
                    if (_billline != null)
                    {
                        if (_billline.ItemId != null)
                        {
                            _itemId = _billline.ItemId.Value;
                            using (dbEntities db = new dbEntities(0))
                            {
                                decimal _salePrice = db.Items
                                    .FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId)
                                    .SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;
                                int _selectedCurrencyId = (int)currencycb.SelectedValue;
                                int _currencyId = db.Items.Find(_itemId).CurrencyId.Value;
                                if (_selectedCurrencyId == 1)
                                {
                                    if (_currencyId == 1)
                                    {
                                        priceusdnud.Value = _salePrice;
                                        pricesypnud.Value = _salePrice * ratenud.Value;
                                    }
                                    else if (_currencyId == 2)
                                    {
                                        priceusdnud.Value = _salePrice / ratenud.Value;
                                        pricesypnud.Value = _salePrice;
                                    }
                                }
                                else if (_selectedCurrencyId == 2)
                                {
                                    if (_currencyId == 1)
                                    {
                                        priceusdnud.Value = _salePrice / ratenud.Value;
                                        pricesypnud.Value = _salePrice;
                                    }
                                    else if (_currencyId == 2)
                                    {
                                        priceusdnud.Value = _salePrice / ratenud.Value;
                                        pricesypnud.Value = _salePrice;
                                    }
                                }
                                //priceusdnud.Value = _salePrice;
                                //pricesypnud.Value = _salePrice * ratenud.Value;
                            }
                            decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);
                            remainedquantitynud.Value = _remainedQuantity;
                            if (billtypecb.Text.Trim() == BillType.بيع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity - _billline.Quantity.Value;
                            }
                            else if (billtypecb.Text.Trim() == BillType.مرتجع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity + _billline.Quantity.Value;
                            }
                        }
                    }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //
                if (e.ColumnIndex == deleteclm.Index)
                {
                    DeleteLine();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void clearbilllinesbtn_Click(object sender, EventArgs e)
        {
            ClearBillLines();
        }

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteLine();
            }
        }

        private void selltypecb_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selltypecb.Text.Trim()))
            {
                if (selltypecb.Text.Trim() == "نقدي")
                {
                    accountcb.Enabled = false;
                    accountBS.DataSource = null;
                }
                else if (selltypecb.Text.Trim() == "آجل")
                {
                    accountcb.Enabled = true;
                    accountBS.DataSource = (new dbEntities(0)).Accounts.ToList();
                }
            }
        }

        private void cashoutbillbtn_Click(object sender, EventArgs e)
        {
            if (CheckAttributes())
            {
                int billId = SaveBill();
                RetriveDailyBillAmount();
                if (printbillchkbox.Checked)
                {
                    PrintBillSlip(billId, true);
                }
            }
        }

        #endregion Events

        private void billtypecb_SelectedValueChanged(object sender, EventArgs e)
        {
            BilllineCurrentChanged();
        }

        private void itemcb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ItemRead();
            }
            e.Handled = true;
        }
        private bool RetreiveItemById()
        {
            bool _itemFound = false;
            try
            {
                string _barcode = barcodecb.Text;
                int _itemId = (int)itemcb.SelectedValue;
                int  _unitId = 1;
                decimal _salePrice = 0;
                int _currencyId = 0;
                //decimal _roundedExchangedValue = 0, _exchangedValue = 0;
                int _selectedCurrencyId = (int)currencycb.SelectedValue;

                if (!string.IsNullOrEmpty(itemcb.Text))
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        if (db.Items.Where(x => x.Id == _itemId).Any())
                        {
                            //Barcode Found
                            _itemFound = true;
                            //itemBS.DataSource = db.Items.Where(x => x.Id == _itemId).AsQueryable().AsNoTracking().ToList();
                            _barcode = db.Items.FirstOrDefault(x => x.Id == _itemId).Barcode;
                            barcodecb.Text = _barcode;
                            //itemcb.SelectedValue = _itemId;
                            _salePrice = db.Items.FirstOrDefault(x => x.Id == _itemId && x.UnitId == _unitId).SalePrice != null ? db.Items.Find(_itemId).SalePrice.Value : 0;

                            _currencyId = db.Items.FirstOrDefault(x => x.Id == _itemId).CurrencyId.Value;
                            if (_selectedCurrencyId == 1)
                            {
                                if (_currencyId == 1)
                                {
                                    priceusdnud.Value = _salePrice;
                                    pricesypnud.Value = _salePrice * ratenud.Value;
                                }
                                else if (_currencyId == 2)
                                {
                                    priceusdnud.Value = _salePrice / ratenud.Value;
                                    pricesypnud.Value = _salePrice;
                                }
                            }
                            else if (_selectedCurrencyId == 2)
                            {
                                if (_currencyId == 1)
                                {
                                    priceusdnud.Value = _salePrice / ratenud.Value;
                                    pricesypnud.Value = _salePrice ;
                                }
                                else if (_currencyId == 2)
                                {
                                    priceusdnud.Value = _salePrice / ratenud.Value;
                                    pricesypnud.Value = _salePrice;
                                }
                            }

                            //_roundedExchangedValue = CurrencyExchangeFuncs.RoundExchange(_exchangedValue);

                            decimal _remainedQuantity = ItemFuncs.ItemQauantity(_itemId, _unitId);
                            decimal _soldQuantity = 0;
                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                if ((int)row.Cells[itemidclm.Index].Value == _itemId)
                                {
                                    _soldQuantity = (decimal)dgv.Rows[row.Index].Cells[quantityclm.Index].Value + 1;
                                    break;
                                }
                            }
                            remainedquantitynud.Value = _remainedQuantity;
                            if (billtypecb.Text.Trim() == BillType.بيع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity - _soldQuantity;
                            }
                            else if (billtypecb.Text.Trim() == BillType.مرتجع.ToString())
                            {
                                remainedaftersoldnud.Value = _remainedQuantity + _soldQuantity;
                            }
                        }
                        else
                        {
                            //Barcode Not Found
                            _itemFound = false;
                            MessageBox.Show("لم يتم تعريف الباركود او ربطه باي مادة!!!!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _itemFound;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenCalculator();
        }
    }
}