using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using Alver.DAL;
using Alver.Misc;
using Alver.UI.Accounts.AccountReports;
using Alver.UI.Utilities;

namespace Alver.UI.Accounts
{
    public partial class frmAccounts : Form
    {
        dbEntities db;
        Account _client;
        public frmAccounts(Account Client)
        {
            InitializeComponent();
            _client = Client == null ? (new Account()) : Client;
        }
        private void AccountBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            Save();
        }
        private void Save()
        {
            //prepareList();
            db.SaveChanges();
            MSGs.SaveMessage();
            clearForm();
        }
        private void prepareList()
        {
            foreach (Account _account in AccountBindingSource.List)
            {
                try
                {
                    EntityState _state = db.Entry(_account).State;
                    if (_state == EntityState.Detached)
                    {
                        _account.AccountGroupId = 1;
                        _account.Hidden = false;
                        _account.Flag = "";
                        _account.GUID = Guid.NewGuid();
                        foreach (AccountFund _fund in _account.AccountFunds)
                        {
                            _fund.Hidden = false;
                            _fund.Flag = "";
                            _fund.GUID = _account.GUID;
                            _fund.UserId = Properties.Settings.Default.LoggedInUser.Id;
                        }
                        _account.UserId = Properties.Settings.Default.LoggedInUser.Id;
                        db.Accounts.AddOrUpdate(_account);
                    }
                }
                catch (Exception ex) { }
            }
        }
        private void frmClients_Load(object sender, System.EventArgs e)
        {
            db = new dbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
            //clearForm();
            SearchBox.Focus();
        }

        private void LoadData()
        {
            load();
            ColorizeDgv();
        }

