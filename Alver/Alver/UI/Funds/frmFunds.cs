using Alver.DAL;
using Alver.Misc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.UI.Funds
{
    public partial class frmFunds : Form
    {
        DataTable dt = new DataTable();

        public frmFunds()
        {
            InitializeComponent();
            dtInit();
        }

        private void dtInit()
        {
            dt.Columns.Add("الرصيد");
            dt.Columns.Add("$");
            .Columns["YTD"].DefaultCellStyle.Format = "N2";
            //using (dbEntities db = new dbEntities(0))
            //{
            //    foreach (var item in db.Currencies)
            //    {
            //        dt.Columns.Add(item.CurrencySymbol);
            //    }
            //}
        }
        //private void GetOfficeFunds()
        //{
        //    decimal[] OfficeFunds = FundsFuncs.OfficeFunds();
        //    dt.Rows.Add(new object[] { OfficeFunds[0], OfficeFunds[1], OfficeFunds[2], OfficeFunds[3], OfficeFunds[4] });
        //    Fundsdgv.DataSource = dt;
        //}
        //private void GetClientsFunds()
        //{
        //    decimal[] ClientsFunds = FundsFuncs.ClientsFunds();
        //    dt.Rows.Add(new object[] { ClientsFunds[0], ClientsFunds[1], ClientsFunds[2], ClientsFunds[3], ClientsFunds[4] });
        //    //Fundsdgv.DataSource = dt;
        //}

        //private void GetItemsFunds()
        //{
        //    decimal[] ItemsFunds = FundsFuncs.ItemsFunds();
        //    dt.Rows.Add(new object[] { ItemsFunds[0], ItemsFunds[1], ItemsFunds[2], ItemsFunds[3], ItemsFunds[4] });
        //    //Fundsdgv.DataSource = dt;
        //}
        //private void GetFunds()
        //{
        //    dt.Clear();
        //    GetOfficeFunds();
        //    GetClientsFunds();
        //    GetItemsFunds();
        //    SetTotal();
        //}

        private void GetFunds()
        {
            decimal _grand = 0, _USD = 0, _SYP = 0, _TL = 0, _EURO = 0, _SAR = 0;

            dt.Clear();

            decimal[] OfficeFunds = FundsFuncs.OfficeFunds();
            decimal[] ClientsFunds = FundsFuncs.ClientsFunds();
            decimal[] ItemsFunds = FundsFuncs.ItemsFunds();
            decimal[] TotalFunds = new decimal[OfficeFunds.Length];

            for (int i = 0; i < TotalFunds.Length; i++)
            {
                TotalFunds[i] = OfficeFunds[i] + ClientsFunds[i] + ItemsFunds[i];

                OfficeFunds[i]=decimal.Round(OfficeFunds[i], 2, MidpointRounding.AwayFromZero);
                ClientsFunds[i]=decimal.Round(ClientsFunds[i], 2, MidpointRounding.AwayFromZero);
                ItemsFunds[i]=decimal.Round(ItemsFunds[i], 2, MidpointRounding.AwayFromZero);
                TotalFunds[i]=decimal.Round(TotalFunds[i], 2, MidpointRounding.AwayFromZero);
            }

            //dt.Rows.Add(new object[] { "الرصيد العام", TotalFunds[0], TotalFunds[1], TotalFunds[2], TotalFunds[3], TotalFunds[4] });
            //dt.Rows.Add(new object[] { "رصيد المكتب", OfficeFunds[0], OfficeFunds[1], OfficeFunds[2], OfficeFunds[3], OfficeFunds[4] });
            //dt.Rows.Add(new object[] { "رصيد الوكلاء", ClientsFunds[0], ClientsFunds[1], ClientsFunds[2], ClientsFunds[3], ClientsFunds[4] });
            //dt.Rows.Add(new object[] { "رصيد المواد", ItemsFunds[0], ItemsFunds[1], ItemsFunds[2], ItemsFunds[3], ItemsFunds[4] });

            dt.Rows.Add(new object[] { "الرصيد العام", TotalFunds[0]});
            dt.Rows.Add(new object[] { "رصيد المكتب", OfficeFunds[0]});
            dt.Rows.Add(new object[] { "رصيد الوكلاء", ClientsFunds[0]});
            dt.Rows.Add(new object[] { "رصيد المواد", ItemsFunds[0]});


            Fundsdgv.DataSource = dt;
            //Fundsdgv.Columns[1].DefaultCellStyle.Format = "N2";


            using (dbEntities db = new dbEntities(0))
            {
                _USD = 1;
                _SYP = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 2).Rate.Value;
                _TL = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 3).Rate.Value;
                _EURO = db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 4).Rate.Value;
                _SAR = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 5).Rate.Value;

                _USD = _USD * TotalFunds[0];
                _SYP = _SYP * TotalFunds[1];
                _TL = _TL * TotalFunds[2];
                _EURO = _EURO * TotalFunds[3];
                _SAR = _SAR * TotalFunds[4];

                _grand = _USD + _SYP + _TL + _EURO + _SAR;
                this.Text = "حركات الصناديق - ( " + decimal.Round(_grand, 2).ToString() + " )";
                lblTotals.Text = decimal.Round(_grand, 2).ToString();
            }
        }

        private void fundstimer_Tick(object sender, EventArgs e)
        {
            GetFunds();
        }

        private void frmFunds_Load(object sender, EventArgs e)
        {
            fundstimer.Start();
        }
    }
}
