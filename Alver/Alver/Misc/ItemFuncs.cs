using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Alver.MISC
{
    public static class ItemFuncs
    {
        public static int ItemsCount()
        {
            using (dbEntities db=new dbEntities(0))
            {
                int _count= db.Items.Count();
                if (_count<1)
                {
                    MessageBox.Show("لم يتم اضافة مواد بعد لا يمكن فتح النافذة الا بعد اضافة المواد");
                }
                return _count;
            }
        }
        public static bool CheckRecords()
        {
            bool _result = true;
            using (dbEntities db = new dbEntities(0))
            {
                if (db.ItemCategories.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة تصنيفات المواد بعد، لا يمكنك إضافة مادة");
                    _result = false;
                }
                else if (db.Units.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة الوحدات بعد، لا يمكنك اضافة مادة");
                    _result = false;
                }
                
            }
            return _result;
        }
        public static decimal ItemQauantity(int ItemId)
        {
            decimal _quantity = 0;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _quantity = db.ItemTransactions.Where(x => x.Id == ItemId).Sum(x => x.Amount.Value);
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _quantity;
        }

        public static decimal ItemQauantity(int ItemId, int UnitId)
        {
            decimal _quantity = 0;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    List<ItemTransaction> _transactions = db.ItemTransactions.Where(x => x.ItemId == ItemId && x.UnitId == UnitId).ToList();
                    _quantity = _transactions.Sum(x => x.Amount.Value);
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _quantity;
        }

        public static System.Windows.Forms.BindingSource ItemAvgPurchasePrice(int ItemId)
        {
            System.Windows.Forms.BindingSource _avg = new System.Windows.Forms.BindingSource();
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _avg.DataSource = db.ItemAvgPurchasePrice(ItemId, 1).ToList();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _avg;
        }

        public static System.Windows.Forms.BindingSource ItemAvgPurchasePrice(int ItemId, int UnitId)
        {
            System.Windows.Forms.BindingSource _avg = new System.Windows.Forms.BindingSource();
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _avg.DataSource = db.ItemAvgPurchasePrice(ItemId, UnitId).ToList();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _avg;
        }

        public static System.Windows.Forms.BindingSource ItemAvgSalePrice(int ItemId)
        {
            System.Windows.Forms.BindingSource _avg = new System.Windows.Forms.BindingSource();
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _avg.DataSource = db.ItemAvgSalePrice(ItemId, 1).ToList();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _avg;
        }

        public static System.Windows.Forms.BindingSource ItemAvgSalePrice(int ItemId, int UnitId)
        {
            System.Windows.Forms.BindingSource _avg = new System.Windows.Forms.BindingSource();
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _avg.DataSource = db.ItemAvgSalePrice(ItemId, UnitId).ToList();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _avg;
        }
    }
}