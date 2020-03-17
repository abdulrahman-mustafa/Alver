using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.UI.Bills
{
    public partial class frmSellBill : Form
    {
        public frmSellBill()
        {
            InitializeComponent();
        }

        private void ControlsEnable(bool _enable)
        {
            //operationDateDateTimePicker.Value = DateTime.Now;
            //declarationTextBox.Enabled = _enable;
            //declarationTextBox.Clear();
            checkbillbtn.Enabled = _enable;
            chechprintbillbtn.Enabled = _enable;
            printbillslipbtn.Enabled = _enable;
            addbtn.Enabled = !_enable;
            //amountNumericUpDown.Value = amountNumericUpDown.Minimum;
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(GroupBox))
                {
                    item.Enabled = _enable;
                }
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ControlsEnable(true);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            ControlsEnable(false);
        }

        private void pricenud_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}