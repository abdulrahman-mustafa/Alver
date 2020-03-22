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

namespace Alver.UI.Bills
{
    public partial class pos : Form
    {
        #region Init

        public pos()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    db.Currencies.AsNoTracking().AsQueryable().Load();
                    currencyBS.DataSource = db.Currencies.Where(x => x.Id == 1 || x.Id == 2).AsQueryable().AsNoTracking().ToList();
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }

        #endregion Init

        #region Methods

        private void ClearForm()
        {
            billdatedtp.Value = DateTime.Now;
            declarationtb.Clear();
            barcodecb.Text = "";
            itemcb.Text = "";
            billLineBS.DataSource = null;
            sumtotalsnud.Value = 0;
            discountnud.Value = 0;
            totalnud.Value = 0;
            barcodecb.Focus();
        }

        #endregion Methods
    }
}