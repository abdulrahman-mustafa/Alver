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
using JCS;
using Alver.DAL;
using Alver.MISC;

namespace Alver.UI.Funds.Transactions
{
    public partial class frmFundTransactions : Form
    {
        private List<JCS.ToggleSwitch> _toggles = new List<JCS.ToggleSwitch>();

        public frmFundTransactions()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Currencies.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
            }
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities(0))
            {
                currencyBindingSource.DataSource = db.Currencies.Where(x=>x.Id==1||x.Id==2).AsNoTracking().ToList().AsQueryable();
            }
            MISC.Utilities.SearchableComboBox(currencycomboBox);
            _toggles.Add(onlypayments);
            _toggles.Add(onlyloans);
            _toggles.Add(onlydeposites);
        }

        private void DGVTotals()
        {
            int _currencyIndex = currencyIdDataGridViewTextBoxColumn.Index;
            int _amountIndex = amountDataGridViewTextBoxColumn.Index;
            dgvTotals.DataSource = dgv.TotalsDGV(_currencyIndex, _amountIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int currencyId = (int)currencycomboBox.SelectedValue;
            TransactionsFuncs.FundsRunningTotals(currencyId);
            Retrive();
            DGVTotals();
            ColorizeDgv();
        }

        private void Retrive()
        {
            this.Cursor = Cursors.WaitCursor;
            LoadData();
            int _currencyId = 0;
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
                _currencyId = (int)currencycomboBox.SelectedValue;
            }
            GrandSearch(_from, _to, _currencyId);
            this.Cursor = Cursors.Default;
        }

        private IQueryable<FundTransaction> GrandSearch(DateTime _from, DateTime _to, int _currencyId)
        {
            IQueryable<FundTransaction> _query;// = new IQueryable<Remittances_Operation>;
            using (dbEntities db = new dbEntities(0))
            {
                _query = db.FundTransactions as IQueryable<FundTransaction>;
                if (_from.Year == _to.Year && _from.Month == _to.Month)
                {
                    _query = db.FundTransactions.Where(
                            x => ((x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year) &&
                                (x.TTS.Value.Month >= _from.Month && x.TTS.Value.Month <= _to.Month) &&
                                (x.TTS.Value.Day >= _from.Day && x.TTS.Value.Day <= _to.Day))
                        ).AsQueryable();
                }
                else if (_from.Year != _to.Year)
                {
                    _query = db.FundTransactions.Where(
                        x => x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year
                        ).AsQueryable();
                }
                else if (_from.Year == _to.Year && _from.Month != _to.Month)
                {
                    _query = db.FundTransactions.Where(
                        x => ((x.TTS.Value.Year >= _from.Year && x.TTS.Value.Year <= _to.Year) &&
                        (x.TTS.Value.Month >= _from.Month && x.TTS.Value.Month <= _to.Month))
                        ).AsQueryable();
                }
                if (_currencyId != 0)
                {
                    _query = _query.Where(x => x.CurrencyId == _currencyId);
                }
                if (onlypayments.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.PAY.ToString()
                        || x.TT == TransactionsFuncs.TT.PID.ToString()
                        );
                }
                else if (onlyloans.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.LNF.ToString()
                        || x.TT == TransactionsFuncs.TT.LNT.ToString()
                        );
                }
                else if (onlydeposites.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.DTF.ToString()
                        || x.TT == TransactionsFuncs.TT.DTT.ToString()
                        );
                }
                else if (onlyrefunds.Checked)
                {
                    _query = _query.Where(
                        x =>
                        x.TT == TransactionsFuncs.TT.RFD.ToString()
                        || x.TT == TransactionsFuncs.TT.DDT.ToString()
                        || x.TT == TransactionsFuncs.TT.FDI.ToString()
                        || x.TT == TransactionsFuncs.TT.FDO.ToString()
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
                _query.Where(x => x.TT == TransactionsFuncs.TT.FDI.ToString()).ToList().ForEach(x => x.TT = "تغذية");
                _query.Where(x => x.TT == TransactionsFuncs.TT.DDT.ToString()).ToList().ForEach(x => x.TT = "سحب");
                _query.Where(x => x.TT == TransactionsFuncs.TT.FDO.ToString()).ToList().ForEach(x => x.TT = "سحب");

                _query.Where(x => x.TT == TransactionsFuncs.TT.SOT.ToString()).ToList().ForEach(x => x.TT = "موازنة خارجة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.SIN.ToString()).ToList().ForEach(x => x.TT = "موازنة داخلة");

                _query.Where(x => x.TT == TransactionsFuncs.TT.EXS.ToString()).ToList().ForEach(x => x.TT = "مصروف");

                _query.Where(x => x.TT == TransactionsFuncs.TT.CEB.ToString()).ToList().ForEach(x => x.TT = "فرق تصريف");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CES.ToString()).ToList().ForEach(x => x.TT = "بيع عملة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.CEB.ToString()).ToList().ForEach(x => x.TT = "شراء عملة");

                _query.Where(x => x.TT == TransactionsFuncs.TT.TNS.ToString()).ToList().ForEach(x => x.TT = "بيع عملة تالفة");
                _query.Where(x => x.TT == TransactionsFuncs.TT.TNB.ToString()).ToList().ForEach(x => x.TT = "شراء عملة تالفة");

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

                fundTransactionBindingSource.DataSource = _query.ToList();
            }
            return _query;
        }

        private void accountchkb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void currencycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            currencycomboBox.Enabled = currencycheckBox.Checked;
        }

        private void ColorizeDgv()
        {
            int _index1 = amountDataGridViewTextBoxColumn.Index;
            int _index2 = runningTotalDataGridViewTextBoxColumn.Index;
            dgv.ColorizeDecimalDGVTwoCells(_index1, _index2);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
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
                FundTransaction _transaction = fundTransactionBindingSource.Current as FundTransaction;
                long _transactionId = _transaction.Id;
                int _currencyId = _transaction.CurrencyId.Value;
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
                            db.FundTransactions.Remove(db.FundTransactions.Find(_transactionId));
                            db.SaveChanges();
                            TransactionsFuncs.FundsRunningTotals(_currencyId);
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
                FundTransaction _transaction = fundTransactionBindingSource.Current as FundTransaction;
                if (_transaction != null)
                {
                    frmFundTransaction frm = new frmFundTransaction(_transaction);
                    frm.ShowDialog();
                    Retrive();
                    ColorizeDgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي" + Environment.NewLine + ex.Message);
            }
        }
    }
}