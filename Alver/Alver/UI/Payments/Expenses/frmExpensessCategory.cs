using Alver.DAL;
using Alver.Misc;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmExpensessCategory : Form
    {
        dbEntities db;
        ExpenseCategory _category;
        public frmExpensessCategory()
        {
            InitializeComponent();
        }

        private void frmExpensessCategory_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;

            db.ExpenseCategories.Load();
            payments_ExpenseCategoryBindingSource.DataSource = db.ExpenseCategories.Local;
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
