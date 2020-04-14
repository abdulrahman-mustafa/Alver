using Alver.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Funds.Transactions
{
    public partial class frmFundTransaction : Form
    {
        private FundTransaction _baseTransaction;

        public frmFundTransaction(FundTransaction transaction)
        {
            InitializeComponent();
            _baseTransaction = transaction == null ? (new FundTransaction()) : transaction;
        }

        private void frmWage_Load(object sender, EventArgs e)
        {
            using (dbEntities db = new dbEntities(0))
            {
                int _currencyId = _baseTransaction.CurrencyId.Value;
                db.Currencies.AsNoTracking().Load();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().ToList().AsQueryable();
                accountlbl.Text = db.Funds.Find(_currencyId).FundTitle;
                datelbl.Text = _baseTransaction.TTS.ToString();
                amountLabel1.Text = _baseTransaction.Amount.ToString();
                currencyIdLabel1.Text = db.Currencies.Find(_baseTransaction.CurrencyId.Value).CurrencyName.ToString();
                amountnud.Value = _baseTransaction.Amount.Value;
                currencyComboBox.SelectedValue = _baseTransaction.CurrencyId.Value;
                declarationtb.Text = _baseTransaction.Declaration;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    Validate();
                    currencyBindingSource.EndEdit();
                    int _currencyId = (int)currencyComboBox.SelectedValue;
                    decimal _amount = amountnud.Value;
                    string _declaration = declarationtb.Text.Trim();
                    FundTransaction _transaction = db.FundTransactions.Find(_baseTransaction.Id);
                    _transaction.Amount = _amount;
                    _transaction.CurrencyId = _currencyId;
                    _transaction.Declaration = _declaration;
                    db.SaveChanges();
                    MessageBox.Show("تم الحفظ بنجاح");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ داخلي اثناء الحفظ، لم يتم الحفظ بنجاح " + Environment.NewLine + ex.Message);
                Close();
            }
        }

        private void frmWage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                if (savebtn.Enabled)
                    savebtn_Click(sender, e);
            }
        }
    }
}