using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmExpensessCategory : Form
    {
        dbEntities db;
#pragma warning disable CS0169 // The field 'frmExpensessCategory._category' is never used
        ExpenseCategory _category;
#pragma warning restore CS0169 // The field 'frmExpensessCategory._category' is never used
        public frmExpensessCategory()
        {
            InitializeComponent();
        }

        private void frmExpensessCategory_Load(object sender, EventArgs e)
        {
            LoadData();
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
                ExpenseCategory _expenseCategory = payments_ExpenseCategoryBindingSource.Current as ExpenseCategory;
                db.ExpenseCategories.Remove(_expenseCategory);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void LoadData()
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;

            db.ExpenseCategories.Load();
            db.Users.Load();
            payments_ExpenseCategoryBindingSource.DataSource = db.ExpenseCategories.Local;
            userBindingSource.DataSource = db.Users.ToList();
        }
    }
}
