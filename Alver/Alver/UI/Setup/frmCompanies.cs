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
    public partial class frmCompanies : Form
    {
        dbEntities db;

        public frmCompanies()
        {
            InitializeComponent();
        }

        private void frmCompanies_Load(object sender, EventArgs e)
        {
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;

            db.Units.Load();
            db.Users.Load();
            companyBS.DataSource = db.Companies.Local;
            userBindingSource.DataSource = db.Users.Local;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
