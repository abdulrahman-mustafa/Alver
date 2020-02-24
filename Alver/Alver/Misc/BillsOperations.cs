﻿using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alver.Misc
{
    public class BillsOperations
    {
        public static void DeleteBillLine(BillLine _operation)
        {
            try
            {
                if (_operation != null && _operation.Id != 0)
                {
                    //Delete transaction
                    TransactionsOperations.DeleteTransactions(_operation.GUID.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ اثناء حذف الحركة");
            }
        }
        public static void DeleteBill(int _billId)
        {
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    Bill _bill = db.Bills.Find(_billId);
                    if (_bill != null && _bill.Id != 0)
                    {
                        foreach (var item in _bill.BillLines)
                        {
                            DeleteBillLine(item);
                        }
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
                using (dbEntities db = new dbEntities())
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
                            TransactionsOperations.DeleteTransactions(_bill.GUID.Value);
                            //_ex.CurrencyExchangeOperations.
                            db.BillLines.RemoveRange(_bill.BillLines);
                            db.Bills.Remove(_bill);
                        }
                    }
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حصل خطأ أثناء حذف الفواتير ،لم يتم الحذف بنجاح", "حذف فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
