using Alver.DAL;
using Alver.Misc;
using System;
using System.Data.Entity;
using System.Linq;
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
            LoadData();
        }

        private void LoadData()
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;

            db.ExpenseCategories.Load();
            db.Users.Load();
            accountGroupBindingSource.DataSource = db.AccountGroups.ToList();
            userBindingSource.DataSource = db.Users.ToList();
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
                AccountGroup _accountGroup = accountGroupBindingSource.Current as AccountGroup;
                db.AccountGroups.Remove(_accountGroup);
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
