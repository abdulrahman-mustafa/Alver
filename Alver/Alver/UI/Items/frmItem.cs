using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Items
{
    public partial class frmItem : Form
    {
        dbEntities db;
        Item _item;
        ItemCategory _category = null;
        Unit _unit = null;

        public frmItem()
        {
            InitializeComponent();
        }
        private void frmOut_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            ControlsEnable(false);
        }
        private void LoadData()
        {
            db.Units.AsNoTracking().AsQueryable().Load();
            db.ItemCategories.AsNoTracking().AsQueryable().Load();
            itemCategoryBindingSource.DataSource = db.ItemCategories.AsNoTracking().AsQueryable().ToList();
            unitBindingSource.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
            Misc.Utilities.SearchableComboBox(itemcb);
        }
        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities();
            //db.Configuration.ProxyCreationEnabled = false;
            ClearForm();
            LoadData();
        }
        private void ClearForm()
        {
            itemcb.Text = string.Empty;
            barcodecb.Text = string.Empty;
            declarationcb.Text = string.Empty;
        }
        private void PrepareItem()
        {
            try
            {
                int _categoryId = 0;
                int _unitId = 0;
                using (dbEntities db = new dbEntities())
                {

                    if (itemCategorycb.SelectedValue != null)
                    {
                        _categoryId = (int)itemCategorycb.SelectedValue;
                    }
                    if (unitcb.SelectedValue != null)
                    {
                        _unitId = (int)unitcb.SelectedValue;
                    }
                    _category = db.ItemCategories.Find(_categoryId);
                    _unit = db.Units.Find(_unitId);
                    _item = new Item()
                    {

                        ItemName = itemcb.Text.Trim(),
                        Declaration = declarationcb.Text.Trim(),
                        UserId = Properties.Settings.Default.LoggedInUser.Id,
                        //Users_User = Properties.Settings.Default.LoggedInUser,
                        //Navigation properties
                        CategoryId = _categoryId,
                        UnitId = _unitId,
                        ItemCategory = _category,
                        Unit = _unit,
                        Hidden = false,
                        LUD = DateTime.Now,
                        GUID = Guid.NewGuid(),
                        Flag = string.Empty,
                        PROTECTED = false
                    };
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
        //private void GetValuesFromForm()
        //{

        //    _item.AccountGroupId = 1;// Misc.Utilities.AccountGroup.وكيل_حوالات.ToString();
        //    _item.FullName = itemcb.Text.Trim();
        //    _item.Father = fatherTextBox.Text.Trim();
        //    _item.Mother = barcodecb.Text.Trim();
        //    _item.IdNumber = declarationcb.Text.Trim();
        //    _item.CountryId = 0;// (int)countryNameComboBox.SelectedValue;
        //    _item.CityId = 0;// (int)cityNameComboBox.SelectedValue;
        //    _item.Phone = phoneMaskedTextBox.Text.Trim();
        //    _item.Address = addressTextBox.Text.Trim();
        //    _item.LUD = DateTime.Now;
        //    _item.GUID = Guid.NewGuid();
        //    _item.Flag = string.Empty;
        //    _item.UserId = Properties.Settings.Default.LoggedInUser.Id;
        //    //_client.Users_User = Properties.Settings.Default.LoggedInUser;
        //    _item.Hidden = false;
        //    _item.Deactivated = isActiveCheckBox.Checked;
        //    _item.Declaration = notestextBox.Text.Trim();
        //    //Navigation properties
        //}
        private void ControlsEnable(bool _enable)
        {
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            addNew();
            ControlsEnable(true);
        }
        private bool CheckValues()
        {
            bool _result = true;
            try
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
                PrepareItem();
                //db.Entry(_client).State = EntityState.Modified;
                Save();
                ControlsEnable(false);
            }
            catch (Exception ex) { }
        }
        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities())
                    {
                        User _user = Properties.Settings.Default.LoggedInUser;
                        decimal _balance = fundBalancenud.Value;
                        int _unitId = _unit.Id, _itemId = _item.Id, _userId = _user.Id;
                        //_payment = new Payments_Operation();
                        _item.User = _user;
                        _item.ItemCategory = _category;
                        _item.Unit = _unit;
                        db.Set<Item>().Add(_item);
                        db.Entry(_category).State = EntityState.Detached;
                        db.Entry(_unit).State = EntityState.Detached;
                        db.Entry(_user).State = EntityState.Detached;
                        db.SaveChanges();
                        _itemId = _item.Id;
                        ItemFund _fund = new ItemFund()
                        {
                            ItemId = _itemId,
                            Balance = _balance,
                            BalanceDirection = "",
                            Declaration = "",
                            FundTitle = "الكمية المتبقية",
                            UnitId = _unitId,
                            UserId= _userId,
                            Hidden = false,
                            LUD = DateTime.Now,
                            GUID = Guid.NewGuid(),
                            Flag = string.Empty,
                            PROTECTED = false
                        };
                        db.Set<ItemFund>().Add(_fund);
                        db.SaveChanges();
                        string _declaration = "كمية اول المدة";
                        TransactionsOperations.InsertItemOpeningBalance(_fund, _declaration);
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                    scope.Complete();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح");
            }
        }
        private void frmClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addbtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}
