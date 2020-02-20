using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alver.Misc
{
    public static class DateTimeCompare
    {
        public static DateTime BaseDate { get; set; }
        public static DateTime SubDate { get; set; }

        //public DateTimeCompare(DateTime _fromDate, DateTime _toDate)
        //{
        //    FromDate = _fromDate;
        //    ToDate = _toDate;
        //}

        public static int Compare(DateTime _baseDate, DateTime _subDate)
        {
            int _result = 0;
            BaseDate = _baseDate;
            SubDate = _subDate;
            try
            {
                double _DIFF = SubDate.Subtract(BaseDate).TotalSeconds;
                if (_DIFF > 0)
                {
                    _result = 1;
                }
                else if (_DIFF < 0)
                {
                    _result = -1;
                }
                else
                {
                    _result = 0;
                }
                //if (FromDate.Year == ToDate.Year)
                //    if (FromDate.Month == ToDate.Month)
                //        if (FromDate.Day == ToDate.Day)
                //            if (FromDate.Hour == ToDate.Hour)
                //                if (FromDate.Minute == ToDate.Minute) { }
            }
            catch (Exception ex)
            { }
            return _result;// 0 = Equal - 1 = FromDate is greater - -1 = FromDate is less than
        }
    }
}
