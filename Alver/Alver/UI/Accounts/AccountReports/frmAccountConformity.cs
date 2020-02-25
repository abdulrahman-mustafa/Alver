using Alver.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts.AccountReports
{
    public partial class frmAccountConformity : Form
    {
        //dbEntities db;
        Account _client;
        public frmAccountConformity(Account Client)
        {
            InitializeComponent();
            _client = Client == null ? (new Account()) : Client;
        }

        private void frmClientConformity_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities())
            {
                db.Accounts.Load();
                db.Images.Load();
                ImageBindingSource.DataSource = db.Images.Find(1);
                AccountBindingSource.DataSource = db.Accounts.FirstOrDefault(x => x.Id == _client.Id);
                SP_ClientGrand_ResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                this.reportViewer1.RefreshReport();
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
