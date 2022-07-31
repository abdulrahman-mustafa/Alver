using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alver.MISC.Utilities;

namespace Alver.MISC
{
    public static class BillsFuncs
    {
        public static int BillsCount()
        {
            int _result = 0;
            _result = (new dbEntities(0)).Bills.Count();
            return _result;
        }
        public static int PurchaseBillsCount()
        {
            int _result = 0;
            _result = (new dbEntities(0)).Bills.Where(x => x.BillType == BillType.شراء.ToString()).Count();
            return _result;
        }
            public static bool CheckRecords()
        {
            bool _result = true;
            using (dbEntities db = new dbEntities(0))
            {
                if (db.Items.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة مواد بعد، لا يمكنك إضافة فاتورة");
                    _result = false;
                }
                else if (db.Currencies.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة عملات بعد، لا يمكنك اضافة فاتورة");
                    _result = false;
                }
                else if (db.Accounts.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة وكلاء او زبائن بعد، لا يمكنك إضافة فاتورة");
                    _result = false;
                }
                else if (db.CurrencyBulletins.Count() < 1)
                {
                    MessageBox.Show("لم يتم إضافة اسعار الصرف بعد، لا يمكنك إضافة فاتورة");
                    _result = false;
                }
            }
            return _result;
        }
        public static void DeleteBillLine(Guid _guid)
        {
            try
            {
                //Delete transaction
                TransactionsFuncs.DeleteTransactions(_guid);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ اثناء حذف الحركة");
            }
        }

        public static void DeleteBillLine(BillLine _operation)
        {
            try
            {
                if (_operation != null && _operation.Id != 0)
                {
                    //Delete transaction
                    TransactionsFuncs.DeleteTransactions(_operation.GUID.Value);
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حدث خطأ اثناء حذف الحركة");
            }
        }

        public static void DeleteBill(int _billId)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    Bill _bill = db.Bills.Find(_billId);
                    if (_bill != null && _bill.Id != 0)
                    {
                        foreach (var item in _bill.BillLines)
                        {
                            DeleteBillLine(item);
                        }
                        TransactionsFuncs.DeleteTransactions(_bill.GUID.Value);
                        //_ex.CurrencyExchangeOperations.
                        db.BillLines.RemoveRange(_bill.BillLines);
                        db.Bills.Remove(_bill);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("تم حذف العملية بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء حذف الفاتورة ،لم يتم الحذف بنجاح", "حذف فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteAccountBills(int _accountId)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    List<Bill> _bills = db.Bills.Where(x => x.AccountId == _accountId).ToList();

                    for (int i = 1; i <= _bills.Count; i++)
                    {
                        var _bill = _bills[i];
                        if (_bill != null && _bill.Id != 0)
                        {
                            foreach (var item in _bill.BillLines)
                            {
                                DeleteBillLine(item);
                            }
                            TransactionsFuncs.DeleteTransactions(_bill.GUID.Value);
                            //_ex.CurrencyExchangeOperations.
                            db.BillLines.RemoveRange(_bill.BillLines);
                            db.Bills.Remove(_bill);
                        }
                    }
                    db.SaveChanges();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء حذف الفواتير ،لم يتم الحذف بنجاح", "حذف فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteItemBills(int _itemId)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    List<BillLine> _billLines = db.BillLines.Where(x => x.ItemId == _itemId).ToList();
                    List<int> _billsIds = new List<int>();
                    List<Bill> _bills = db.Bills.Where(x => x.AccountId == _itemId).ToList();

                    for (int i = 1; i <= _bills.Count; i++)
                    {
                        var _bill = _bills[i];
                        if (_bill != null && _bill.Id != 0)
                        {
                            foreach (var item in _bill.BillLines)
                            {
                                DeleteBillLine(item);
                            }
                            TransactionsFuncs.DeleteTransactions(_bill.GUID.Value);
                            //_ex.CurrencyExchangeOperations.
                            db.BillLines.RemoveRange(_bill.BillLines);
                            db.Bills.Remove(_bill);
                        }
                    }
                    db.SaveChanges();
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {
                MessageBox.Show("حصل خطأ أثناء حذف الفواتير ،لم يتم الحذف بنجاح", "حذف فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void InitTransactions(int _accId, int _currencyId, decimal _amount, string _declaration,DateTime _date,Guid _guid)
        {
                TransactionsFuncs.InsertClientTransaction(_accId, _currencyId, _amount, TransactionsFuncs.TT.PAY, _date, _guid, _declaration);
                TransactionsFuncs.InsertFundTransaction(_currencyId, _amount, TransactionsFuncs.TT.PYI, _date, _guid, _declaration);
        }
        public static void CashoutBill(int _billId)
        {
            try
            {
                using (dbEntities db = new dbEntities(0))
                {
                    Bill _bill = db.Bills.Find(_billId);
                    _bill.Cashout= true;
                    _bill.CheckedOut = true;
                    if (_bill != null && _bill.Id != 0)
                    {
                        int _accountId = _bill.AccountId.Value;
                        string _account = db.Accounts.Find(_accountId).FullName;
                        int _currencyId = _bill.CurrencyId.Value;
                        decimal _billTotalAmount = _bill.TotalAmount.Value;
                        bool _payed = true;
                        bool _locked = false;
                        Guid _guid = Guid.NewGuid();
                        
                        Payment _payment = new Payment()
                        {
                            PaymentType = MISC.Utilities.PaymentType.دفعة_من_وكيل.ToString(),
                            PaymentDate = DateTime.Now,
                            CurrencyId = _currencyId,
                            Amount = _billTotalAmount,
                            Declaration = "",
                            AccountId = _accountId,
                            Locked = _locked,
                            LUD = DateTime.Now,
                            Payed = _payed,
                            UserId = Properties.Settings.Default.LoggedInUser.Id,
                            Flag = string.Empty,
                            Hidden = false,
                            GUID = _guid,
                            PROTECTED = false
                        };
                        db.Set<Payment>().Add(_payment);
                        db.SaveChanges();

                        string _declaration = "دفعة لقاء فاتورة آجلة رقم الفاتورة: " + _billId.ToString() + " - " + string.Format("{0} الوكيل: {1} {2}",
                            _payment.PaymentType.ToString(),
                            _account,
                            _payment.Declaration);
                        _payment.Declaration = _declaration;
                        db.SaveChanges();
                        InitTransactions(_accountId, _currencyId, _billTotalAmount, _declaration, DateTime.Now, _guid);
                        MessageBox.Show("تم الحفظ بنجاح");
                    }
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
        }
    }
}