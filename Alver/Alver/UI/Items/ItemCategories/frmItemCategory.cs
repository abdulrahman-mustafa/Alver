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
    }
}
