using Alver.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alver.Misc
{
    public static class TransactionsOperations
    {
        public enum TT
        {
            //BILL
            BLB,//BILL BUY
            BLS,//BILL SELL

            //LOSS & GAIN
            LOS,//LOSS
            GIN,//GAIN

            //CUT
            CTF,//CUT FROM
            CTT,//CUT TO

            //TRANSFER
            TRF,//TRANSFER FROM
            TRT,//TRANSFER TO

            //PAYMENT
            PAY,//PAY
            PID,//PAYED
            PYI,//PAYMENT IN FUND
            PYO,//PAYMENT OUT FUND

            //REMITTANCE
            INC,//INCOME REMITTANCE
            IGNINC,//IGNORE INCOME REMITTANCE
            OTD,//OUTBOUND REMITTANCE
            IGNOTD,//IGNORE OUTBOUND REMITTANCE
            ORF,//OUTER FROM REMITTANCE
            IGNORF,//IGNORE OUTER FROM REMITTANCE
            ORT,//OUTER TO REMITTANCE
            IGNORT,//IGNORE OUTER TO REMITTANCE
            ICF,//INCOME FUND REMITTANCE
            IGNICF,//IGNORE INCOME FUND  REMITTANCE
            OBF,//OUTBOUND FUND REMITTANCE
            IGNOBF,//IGNORE OUTBOUND FUND REMITTANCE
            WEI,//WAGE IN 
            IGNWEI,//IGNORE WAGE IN 
            WEO,//WAGE OUT
            IGNWEO,//IGNORE WAGE OUT

            //LOAN
            LNF,//LOAN FROM
            LNT,//LOAN TO
            LNI,//LOAN IN FUND
            LNO,//LOAN FROM FUND

            //DEPOSITE
            DTF,//DEPOSITE FROM
            DTT,//DEPOSITE TO
            DTI,//DEPOSITE IN FUND
            DTO,//DEPOSITE OUT FUND

            //CURRENCY EXCHANGE
            CEB,//CURRENCY EXCHANGE BUY
            CES,//CURRENCY EXCHANGE SELL
            CED,//CURRENCY EXCHANGE DIFFERENCE

            EXS,//EXPENSE

            SIN,//SETTLEMENT IN FUND
            SOT,//SETTLEMENT OUT FUND

            FDO,//FUND OUT
            FDI,//FUND IN

            TNS,//TORN SELL
            TNB,//TORN BUY

            DDT,//DEDUCTION
            RFD,//REFUND

            OPN,//OPPENING
            FOO,//FOO

            //EMPLOYEES SECTION
            EMPOPN,//EMPLOYEE OPENING
            EMPSAL,//EMPLOYEE SALARY
            EMPLNI,//EMPLOYEE LOAN IN
            EMPLNO,//EMPLOYEE LOAN OUT
            EMPDTI,//EMPLOYEE DEPOSITE IN
            EMPDTO//EMPLOYEE DEPOSITE OUT
        }
        public enum CC
        {
            ONE,
            TWO,
            THR
        }

        //GENERAL PURPOSE METHODS
        /*public static void DeleteTransactionById(ref dbEntities db, int _transactionId)
        {
            db.Transactions.Remove((db.Transactions.FirstOrDefault(x => x.id == _transactionId)));
            db.FundTransactions.Remove((db.FundTransactions.FirstOrDefault(x => x.id == _transactionId)));
        }*/
        /*public static void DeleteTransactions(ref dbEntities db, Guid _guid, TT _TT = TT.FOO)
        {
            if (_TT == TT.FOO)
            {
                db.Transactions.RemoveRange((db.Transactions.Where(x => x.GUID == _guid)));
                db.FundTransactions.RemoveRange((db.FundTransactions.Where(x => x.GUID == _guid)));
            }
            else
            {
                db.Transactions.RemoveRange((db.Transactions.Where(x => x.GUID == _guid && x.TT == _TT.ToString())));
                db.FundTransactions.RemoveRange((db.FundTransactions.Where(x => x.GUID == _guid && x.TT == _TT.ToString())));
            }
        }*/
        public static void DeleteTransactions(Guid _guid, int currencyId = 0, int accountId = 0,int itemId=0, TT _TT = TT.FOO)
        {
            using (dbEntities db = new dbEntities())
            {
                if (_TT == TT.FOO)
                {
                    List<Transaction> _transactions = db.Transactions.Where(x => x.GUID == _guid).ToList();
                    List<FundTransaction> _fundtransactions = db.FundTransactions.Where(x => x.GUID == _guid).ToList();
                    List<ItemTransaction> _itemtransactions = db.ItemTransactions.Where(x => x.GUID == _guid).ToList();
                    db.Transactions.RemoveRange(_transactions);
                    db.FundTransactions.RemoveRange(_fundtransactions);
                    db.ItemTransactions.RemoveRange(_itemtransactions);
                }
                else
                {
                    List<Transaction> _transactions = db.Transactions.Where(x => x.GUID == _guid && x.TT == _TT.ToString()).ToList();
                    List<FundTransaction> _fundtransactions = db.FundTransactions.Where(x => x.GUID == _guid && x.TT == _TT.ToString()).ToList();
                    List<ItemTransaction> _itemtransactions = db.ItemTransactions.Where(x => x.GUID == _guid && x.TT == _TT.ToString()).ToList();
                    db.Transactions.RemoveRange(_transactions);
                    db.FundTransactions.RemoveRange(_fundtransactions);
                    db.ItemTransactions.RemoveRange(_itemtransactions);
                }
                db.SaveChanges();
                ClientsRunningTotals(accountId);
                FundsRunningTotals(currencyId);
                ItemsRunningTotals(itemId);
            }
        }
        public static TEnum GetEnumStringEnumType<TEnum>(string strenum)
    where TEnum : struct
        {
            TEnum resultInputType = default(TEnum);
            bool enumParseResult = false;

            while (!enumParseResult)
            {
                enumParseResult = Enum.TryParse(strenum, true, out resultInputType);
            }
            return resultInputType;
        }

        //CLIENT TRANACTIONS OPERATIONS
        public static void DeleteAllClientTransactions(int _clientId, TT _TT = TT.FOO)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                Guid _guid = new Guid();
                List<Transaction> _transactions = db.Transactions.Where(x => x.AccountId == _clientId).ToList();
                foreach (Transaction _transaction in _transactions)
                {
                    _guid = _transaction.GUID.Value;
                    db.Transactions.RemoveRange((db.Transactions.Where(x => x.GUID == _guid)));
                    db.FundTransactions.RemoveRange((db.FundTransactions.Where(x => x.GUID == _guid)));
                }

                db.SaveChanges();
                ClientsRunningTotals(_clientId);
            }
        }
        /*public static void InsertClientTransaction(ref dbEntities db, int accountId, int currencyId, decimal amount, TT OperationType, DateTime OperationDate, Guid OperationGUID, int ForeignCurrency = 0)
        {
            db.Transactions.Load();

            List<Transaction> _transactions = db.Transactions.Where(x =>
              x.AccountId == accountId &&
              x.CurrencyId == currencyId
            //DateTimeCompare.Compare(x.TTS.Value, OperationDate) == 1
            ).ToList();
            //decimal _initBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId).Balance.Value;
            decimal _initBalance = 0;
            Transaction _trans = db.Transactions.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId && x.TT == TT.OPN.ToString());
            if (_trans == null)
            {
                _trans = new DAL.Transaction();
            }
            else if (_trans.Amount != null)
            {
                _initBalance = _trans.Amount.Value;
            }
            decimal _sum = _initBalance;
            _sum += _transactions.Sum(x => x.Amount.Value); //Previous running total
            switch (OperationType)
            {
                case TT.CTF:
                    if (_sum >= 0)
                    {
                        amount = amount * -1;
                    }
                    else if (_sum < 0)
                    {
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                    }
                    break;
                case TT.CTT:
                    //Transfer_ClientFund _transfer = db.Transfer_ClientFund.FirstOrDefault(x => x.GUID == OperationGUID);
                    int _fromCurrency = ForeignCurrency;// db.Funds.FirstOrDefault(x => x.Id == _transfer.FundFrom.Value).CurrencyId.Value;
                    List<Transaction> _fromTransactions = db.Transactions.Where(x =>
                          x.AccountId == accountId &&
                          x.CurrencyId == _fromCurrency &&
                              DateTimeCompare.Compare(OperationDate, x.TTS.Value) == 1
                        ).ToList();
                    decimal _initFromBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == _fromCurrency).Balance.Value;
                    decimal _fromSum = _initFromBalance;
                    _fromSum += _fromTransactions.Sum(x => x.Amount).Value;
                    if (_sum >= 0)
                    {
                        if (_fromSum <= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_fromSum > 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                    }
                    else if (_sum < 0)
                    {
                        if (_fromSum <= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_fromSum > 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                    }
                    else
                    {
                        amount = amount * -1;
                    }
                    break;
                case TT.TRF:
                case TT.DDT:
                case TT.DTF:
                case TT.LNF:
                case TT.WEO:
                case TT.ORT:
                case TT.OTD:
                case TT.PAY:
                    amount = amount * -1;
                    break;
                case TT.TRT:
                case TT.RFD:
                case TT.DTT:
                case TT.LNT:
                case TT.WEI:
                case TT.ORF:
                case TT.INC:
                case TT.PID:
#pragma warning disable CS1717 // Assignment made to same variable
                    amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                    break;
                default:
                    break;
            }
            Transaction _transaction = new Transaction()
            {
                AccountId = accountId,
                CurrencyId = currencyId,
                Amount = amount,
                TT = OperationType.ToString(),
                TTS = OperationDate,
                GUID = OperationGUID
            };
            db.Transactions.Add(_transaction);
        }
        */
        public static void InsertClientTransaction(int accountId, int currencyId, decimal amount, TT OperationType, DateTime OperationDate, Guid OperationGUID, string _declaration, int ForeignCurrency = 0)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                List<Transaction> _transactions = db.Transactions.Where(x =>
                                                                          x.AccountId == accountId &&
                                                                          x.CurrencyId == currencyId
                                                                        ).ToList();
                decimal _sum = _transactions.Sum(x => x.Amount.Value); //Previous running total
                amount = Math.Abs(amount);
                switch (OperationType)
                {
                    case TT.TRT:
                        List<Transaction> _fromClientTransactions = db.Transactions.Where(x =>
                                                                                    x.AccountId == ForeignCurrency && //Foreign currency == from client id
                                                                                    x.CurrencyId == currencyId &&
                                                                                    DateTimeCompare.Compare(OperationDate, x.TTS.Value) == 1
                                                                                    ).ToList();
                        decimal _fromClientBalance = _fromClientTransactions.Sum(x => x.Amount.Value);
                        if (_fromClientBalance <= 0)
                        {
                            amount *= -1;
                        }
                        break;
                    case TT.TRF:
                    case TT.CTF:
                        if (_sum >= 0)
                        {
                            amount = amount * -1;
                        }
                        break;
                    case TT.CTT:
                        int _fromCurrency = ForeignCurrency;// db.Funds.FirstOrDefault(x => x.Id == _transfer.FundFrom.Value).CurrencyId.Value;
                        List<Transaction> _fromTransactions = db.Transactions.Where(x =>
                                                                                    x.AccountId == accountId &&
                                                                                    x.CurrencyId == _fromCurrency &&
                                                                                    DateTimeCompare.Compare(OperationDate, x.TTS.Value) == 1
                                                                                    ).ToList();
                        decimal _fromSum = _fromTransactions.Sum(x => x.Amount).Value;
                        if (_fromSum < 0)
                        {
                            amount *= -1;
                        }
                        break;
                    case TT.DDT:
                    case TT.DTF:
                    case TT.LNF:
                    case TT.WEO:
                    case TT.ORT:
                    case TT.OTD:
                    case TT.PAY:
                    case TT.IGNINC:
                    case TT.IGNORF:
                    case TT.IGNWEI:
                    case TT.LOS:
                    case TT.BLB:
                        amount = amount * -1;
                        break;
                    case TT.RFD:
                    case TT.DTT:
                    case TT.LNT:
                    case TT.WEI:
                    case TT.ORF:
                    case TT.INC:
                    case TT.PID:
                    case TT.IGNOTD:
                    case TT.IGNORT:
                    case TT.IGNWEO:
                    case TT.GIN:
                    case TT.BLS:
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        break;
                    default:
                        break;
                }
                _sum += amount;
                Transaction _transaction = new Transaction()
                {
                    AccountId = accountId,
                    CurrencyId = currencyId,
                    Amount = amount,
                    TT = OperationType.ToString(),
                    TTS = OperationDate,
                    GUID = OperationGUID,
                    RunningTotal = _sum,
                    Declaration = _declaration
                };
                db.Set<Transaction>().Add(_transaction);
                db.SaveChanges();
                ClientsRunningTotals(accountId, currencyId);
            }
        }
        /*public static void UpdateTransactions(ref dbEntities db, DbPropertyValues originalValues, DbPropertyValues currentValues, DateTime OperationDate, Guid _guid, int ForeignCurrency = 0)
        {
            List<int> _currencies = new List<int>();
            List<decimal> _amounts = new List<decimal>();
            List<int> _accountsids = new List<int>();
            //ALL transactions before this one
            var _transactions = db.Transactions.Where(x =>
              x.GUID == _guid
            ).ToList();
            decimal _tempId = 0;
            foreach (var item in currentValues.PropertyNames)
            {
                if (currentValues[item] != null)
                    if (decimal.TryParse(currentValues[item].ToString(), out _tempId))
                    {
                        if (_tempId > 0)
                        {
                            if (item.ToLower().Contains("currencyid"))
                            {
                                _currencies.Add((int)_tempId);
                            }
                            else if (item.ToLower().Contains("amount"))
                            {
                                _amounts.Add(_tempId);
                            }
                            else if (item.ToLower().Contains("account") || item.ToLower().Contains("sender") || item.ToLower().Contains("client") || item.ToLower().Contains("fund"))
                            {
                                _accountsids.Add((int)_tempId);
                            }
                        }
                    }
            }
            db.Accounts_Info.Load();
            db.Currencies.Load();
            //TODO WORK
            ClientWorker(ref db, originalValues, currentValues, _accountsids, _currencies, _amounts, _transactions, ForeignCurrency);
            //db.SaveChanges();
        }
        private static void ClientWorker(ref dbEntities db, DbPropertyValues originalValues, DbPropertyValues currentValues, List<int> _accountsids, List<int> _currencies, List<decimal> _amounts, List<Transaction> _transactions, int ForeignCurrency = 0)
        {
            int i = 0;
            List<Accounts_Info> accounts = new List<Accounts_Info>();
            List<Currency> currencies = new List<Currency>();
            if (_currencies.Count < _transactions.Count)
            {
                int count = _transactions.Count - _currencies.Count;
                for (int j = 0; j < count; j++)
                {
                    _currencies.Add(_currencies[_currencies.Count - 1]);
                }
            }
            if (_amounts.Count < _transactions.Count)
            {
                int count = _transactions.Count - _amounts.Count;
                for (int j = 0; j < count; j++)
                {
                    _amounts.Add(_amounts[_amounts.Count - 1]);
                }
            }
            foreach (var _transaction in _transactions)
            {
                int _currencyId = _currencies[i];
                int _accountId = _accountsids[i];
                //int _sign = 1;
                //if (_transaction.Amount.Value < 0)
                //{
                //    _sign *= -1;
                //}
                //decimal amount = _amounts[i];//*_sign;
                Transaction _temp = _transaction;
                _temp.Amount = _amounts[i];
                decimal amount = TransactionAmount(ref db, _temp);
                accounts.Add(db.Accounts_Info.FirstOrDefault(x => x.Id == _accountId));
                currencies.Add(db.Currencies.FirstOrDefault(x => x.Id == _currencyId));

                _transaction.Amount = amount;
                _transaction.CurrencyId = _currencyId;
                _transaction.AccountId = _accountId;
                string _TTS = currentValues.PropertyNames.FirstOrDefault(x => x.ToLower().Contains("date")).ToString();
                string _TT = originalValues.PropertyNames.FirstOrDefault(x =>
                x.ToLower().Contains("type") ||
                x.ToLower().Contains("class") ||
                x.ToLower().Contains("origin") ||
                x.ToLower().Contains("direction")).ToString();
                _transaction.TTS = (DateTime)currentValues[_TTS];

                if (originalValues[_TT] != currentValues[_TT])
                {
                    switch (GetEnumStringEnumType<TT>(_transaction.TT))
                    {
                        case TT.CTF:
                            _transaction.TT = TT.CTT.ToString();
                            break;
                        case TT.CTT:
                            _transaction.TT = TT.CTF.ToString();
                            break;
                        case TT.TRF:
                            _transaction.TT = TT.TRT.ToString();
                            break;
                        case TT.TRT:
                            _transaction.TT = TT.TRF.ToString();
                            break;
                        case TT.PAY:
                            _transaction.TT = TT.PID.ToString();
                            break;
                        case TT.PID:
                            _transaction.TT = TT.PAY.ToString();
                            break;
                        case TT.INC:
                            _transaction.TT = TT.OTD.ToString();
                            break;
                        case TT.OTD:
                            _transaction.TT = TT.INC.ToString();
                            break;
                        case TT.ORF:
                            _transaction.TT = TT.ORT.ToString();
                            break;
                        case TT.ORT:
                            _transaction.TT = TT.ORF.ToString();
                            break;
                        case TT.WEI:
                            _transaction.TT = TT.WEO.ToString();
                            break;
                        case TT.WEO:
                            _transaction.TT = TT.WEI.ToString();
                            break;
                        case TT.LNF:
                            _transaction.TT = TT.LNT.ToString();
                            break;
                        case TT.LNT:
                            _transaction.TT = TT.LNF.ToString();
                            break;
                        case TT.DTF:
                            _transaction.TT = TT.DTT.ToString();
                            break;
                        case TT.DTT:
                            _transaction.TT = TT.DTF.ToString();
                            break;
                        case TT.EXS:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDO:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDI:
                            _transaction.TT = TT.FDO.ToString();
                            break;
                        case TT.DDT:
                            _transaction.TT = TT.RFD.ToString();
                            break;
                        case TT.RFD:
                            _transaction.TT = TT.DDT.ToString();
                            break;
                        default:
                            break;
                    }
                }
                ++i;
            }
            _accountsids = _accountsids.Distinct().ToList();
            _currencies = _currencies.Distinct().ToList();
            for (int k = 0; k < _accountsids.Count; k++)
            {
                for (int z = 0; z < _currencies.Count; z++)
                {
                    ReorganizeClientTransaction(ref db, _accountsids[k], _currencies[z]);
                }
            }
        }
        public static void ReorganizeClientTransaction(ref dbEntities db, int accountId, int currencyId)
        {
            db.Transactions.Load();
            decimal amount = 0;
            int ForeignCurrency = 0;
            List<Transaction> _transactions = db.Transactions.Where(x =>
              x.AccountId == accountId &&
              x.CurrencyId == currencyId
            ).OrderBy(x => x.TTS.Value.Year)
            .ThenBy(x => x.TTS.Value.Month)
            .ThenBy(x => x.TTS.Value.Day)
            .ThenBy(x => x.TTS.Value.Hour)
            .ThenBy(x => x.TTS.Value.Minute)
            .ThenBy(x => x.TTS.Value.Second)
            .ToList();
            //decimal _initBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId).Balance.Value;
            decimal _initBalance = 0;
            Transaction _trans = db.Transactions.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId && x.TT == TT.OPN.ToString());
            if (_trans == null)
            {
                _trans = new DAL.Transaction();
            }
            else if (_trans.Amount != null)
            {
                _initBalance = _trans.Amount.Value;
            }
            decimal _sum = _initBalance;
            foreach (var _transaction in _transactions)
            {
                amount = Math.Abs(_transaction.Amount.Value);
                switch (GetEnumStringEnumType<TT>(_transaction.TT))
                {
                    case TT.CTF:
                        if (_sum >= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_sum < 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                        break;
                    case TT.CTT:
                        Transfer_ClientFund _transfer = db.Transfer_ClientFund.FirstOrDefault(x => x.GUID == _transaction.GUID);
                        ForeignCurrency = db.Funds.FirstOrDefault(x => x.Id == _transfer.FundFrom.Value).CurrencyId.Value;
                        int _fromCurrency = ForeignCurrency;
                        List<Transaction> _fromTransactions = db.Transactions.Where(x =>
                              x.AccountId == accountId &&
                              x.CurrencyId == _fromCurrency &&
                              DateTimeCompare.Compare(_transaction.TTS.Value, x.TTS.Value) == 1
                            ).ToList();
                        decimal _initFromBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == _fromCurrency).Balance.Value;
                        decimal _fromSum = _initFromBalance;
                        _fromSum += _fromTransactions.Sum(x => x.Amount).Value;
                        if (_sum >= 0)
                        {
                            if (_fromSum <= 0)
                            {
                                amount = amount * -1;
                            }
                            else if (_fromSum > 0)
                            {
#pragma warning disable CS1717 // Assignment made to same variable
                                amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                            }
                        }
                        else if (_sum < 0)
                        {
                            if (_fromSum <= 0)
                            {
                                amount = amount * -1;
                            }
                            else if (_fromSum > 0)
                            {
#pragma warning disable CS1717 // Assignment made to same variable
                                amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                            }
                        }
                        else
                        {
                            amount = amount * -1;
                        }
                        break;
                    case TT.TRF:
                    case TT.DDT:
                    case TT.DTF:
                    case TT.LNF:
                    case TT.WEO:
                    case TT.ORT:
                    case TT.OTD:
                    case TT.PAY:
                        amount = amount * -1;
                        break;
                    case TT.TRT:
                    case TT.RFD:
                    case TT.DTT:
                    case TT.LNT:
                    case TT.WEI:
                    case TT.ORF:
                    case TT.INC:
                    case TT.PID:
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        break;
                    default:
                        break;
                }
                _sum += amount; //Previous running total
                _transaction.Amount = amount;
            }
            //db.SaveChanges();
        }
        */
        /*public static decimal TransactionAmount(ref dbEntities db, Transaction _baseTransaction)
        {
            db.Transactions.Load();
            int ForeignCurrency = 0;
            decimal amount = 0;
            int accountId, currencyId;
            accountId = _baseTransaction.AccountId.Value;
            currencyId = _baseTransaction.CurrencyId.Value;
            List<Transaction> _transactions = db.Transactions.Where(x =>
              x.AccountId == accountId &&
              x.CurrencyId == currencyId &&
              DateTimeCompare.Compare(_baseTransaction.TTS.Value, x.TTS.Value) == 1
            ).ToList();
            _transactions.Add(_baseTransaction);
            //decimal _initBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId).Balance.Value;
            decimal _initBalance = 0;
            Transaction _trans = db.Transactions.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId && x.TT == TT.OPN.ToString());
            if (_trans == null)
            {
                _trans = new DAL.Transaction();
            }
            else if (_trans.Amount != null)
            {
                _initBalance = _trans.Amount.Value;
            }
            decimal _sum = _initBalance;
            foreach (var _transaction in _transactions)
            {
                amount = Math.Abs(_transaction.Amount.Value);
                switch (GetEnumStringEnumType<TT>(_transaction.TT))
                {
                    case TT.CTF:
                        if (_sum >= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_sum < 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                        break;
                    case TT.CTT:
                        Transfer_ClientFund _transfer = db.Transfer_ClientFund.FirstOrDefault(x => x.GUID == _transaction.GUID);
                        ForeignCurrency = db.Funds.FirstOrDefault(x => x.Id == _transfer.FundFrom.Value).CurrencyId.Value;
                        int _fromCurrency = ForeignCurrency;
                        List<Transaction> _fromTransactions = db.Transactions.Where(x =>
                              x.AccountId == accountId &&
                              x.CurrencyId == _fromCurrency &&
                              DateTimeCompare.Compare(_transaction.TTS.Value, x.TTS.Value) == 1
                            ).ToList();
                        decimal _initFromBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == _fromCurrency).Balance.Value;
                        decimal _fromSum = _initFromBalance;
                        _fromSum += _fromTransactions.Sum(x => x.Amount).Value;
                        if (_sum >= 0)
                        {
                            if (_fromSum <= 0)
                            {
                                amount = amount * -1;
                            }
                            else if (_fromSum > 0)
                            {
#pragma warning disable CS1717 // Assignment made to same variable
                                amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                            }
                        }
                        else if (_sum < 0)
                        {
                            if (_fromSum <= 0)
                            {
                                amount = amount * -1;
                            }
                            else if (_fromSum > 0)
                            {
#pragma warning disable CS1717 // Assignment made to same variable
                                amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                            }
                        }
                        else
                        {
                            amount = amount * -1;
                        }
                        break;
                    case TT.TRF:
                    case TT.DDT:
                    case TT.DTF:
                    case TT.LNF:
                    case TT.WEO:
                    case TT.ORT:
                    case TT.OTD:
                    case TT.PAY:
                        amount = amount * -1;
                        break;
                    case TT.TRT:
                    case TT.RFD:
                    case TT.DTT:
                    case TT.LNT:
                    case TT.WEI:
                    case TT.ORF:
                    case TT.INC:
                    case TT.PID:
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        break;
                    default:
                        break;
                }
                _sum += amount; //Previous running total
                //_transaction.Amount = amount;
            }
            return amount;
        }*/
        public static void InsertClientOpeningBalance(ref dbEntities db, AccountFund _fund, string _declaration)
        {
            int _sign = 1;
            if (_fund.BalanceDirection == "لكم")
            {
                _sign *= -1;
            }
            decimal Amount = Math.Abs(_fund.Balance.Value) * _sign;
            db.Transactions.Add(new Transaction()
            {
                TT = TT.OPN.ToString(),
                CurrencyId = _fund.CurrencyId,
                AccountId = _fund.AccountId,
                GUID = _fund.GUID,
                Amount = Amount,
                RunningTotal = Amount,
                TTS = DateTime.Now,
                Declaration = _declaration
            }
            );
            ClientsRunningTotals(_fund.AccountId.Value, _fund.CurrencyId.Value);
        }
        public static void UpdateClientOpeningBalance(AccountFund _fund, decimal _amount)
        {
            using (dbEntities db = new dbEntities())
            {
                Transaction _transaction = db.Transactions.FirstOrDefault(x => x.GUID.Value == _fund.GUID.Value && x.TT == TT.OPN.ToString());
                int _sign = 1;
                if (_fund.BalanceDirection == "لكم")
                {
                    _sign *= -1;
                }
                _amount = Math.Abs(_fund.Balance.Value) * _sign;
                _transaction.Amount = _amount;
                db.SaveChanges();
                ClientsRunningTotals(_transaction.AccountId.Value, _transaction.CurrencyId.Value);
            }
        }


        //FUND TRANACTIONS OPERATIONS
        public static void DeleteAllFundTransactions(int _fundId, TT _TT = TT.FOO)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                db.FundTransactions.RemoveRange((db.FundTransactions.Where(x => x.FundId == _fundId)));
                db.SaveChanges();
            }
        }
        public static void InsertFundOpeningBalance(Fund _fund, string _declaration)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                int _sign = 1;
                if (_fund.BalanceDirection == "لكم")
                {
                    _sign *= -1;
                }
                decimal Amount = Math.Abs(_fund.Balance.Value) * _sign;
                db.FundTransactions.Add(new FundTransaction()
                {
                    TT = TT.OPN.ToString(),
                    CurrencyId = _fund.CurrencyId,
                    FundId = _fund.Id,
                    GUID = _fund.GUID,
                    Amount = Amount,
                    TTS = DateTime.Now,
                    Declaration = _declaration
                }
                );
                db.SaveChanges();
                FundsRunningTotals(_fund.CurrencyId.Value);
            }
        }
        /*public static void InsertFundTransaction(ref dbEntities db, int currencyId, decimal amount, TT OperationType, DateTime OperationDate, Guid OperationGUID)
        {
            switch (OperationType)
            {
                case TT.RFD:
                case TT.CED:
                case TT.CEB:
                case TT.FDI:
                case TT.LNI:
                case TT.DTI:
                //case TT.DTF:
                //case TT.LNF:
                case TT.WEI:
                //case TT.OTD:
                case TT.OBF:
                //case TT.PAY:
                case TT.PYI:
#pragma warning disable CS1717 // Assignment made to same variable
                    amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                    break;
                case TT.DDT:
                case TT.CES:
                case TT.FDO:
                case TT.EXS:
                //case TT.DTT:
                //case TT.LNT:
                case TT.DTO:
                case TT.LNO:
                //case TT.INC:
                case TT.ICF:
                //case TT.PID:
                case TT.PYO:
                    amount = amount * -1;
                    break;
                default:
                    break;
            }
            FundTransaction _transaction = new FundTransaction()
            {
                FundId = currencyId,
                CurrencyId = currencyId,
                Amount = amount,
                TT = OperationType.ToString(),
                TTS = OperationDate,
                GUID = OperationGUID
            };
            db.FundTransactions.Add(_transaction);
        }
        */
        public static void InsertFundTransaction(int currencyId, decimal amount, TT OperationType, DateTime OperationDate, Guid OperationGUID, string _declaration)
        {
            if (OperationType != TT.CED)
                amount = Math.Abs(amount);

            using (dbEntities db = new DAL.dbEntities())
            {
                switch (OperationType)
                {
                    case TT.SIN:
                    case TT.RFD:
                    //case TT.CED:
                    case TT.CEB:
                    case TT.TNB:
                    case TT.FDI:
                    case TT.LNI:
                    case TT.DTI:
                    //case TT.DTF:
                    //case TT.LNF:
                    case TT.WEI:
                    //case TT.OTD:
                    case TT.OBF:
                    //case TT.PAY:
                    case TT.PYI:
                    case TT.IGNICF:
                    case TT.BLB:
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        break;
                    case TT.SOT:
                    case TT.DDT:
                    case TT.CES:
                    case TT.TNS:
                    case TT.FDO:
                    case TT.EXS:
                    //case TT.DTT:
                    //case TT.LNT:
                    case TT.DTO:
                    case TT.LNO:
                    //case TT.INC:
                    case TT.ICF:
                    //case TT.PID:
                    case TT.PYO:
                    case TT.IGNOBF:
                    case TT.IGNWEI:
                    case TT.BLS:
                        amount = amount * -1;
                        break;
                    default:
                        break;
                }
                List<FundTransaction> _transactions = db.FundTransactions.Where(x =>
                                                                          x.CurrencyId == currencyId
                                                                        ).ToList();
                decimal _sum = _transactions.Sum(x => x.Amount.Value); //Previous running total
                _sum += amount;
                FundTransaction _transaction = new FundTransaction()
                {
                    FundId = currencyId,
                    CurrencyId = currencyId,
                    Amount = amount,
                    TT = OperationType.ToString(),
                    TTS = OperationDate,
                    GUID = OperationGUID,
                    RunningTotal = _sum,
                    Declaration = _declaration
                };
                db.Set<FundTransaction>().Add(_transaction);
                // use the following statement so that Childs won't be inserted
                db.SaveChanges();
                FundsRunningTotals(currencyId);
            }
        }
        /*public static void UpdateFundTransactions(ref dbEntities db, DbPropertyValues originalValues, DbPropertyValues currentValues, Guid _guid)
        {
            List<int> _currencies = new List<int>();
            List<decimal> _amounts = new List<decimal>();
            var _transactions = db.FundTransactions.Where(x =>
              x.GUID == _guid
            ).ToList();
            foreach (var item in currentValues.PropertyNames)
            {
                if (item.ToLower().Contains("currencyid"))
                {
                    _currencies.Add(int.Parse(currentValues[item].ToString()));
                }
                else if (item.ToLower().Contains("amount"))
                {
                    _amounts.Add(decimal.Parse(currentValues[item].ToString()));
                }
            }
            db.Funds.Load();
            db.Currencies.Load();
            FundWorker(ref db, originalValues, currentValues, _currencies, _amounts, _transactions);
            //db.SaveChanges();
        }
        private static void OneCurrency(dbEntities db, DbPropertyValues originalValues, DbPropertyValues currentValues, List<int> _currencies, List<decimal> _amounts, List<FundTransaction> _transactions)
        {
            int _currencyId = _currencies[0];
            foreach (var _transaction in _transactions)
            {
                _transaction.Amount = _amounts[0];
                _transaction.CurrencyId = _currencies[0];
                string _TTS = originalValues.PropertyNames.FirstOrDefault(x => x.ToLower().Contains("date")).ToString();
                string _TT = originalValues.PropertyNames.FirstOrDefault(x => x.ToLower().Contains("type") || x.ToLower().Contains("class") || x.ToLower().Contains("direction")).ToString();
                _transaction.TTS = (DateTime)currentValues[_TTS];
                if (originalValues[_TT] != currentValues[_TT])
                {
                    _transaction.Amount = _transaction.Amount * -1;

                    switch (GetEnumStringEnumType<TT>(_transaction.TT))
                    {
                        case TT.PAY:
                            _transaction.TT = TT.PID.ToString();
                            break;
                        case TT.PID:
                            _transaction.TT = TT.PAY.ToString();
                            break;
                        case TT.INC:
                            _transaction.TT = TT.OTD.ToString();
                            break;
                        case TT.OTD:
                            _transaction.TT = TT.INC.ToString();
                            break;
                        case TT.ORF:
                            _transaction.TT = TT.ORT.ToString();
                            break;
                        case TT.ORT:
                            _transaction.TT = TT.ORF.ToString();
                            break;
                        case TT.WEI:
                            _transaction.TT = TT.WEO.ToString();
                            break;
                        case TT.WEO:
                            _transaction.TT = TT.WEI.ToString();
                            break;
                        case TT.LNF:
                            _transaction.TT = TT.LNT.ToString();
                            break;
                        case TT.LNT:
                            _transaction.TT = TT.LNF.ToString();
                            break;
                        case TT.DTF:
                            _transaction.TT = TT.DTT.ToString();
                            break;
                        case TT.DTT:
                            _transaction.TT = TT.DTF.ToString();
                            break;
                        case TT.EXS:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDO:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDI:
                            _transaction.TT = TT.FDO.ToString();
                            break;
                        case TT.DDT:
                            _transaction.TT = TT.RFD.ToString();
                            break;
                        case TT.RFD:
                            _transaction.TT = TT.DDT.ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        private static void FundWorker(ref dbEntities db, DbPropertyValues originalValues, DbPropertyValues currentValues, List<int> _currencies, List<decimal> _amounts, List<FundTransaction> _transactions)
        {
            int i = 0;
            List<Fund> funds = new List<Fund>();
            List<Currency> currencies = new List<Currency>();
            if (_currencies.Count < _transactions.Count)
            {
                int count = _transactions.Count - _currencies.Count;
                for (int j = 0; j < count; j++)
                {
                    _currencies.Add(_currencies[_currencies.Count]);
                }
            }
            foreach (var _transaction in _transactions)
            {
                int _sign = 1;
                if (_transaction.Amount.Value < 0)
                {
                    _sign *= -1;
                }
                int _currencyId = _currencies[i];
                funds.Add(db.Funds.FirstOrDefault(x => x.CurrencyId == _currencyId));
                currencies.Add(db.Currencies.FirstOrDefault(x => x.Id == _currencyId));
                _transaction.Amount = _amounts[i] * _sign;
                _transaction.CurrencyId = _currencies[i];
                string _TTS = currentValues.PropertyNames.FirstOrDefault(x => x.ToLower().Contains("date")).ToString();
                string _TT = originalValues.PropertyNames.FirstOrDefault(x =>
                x.ToLower().Contains("type") ||
                x.ToLower().Contains("origin") ||
                x.ToLower().Contains("class") ||
                x.ToLower().Contains("direction")).ToString();
                _transaction.TTS = (DateTime)currentValues[_TTS];
                if (originalValues[_TT] != currentValues[_TT])
                {
                    _transaction.Amount = _transaction.Amount * -1;

                    switch (GetEnumStringEnumType<TT>(_transaction.TT))
                    {
                        case TT.PAY:
                            _transaction.TT = TT.PID.ToString();
                            break;
                        case TT.PID:
                            _transaction.TT = TT.PAY.ToString();
                            break;
                        case TT.PYO:
                            _transaction.TT = TT.PYI.ToString();
                            break;
                        case TT.PYI:
                            _transaction.TT = TT.PYO.ToString();
                            break;
                        case TT.INC:
                            _transaction.TT = TT.OTD.ToString();
                            break;
                        case TT.OTD:
                            _transaction.TT = TT.INC.ToString();
                            break;
                        case TT.ICF:
                            _transaction.TT = TT.OBF.ToString();
                            break;
                        case TT.OBF:
                            _transaction.TT = TT.ICF.ToString();
                            break;
                        case TT.ORF:
                            _transaction.TT = TT.ORT.ToString();
                            break;
                        case TT.ORT:
                            _transaction.TT = TT.ORF.ToString();
                            break;
                        case TT.WEI:
                            _transaction.TT = TT.WEO.ToString();
                            break;
                        case TT.WEO:
                            _transaction.TT = TT.WEI.ToString();
                            break;
                        case TT.LNF:
                            _transaction.TT = TT.LNT.ToString();
                            break;
                        case TT.LNT:
                            _transaction.TT = TT.LNF.ToString();
                            break;
                        case TT.DTF:
                            _transaction.TT = TT.DTT.ToString();
                            break;
                        case TT.DTT:
                            _transaction.TT = TT.DTF.ToString();
                            break;
                        case TT.LNI:
                            _transaction.TT = TT.LNO.ToString();
                            break;
                        case TT.LNO:
                            _transaction.TT = TT.LNI.ToString();
                            break;
                        case TT.DTO:
                            _transaction.TT = TT.DTI.ToString();
                            break;
                        case TT.DTI:
                            _transaction.TT = TT.DTO.ToString();
                            break;
                        case TT.EXS:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDO:
                            _transaction.TT = TT.FDI.ToString();
                            break;
                        case TT.FDI:
                            _transaction.TT = TT.FDO.ToString();
                            break;
                        case TT.CES:
                            _transaction.TT = TT.CEB.ToString();
                            break;
                        case TT.CEB:
                            _transaction.TT = TT.CES.ToString();
                            break;
                        case TT.DDT:
                            _transaction.TT = TT.RFD.ToString();
                            break;
                        case TT.RFD:
                            _transaction.TT = TT.DDT.ToString();
                            break;
                        default:
                            break;
                    }
                }
                ++i;
            }
        }
        */
        public static void UpdateFundOpeningBalance(Fund _fund, decimal _amount)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                Transaction _transaction = db.Transactions.FirstOrDefault(x => x.GUID.Value == _fund.GUID.Value && x.TT == TT.OPN.ToString());
                int _sign = 1;
                if (_fund.BalanceDirection == "لكم")
                {
                    _sign *= -1;
                }
                _amount = Math.Abs(_fund.Balance.Value) * _sign;
                _transaction.Amount = _amount;
                db.SaveChanges();
                FundsRunningTotals(_transaction.CurrencyId.Value);
            }
        }
        //public static void UpdateExchangeTransactions(ref dbEntities db, CurrencyExchangeOperation item)
        //{
        //    DateTime _opertationDate = item.LUD.Value;
        //    item.OpreationDate = _opertationDate;
        //    DeleteTransactions(ref db, item.GUID.Value);
        //    if (item.Direction == Utilities.ExchangeDirection.بيع.ToString())
        //    {
        //        InsertFundTransaction(ref db, item.BaseCurrencyId.Value, item.BaseAmount.Value, TT.CES, item.OpreationDate.Value, item.GUID.Value);
        //        InsertFundTransaction(ref db, item.SubCurrencyId.Value, item.SubAmount.Value, TT.CEB, item.OpreationDate.Value, item.GUID.Value);
        //    }
        //    else if (item.Direction == Utilities.ExchangeDirection.شراء.ToString())
        //    {
        //        InsertFundTransaction(ref db, item.BaseCurrencyId.Value, item.BaseAmount.Value, TT.CEB, item.OpreationDate.Value, item.GUID.Value);
        //        InsertFundTransaction(ref db, item.SubCurrencyId.Value, item.SubAmount.Value, TT.CES, item.OpreationDate.Value, item.GUID.Value);
        //    }
        //}


        //EMPLOYEES TRANSACTIONS OPERATIONS
        /*
        public static void DeleteEmployeeTransactions(ref dbEntities db, int _employeeId, TT _TT = TT.FOO)
        {
            db.EmployeeTransactions.RemoveRange((db.EmployeeTransactions.Where(x => x.EmployeeId == _employeeId)));
        }
        public static void InsertEmployeeOpeningBalance(ref dbEntities db, Employees_Fund _fund)
        {
            int _sign = 1;
            if (_fund.BalanceDirection == "لكم")
            {
                _sign *= -1;
            }
            decimal Amount = Math.Abs(_fund.Balance.Value) * _sign;
            db.EmployeeTransactions.Add(new EmployeeTransaction()
            {
                TT = TT.EMPOPN.ToString(),
                CurrencyId = _fund.CurrencyId,
                EmployeeId = _fund.EmployeeId,
                GUID = _fund.GUID,
                Amount = Amount,
                RunningTotal = Amount,
                TTS = DateTime.Now
            }
            );
        }
        public static void UpdateEmployeeOpeningBalance(ref dbEntities db, Employees_Fund _fund, decimal _amount)
        {
            EmployeeTransaction _transaction = db.EmployeeTransactions.FirstOrDefault(x => x.GUID.Value == _fund.GUID.Value && x.TT == TT.EMPOPN.ToString());
            int _sign = 1;
            if (_fund.BalanceDirection == "لكم")
            {
                _sign *= -1;
            }
            _amount = Math.Abs(_fund.Balance.Value) * _sign;
            _transaction.Amount = _amount;
        }
        */
        //Regenerate Transactions
        //FundTransactions
        public static void FundsRunningTotals(int currencyid)
        {
            using (dbEntities db = new dbEntities())
            {
                decimal runningtotal = 0;
                runningtotal = 0;
                var list = db.FundTransactions
                    .Where(x => x.CurrencyId == currencyid).OrderBy(x => x.TTS);
                foreach (var trans in list)
                {
                    runningtotal += trans.Amount.Value;
                    trans.RunningTotal = runningtotal;
                }
                db.SaveChanges();
            }
        }


        //ITEM TRANACTIONS OPERATIONS
        public static void DeleteAllItemTransactions(int _itemId, TT _TT = TT.FOO)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                Guid _guid = new Guid();
                List<ItemTransaction> _transactions = db.ItemTransactions.Where(x => x.ItemId == _itemId).ToList();
                foreach (ItemTransaction _transaction in _transactions)
                {
                    _guid = _transaction.GUID.Value;
                    db.ItemTransactions.RemoveRange((db.ItemTransactions.Where(x => x.GUID == _guid)));
                }

                db.SaveChanges();
                ItemsRunningTotals(_itemId);
            }
        }
        public static void InsertItemTransaction(
            int ItemId,
            int UnitId,
            decimal amount,
            TT OperationType,
            DateTime OperationDate,
            Guid OperationGUID,
            string Declaration)
        {
            using (dbEntities db = new DAL.dbEntities())
            {
                List<ItemTransaction> _transactions = db.ItemTransactions.Where(x =>
                                                                          x.ItemId == ItemId&&
                                                                          x.UnitId == UnitId
                                                                        ).ToList();
                decimal _sum = _transactions.Sum(x => x.Amount.Value); //Previous running total
                amount = Math.Abs(amount);
                switch (OperationType)
                {
                    case TT.BLB:
                        amount *= -1;
                        break;
                    case TT.BLS:
                        amount = amount;
                        break;
                    default:
                        break;
                }
                _sum += amount;
                ItemTransaction _transaction = new ItemTransaction()
                {
                    ItemId = ItemId,
                    UnitId = UnitId,
                    Amount = amount,
                    TT = OperationType.ToString(),
                    TTS = OperationDate,
                    GUID = OperationGUID,
                    RunningTotal = _sum,
                    Declaration = Declaration
                };
                db.Set<ItemTransaction>().Add(_transaction);
                db.SaveChanges();
                ItemsRunningTotals(ItemId, UnitId);
            }
        }
        public static void InsertItemOpeningBalance(ItemFund _fund, string _declaration)
        {
            int _sign = 1;
            //if (_fund.BalanceDirection == "لكم")
            //{
            //    _sign *= -1;
            //}
            decimal Amount = Math.Abs(_fund.Balance.Value) * _sign;
            using (dbEntities db=new dbEntities())
            {
                ItemTransaction _transaction = new ItemTransaction()
                {
                    ItemId = _fund.ItemId.Value,
                    UnitId = _fund.UnitId.Value,
                    Amount = _fund.Balance.Value,
                    TT = TT.OPN.ToString(),
                    TTS = DateTime.Now,
                    GUID = _fund.GUID.Value,
                    RunningTotal = _fund.Balance.Value,
                    Declaration = _fund.Declaration
                };
                db.Set<ItemTransaction>().Add(_transaction);
                db.SaveChanges();
            }
            ItemsRunningTotals(_fund.ItemId.Value, _fund.UnitId.Value);
        }
        public static void UpdateItemOpeningBalance(ItemFund _fund, decimal _amount)
        {
            using (dbEntities db = new dbEntities())
            {
                ItemTransaction _transaction = db.ItemTransactions.FirstOrDefault(x => x.GUID.Value == _fund.GUID.Value && x.TT == TT.OPN.ToString());
                int _sign = 1;
                //if (_fund.BalanceDirection == "لكم")
                //{
                //    _sign *= -1;
                //}
                _amount = Math.Abs(_fund.Balance.Value) * _sign;
                _transaction.Amount = _amount;
                db.SaveChanges();
                ItemsRunningTotals(_transaction.ItemId.Value, _transaction.UnitId.Value);
            }
        }



        //Client Transactions
        public static void RegenerateClientTransaction(ref dbEntities db, int accountId, int currencyId, decimal amount, TT OperationType, DateTime OperationDate, Guid OperationGUID, int ForeignCurrency = 0)
        {
            db.Transactions.Load();
            //GET ALL ITEM TRANSACTIONS TO DELETE IT
            List<Transaction> _baseTransactions = db.Transactions.Where(x =>
              x.GUID == OperationGUID
           ).ToList();
            //GET ALL CLIENT TRANSACTIONS EXCEPT ITEM'S TRANSACTIONS
            List<Transaction> _clientTransactions = db.Transactions.Where(x =>
              x.AccountId == accountId &&
              x.CurrencyId == currencyId
              && x.GUID != OperationGUID
            //DateTimeCompare.Compare(x.TTS.Value, OperationDate) == 1
            ).ToList();
            //GET OPENING BALANCE FOR THE CLIENT
            //decimal _initBalance = db.Accounts_Fund.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId).Balance.Value;
            decimal _initBalance = 0;
            Transaction _initTrans = db.Transactions.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == currencyId && x.TT == TT.OPN.ToString());
            if (_initTrans == null)
            {
                _initTrans = new Transaction();
            }
            else if (_initTrans.Amount != null)
            {
                _initBalance = _initTrans.Amount.Value;
            }
            //TODO MAY BE SUM MUST BE FOR THE TRANSACTIONS BEFORE THE CURRENT ITEM'S DATE
            //SUM ALL CLIENT TRANSACTIONS FOR THE SAKE OF CUT AND TRANSFER OPERATIONS
            decimal _sum = _initBalance;
            _sum += _clientTransactions.Sum(x => x.Amount.Value); //Previous running total
            switch (OperationType)
            {
                case TT.CTF:
                    if (_sum >= 0)
                    {
                        amount = amount * -1;
                    }
                    else if (_sum < 0)
                    {
#pragma warning disable CS1717 // Assignment made to same variable
                        amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                    }
                    break;
                case TT.CTT:
                    //Transfer_ClientFund _transfer = db.Transfer_ClientFund.FirstOrDefault(x => x.GUID == OperationGUID);
                    int _fromCurrency = ForeignCurrency;// db.Funds.FirstOrDefault(x => x.Id == _transfer.FundFrom.Value).CurrencyId.Value;
                    List<Transaction> _fromTransactions = db.Transactions.Where(x =>
                          x.AccountId == accountId &&
                          x.CurrencyId == _fromCurrency &&
                              DateTimeCompare.Compare(OperationDate, x.TTS.Value) == 1
                        ).ToList();
                    decimal _initFromBalance = db.AccountFunds.FirstOrDefault(x => x.AccountId == accountId && x.CurrencyId == _fromCurrency).Balance.Value;
                    decimal _fromSum = _initFromBalance;
                    _fromSum += _fromTransactions.Sum(x => x.Amount).Value;
                    if (_sum >= 0)
                    {
                        if (_fromSum <= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_fromSum > 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                    }
                    else if (_sum < 0)
                    {
                        if (_fromSum <= 0)
                        {
                            amount = amount * -1;
                        }
                        else if (_fromSum > 0)
                        {
#pragma warning disable CS1717 // Assignment made to same variable
                            amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                        }
                    }
                    else
                    {
                        amount = amount * -1;
                    }
                    break;
                case TT.TRF:
                case TT.DDT:
                case TT.DTF:
                case TT.LNF:
                case TT.WEO:
                case TT.ORT:
                case TT.OTD:
                case TT.PAY:
                    amount = amount * -1;
                    break;
                case TT.TRT:
                case TT.RFD:
                case TT.DTT:
                case TT.LNT:
                case TT.WEI:
                case TT.ORF:
                case TT.INC:
                case TT.PID:
#pragma warning disable CS1717 // Assignment made to same variable
                    amount = amount;
#pragma warning restore CS1717 // Assignment made to same variable
                    break;
                default:
                    break;
            }
            Transaction _transaction = new Transaction()
            {
                AccountId = accountId,
                CurrencyId = currencyId,
                Amount = amount,
                TT = OperationType.ToString(),
                TTS = OperationDate,
                GUID = OperationGUID
            };
            db.Transactions.Add(_transaction);
        }
        public static void ClientsRunningTotals(int accountId)
        {
            using (dbEntities db = new dbEntities())
            {
                decimal runningtotal = 0;
                var currencyid = db.Currencies.Select(x => x.Id);
                foreach (var currency in currencyid)
                {
                    runningtotal = 0;
                    var list = db.Transactions
                        .Where(x => x.AccountId == accountId && x.CurrencyId == currency);
                    foreach (var trans in list)
                    {
                        runningtotal += trans.Amount.Value;
                        trans.RunningTotal = runningtotal;
                    }
                }
                db.SaveChanges();
            }
        }
        public static void ClientsRunningTotals(int accountId, int currencyId)
        {
            using (dbEntities db = new dbEntities())
            {
                decimal runningtotal = 0;
                var list = db.Transactions
                    .Where(x => x.AccountId == accountId && x.CurrencyId == currencyId);
                foreach (var trans in list)
                {
                    runningtotal += trans.Amount.Value;
                    trans.RunningTotal = runningtotal;
                }
                db.SaveChanges();
            }
        }


        //Item Transactions
        public static void ItemsRunningTotals(int itemId)
        {
            using (dbEntities db = new dbEntities())
            {
                decimal runningtotal = 0;
                var units = db.Units.Select(x => x.Id);
                foreach (var unit in units)
                {
                    runningtotal = 0;
                    var list = db.ItemTransactions
                        .Where(x => x.ItemId == itemId && x.UnitId == unit);
                    foreach (var trans in list)
                    {
                        runningtotal += trans.Amount.Value;
                        trans.RunningTotal = runningtotal;
                    }
                }
                db.SaveChanges();
            }
        }
        public static void ItemsRunningTotals(int itemId, int unitId)
        {
            using (dbEntities db = new dbEntities())
            {
                decimal runningtotal = 0;
                var list = db.ItemTransactions
                    .Where(x => x.ItemId == itemId && x.UnitId == unitId);
                foreach (var trans in list)
                {
                    runningtotal += trans.Amount.Value;
                    trans.RunningTotal = runningtotal;
                }
                db.SaveChanges();
            }
        }
    }
}