        private void load()
        {
            db.Accounts.Load();
            db.AccountFunds.Load();
            db.Currencies.Load();
            var _clientsList = db.Accounts.ToList();
            AccountBindingSource.DataSource = _clientsList;
            accounts_FundBindingSource.DataSource = AccountBindingSource;
            currencyBindingSource.DataSource = db.Currencies.ToList();
        }
        private void clearForm()
        {
            this.Controls.ClearControls();
            tabPage1.Controls.ClearControls();
            tabPage2.Controls.ClearControls();
        }
        private void accounts_FundDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }
        private void AccountDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Account _temp = (AccountBindingSource.Current as Account);
                _temp.AccountGroupId = 1;
                _temp.LUD = DateTime.Now;
            }
            catch (Exception ex)
            {
            }
        }
        private void AccountBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int _clientPosition, _fundPosition;
            _clientPosition = AccountBindingSource.Position;
            _fundPosition = accounts_FundBindingSource.Position;
            accountsdgv.EndEdit();
            CheckChanges();
            Save();
            LoadData();
            AccountBindingSource.Position = _clientPosition;
            accounts_FundBindingSource.Position = _fundPosition;
            this.Cursor = Cursors.Default;
        }
        private void CheckChanges()
        {
            foreach (AccountFund item in accounts_FundBindingSource.List)
            {
                try
                {
                    if (item != null)
                    {
                        try
                        {
                            if (db.Entry(item).State == EntityState.Modified)
                            {
                                //if (item.Balance.Value < 0)
                                //    MessageBox.Show("يجب ان تضاف الارصدة بقيمة موجبة فقط؟!!!، سيتم تحويل كل القيم السالبة إلى قيم موجبة", "تنبيه");
                                var originalValues = db.Entry(item).OriginalValues;
                                var currentValues = db.Entry(item).CurrentValues;
                                ItemChanged(originalValues, currentValues, item);
                                item.LUD = DateTime.Now;
                            }
                            //if (db.Entry(item).State == EntityState.Detached || db.Entry(item).State == EntityState.Added)
                            //{

                            //}
                        }
                        catch (Exception ex) { }
                    }
                }
                catch (Exception ex) { }
            }//END foreach
        }
        private void ItemChanged(DbPropertyValues originalValues, DbPropertyValues currentValues, AccountFund item)
        {
            foreach (string propertyName in originalValues.PropertyNames)
            {
                var original = originalValues[propertyName];
                var current = currentValues[propertyName];
                if (!Equals(original, current))
                {
                    decimal _amount = item.Balance.Value;
                    //if (item.BalanceDirection == "لنا")
                    //{
                    //    _amount = Math.Abs(_amount);
                    //}
                    //else if (item.BalanceDirection == "لكم")
                    //{
                    //    _amount = Math.Abs(_amount) * -1;
                    //}
                    TransactionsFuncs.UpdateClientOpeningBalance(item, _amount);
                    break;
                }
            }
        }
        private void accounts_FundDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void accounts_FundDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Misc.Utilities.ComboBoxBlackBGFix((DataGridView)sender, e);
        }
        private void AccountBindingSource_ListChanged(object sender, System.ComponentModel.ListChangedEventArgs e)
        {
        }
        private void AccountBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                Account _client = AccountBindingSource.Current as Account;
                if (_client != null)
                {
                    //remittancesWageBindingSource.DataSource = db.Remittances_Wage.Where(
                    //    x => (x.Origin == Misc.Utilities.WageOrigin.وكيل_مقبوض.ToString()
                    //    || x.Origin == Misc.Utilities.WageOrigin.وكيل_غير_مقبوض.ToString()
                    //    ) &&
                    //    x.FundId == _client.Id).ToList();
                    //decimal _profitsSum = Misc.Utilities.ColumnSum(dataGridView1, wageAmountDataGridViewTextBoxColumn.Index);clientGrandResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                    //sPAccountTotalsResultBindingSource.DataSource = db.SP_AccountTotals(_client.Id).ToList();
                    //sPAccountProfitsResultBindingSource.DataSource = db.SP_AccountProfits(_client.Id).ToList();
                    clientGrandResultBindingSource.DataSource = db.SP_ClientGrand(_client.Id).ToList();
                    //sPClientGainResultBindingSource.DataSource = db.SP_ClientGain(_client.Id).ToList();
                    ColorizeDgv();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void accounts_FundDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //int _index = dataGridViewTextBoxColumn5.Index;
            //Misc.Utilities.ColorizeDecimalDGV(_dgv, _index);
            ColorizeDgv();
        }

        private void balancesDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeDgv();

        }

        private void Search(string _keyword)
        {
            if (string.IsNullOrEmpty(_keyword))
            {
                AccountBindingSource.DataSource = db.Accounts.ToList();
            }
            else
            {
                AccountBindingSource.DataSource = db.Accounts.Where(
                    x =>
                    x.FullName.Contains(_keyword.Trim())).ToList();
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

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc = AccountBindingSource.Current as Account;
            if (acc != null)
            {
                frmAccountConformity frm = new frmAccountConformity(acc);
                frm.ShowDialog();
            }
        }

        private void AccountDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ColorizeDgv();
        }

        private void ColorizeDgv()
        {
            int _index = DeactivatedColumn.Index;
            Misc.Utilities.ColorizeBoolDGV(accountsdgv, _index, true, System.Drawing.Color.Tomato);
            Misc.Utilities.ColorizeForeColor(balancesDgv, dataGridViewTextBoxColumn9.Index);
            _index = balanceDirectionDataGridViewTextBoxColumn.Index;
            Misc.Utilities.ColorizeStringDGV(accounts_FundDataGridView, _index, "لكم");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int _clientPosition, _fundPosition;
            _clientPosition = AccountBindingSource.Position;
            _fundPosition = accounts_FundBindingSource.Position;
            db.Configuration.LazyLoadingEnabled = false;
            LoadData();
            if (SearchBox.Text.Length > 0)
            {
                toolStripTextBox3_TextChanged(null, null);
            }
            db.Configuration.LazyLoadingEnabled = true;
            ColorizeDgv();
            AccountBindingSource.Position = _clientPosition;
            accounts_FundBindingSource.Position = _fundPosition;
            accountsdgv.DoubleBuffered(true);
            this.Cursor = Cursors.Default;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void frmClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountBindingSource.DataSource = null;
            accountsdgv.DataSource = null;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void accounts_FundDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AccountFund _fund = accounts_FundBindingSource.Current as AccountFund;
                db.Entry(_fund).State = EntityState.Modified;
                _fund.LUD = DateTime.Now;
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
                AccountBindingNavigatorSaveItem_Click_1(null, null);
            }
            else if (e.KeyCode == Keys.P && e.Control)
            {
                toolStripButton7_Click(null, null);
            }
        }

        private void SearchBox_Click(object sender, EventArgs e)
        {

        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (accountsdgv.Rows.Count > 0)
                accountsdgv.ExportToExcel();
        }

        private void deactivatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (AccountBindingSource.Count <= 0)
                    return;
                DialogResult _dialog = MessageBox.Show("هل انت متأكد من إجراء العملية؟ لن تتمكن من إجراء أي عملية تخص الوكيل بعد إلغاء التفعيل",
                    "تأكيد",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign);
                if (_dialog == DialogResult.Yes)
                {
                    Account _client = AccountBindingSource.Current as Account;
                    if (_client != null)
                    {
                        int _clientId = _client.Id;
                        if (_client.Deactivated.Value == true)
                        {
                            DialogResult _dialog2 = MessageBox.Show("الوكيل غير نشط بالفعل، لا يمكن إتمام العملية، هل ترغب في إعادة تنشيط الوكيل؟!!",
                                                            "",
                                                            MessageBoxButtons.YesNoCancel,
                                                            MessageBoxIcon.Information);
                            if (_dialog2 == DialogResult.Yes)
                            {
                                using (dbEntities db = new dbEntities())
                                {
                                    AccountBindingSource.EndEdit();
                                    accountsdgv.EndEdit();
                                    _client = db.Accounts.Find(_clientId);
                                    _client.Deactivated = false;
                                    db.SaveChanges();
                                    MessageBox.Show("تم الحفظ بنجاح");
                                    accountsdgv.Refresh();
                                    LoadData();
                                }
                            }
                        }
                        else
                        {
                            using (dbEntities db = new dbEntities())
                            {
                                AccountBindingSource.EndEdit();
                                accountsdgv.EndEdit();
                                _client = db.Accounts.Find(_clientId);
                                _client.Deactivated = true;
                                db.SaveChanges();
                                MessageBox.Show("تم الحفظ بنجاح");
                                accountsdgv.Refresh();
                                LoadData();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            AddClient();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DeleteClient();
        }
        private void DeleteClient()
        {
            using (TransactionScope transaction=new TransactionScope())
            {
                if (AccountBindingSource.Count <= 0)
                    return;
                string _msg = "هل أنت متأكد من تنفيذ العملية؟، سيتم حذف الوكيل وجميع العمليات المتعلقة به!";
                DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.RightAlign);
                if (_ConfirmationDialog == DialogResult.Yes)
                {
                    DialogResult _PasswordConfirmationDialog = (new frmConfirmPassword()).ShowDialog();
                    if (_PasswordConfirmationDialog == DialogResult.OK)
                    {
                        deletebtn.Enabled = false;
                        try
                        {
                            Account _client = AccountBindingSource.Current as Account;
                            if (_client != null && AccountBindingSource.Count > 0)
                            {
                                int _clientId = _client.Id;
                                using (dbEntities db = new dbEntities())
                                {
                                    db.AccountFunds.RemoveRange(db.AccountFunds.Where(x => x.AccountId == _clientId));
                                    db.Payments.RemoveRange(db.Payments.Where(x => x.AccountId == _clientId));
                                    //db.Bills.RemoveRange(db.Bills.Where(x => x.AccountId == _clientId));
                                    BillsFuncs.DeleteAccountBills(_clientId);
                                    db.ExchangeFunds.RemoveRange(db.ExchangeFunds.Where(x => x.AccountFromId == _clientId));
                                    db.ExchangeFunds.RemoveRange(db.ExchangeFunds.Where(x => x.AccountToId == _clientId));

                                    TransactionsFuncs.DeleteAllClientTransactions(_clientId);

                                    if (!db.Accounts.Any(x => x.Id == _clientId))
                                    {
                                        AccountBindingSource.RemoveCurrent();
                                    }
                                    else
                                    {
                                        _client = db.Accounts.Find(_clientId);
                                        db.Accounts.Remove(_client);
                                        AccountBindingSource.RemoveCurrent();
                                    }
                                    db.SaveChanges();
                                }
                                TransactionsFuncs.DeleteAllClientTransactions(_clientId);
                                MessageBox.Show("تم حذف الوكيل بنجاح");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("حصل خطأ أثناء حذف الوكيل ،لم يتم الحذف بنجاح", "حذف وكيل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                deletebtn.Enabled = true;
                transaction.Complete();
            }
            
        }
        private void AddClient()
        {
            frmAddAccount frm = new frmAddAccount();
            frm.ShowDialog();
            toolStripButton8_Click(null, null);
        }
        private void EditClient()
        {
            try
            {
                int _accountId = 0;
                Account _client = AccountBindingSource.Current as Account;
                _accountId = _client.Id;
                frmEditAccount frm = new frmEditAccount(_accountId);
                frm.ShowDialog();
                toolStripButton8_Click(null, null);
            }
            catch (Exception ex)
            {
                
            }
        }

        private void تعديلالوكيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient();
        }
    }
}
