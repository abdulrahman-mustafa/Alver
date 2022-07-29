using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.UI.Setup
{
    public partial class frmCurrencies : Form
    {
        dbEntities db;
        public frmCurrencies()
        {
            InitializeComponent();
        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;

            db.Currencies.Load();
            db.Users.Load();
            currencyBindingSource.DataSource = db.Currencies.Local;
            userBindingSource.DataSource = db.Users.Local;
        }

        private void dgvCurrencies_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
