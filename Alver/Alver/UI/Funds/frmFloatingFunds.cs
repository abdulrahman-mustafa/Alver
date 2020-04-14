using Alver.DAL;
using Alver.MISC;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Alver.UI.Funds
{
    public partial class frmFloatingFunds : Form
    {
        private dbEntities db;

        public frmFloatingFunds()
        {
            InitializeComponent();
        }

        private void frmFloatingFunds_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0,
                                   Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            db = new dbEntities(0);
            db.Configuration.ProxyCreationEnabled = false;
            LoadData();
            timer1.Start();
        }

        private Decimal GetValue(int _index)
        {
            decimal _value = 0;
            try
            {
                _value = (decimal)dgv.Rows[0].Cells[_index].Value;
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
            }
            return _value;
        }

        private void LoadData()
        {
            fundsMovements_ResultBindingSource.DataSource = db.SP_FundsMovements().ToList();
            MISC.Utilities.ColorizeGain(dgv);
            decimal _grand = 0;
            decimal _USD = 0, _SYP = 0, _TL = 0, _EURO = 0, _SAR = 0;
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    _USD = 1;
                    _SYP = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 2).Rate.Value;
                    _TL = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 3).Rate.Value;
                    _EURO = db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 4).Rate.Value;
                    _SAR = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 5).Rate.Value;

                    _USD = _USD * GetValue(1);
                    _SYP = _SYP * GetValue(2);
                    _TL = _TL * GetValue(3);
                    _EURO = _EURO * GetValue(4);
                    _SAR = _SAR * GetValue(5);

                    _grand = _USD + _SYP + _TL + _EURO + _SAR;
                    this.Text = "حركات الصناديق - ( " + decimal.Round(_grand, 2).ToString() + " )";
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                //MSGs.ErrorMessage(ex);
            }
        }

        private void fundsMovements_ResultDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}