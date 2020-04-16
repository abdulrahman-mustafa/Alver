using Alver.DAL;
using Alver.MISC;
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

namespace Alver.UI.Exchange
{
    public partial class frmCurrenciesBulletin : Form
    {
        public frmCurrenciesBulletin()
        {
            InitializeComponent();
        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (dbEntities db = new dbEntities(0))
            {
                db.Currencies.AsNoTracking().Load();
                db.CurrencyBulletins.AsNoTracking().Load();
                currencyBulletinBindingSource.DataSource = db.CurrencyBulletins.AsNoTracking().AsQueryable().ToList();
                currencyBindingSource.DataSource = db.Currencies.AsNoTracking().AsQueryable().ToList();
                currencyBindingSource1.DataSource = db.Currencies.Where(x => x.BaseCurrency == false).AsNoTracking().AsQueryable().ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime _date = datetimepicker.Value;
                int _currencyId = (int)currencyIdComboBox.SelectedValue;
                decimal _rate = ratenud.Value;
                bool _isReversed = drb.Checked;//  DIVISION=TRUE - MULTIPLICATION=FALSE
                CurrencyBulletin _bulletin = new CurrencyBulletin();
                _bulletin.RateDate = _date;
                _bulletin.CurrencyId = _currencyId;
                _bulletin.Rate = _rate;
                _bulletin.GUID = Guid.NewGuid();
                _bulletin.ReversedRate = 1 / _rate;
                _bulletin.Factor = _isReversed;
                using (dbEntities db = new dbEntities(0))
                {
                    db.Set<CurrencyBulletin>().Add(_bulletin);
                    db.SaveChanges();
                }
                MessageBox.Show("تم الحفظ بنجاح");
                LoadData();
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ داخلي سيتم التراجع عن الحفظ");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            deletebtn.Enabled = false;
            try
            {
                CurrencyBulletin _bulletin = currencyBulletinBindingSource.Current as CurrencyBulletin;
                if (_bulletin != null && currencyBulletinBindingSource.Count > 0)
                {
                    int _bulletinId = _bulletin.Id;
                    using (dbEntities db = new dbEntities(0))
                    {
                        _bulletin = db.CurrencyBulletins.Find(_bulletinId);
                        db.CurrencyBulletins.Remove(_bulletin);
                        currencyBulletinBindingSource.RemoveCurrent();
                        db.SaveChanges();
                    }
                    MessageBox.Show("تم الحذف بنجاح");
                    LoadData();
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

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void excelexportbtn_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
                dgv.ExportToExcel();
        }
    }
}