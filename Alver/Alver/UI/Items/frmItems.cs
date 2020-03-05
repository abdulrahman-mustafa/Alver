using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Alver.DAL;
using Alver.MISC;
using Alver.UI.Items;
using Alver.UI.Utilities;

namespace Alver.UI.Accounts
{
    public partial class frmItems : Form
    {
        //dbEntities db;
        private Item _item;

        public frmItems(Item item)
        {
            InitializeComponent();
            _item = item == null ? (new Item()) : item;
        }

        private void AccountBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
        }

        private void frmClients_Load(object sender, System.EventArgs e)
        {
            LoadData();
            SearchBox.Focus();
        }

        private void LoadData()
        {
            load();
            ColorizeDgv();
        }

        private void load()
        {
            using (dbEntities db = new dbEntities())
            {
                db.Items.AsNoTracking().Load();
                db.ItemFunds.AsNoTracking().Load();
                db.ItemCategories.AsNoTracking().Load();
                db.Units.AsNoTracking().Load();
                db.Currencies.AsNoTracking().Load();
                currencyBS.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                itemsBS.DataSource = db.Items.AsNoTracking().AsQueryable().ToList();
                unitsBS.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
                ItemCategoriesBS.DataSource = db.ItemCategories.AsNoTracking().AsQueryable().ToList();
            }
        }

        private void clearForm()
        {
            this.Controls.ClearControls();
            tabPage2.Controls.ClearControls();
        }

