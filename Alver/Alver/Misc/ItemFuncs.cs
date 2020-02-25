using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alver.Misc
{
    public static class ItemFuncs
    {
        public static decimal ItemQauantity(int ItemId)
        {
            decimal _quantity = 0;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _quantity = db.ItemTransactions.Where(x => x.Id == ItemId).Sum(x => x.Amount.Value);
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _quantity;
        }
        public static decimal ItemQauantity(int ItemId,int UnitId)
        {
            decimal _quantity = 0;
            try
            {
                using (dbEntities db = new dbEntities())
                {
                    _quantity = db.ItemTransactions.Where(x => x.Id == ItemId && x.UnitId== UnitId).Sum(x => x.Amount.Value);
                }
            }
            catch (Exception ex)
            {
                MSGs.ErrorMessage(ex);
            }
            return _quantity;
        }
    }
}
