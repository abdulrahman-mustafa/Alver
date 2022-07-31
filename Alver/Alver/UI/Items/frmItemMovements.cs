using Alver.DAL;
using Alver.MISC;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static Alver.MISC.Utilities;
using static Alver.MISC.ItemFuncs;

namespace Alver.UI.Items
{
    public partial class frmItemMovements : Form
    {
        public frmItemMovements()
        {
            InitializeComponent();
        }

        private void frmClientsOverview_Load(object sender, EventArgs e)
        {
            if (ItemsCount() > 0)
            {
                using (dbEntities db = new dbEntities(0))
                {
                    db.Items.Load();
                    itemBindingSource.DataSource = db.Items.AsNoTracking().AsQueryable().ToList();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Items.Load();
                db.Users.Load();
                db.Units.Load();
                db.Currencies.Load();
                itemBS.DataSource = db.Items.AsNoTracking().AsQueryable().ToList();
                userBS.DataSource = db.Users.AsNoTracking().AsQueryable().ToList();
                unitBS.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
                basecurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                subcurrencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
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
                    //vSTOCKBindingSource.DataSource = db.V_STOCK.ToList();
                }
                else
                {
                    //vSTOCKBindingSource.DataSource = db.V_STOCK.Where(
                    //    x =>
                    //    x.اسم_المادة.Contains(_keyword.Trim())).ToList();
                }
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            Search(SearchBox.Text.Trim());
        }

        private IQueryable<BillLine> GrandSearch(DateTime _from, DateTime _to, int _itemId)
        {
            IQueryable<BillLine> _query;// = new IQueryable<Remittances_Operation>;
            using (dbEntities db = new dbEntities(0))
            {
                _query = db.BillLines as IQueryable<BillLine>;
                if (_from.Year == _to.Year && _from.Month == _to.Month)
                {
                    _query = db.BillLines.Where(
                            x => ((x.LUD.Value.Year >= _from.Year && x.LUD.Value.Year <= _to.Year) &&
                                (x.LUD.Value.Month >= _from.Month && x.LUD.Value.Month <= _to.Month) &&
                                (x.LUD.Value.Day >= _from.Day && x.LUD.Value.Day <= _to.Day))
                        ).AsQueryable();
                }
                else if (_from.Year != _to.Year)
                {
                    _query = db.BillLines.Where(
                        x => x.LUD.Value.Year >= _from.Year && x.LUD.Value.Year <= _to.Year
                        ).AsQueryable();
                }
                else if (_from.Year == _to.Year && _from.Month != _to.Month)
                {
                    _query = db.BillLines.Where(
                        x => ((x.LUD.Value.Year >= _from.Year && x.LUD.Value.Year <= _to.Year) &&
                        (x.LUD.Value.Month >= _from.Month && x.LUD.Value.Month <= _to.Month))
                        ).AsQueryable();
                }
                if (_itemId != 0)
                {
                    _query = _query.Where(x => x.ItemId == _itemId);
                }
                _query = _query.OrderBy(x => x.LUD);

                billLineBS.DataSource = _query.ToList();
            }
            return _query;
        }

        private void Retrive()
        {
            this.Cursor = Cursors.WaitCursor;
            LoadData();
            int _itemId = 0;
            DateTime _from, _to;
            if (FromDateTimePicker.Checked)
            {
                _from = FromDateTimePicker.Value;
            }
            else
            {
                _from = FromDateTimePicker.MinDate;
            }
            _to = ToDateTimePicker.Value;

            if (itemchkbox.Checked && itemcb.SelectedValue != null)
            {
                _itemId = (int)itemcb.SelectedValue;
            }
            GrandSearch(_from, _to, _itemId);
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            dgv.ColorizeStringDGVFullRow(dgv.Columns["BillIdClm"].Index, BillType.بيع.ToString());
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void itemchkbox_CheckedChanged(object sender, EventArgs e)
        {
            itemcb.Enabled = itemchkbox.Checked;
        }
    }
}