        private void accounts_FundDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void accounts_FundDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            MISC.Utilities.ComboBoxBlackBGFix((DataGridView)sender, e);
        }

        private void AccountBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
        }

        private void AccountBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                //Account _client = AccountBindingSource.Current as Account;
                //if (_client != null)
                //{
                //    //remittancesWageBindingSource.DataSource = db.Remittances_Wage.Where(
                //    //    x => (x.Origin == Misc.Utilities.WageOrigin.وكيل_مقبوض.ToString()
                //    //    || x.Origin == Misc.Utilities.WageOrigin.وكيل_غير_مقبوض.ToString()
                //    //    ) &&
                //    //    x.FundId == _client.Id).ToList();
                //    //decimal _profitsSum = Misc.Utilities.ColumnSum(dataGridView1, wageAmountDataGridViewTextBoxColumn.Index);clientGrandResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                //    //sPAccountTotalsResultBindingSource.DataSource = db.SP_AccountTotals(_client.Id).ToList();
                //    //sPAccountProfitsResultBindingSource.DataSource = db.SP_AccountProfits(_client.Id).ToList();
                //    clientGrandResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                //    //sPClientGainResultBindingSource.DataSource = db.SP_ClientGain(_client.Id).ToList();
                //    ColorizeDgv();
                //}
            }
            catch (Exception ex)
            {
            }
        }

        private void accounts_FundDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeDgv();
        }

        private void balancesDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeDgv();
        }

        private void Search(string _keyword)
        {
            using (dbEntities db = new dbEntities())
            {
                if (string.IsNullOrEmpty(_keyword))
                {
                    itemsBS.DataSource = db.Items.ToList();
                }
                else
                {
                    itemsBS.DataSource = db.Items.Where(
                        x =>
                        x.ItemName.Contains(_keyword.Trim())).ToList();
                }
            }
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            Search(SearchBox.Text);
        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigator3_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripTextBox4_TextChanged(object sender, EventArgs e)
        {
            //Account _client = AccountBindingSource.Current as Account;
            //string Keyword = toolStripTextBox4.Text;
            //if (string.IsNullOrEmpty(Keyword) || _client.Id == 0)
            //{
            //    payeesBindingSource.DataSource = db.Payees.Where(
            //    x => x.ClientId == _client.Id).ToList();
            //}
            //else
            //{
            //    payeesBindingSource.DataSource = db.Payees.Where(
            //    x => x.Fullname.Contains(Keyword.Trim()) &&
            //    x.ClientId == _client.Id).ToList();
            //}
        }

        private void AccountDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeDgv();
        }

        private void ColorizeDgv()
        {
            //int _index = DeactivatedColumn.Index;
            //Misc.Utilities.ColorizeBoolDGV(accountsdgv, _index, true, System.Drawing.Color.Tomato);
            //Misc.Utilities.ColorizeForeColor(balancesDgv, dataGridViewTextBoxColumn9.Index);
            //_index = balanceDirectionDataGridViewTextBoxColumn.Index;
            //Misc.Utilities.ColorizeStringDGV(accounts_FundDataGridView, _index, "لكم");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            //int _clientPosition, _fundPosition;
            //_clientPosition = AccountBindingSource.Position;
            //_fundPosition = accounts_FundBindingSource.Position;
            //db.Configuration.LazyLoadingEnabled = false;
            //LoadData();
            //if (SearchBox.Text.Length > 0)
            //{
            //    toolStripTextBox3_TextChanged(null, null);
            //}
            //db.Configuration.LazyLoadingEnabled = true;
            //ColorizeDgv();
            //AccountBindingSource.Position = _clientPosition;
            //accounts_FundBindingSource.Position = _fundPosition;
            //accountsdgv.DoubleBuffered(true);
            //this.Cursor = Cursors.Default;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void frmClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            itemsBS.DataSource = null;
            itemsdgv.DataSource = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void accounts_FundDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //AccountFund _fund = accounts_FundBindingSource.Current as AccountFund;
                //db.Entry(_fund).State = EntityState.Modified;
                //_fund.LUD = DateTime.Now;
                //Misc.Utilities.ColorizeDGV((DataGridView)sender, dataGridViewTextBoxColumn4.Index);
            }
            catch (Exception ex) { }
        }

        private void frmClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R && e.Control)
            {
                toolStripButton8_Click(null, null);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                //AccountBindingNavigatorSaveItem_Click_1(null, null);
            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                //toolStripButton7_Click(null, null);
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemsdgv.Rows.Count > 0)
                itemsdgv.ExportToExcel();
        }

        private void itemsBS_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Item _item = itemsBS.Current as Item;
                    if (_item != null)
                    {
                        sPItemGrandResultBindingSource.DataSource = db.SP_ItemGrand(_item.Id).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            frmItem frm = new frmItem();
            frm.ShowDialog();
            LoadData();
        }

        private void DeleteItem()
        {
            if (itemsBS.Count <= 0)
                return;
            string _msg = "هل أنت متأكد من تنفيذ العملية؟، سيتم حذف المادة وجميع الفواتير التي تحوي المادة!";
            DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign);
            if (_ConfirmationDialog == DialogResult.Yes)
            {
                DialogResult _PasswordConfirmationDialog = new frmConfirmPassword().ShowDialog();
                if (_PasswordConfirmationDialog == DialogResult.OK)
                {
                    deletebtn.Enabled = false;
                    try
                    {
                        Item _item = itemsBS.Current as Item;
                        if (_item != null && itemsBS.Count > 0)
                        {
                            int _itemId = _item.Id;
                            using (dbEntities db = new dbEntities())
                            {
                                List<Bill> _bills = new List<Bill>();
                                db.ItemFunds.RemoveRange(db.ItemFunds.Where(x => x.ItemId == _itemId));
                                var _billLines = db.BillLines.Where(x => x.ItemId == _itemId).ToList();
                                foreach (var _billLine in _billLines)
                                {
                                    _bills.Add(db.Bills.FirstOrDefault(x => x.Id == _billLine.BillId.Value));
                                    //db.Bills.Remove(db.Bills.FirstOrDefault(x => x.Id == _billLine.BillId.Value));
                                    //db.BillLines.Remove(db.BillLines.FirstOrDefault(x => x.BillId == _billLine.Id));
                                }
                                _bills = _bills.Distinct().ToList();
                                foreach (Bill bill in _bills)
                                {
                                    BillsFuncs.DeleteBill(bill.Id);
                                }
                                //TransactionsOperations.DeleteAllItemTransactions(_itemId);
                                if (!db.Items.Any(x => x.Id == _itemId))
                                {
                                    itemsBS.RemoveCurrent();
                                }
                                else
                                {
                                    _item = db.Items.Find(_itemId);
                                    db.Items.Remove(_item);
                                    itemsBS.RemoveCurrent();
                                }
                                db.SaveChanges();
                            }
                            TransactionsFuncs.DeleteAllItemTransactions(_itemId);
                            MessageBox.Show("تم حذف المادة بنجاح");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("حصل خطأ أثناء حذف الفاتورة ،لم يتم الحذف بنجاح", "حذف وكيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            deletebtn.Enabled = true;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteItem();
            LoadData();
        }

        private void تعديلالوكيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (itemsBS.Count > 0)
                {
                    int _itemId = (itemsBS.Current as Item).Id;
                    frmItemEdit frm = new frmItemEdit(_itemId);
                    frm.ShowDialog();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void itemsdgv_DoubleClick(object sender, EventArgs e)
        {
            تعديلالوكيلToolStripMenuItem_Click(null, null);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
        }

        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            if (itemsdgv.RowCount > 0)
            {
                string _companyname = "",
                    _companyAddress = "",
                    _companyManager = "",
                    _ManagerPhone = "";
                using (dbEntities db = new dbEntities())
                {
                    _companyname = db.Companies.Find(1).Title;
                    _companyAddress = db.Companies.Find(1).Address;
                    _companyManager = db.Companies.Find(1).Manager;
                    _ManagerPhone = db.Companies.Find(1).ManagerPhone;
                }
                string _reportName = "المواد";
                string _reportHeader = "قائمة بالمواد الموجودة في المخزن";
                string _decimalPlaces = "2";
                string _firstTitle = string.Format("{0} - العنوان: {1}", _companyname, _companyAddress);
                string _secondTitle = string.Format("بإدارة: {0} - الهاتف: {1}", _companyManager, _ManagerPhone);
                itemsdgv.EXPXLS(_reportName, _reportHeader, _decimalPlaces, _firstTitle, _secondTitle);
            }
        }
    }
}