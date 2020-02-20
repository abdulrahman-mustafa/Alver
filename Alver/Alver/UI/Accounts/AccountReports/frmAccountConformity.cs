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
                Accounts_InfoBindingSource.DataSource = db.Accounts.FirstOrDefault(x => x.Id == _client.Id);
                ClientGrand_ResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                this.reportViewer1.RefreshReport();
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
