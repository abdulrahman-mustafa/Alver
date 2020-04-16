using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts
{
    public partial class frmAccountsGroups : Form
    {
        dbEntities db;
#pragma warning disable CS0169 // The field 'frmAccountsGroups._category' is never used
        ExpenseCategory _category;
#pragma warning restore CS0169 // The field 'frmAccountsGroups._category' is never used
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
            db = new dbEntities(0);
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
