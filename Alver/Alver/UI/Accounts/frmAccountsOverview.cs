using Alver.DAL;
using Alver.Misc;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Accounts
{
    public partial class frmAccountsOverview : Form
    {
        public frmAccountsOverview()
        {
            InitializeComponent();
        }
        private void frmClientsOverview_Load(object sender, EventArgs e)
        {
            LoadData();
            sortcb.Checked = false;
        }
        private void LoadData()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Currencies.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
            }
        }
        private void printbtn_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            V_CLIENTS _currentRow = vCLIENTSBindingSource.Current as V_CLIENTS;
            int _accountId = _currentRow.AccountId;
            using (dbEntities db = new dbEntities())
            {
                acc = db.Accounts.Find(_accountId);
            }
            if (acc != null)
            {
                //frmClientConformity frm = new frmClientConformity(acc);
                //frm.ShowDialog();
            }
        }
        private void refreshdatabtn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int _clientPosition;
            _clientPosition = vCLIENTSBindingSource.Position;
            LoadData();
            if (SearchBox.Text.Length > 0)
            {
                SearchBox_TextChanged(null, null);
            }
            vCLIENTSBindingSource.Position = _clientPosition;
            dgv.DoubleBuffered(true);
            this.Cursor = Cursors.Default;
        }
        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }
        private void Search(string _keyword)
        {
            using (dbEntities db = new dbEntities())
            {
                if (string.IsNullOrEmpty(_keyword))
                {
                    vCLIENTSBindingSource.DataSource = db.V_CLIENTS.ToList();
                }
                else
                {
                    vCLIENTSBindingSource.DataSource = db.V_CLIENTS.Where(
                        x =>
                        x.Account.Contains(_keyword.Trim())).ToList();
                }
            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            sortcb.Checked = false;
            Search(SearchBox.Text.Trim());
        }
        private void Retrieve(int _currencyId, bool ASEC)
        {
            IQueryable<V_CLIENTS> _query;
            using (dbEntities db = new dbEntities())
            {
                _query = db.V_CLIENTS as IQueryable<V_CLIENTS>;
                switch (_currencyId)
                {
                    case 1:
                        _query = ASEC ? _query.OrderBy(x => x.USDAmount) : _query.OrderByDescending(x => x.USDAmount);
                        break;
                    case 2:
                        _query = ASEC ? _query.OrderBy(x => x.SYPAmount) : _query.OrderByDescending(x => x.SYPAmount);
                        break;
                    case 3:
                        _query = ASEC ? _query.OrderBy(x => x.TLAmount) : _query.OrderByDescending(x => x.TLAmount);
                        break;
                    case 4:
                        _query = ASEC ? _query.OrderBy(x => x.EUROAmount) : _query.OrderByDescending(x => x.EUROAmount);
                        break;
                    case 5:
                        _query = ASEC ? _query.OrderBy(x => x.SARAmount) : _query.OrderByDescending(x => x.SARAmount);
                        break;
                    default:
                        break;
                }
                vCLIENTSBindingSource.DataSource = _query.ToList();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int _currencyId = (int)currencycomboBox.SelectedValue;
            bool ASEC = false, DESC = false;
            ASEC = aseccb.Checked;
            DESC = !ASEC;
            if (sortcb.Checked)
            {
                Retrieve(_currencyId, ASEC);
            }
            else
            {
                using (dbEntities db = new dbEntities())
                {
                    vCLIENTSBindingSource.DataSource = db.V_CLIENTS.ToList();
                }
            }
            dgv.ColorizeDecimalDGVCell();
            dgvTotals.DataSource = dgv.OverviewTotalsDGV();
            this.Cursor = Cursors.Default;
        }

        private void sortcb_CheckedChanged(object sender, EventArgs e)
        {
            sortgb.Enabled = sortcb.Checked;
        }
    }
}
