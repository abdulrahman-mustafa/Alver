using Alver.DAL;
using Alver.Misc;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Alver.UI.Accounts
{
    public partial class frmAccountsGroups : Form
    {
        dbEntities db;
        ExpenseCategory _category;
        public frmAccountsGroups()
        {
            InitializeComponent();
        }

        private void frmExpensessCategory_Load(object sender, EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;

            db.ExpenseCategories.Load();
            accountGroupBindingSource.DataSource = db.AccountGroups.Local;
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
