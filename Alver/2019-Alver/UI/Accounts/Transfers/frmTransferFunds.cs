﻿using Alver.DAL;
using Alver.MISC;
using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;

namespace Alver.UI.Accounts.Transfers
{
    public partial class frmTransferFunds : Form
    {
        private Transfer _transfer;

        public frmTransferFunds(Transfer Trans)
        {
            InitializeComponent();
            _transfer = Trans == null ? (new Transfer()) : Trans;
        }

        private void frmTransferFunds_Load(object sender, EventArgs e)
        {
            LoadData();
            ControlsEnable(false);
        }

        private void ControlsEnable(bool _enable)
        {
            operationDateDateTimePicker.Value = DateTime.Now;
            declarationTextBox.Clear();
            savebtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            amountNumericUpDown.Value = amountNumericUpDown.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Currencies.AsNoTracking().Load();
                db.AccountFunds.AsNoTracking().Load();
                db.Accounts.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
                accountsInfoBindingSource.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
                accountsInfoBindingSource1.DataSource = db.Accounts.AsNoTracking().Where(x => x.Deactivated == false && x.Hidden == false).ToList().AsQueryable();
            }
            MISC.Utilities.SearchableComboBox(fromclientComboBox);
            MISC.Utilities.SearchableComboBox(toclientcomboBox);
        }

        private void transferClientFundBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //_transfer = transferClientFundBindingSource.Current as Transfer;
        }

        private void addNew()
        {
            //db.Dispose();
            //db = new dbEntities(0);
            //db.Configuration.ProxyCreationEnabled = false;
            //_transfer = new Transfer();
            //LoadData();
        }

        private void Save()
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (dbEntities db = new dbEntities(0))
                    {
                        Account _fromAccount, _toAccount;
                        _fromAccount = accountsInfoBindingSource.Current as Account;
                        _toAccount = accountsInfoBindingSource.Current as Account;
                        _transfer.Account = _fromAccount;
                        _transfer.Account1 = _toAccount;

                        db.Set<Transfer>().Add(_transfer);
                        db.Entry(_fromAccount).State = EntityState.Detached;
                        db.Entry(_toAccount).State = EntityState.Detached;
                        db.SaveChanges();
                        InitTransactions();
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                    scope.Complete();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            { MessageBox.Show("حدث خطأ داخلي، لم يتم الحفظ بنجاح"); }
        }

        private void InitTransactions()
        {
            string _declaration = string.Format("تحويل/اعتماد رصيد {0} من صندوق الوكيل: {1} إلى صندوق الوكيل: {2}",
                amountNumericUpDown.Value.ToString(),
                fromclientComboBox.Text.ToString(),
                toclientcomboBox.Text.ToString());

            int _fromAccountId = (int)fromclientComboBox.SelectedValue;
            int _toAccountId = (int)toclientcomboBox.SelectedValue;
            int _currencyId = (int)currencyIdComboBox.SelectedValue;
            decimal _amount = amountNumericUpDown.Value;

            TransactionsFuncs.InsertClientTransaction(_toAccountId, _currencyId, _amount, TransactionsFuncs.TT.TRT, _transfer.TransferDate.Value, _transfer.GUID.Value, _declaration, _fromAccountId);
            TransactionsFuncs.InsertClientTransaction(_fromAccountId, _currencyId, _amount, TransactionsFuncs.TT.TRF, _transfer.TransferDate.Value, _transfer.GUID.Value, _declaration);
        }

        private void PrepareItem()
        {
            using (dbEntities db = new dbEntities(0))
            {
                if (_transfer != null)
                {
                    Guid _guid = Guid.NewGuid();
                    int _currencyId = (int)currencyIdComboBox.SelectedValue;
                    _transfer.CurrencyId = _currencyId;
                    _transfer.ClientFrom = (int)fromclientComboBox.SelectedValue;
                    _transfer.ClientTo = (int)toclientcomboBox.SelectedValue;
                    _transfer.TransferDate = operationDateDateTimePicker.Value;
                    _transfer.FromAmount = amountNumericUpDown.Value;
                    _transfer.ToAmount = amountNumericUpDown.Value;
                    _transfer.Rate = 1;
                    _transfer.Declaration = declarationTextBox.Text.Trim();
                    _transfer.LUD = DateTime.Now;
                    _transfer.UserId = Properties.Settings.Default.LoggedInUser.Id;
                    _transfer.Flag = string.Empty;
                    _transfer.Hidden = false;
                    _transfer.GUID = _guid;
                    _transfer.PROTECTED = false;
                }
            }
        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }

        private void ExchangeMoney()
        {
            //if (radioButton2.Checked)
            //{
            //    numericUpDown1.Value = amountNumericUpDown.Value * numericUpDown2.Value;
            //}
            //else
            //{
            //    numericUpDown1.Value = amountNumericUpDown.Value / numericUpDown2.Value;
            //}
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ExchangeMoney();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            //addNew();
            ControlsEnable(true);
        }

        private bool CheckTransferAmount()
        {
            bool _result = true;
            if (amountNumericUpDown.Value == 0)
            {
                MessageBox.Show("الرجاء التأكد من قيمة المبلغ، لا يجب ان يكون المبلغ 0");
                amountNumericUpDown.Focus();
                _result = false;
            }
            return _result;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckTransferAmount())
                    return;
                PrepareItem();
                Save();
                ControlsEnable(false);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء الحفظ");
            }
        }

        private void fromclientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    int fromId = (int)fromclientComboBox.SelectedValue;
                    accountsInfoBindingSource1.DataSource = db.Accounts.Where(x => x.Id != fromId).ToList();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAddAccount frm = new frmAddAccount();
            frm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmAddAccount frm = new frmAddAccount();
            frm.Show();
        }

        private void frmTransferFunds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control)
            {
                addbtn_Click(sender, e);
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}