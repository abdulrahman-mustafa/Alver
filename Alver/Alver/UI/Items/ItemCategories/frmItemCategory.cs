using Alver.DAL;
using Alver.Misc;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmItemCategory : Form
    {
        dbEntities db;
        ExpenseCategory _category;
        public frmItemCategory()
        {
            InitializeComponent();
        }

        private void frmExpensessCategory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;

            db.Users.Load();
            userBindingSource.DataSource = db.Users.Local;

            db.ItemCategories.Load();
            itemCategoryBindingSource.DataSource = db.ItemCategories.Local;
        }

        private void payments_ExpenseCategoryDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
            MSGs.SaveMessage();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                ItemCategory _itemCategory = itemCategoryBindingSource.Current as ItemCategory;
                db.ItemCategories.Remove(_itemCategory);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
    }
}
