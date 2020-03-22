using Alver.DAL;
using Alver.MISC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alver.MISC.Utilities;

namespace DAL.Classes
{
    public static class CurrencyExchangeFuncs
    {
        public static void InsertExchangeOperation(CurrencyExchange _ex,
            CurrencyExchangeOperation _exo,
            string direction,
            decimal rate,
            int basecurrency,
            decimal baseAmount,
            int subcurrency,
            decimal subAmount,
            decimal roundAmount,
            bool factor,
            int userid)
        {
            try
            {
                DateTime _exchangeDate = DateTime.Now;
                Currency _baseCurrency, _subCurrency;
                //string direction = string.Empty, declaration;
                //if (_dir != null)
                //{
                //direction = _dir;
                //}
                if (basecurrency == subcurrency)
                {
                    MessageBox.Show("لا يمكن ان تكون عملة الشراء مطابقة لعملة البيع");
                    return;
                }
                else if (
                        _ex != null ||
                        _ex.Id != 0 ||
                        direction != null ||
                        baseAmount != 0 ||
                        subAmount != 0 ||
                        basecurrency != 0 ||
                        subcurrency != 0 ||
                        rate > 0)
                {
                    using (dbEntities db = new dbEntities())
                    {
                        _baseCurrency = db.Currencies.FirstOrDefault(x => x.Id == basecurrency);
                        _subCurrency = db.Currencies.FirstOrDefault(x => x.Id == subcurrency);
                        _exo.Direction = direction;
                        _exo.BaseAmount = baseAmount;
                        _exo.BaseCurrencyId = subcurrency;
                        _exo.Currency = _baseCurrency;
                        _exo.SubAmount = Math.Round(subAmount, 2);
                        _exo.RoundAmount = roundAmount;
                        _exo.SubCurrencyId = basecurrency;
                        _exo.Currency1 = _subCurrency;
                        _exo.Rate = rate;
                        _exo.Factor = factor == true ? "ضرب" : "تقسيم";
                        _exo.OpreationDate = _exchangeDate;
                        _exo.Hidden = false;
                        _exo.Flag = string.Empty;
                        _exo.LUD = DateTime.Now;
                        _exo.GUID = Guid.NewGuid();
                        _exo.UserId = userid;
                        _exo.ExchangeId = _ex.Id;
                        //Navigation Properties
                        _exo.CurrencyExchange = _ex;
                        //db.CurrencyExchangeOperations.Attach(_exo);
                        db.Set<CurrencyExchangeOperation>().Add(_exo);
                        db.Entry(_baseCurrency).State = EntityState.Detached;
                        db.Entry(_subCurrency).State = EntityState.Detached;
                        db.Entry(_ex).State = EntityState.Detached;
                        //db.Entry(_exo).State = EntityState.Added;
                        db.SaveChanges();

                        if (_exo.Direction == ExchangeType.بيع.ToString())
                        {
                            TransactionsFuncs.InsertFundTransaction(_exo.BaseCurrencyId.Value, _exo.BaseAmount.Value, TransactionsFuncs.TT.CES, _exo.OpreationDate.Value, _exo.GUID.Value, "");
                            TransactionsFuncs.InsertFundTransaction(_exo.SubCurrencyId.Value, _exo.RoundAmount.Value, TransactionsFuncs.TT.CEB, _exo.OpreationDate.Value, _exo.GUID.Value, "");
                        }
                        else if (_exo.Direction == Utilities.ExchangeType.شراء.ToString())
                        {
                            TransactionsFuncs.InsertFundTransaction(_exo.BaseCurrencyId.Value, _exo.BaseAmount.Value, TransactionsFuncs.TT.CEB, _exo.OpreationDate.Value, _exo.GUID.Value, "");
                            TransactionsFuncs.InsertFundTransaction(_exo.SubCurrencyId.Value, _exo.RoundAmount.Value, TransactionsFuncs.TT.CES, _exo.OpreationDate.Value, _exo.GUID.Value, "");
                        }
                        decimal _exchange = _exo.SubAmount.Value - _exo.RoundAmount.Value;
                        TransactionsFuncs.InsertFundTransaction(_exo.SubCurrencyId.Value, _exchange, TransactionsFuncs.TT.CED, _exo.OpreationDate.Value, _exo.GUID.Value, "");
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال قيم فارغة");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("الرجاء التأكد من القيم المدخلة ومن عدم إدخال  قيم فارغة");
            }
        }
        public static decimal RoundExchange(decimal _value)
        {
            decimal _result = 0;
            //decimal x = decimal.Parse(roundtb.Text.Trim());
            _result = Math.Round(_value / 100, 0, MidpointRounding.AwayFromZero) * 100;
            return _result;
        }
    }
}
