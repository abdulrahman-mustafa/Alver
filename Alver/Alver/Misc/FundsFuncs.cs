using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alver.Misc
{
    public static class FundsFuncs
    {
        public static decimal[] OfficeFunds()
        {
            //DataTable dt = new DataTable();
            int _index = 0;
            int CURRENCIESCOUNT = (new dbEntities(0)).Currencies.Count();
            decimal[] _totals = new decimal[CURRENCIESCOUNT];
            using (dbEntities db = new dbEntities(0))
            {
                foreach (var item in db.Currencies)
                {
                    _index = item.Id;
                    List<FundTransaction> _list = new List<FundTransaction>();
                    _list = db.FundTransactions
                        .Where(x => x.CurrencyId == item.Id).ToList(); ;
                    _totals[_index - 1] = _list.Sum(x => x.Amount).Value==null? 0 : _list.Sum(x => x.Amount).Value;
                }
            }
            return _totals;
        }
        public static decimal[] ClientsFunds()
        {
            //DataTable dt = new DataTable();
            int _index = 0;
            int CURRENCIESCOUNT = (new dbEntities(0)).Currencies.Count();
            decimal[] _totals = new decimal[CURRENCIESCOUNT];
            using (dbEntities db = new dbEntities(0))
            {
                foreach (var item in db.Currencies)
                {
                    _index = item.Id;
                    List<Transaction> _list = new List<Transaction>();
                    _list = db.Transactions.Where(x => x.CurrencyId == item.Id).ToList();
                    _totals[_index - 1] = _list.Sum(x => x.Amount).Value == null ? 0 : _list.Sum(x => x.Amount).Value;
                }
            }
            return _totals;
        }
        public static decimal[] ItemsFunds()
        {
            decimal _subTotal = 0,_amount=0,_price=0;
            int _index = 0;
            int CURRENCIESCOUNT = (new dbEntities(0)).Currencies.Count();
            decimal[] _totals = new decimal[CURRENCIESCOUNT];
            using (dbEntities db = new dbEntities(0))
            {
                foreach (var curr in db.Currencies)
                {
                    _index = curr.Id;
                    List<BillLine> _list = new List<BillLine>();
                    _list = db.BillLines.Where(x => x.CurrencyId == curr.Id).ToList();
                    _totals[_index - 1] = _list.Sum(x => x.TotalPrice).Value == null ? 0 : _list.Sum(x => x.TotalPrice).Value;

                    //_amount = db.BillLines
                    //        .Where(x => x.Currency.Id==curr.Id)
                    //        .Sum(x => x.TotalPrice).Value;
                    //foreach (var item in db.Items)
                    //{
                    //    _amount = db.BillLines
                    //        .Where(x => x.ItemId == item.Id && x.UnitId == item.UnitId)
                    //        .Sum(x => x.TotalPrice).Value;
                    //    //_amount = db.ItemTransactions.Where(x => x.Id == item.Id && x.UnitId == item.UnitId).Sum(x => x.Amount).Value;
                    //    //_price = db.ItemAvgPurchasePrice(item.Id, item.UnitId)
                    //    //    .Where(x=>x.رقم_العملة_الاساس==curr.Id)
                    //    //    .Sum(x=>x.السعر_بالعملة_الاساس);
                    //}

                    //_totals[_index - 1] = _amount;

                    //dt.Columns.Add(item.CurrencySymbol);
                }
                //dt.Rows.Add(new object[] { _totals[0], _totals[1], _totals[2], _totals[3], _totals[4] });
            }
            return _totals;
        }
    }
}
