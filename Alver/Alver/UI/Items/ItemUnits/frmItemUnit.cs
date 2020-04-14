using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Alver.UI.Payments.Expenses
{
    public partial class frmItemUnit : Form
    {
        dbEntities db;
        public frmItemUnit()
        {
            InitializeComponent();
        }

        private void frmExpensessCategory_Load(object sender, EventArgs e)
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;

            db.Units.Load();
            db.Users.Load();
            userBindingSource.DataSource = db.Users.Local;
            unitBindingSource.DataSource = db.Units.Local;
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
