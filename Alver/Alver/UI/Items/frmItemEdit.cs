using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Items
{
    public partial class frmItemEdit : Form
    {
        private int _itemId = 0;

        public frmItemEdit(int ItemId)
        {
            if (ItemId < 1)
            {
                MessageBox.Show("حدث خطأ اثناء جلب بيانات المادة، حاول مرة أخرى");
                this.Close();
            }
            else
            {
                _itemId = ItemId;
            }
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    //db.Units.AsNoTracking().Load();
                    //db.Currencies.AsNoTracking().Load();
                    //db.ItemCategories.AsNoTracking().Load();
                    //db.ItemFunds.AsNoTracking().Load();
                    unitBindingSource.DataSource = db.Units.AsNoTracking().ToList().AsQueryable();
                    itemCategoryBindingSource.DataSource = db.ItemCategories.AsNoTracking().ToList().AsQueryable();
                    currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
                    MISC.Utilities.SearchableComboBox(itemcb);
                    Item _item = db.Items.Find(_itemId);
                    if (_item != null)
                    {
                        //fundBalancenud.Value = (db.ItemFunds.FirstOrDefault(x => x.ItemId == _itemId).Balance.Value);
                        itemcb.Text = _item.ItemName;
                        //fundBalancenud.Value = (db.ItemFunds.FirstOrDefault(x => x.ItemId == _itemId).Balance.Value);
                        barcodecb.Text = _item.Barcode;
                        itemCategorycb.SelectedValue = _item.CategoryId.Value;
                        itemCategorycb.SelectedValue = _item.CategoryId.Value;
                        unitcb.SelectedValue = _item.UnitId.Value;
                        currencycb.SelectedValue = _item.CurrencyId.Value;
                        purchasepricenud.Value = _item.PurchasePrice.Value;
                        salepricenud.Value = _item.SalePrice.Value;
                        declarationcb.Text = _item.Declaration;
                        ItemFund _fund = db.ItemFunds.FirstOrDefault(x => x.ItemId == _itemId);
                        if (_fund != null)
                        {
                            fundBalancenud.Value = _fund.Balance.Value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private bool CheckValues()
        {
            bool _result = true;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    if (string.IsNullOrWhiteSpace(itemcb.Text.Trim()))
                    {
                        MessageBox.Show("الرجاء التأكد من اسم المادة، لا يجب ان يكون اسم المادة فارغاً");
                        itemcb.Focus();
                        _result = false;
                    }
                    else if (db.Accounts.Any(x => x.FullName.ToLower().Trim() == itemcb.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("اسم المادة موجود من قبل، يرجى اختيار اسم آخر");
                        itemcb.Focus();
                        _result = false;
                    }
                    //else if (db.Items.Any(x => x.Barcode.ToLower().Trim() == barcodecb.Text.ToLower().Trim()))
                    //{
                    //    MessageBox.Show("الباركود مستخدم من قبل، يرجى التأكد من الباركود");
                    //    barcodecb.Focus();
                    //    _result = false;
                    //}
                }
            }
            catch (Exception ex) { }
            return _result;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValues())
                    return;
                //PrepareItem();
                //db.Entry(_client).State = EntityState.Modified;
                //PrepareFund();
                Save();
                MessageBox.Show("تم الحفظ بنجاح");
                this.Close();
            }
            catch (Exception ex) { }
        }

        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        try
                        {
                            int _currencyId = 0;
                            int _categoryId = 0;
                            int _unitId = 0;
                            Item _item;

                            if (currencycb.SelectedValue != null)
                            {
                                _currencyId = (int)currencycb.SelectedValue;
                            }
                            if (itemCategorycb.SelectedValue != null)
                            {
                                _categoryId = (int)itemCategorycb.SelectedValue;
                            }
                            if (unitcb.SelectedValue != null)
                            {
                                _unitId = (int)unitcb.SelectedValue;
                            }
                            _item = db.Items.Find(_itemId);

                            _item.ItemName = itemcb.Text.Trim();
                            _item.Barcode = barcodecb.Text.Trim();
                            _item.Declaration = declarationcb.Text.Trim();
                            _item.UserId = Properties.Settings.Default.LoggedInUser.Id;
                            //Users_User = Properties.Settings.Default.LoggedInUser;
                            //Navigation properties
                            _item.CurrencyId = _currencyId;
                            _item.CategoryId = _categoryId;
                            _item.UnitId = _unitId;
                            _item.Hidden = false;
                            _item.PurchasePrice = purchasepricenud.Value;
                            _item.SalePrice = salepricenud.Value;
                            _item.LUD = DateTime.Now;
                            _item.GUID = Guid.NewGuid();
                            _item.Flag = string.Empty;
                            _item.PROTECTED = false;
                            db.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MSGs.ErrorMessage(ex);
                        }
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
        }

        private void PrepareFund()
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    int _fundId = db.ItemFunds.FirstOrDefault(x => x.ItemId == _itemId).Id;
                    ItemFund _fund = db.ItemFunds.Find(_fundId);
                    _fund.Balance = fundBalancenud.Value;
                    db.SaveChanges();
                    TransactionsFuncs.UpdateItemOpeningBalance(_fund, fundBalancenud.Value);
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void frmClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}