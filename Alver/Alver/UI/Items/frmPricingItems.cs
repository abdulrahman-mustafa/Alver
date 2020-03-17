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
    public partial class frmPricingItems : Form
    {
        private dbEntities db;

        //int _itemId = 0;
        public frmPricingItems()
        {
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {
            try
            {
                db = new dbEntities();
                db.Configuration.ProxyCreationEnabled = false;

                db.Items.Load();
                db.Units.Load();
                db.Currencies.Load();
                db.ItemCategories.Load();
                unitBindingSource.DataSource = db.Units.ToList();
                itemCategoryBindingSource.DataSource = db.ItemCategories.ToList();
                currencyBindingSource.DataSource = db.Currencies.ToList();
                itemBindingSource.DataSource = db.Items.Local;
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!CheckValues())
                //    return;
                ////PrepareItem();
                ////db.Entry(_client).State = EntityState.Modified;
                //PrepareFund();
                //Save();
                //MessageBox.Show("تم الحفظ بنجاح");
                //this.Close();
                db.SaveChanges();
                MessageBox.Show("تم الحفظ بنجاح");
            }
            catch (Exception ex) { }
        }

        private void frmClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }

        private void itemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                int _itemId = (itemBindingSource.Current as Item).Id;
                itemAvgPurchasePriceResultBindingSource.DataSource = ItemFuncs.ItemAvgPurchasePrice(_itemId);
                itemAvgSalePriceResultBindingSource.DataSource = ItemFuncs.ItemAvgSalePrice(_itemId);
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
    }
}