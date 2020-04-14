using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.MISC
{
    public class BillsFuncs
    {
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
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
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
    }
}