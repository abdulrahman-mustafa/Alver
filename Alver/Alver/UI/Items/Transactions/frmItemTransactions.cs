﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JCS;
using Alver.DAL;
using Alver.MISC;
using Alver.UI.Accounts.AccountReports;
using static Alver.MISC.ItemFuncs;

namespace Alver.UI.Items.Transactions
{
    public partial class frmItemTransactions : Form
    {
        private List<JCS.ToggleSwitch> _toggles = new List<JCS.ToggleSwitch>();

        public frmItemTransactions()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Units.AsNoTracking().Load();
                db.Items.AsNoTracking().Load();
                unitBindingSource.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
                unitBindingSource1.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
                ItemstransactionBindingSource.DataSource = db.Items.Where(x => x.Hidden == false).AsNoTracking().AsQueryable().ToList();
            }
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            if (ItemsCount() > 0)
            {
                using (dbEntities db = new dbEntities(0))
                {
                    unitBindingSource.DataSource = db.Units.AsNoTracking().ToList().AsQueryable();
                    unitBindingSource1.DataSource = db.Units.AsNoTracking().AsQueryable().ToList();
                    itemBindingSource.DataSource = db.Items.Where(x => x.Hidden == false).AsNoTracking().ToList().AsQueryable();
                    itemBindingSource1.DataSource = db.Items.Where(x => x.Hidden == false).AsNoTracking().ToList().AsQueryable();
                }
                MISC.Utilities.SearchableComboBox(itemcb);
                MISC.Utilities.SearchableComboBox(unitcb);
                _toggles.Add(onlypurchases);
                _toggles.Add(onlysales);
            }
            else
            {
                this.Close();
            }
            
        }

        private void DGVTotals()
        {
            int _unitId = UnitIdcolumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_unitId, _amountIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retrive();
            DGVTotals();
            ColorizeDgv();
        }

        private void Retrive()
        {
            this.Cursor = Cursors.WaitCursor;
            LoadData();
            int _unitId = 0;
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
            if (currencycheckBox.Checked)
            {
                _unitId = (int)unitcb.SelectedValue;
            }
            if (accountchkb.Checked)
            {
                _itemId = (int)itemcb.SelectedValue;
            }
            GrandSearch(_from, _to, _unitId, _itemId);
            this.Cursor = Cursors.Default;
        }

        private IQueryable<ItemTransaction> GrandSearch(DateTime _from, DateTime _to, int _unitId, int _itemId)
        {
            IQueryable<ItemTransaction> _query;// = new IQueryable<Remittances_Operation>;
            using (dbEntities db = new dbEntities(0))
            {
                _query = db.ItemTransactions as IQueryable<ItemTransaction>;
                if (_from.Year == _to.Year && _from.Month == _to.Month)
                {
                    _query = db.ItemTransactions.Where(
                            x => ((x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year) &&
                                (x.TTS.Value.Month >= _from.Month && x.TTS.Value.Month <= _to.Month) &&
                                (x.TTS.Value.Day >= _from.Day && x.TTS.Value.Day <= _to.Day))
                        ).AsQueryable();
                }
                else if (_from.Year != _to.Year)
                {
                    _query = db.ItemTransactions.Where(
                        x => x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year
                        ).AsQueryable();
                }
                else if (_from.Year == _to.Year && _from.Month != _to.Month)
                {
                    _query = db.ItemTransactions.Where(
                        x => ((x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year) &&
                        (x.TTS.Value.Month >= _from.Month && x.TTS.Value.Month <= _to.Month))
                        ).AsQueryable();
                }
                if (_itemId != 0)
                {
                    _query = _query.Where(x => x.ItemId == _itemId);
                }
                if (_unitId != 0)
                {
                    _query = _query.Where(x => x.UnitId == _unitId);
                }
                if (onlypurchases.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.BLS.ToString()
                        );
                }
                else if (onlysales.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.BLP.ToString()
                        );
                }
                _query = _query.OrderBy(x => x.TTS);

                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNWEO.ToString()).ToList().ForEach(x => x.TT = "اجور علينا ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNWEI.ToString()).ToList().ForEach(x => x.TT = "اجور لنا ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNORT.ToString()).ToList().ForEach(x => x.TT = "حوالة خارجية - المستقبل ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNORF.ToString()).ToList().ForEach(x => x.TT = "حوالة خارجية - المرسل ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNOBF.ToString()).ToList().ForEach(x => x.TT = "حوالة صادرة ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNOTD.ToString()).ToList().ForEach(x => x.TT = "حوالة صادرة ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNICF.ToString()).ToList().ForEach(x => x.TT = "حوالة واردة ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.IGNINC.ToString()).ToList().ForEach(x => x.TT = "حوالة واردة ملغاة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.WEO.ToString()).ToList().ForEach(x => x.TT = "اجور علينا");
                _query.Where(x => x.TT == TransactionsFuncs.TT.WEI.ToString()).ToList().ForEach(x => x.TT = "اجور لنا");
                _query.Where(x => x.TT == TransactionsFuncs.TT.ORT.ToString()).ToList().ForEach(x => x.TT = "حوالة خارجية - المستقبل");
                _query.Where(x => x.TT == TransactionsFuncs.TT.ORF.ToString()).ToList().ForEach(x => x.TT = "حوالة خارجية - المرسل");
                _query.Where(x => x.TT == TransactionsFuncs.TT.OBF.ToString()).ToList().ForEach(x => x.TT = "حوالة صادرة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.OTD.ToString()).ToList().ForEach(x => x.TT = "حوالة صادرة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.ICF.ToString()).ToList().ForEach(x => x.TT = "حوالة واردة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.INC.ToString()).ToList().ForEach(x => x.TT = "حوالة واردة");

                _query.Where(x => x.TT == TransactionsFuncs.TT.TRT.ToString()).ToList().ForEach(x => x.TT = "تحويل رصيد الى");
                _query.Where(x => x.TT == TransactionsFuncs.TT.TRF.ToString()).ToList().ForEach(x => x.TT = "تحويل رصيد من");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CTT.ToString()).ToList().ForEach(x => x.TT = "قص الى");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CTF.ToString()).ToList().ForEach(x => x.TT = "قص من");

                _query.Where(x => x.TT == TransactionsFuncs.TT.PYO.ToString()).ToList().ForEach(x => x.TT = "دفعة خارجة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.PYI.ToString()).ToList().ForEach(x => x.TT = "دفعة داخلة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.PID.ToString()).ToList().ForEach(x => x.TT = "دفعة الى");
                _query.Where(x => x.TT == TransactionsFuncs.TT.PAY.ToString()).ToList().ForEach(x => x.TT = "دفعة من");

                _query.Where(x => x.TT == TransactionsFuncs.TT.FOO.ToString()).ToList().ForEach(x => x.TT = "FOO");

                _query.Where(x => x.TT == TransactionsFuncs.TT.OPN.ToString()).ToList().ForEach(x => x.TT = "افتتاحي");

                _query.Where(x => x.TT == TransactionsFuncs.TT.RFD.ToString()).ToList().ForEach(x => x.TT = "تغذية");
                _query.Where(x => x.TT == TransactionsFuncs.TT.DDT.ToString()).ToList().ForEach(x => x.TT = "سحب");

                _query.Where(x => x.TT == TransactionsFuncs.TT.SOT.ToString()).ToList().ForEach(x => x.TT = "موازنة خارجة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.SIN.ToString()).ToList().ForEach(x => x.TT = "موازنة داخلة");

                _query.Where(x => x.TT == TransactionsFuncs.TT.GIN.ToString()).ToList().ForEach(x => x.TT = "سحب أرباح");
                _query.Where(x => x.TT == TransactionsFuncs.TT.LOS.ToString()).ToList().ForEach(x => x.TT = "إيداع أرباح");

                _query.Where(x => x.TT == TransactionsFuncs.TT.EXS.ToString()).ToList().ForEach(x => x.TT = "مصروف");

                _query.Where(x => x.TT == TransactionsFuncs.TT.CEB.ToString()).ToList().ForEach(x => x.TT = "فرق تصريف");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CES.ToString()).ToList().ForEach(x => x.TT = "بيع عملة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CEB.ToString()).ToList().ForEach(x => x.TT = "شراء عملة");

                _query.Where(x => x.TT == TransactionsFuncs.TT.DTO.ToString()).ToList().ForEach(x => x.TT = "امانة خارجة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.DTI.ToString()).ToList().ForEach(x => x.TT = "امانة داخلة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.DTT.ToString()).ToList().ForEach(x => x.TT = "امانة الى");
                _query.Where(x => x.TT == TransactionsFuncs.TT.DTF.ToString()).ToList().ForEach(x => x.TT = "امانة من");

                _query.Where(x => x.TT == TransactionsFuncs.TT.LNO.ToString()).ToList().ForEach(x => x.TT = "دين خارج");
                _query.Where(x => x.TT == TransactionsFuncs.TT.LNI.ToString()).ToList().ForEach(x => x.TT = "دين داخل");
                _query.Where(x => x.TT == TransactionsFuncs.TT.LNT.ToString()).ToList().ForEach(x => x.TT = "دين الى");
                _query.Where(x => x.TT == TransactionsFuncs.TT.LNF.ToString()).ToList().ForEach(x => x.TT = "دين من");

                _query.Where(x => x.TT == TransactionsFuncs.TT.BLP.ToString()).ToList().ForEach(x => x.TT = "فاتورة شراء");
                _query.Where(x => x.TT == TransactionsFuncs.TT.BLS.ToString()).ToList().ForEach(x => x.TT = "فاتورة بيع");

                ItemstransactionBindingSource.DataSource = _query.ToList();
            }
            return _query;
        }

        private void accountchkb_CheckedChanged(object sender, EventArgs e)
        {
            itemcb.Enabled = accountchkb.Checked;
        }

        private void currencycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            unitcb.Enabled = currencycheckBox.Checked;
        }

        private void ColorizeDgv()
        {
            int _index1 = amountDataGridViewTextBoxColumn.Index;
            int _index2 = runningTotalDataGridViewTextBoxColumn.Index;
            dgv.ColorizeDecimalDGVTwoCells(_index1, _index2);
            //int _index3 = amountDataGridViewTextBoxColumn1.Index;
            //int _index4 = runningtotalDataGridViewTextBoxColumn1.Index;
            //dgv2.ColorizeDecimalDGVTwoCells(_index3, _index4);
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void frmTransactions_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgv.DataSource = null;
        }

        private void onlyremittances_CheckedChanged(object sender, EventArgs e)
        {
            JCS.ToggleSwitch _this = (JCS.ToggleSwitch)sender;
            ActivateMe(_this);
        }

        private void ActivateMe(JCS.ToggleSwitch _this)
        {
            if (_this.Checked)
                DisableAllTogglesButThis(_this);
        }

        private void DisableAllTogglesButThis(JCS.ToggleSwitch activeToggle)
        {
            foreach (var item in _toggles)
            {
                if (item != activeToggle)
                {
                    item.Checked = false;
                }
                else
                {
                    item.Checked = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private string ConvertMasterFieldsToHTMLTable()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<table border='1' cellpadding='0' cellspacing='0'>");

            sb.AppendLine("<tr><td>");
            sb.AppendLine("كشف حساب الوكيل: ");
            sb.AppendLine("</td><td>");
            sb.AppendLine(itemcb.Text);
            sb.AppendLine("</td></tr>");

            sb.AppendLine("<tr><td>");
            sb.AppendLine("التاريخ: ");
            sb.AppendLine("</td><td>");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("</td></tr>");

            //sb.AppendLine("<tr><td>");
            //sb.AppendLine("PR: ");
            //sb.AppendLine("</td><td>");
            //sb.AppendLine(comboBox1.Text.ToString());
            //sb.AppendLine("</td></tr>");
            sb.AppendLine("</table>");
            sb.AppendLine("<br>");
            return sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
            //dgv.ExportToExcelViaHTML();
            //string fieldToHTMLTable = ConvertMasterFieldsToHTMLTable();
            //string dgvToHTMLTable = dgv.ConvertDataGridViewToHTMLWithFormatting();

            ////Strip the enclosing <HTML><body> tags and wrap them around both HTML Tables
            //dgvToHTMLTable = dgvToHTMLTable.Replace("<html><body><center>", string.Empty);
            //dgvToHTMLTable = dgvToHTMLTable.Replace("</center></body></html>", string.Empty);

            //Clipboard.SetText("<html><body><center>" + fieldToHTMLTable + dgvToHTMLTable + "</center></body></html>");
            //dgv.ExportToExcel();
        }

        private void اكسلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            try
            {
                Transaction _transaction = ItemstransactionBindingSource.Current as Transaction;
                long _transactionId = _transaction.Id;
                int _accountId = _transaction.AccountId.Value;
                if (_transaction != null)
                {
                    string _msg = "هل انت متأكد من حذف الحركة، لن يمكنك التراجع عن العملية؟";
                    DialogResult _ConfirmationDialog = MessageBox.Show(_msg, "تأكيد!!!!",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.RightAlign);
                    if (_ConfirmationDialog == DialogResult.Yes)
                    {
                        using (dbEntities db = new dbEntities(0))
                        {
                            db.Transactions.Remove(db.Transactions.Find(_transactionId));
                            db.SaveChanges();
                            TransactionsFuncs.ClientsRunningTotals(_accountId);
                            MessageBox.Show("تم الحذف بنجاح");
                            Retrive();
                            ColorizeDgv();
                        }
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ داخلي");
            }

            deletebtn.Enabled = true;
        }

        private void editobjectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Transaction _transaction = ItemstransactionBindingSource.Current as Transaction;
                //if (_transaction != null)
                //{
                //    frmTransaction frm = new frmTransaction(_transaction);
                //    frm.ShowDialog();
                //    Retrive();
                //    ColorizeDgv();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي" + Environment.NewLine + ex.Message);
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //Account acc = new Account();
            //acc = accountsInfoBindingSource.Current as Account;
            //if (acc != null)
            //{
            //    frmAccountConformity frm = new frmAccountConformity(acc);
            //    frm.ShowDialog();
            //}
        }
    }
}