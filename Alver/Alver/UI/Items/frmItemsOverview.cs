using Alver.DAL;
using Alver.MISC;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.ItemFuncs;

namespace Alver.UI.Items
{
    public partial class frmItemsOverview : Form
    {
        public frmItemsOverview()
        {
            InitializeComponent();
        }

        private void frmClientsOverview_Load(object sender, EventArgs e)
        {
            if (ItemsCount() > 0)
            {
                sortcb.Checked = false;
                using (dbEntities db = new dbEntities(0))
                {
                    db.Currencies.Load();
                    currencyBindingSource.DataSource = db.Currencies.ToList();
                }
            }
            else
            {
                this.Close();
            }
            
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            //Account acc = new Account();
            //V_CLIENTS _currentRow = vCLIENTSBindingSource.Current as V_CLIENTS;
            //int _accountId = _currentRow.AccountId;
            //using (dbEntities db = new dbEntities(0))
            //{
            //    acc = db.Accounts.Find(_accountId);
            //}
            //if (acc != null)
            //{
            //    //frmClientConformity frm = new frmClientConformity(acc);
            //    //frm.ShowDialog();
            //}
        }

        private void refreshdatabtn_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //int _ItemPosition;
            //_ItemPosition = vSTOCKBindingSource.Position;
            //LoadData();
            //if (SearchBox.Text.Length > 0)
            //{
            //    SearchBox_TextChanged(null, null);
            //}
            //vCLIENTSBindingSource.Position = _ItemPosition;
            //dgv.DoubleBuffered(true);
            //this.Cursor = Cursors.Default;
        }

        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.ExportToExcel();
            }
        }

        private void Search(string _keyword)
        {
            using (dbEntities db = new dbEntities(0))
            {
                if (string.IsNullOrEmpty(_keyword))
                {
                    vSTOCKBindingSource.DataSource = db.V_STOCK.ToList();
                }
                else
                {
                    vSTOCKBindingSource.DataSource = db.V_STOCK.Where(
                        x =>
                        x.اسم_المادة.Contains(_keyword.Trim())).ToList();
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
            IQueryable<V_STOCK> _query;
            using (dbEntities db = new dbEntities(0))
            {
                _query = db.V_STOCK as IQueryable<V_STOCK>;
                _query = ASEC ? _query.OrderBy(x => x.عدد_الكروزات_المتوفرة) : _query.OrderByDescending(x => x.عدد_الكروزات_المتوفرة);

                //switch (_currencyId)
                //{
                //    case 1:
                //        _query = ASEC ? _query.OrderBy(x => x.USDAmount) : _query.OrderByDescending(x => x.USDAmount);
                //        break;
                //    case 2:
                //        _query = ASEC ? _query.OrderBy(x => x.SYPAmount) : _query.OrderByDescending(x => x.SYPAmount);
                //        break;
                //    case 3:
                //        _query = ASEC ? _query.OrderBy(x => x.TLAmount) : _query.OrderByDescending(x => x.TLAmount);
                //        break;
                //    case 4:
                //        _query = ASEC ? _query.OrderBy(x => x.EUROAmount) : _query.OrderByDescending(x => x.EUROAmount);
                //        break;
                //    case 5:
                //        _query = ASEC ? _query.OrderBy(x => x.SARAmount) : _query.OrderByDescending(x => x.SARAmount);
                //        break;
                //    default:
                //        break;
                //}
                vSTOCKBindingSource.DataSource = _query.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //int _currencyId = (int)currencycomboBox.SelectedValue;
            bool ASEC = false, DESC = false;
            ASEC = aseccb.Checked;
            DESC = !ASEC;
            if (sortcb.Checked)
            {
                Retrieve(0, ASEC);
            }
            else
            {
                using (dbEntities db = new dbEntities(0))
                {
                    vSTOCKBindingSource.DataSource = db.V_STOCK.ToList();
                }
            }
            dgv.ColorizeDecimalDGVCell();
            //dgvTotals.DataSource = dgv.OverviewTotalsDGV();
            this.Cursor = Cursors.Default;
        }

        private void sortcb_CheckedChanged(object sender, EventArgs e)
        {
            sortgb.Enabled = sortcb.Checked;
        }

        private void dgv_ColumnNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
    }
}