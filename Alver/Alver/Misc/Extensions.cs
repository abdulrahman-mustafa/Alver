using Alver.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.UI;
using System.Windows.Forms;

namespace Alver.MISC
{
    public static class ControlsExtensions
    {
        #region Clear Controls

        private static Dictionary<Type, Action<System.Windows.Forms.Control>> controldefaults = new Dictionary<Type, Action<System.Windows.Forms.Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(NumericUpDown), c => ((NumericUpDown)c).Value=((NumericUpDown)c).Minimum},
            {typeof(DataGridView), c => ((DataGridView)c).Refresh()},
            {typeof(DateTimePicker), c => ((DateTimePicker)c).Value=DateTime.Today},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()}
    };

        private static void FindAndInvoke(Type type, System.Windows.Forms.Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (System.Windows.Forms.Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        public static void ClearControls<T>(this System.Windows.Forms.Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (System.Windows.Forms.Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }
        }

        #endregion Clear Controls

        #region DataGridView Extensions

        public static DataTable ConvertToDatatable(this DataGridView dgv)
        {
            return (DataTable)dgv.DataSource;
        }

        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static void ColorizeStringDGVFullRow(this DataGridView dgv, int index, string _value)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (dgv.Rows[i].Cells[index].FormattedValue.ToString().Trim().ToLower().Equals(_value.Trim().ToLower()))
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void ColorizeDecimalDGVFullRow(this DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (decimal.Parse(dgv.Rows[i].Cells[index].FormattedValue.ToString()) < 0)
                    {
                        dgv.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void ColorizeDecimalDGVCell(this DataGridView dgv, int index)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (decimal.Parse(dgv.Rows[i].Cells[index].FormattedValue.ToString()) < 0)
                    {
                        dgv.Rows[i].Cells[index].Style.ForeColor = Color.Red;
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void ColorizeDecimalDGVCell(this DataGridView dgv)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 1; j < dgv.Columns.Count - 1; j++)
                    {
                        if (decimal.Parse(dgv.Rows[i].Cells[j].FormattedValue.ToString()) < 0)
                        {
                            dgv.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                        }
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void ColorizeDecimalDGVTwoCells(this DataGridView dgv, int index1, int index2)
        {
            try
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (decimal.Parse(dgv.Rows[i].Cells[index1].FormattedValue.ToString()) < 0)
                    {
                        dgv.Rows[i].Cells[index1].Style.ForeColor = Color.Red;
                    }
                    if (decimal.Parse(dgv.Rows[i].Cells[index2].FormattedValue.ToString()) < 0)
                    {
                        dgv.Rows[i].Cells[index2].Style.ForeColor = Color.Red;
                    }
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void copyAlltoClipboard(this DataGridView dgv)
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        public static void ExportToExcelViaHTML(this DataGridView dgv)
        {
            var dgvCounts = dgv.Rows.Count;

            StringBuilder html = new StringBuilder();
            html.Append("<table>");

            if (dgvCounts > 0)
            {
                //sets headers
                html.Append("<tr>");
                html.Append("<th> Name1 </th>");
                html.Append("<th> Name2 </th>");
                html.Append("<th> Name3 </th>");
                html.Append("<th> Name4 </th>");
                html.Append("<th> Name5 </th>");

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    html.Append("<tr>");
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        var cellcolor = cell.Style.BackColor;
                        html.AppendFormat("<td bgcolor = " + cellcolor.Name + ">{0}</td>", cell.Value);
                    }
                    html.Append("</tr>");
                }
            }
            html.Append("</table>");
            CopyHtmlToClipBoard(html.ToString());
        }

        public static void CopyHtmlToClipBoard(string html)
        {
            Encoding enc = Encoding.UTF8;

            string begin = "Version:0.9\r\nStartHTML:{0:000000}\r\nEndHTML:{1:000000}"
              + "\r\nStartFragment:{2:000000}\r\nEndFragment:{3:000000}\r\n";

            string html_begin = "<html>\r\n<head>\r\n"
              + "<meta http-equiv=\"Content-Type\""
              + " content=\"text/html; charset=" + enc.WebName + "\">\r\n"
              + "<title>HTML clipboard</title>\r\n</head>\r\n<body>\r\n"
              + "<!--StartFragment-->";

            string html_end = "<!--EndFragment-->\r\n</body>\r\n</html>\r\n";

            string begin_sample = String.Format(begin, 0, 0, 0, 0);

            int count_begin = enc.GetByteCount(begin_sample);
            int count_html_begin = enc.GetByteCount(html_begin);
            int count_html = enc.GetByteCount(html);
            int count_html_end = enc.GetByteCount(html_end);

            string html_total = String.Format(
              begin
              , count_begin
              , count_begin + count_html_begin + count_html + count_html_end
              , count_begin + count_html_begin
              , count_begin + count_html_begin + count_html
              ) + html_begin + html + html_end;

            DataObject obj = new DataObject();
            obj.SetData(DataFormats.Html, new MemoryStream(
              enc.GetBytes(html_total)));

            Clipboard.SetDataObject(obj, true);
        }

        public static void ExportToExcel(this DataGridView dgv)
        {
            try
            {
                dgv.copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex) { }
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
        }

        public static void ExportToPdf(this DataGridView dgv)
        {
            //Creating iTextSharp Misc Entries Table from the DataTable data
            PdfPTable miscTable = new PdfPTable(dgv.ColumnCount);
            miscTable.DefaultCell.Padding = 3;
            float[] miscWidthPosit = new float[] { 1000f, 200f };
            miscTable.WidthPercentage = 80;
            miscTable.SetWidths(miscWidthPosit);
            miscTable.HorizontalAlignment = Element.ALIGN_CENTER;
            miscTable.DefaultCell.BorderWidth = 1;
            miscTable.SpacingBefore = 10;
            miscTable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        miscTable.AddCell(cell.FormattedValue.ToString());
                    }
                }
            }
        }

        public static string ConvertDataGridViewToHTMLWithFormatting(this DataGridView dgv)
        {
            StringBuilder sb = new StringBuilder();
            //create html & table
            sb.AppendLine("<html><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            sb.AppendLine("<tr>");
            //create table header
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                sb.Append(DGVHeaderCellToHTMLWithFormatting(dgv, i));
                sb.Append(DGVCellFontAndValueToHTML(dgv.Columns[i].HeaderText, dgv.Columns[i].HeaderCell.Style.Font));
                sb.AppendLine("</td>");
            }
            sb.AppendLine("</tr>");
            //create table body
            for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
            {
                sb.AppendLine("<tr>");
                foreach (DataGridViewCell dgvc in dgv.Rows[rowIndex].Cells)
                {
                    sb.AppendLine(DGVCellToHTMLWithFormatting(dgv, rowIndex, dgvc.ColumnIndex));
                    string cellValue = dgvc.Value == null ? string.Empty : dgvc.Value.ToString();
                    sb.AppendLine(DGVCellFontAndValueToHTML(cellValue, dgvc.Style.Font));
                    sb.AppendLine("</td>");
                }
                sb.AppendLine("</tr>");
            }
            //table footer & end of html file
            sb.AppendLine("</table></center></body></html>");
            return sb.ToString();
        }

        //TODO: Add more cell styles described here: https://msdn.microsoft.com/en-us/library/1yef90x0(v=vs.110).aspx
        public static string DGVHeaderCellToHTMLWithFormatting(DataGridView dgv, int col)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td");
            sb.Append(DGVCellColorToHTML(dgv.Columns[col].HeaderCell.Style.ForeColor, dgv.Columns[col].HeaderCell.Style.BackColor));
            sb.Append(DGVCellAlignmentToHTML(dgv.Columns[col].HeaderCell.Style.Alignment));
            sb.Append(">");
            return sb.ToString();
        }

        public static string DGVCellToHTMLWithFormatting(DataGridView dgv, int row, int col)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td");
            sb.Append(DGVCellColorToHTML(dgv.Rows[row].Cells[col].Style.ForeColor, dgv.Rows[row].Cells[col].Style.BackColor));
            sb.Append(DGVCellAlignmentToHTML(dgv.Rows[row].Cells[col].Style.Alignment));
            sb.Append(">");
            return sb.ToString();
        }

        public static string DGVCellColorToHTML(Color foreColor, Color backColor)
        {
            if (foreColor.Name == "0" && backColor.Name == "0") return string.Empty;

            StringBuilder sb = new StringBuilder();
            sb.Append(" style=\"");
            if (foreColor.Name != "0" && backColor.Name != "0")
            {
                sb.Append("color:#");
                sb.Append(foreColor.R.ToString("X2") + foreColor.G.ToString("X2") + foreColor.B.ToString("X2"));
                sb.Append("; background-color:#");
                sb.Append(backColor.R.ToString("X2") + backColor.G.ToString("X2") + backColor.B.ToString("X2"));
            }
            else if (foreColor.Name != "0" && backColor.Name == "0")
            {
                sb.Append("color:#");
                sb.Append(foreColor.R.ToString("X2") + foreColor.G.ToString("X2") + foreColor.B.ToString("X2"));
            }
            else //if (foreColor.Name == "0" &&  backColor.Name != "0")
            {
                sb.Append("background-color:#");
                sb.Append(backColor.R.ToString("X2") + backColor.G.ToString("X2") + backColor.B.ToString("X2"));
            }

            sb.Append(";\"");
            return sb.ToString();
        }

        public static string DGVCellFontAndValueToHTML(string value, System.Drawing.Font font)
        {
            System.Drawing.Font _defualt = new System.Drawing.Font("segoe ui", 9, FontStyle.Regular);
            //If no font has been set then assume its the default as someone would be expected in HTML or Excel
            if (font == null || font == _defualt && !(font.Bold | font.Italic | font.Underline | font.Strikeout)) return value;
            StringBuilder sb = new StringBuilder();
            sb.Append(" ");
            if (font.Bold) sb.Append("<b>");
            if (font.Italic) sb.Append("<i>");
            if (font.Strikeout) sb.Append("<strike>");

            //The <u> element was deprecated in HTML 4.01. The new HTML 5 tag is: text-decoration: underline
            if (font.Underline) sb.Append("<u>");

            string size = string.Empty;
            if (font.Size != _defualt.Size) size = "font-size: " + font.Size + "pt;";

            //The <font> tag is not supported in HTML5. Use CSS or a span instead.
            if (font.FontFamily.Name != _defualt.Name)
            {
                sb.Append("<span style=\"font-family: ");
                sb.Append(font.FontFamily.Name);
                sb.Append("; ");
                sb.Append(size);
                sb.Append("\">");
            }
            sb.Append(value);
            if (font.FontFamily.Name != _defualt.Name) sb.Append("</span>");

            if (font.Underline) sb.Append("</u>");
            if (font.Strikeout) sb.Append("</strike>");
            if (font.Italic) sb.Append("</i>");
            if (font.Bold) sb.Append("</b>");

            return sb.ToString();
        }

        public static string DGVCellAlignmentToHTML(DataGridViewContentAlignment align)
        {
            if (align == DataGridViewContentAlignment.NotSet) return string.Empty;

            string horizontalAlignment = string.Empty;
            string verticalAlignment = string.Empty;
            CellAlignment(align, ref horizontalAlignment, ref verticalAlignment);
            StringBuilder sb = new StringBuilder();
            sb.Append(" align='");
            sb.Append(horizontalAlignment);
            sb.Append("' valign='");
            sb.Append(verticalAlignment);
            sb.Append("'");
            return sb.ToString();
        }

        public static void CellAlignment(DataGridViewContentAlignment align, ref string horizontalAlignment, ref string verticalAlignment)
        {
            switch (align)
            {
                case DataGridViewContentAlignment.MiddleRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "middle";
                    break;

                case DataGridViewContentAlignment.MiddleLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;

                case DataGridViewContentAlignment.MiddleCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "middle";
                    break;

                case DataGridViewContentAlignment.TopCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "top";
                    break;

                case DataGridViewContentAlignment.BottomCenter:
                    horizontalAlignment = "centre";
                    verticalAlignment = "bottom";
                    break;

                case DataGridViewContentAlignment.TopLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "top";
                    break;

                case DataGridViewContentAlignment.BottomLeft:
                    horizontalAlignment = "left";
                    verticalAlignment = "bottom";
                    break;

                case DataGridViewContentAlignment.TopRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "top";
                    break;

                case DataGridViewContentAlignment.BottomRight:
                    horizontalAlignment = "right";
                    verticalAlignment = "bottom";
                    break;

                default: //DataGridViewContentAlignment.NotSet
                    horizontalAlignment = "left";
                    verticalAlignment = "middle";
                    break;
            }
        }

        public static decimal ColumnSum(this DataGridView dgv, int _valueIndex, int _currencyIndex)
        {
            using (dbEntities db = new dbEntities(0))
            {
                int _index = 0;
                int CURRENCIESCOUNT = db.Currencies.Count();
                decimal[] _total = new decimal[CURRENCIESCOUNT];
                foreach (var item in db.Currencies)
                {
                    _index = item.Id;
                    _total[_index - 1] = dgv.Rows.Cast<DataGridViewRow>()
                        .Where(x => Convert.ToInt32(x.Cells[_currencyIndex].Value) == _index)
                        .Sum(t => Convert.ToDecimal(t.Cells[_valueIndex].Value));
                }

#pragma warning disable CS0219 // The variable '_sum' is assigned but its value is never used
                decimal _sum = 0;
#pragma warning restore CS0219 // The variable '_sum' is assigned but its value is never used
                decimal _grand = 0;
                decimal _USD = 0, _SYP = 0, _TL = 0, _EURO = 0, _SAR = 0;
                try
                {
                    _USD = 1;
                    _SYP = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 2).Rate.Value;
                    _TL = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 3).Rate.Value;
                    _EURO = db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 4).Rate.Value;
                    _SAR = 1 / db.CurrencyBulletins.OrderByDescending(x => x.RateDate).First(x => x.CurrencyId == 5).Rate.Value;

                    _USD = _USD * _total[0];
                    _SYP = _SYP * _total[0];
                    _TL = _TL * _total[0];
                    _EURO = _EURO * _total[0];
                    _SAR = _SAR * _total[0];

                    _grand = _USD + _SYP + _TL + _EURO + _SAR;
                }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
                {
                    //MSGs.ErrorMessage(ex);
                }
                return _grand;
            }
        }

        public static decimal ColumnSum(this DataGridView dgv, int _index)
        {
            decimal _sum = 0;
            _sum = dgv.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDecimal(t.Cells[_index].Value));
            return _sum;
        }

        public static DataTable TotalsDGV(this DataGridView dgv, int _currencyIndex, int _amountIndex)
        {
            DataTable dt = new DataTable();
            using (dbEntities db = new dbEntities(0))
            {
                int _index = 0;
                int CURRENCIESCOUNT = db.Currencies.Count();
                decimal[] _total = new decimal[CURRENCIESCOUNT];
                dt.Clear();
                foreach (var item in db.Currencies)
                {
                    dt.Columns.Add(item.CurrencySymbol);
                    _index = item.Id;
                    _total[_index - 1] = dgv.Rows.Cast<DataGridViewRow>()
                        .Where(x => Convert.ToInt32(x.Cells[_currencyIndex].Value) == _index)
                        .Sum(t => Convert.ToDecimal(t.Cells[_amountIndex].Value));
                }
                dt.Rows.Add(new object[] { _total[0], _total[1], _total[2], _total[3], _total[4] });
                //dt.Columns.Add("$");
                //dt.Columns.Add("SYP");
                //dt.Columns.Add("TL");
                //dt.Columns.Add("EUR");
                //dt.Columns.Add("SAR");
                //for (int i = 1; i < CURRENCIESCOUNT; i++)
                //{
                //    _total[i] = dgv.Rows.Cast<DataGridViewRow>()
                //        .Where(x => Convert.ToInt32(x.Cells[_currencyIndex].Value) == i)
                //        .Sum(t => Convert.ToDecimal(t.Cells[_amountIndex].Value));
                //}
            }
            return dt;
        }

        public static DataTable POSTotalsDGV(this DataGridView dgv, int _itemsCount, int _sumQuantity, decimal _sumPrices, decimal _sumTotals)
        {
            DataTable dt = new DataTable();
            int _index = 0;
            int COLUMNSCOUNT = 5;
            decimal[] _total = new decimal[COLUMNSCOUNT];
            dt.Clear();
            dt.Columns.Add("عدد الأقلام");
            dt.Columns.Add("");
            dt.Columns.Add("مجموع الكميات");
            dt.Columns.Add("اجمالي السعر");
            dt.Columns.Add("الاجمالي الكلي");
            _total[0] = _itemsCount;
            //_total[1] = "";
            _total[2] = _sumQuantity;
            _total[3] = _sumPrices;
            _total[4] = _sumTotals;
            dt.Rows.Add(new object[] { _total[0], "", _total[2], _total[3], _total[4] });
            return dt;
        }

        public static DataTable OverviewTotalsDGV(this DataGridView dgv)
        {
            DataTable dt = new DataTable();
            using (dbEntities db = new dbEntities(0))
            {
                int _index = 0;
                int CURRENCIESCOUNT = db.Currencies.Count();
                decimal[] _total = new decimal[CURRENCIESCOUNT];
                dt.Clear();
                foreach (var item in db.Currencies)
                {
                    dt.Columns.Add(item.CurrencySymbol);
                    _index = item.Id + 1;
                    _total[_index - 2] = dgv.Rows.Cast<DataGridViewRow>()
                        .Sum(t => Convert.ToDecimal(t.Cells[_index].Value));
                }
                dt.Rows.Add(new object[] { _total[0], _total[1], _total[2], _total[3], _total[4] });
            }
            return dt;
        }

        public static void EXPXLS(this DataGridView dgv, string ReportName, string ReportHeader, string _decimalPlaces = "1", string _firstTitle = "", string _secondTitle = "", string Head1 = "", string Head2 = "", string Head3 = "")
        {
            DataGridView dgvDetails = CopyDataGridView(dgv);

            // creating Excel Application
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet
            worksheet.Name = ReportName;
            //// Inserting Company Details
            string strColumnAlphabet = GetColumnAlphabet(dgvDetails.Columns.Count); // ((char)(dgvDetails.Columns.Count + 64)).ToStringCustom();
            worksheet.Cells[1, 1] = _firstTitle;
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range["A1:" + strColumnAlphabet + "1"].Merge();

            worksheet.Cells[2, 1] = _secondTitle;
            worksheet.Cells[2, 1].Font.Bold = true;
            worksheet.Cells[2, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range["A2:" + strColumnAlphabet + "2"].Merge();

            worksheet.Cells[3, 1] = "";
            worksheet.Range["A3:" + strColumnAlphabet + "3"].Merge();

            worksheet.Cells[4, 1] = ReportName;
            worksheet.Cells[4, 1].Font.Bold = true;
            worksheet.Cells[4, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range["A4:" + strColumnAlphabet + "4"].Merge();

            worksheet.Cells[5, 1] = ReportHeader;
            worksheet.Cells[5, 1].Font.Bold = true;
            worksheet.Range["A5:" + strColumnAlphabet + "5"].Merge();

            worksheet.Cells[6, 1] = "";
            worksheet.Range["A6:" + strColumnAlphabet + "6"].Merge();

            int RowIndex = 7;

            if (Head1 != string.Empty)
            {
                worksheet.Cells[RowIndex, 1] = Head1;
                worksheet.Cells[RowIndex, 1].Font.Bold = true;
                worksheet.Range["A" + RowIndex + ":" + strColumnAlphabet + RowIndex.ToString()].Merge();
                RowIndex = RowIndex + 1;
            }

            if (Head2 != string.Empty)
            {
                worksheet.Cells[RowIndex, 1] = Head2;
                worksheet.Cells[RowIndex, 1].Font.Bold = true;
                worksheet.Range["A" + RowIndex + ":" + strColumnAlphabet + RowIndex.ToString()].Merge();
                RowIndex = RowIndex + 1;
            }

            if (Head3 != string.Empty)
            {
                worksheet.Cells[RowIndex, 1] = Head3;
                worksheet.Cells[RowIndex, 1].Font.Bold = true;
                worksheet.Range["A" + RowIndex + ":" + strColumnAlphabet + RowIndex.ToString()].Merge();
                RowIndex = RowIndex + 1;
            }

            if (RowIndex > 7)
                RowIndex = RowIndex + 1;

            // storing header part in Excel
            for (int i = 1; i < dgvDetails.Columns.Count + 1; i++)
            {
                worksheet.Cells[RowIndex, i] = dgvDetails.Columns[i - 1].HeaderText;
                worksheet.Cells[RowIndex, i].Font.Bold = true;
            }

            RowIndex = RowIndex + 2;
            // storing Each row and column value to excel sheet
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                int _groupId = 0;
                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                {
                    //if (dgvDetails.Columns[j].Name.ToLower().Contains("id"))
                    //{
                    //    worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                    //    worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "@";
                    //    worksheet.Cells[i + RowIndex, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    //}
                    //else
                    if (dgvDetails.Columns[j].Name.ToLower().Contains("Date") && dgvDetails.Rows[i].Cells[j].Value.ToString() != string.Empty)
                    {
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "@";
                        worksheet.Cells[i + RowIndex, j + 1] = ReportName == "B2B" ? dgvDetails.Rows[i].Cells[j].Value.ToString() : dgvDetails.Rows[i].Cells[j].Value.ToString();//.ToDateTime().ToShortDateString();
                    }
                    else if (dgvDetails.Columns[j].Name.ToLower().Contains("balance"))
                    {
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (
                        (dgvDetails.Columns[j].Name.ToLower().Contains("currency")
                        || dgvDetails.Columns[j].Name.ToLower().Contains("currencies"))
                        && int.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out _groupId))
                    {
                        string _currencyName = "";
                        using (dbEntities db = new dbEntities(0))
                        {
                            _currencyName = db.Currencies.Find(_groupId).CurrencyName;
                        }
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = _currencyName;// dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (
                        dgvDetails.Columns[j].Name.ToLower().Contains("itemcategory")
                        && (int.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out _groupId)))
                    {
                        string _categoryName = "";
                        using (dbEntities db = new dbEntities(0))
                        {
                            _categoryName = db.ItemCategories.Find(_groupId).Title;
                        }
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = _categoryName;// dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (
                        dgvDetails.Columns[j].Name.ToLower().Contains("unit")
                        && (int.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out _groupId)))
                    {
                        string _unitName = "";
                        using (dbEntities db = new dbEntities(0))
                        {
                            _unitName = db.Units.Find(_groupId).Title;
                        }
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = _unitName;// dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (
                        dgvDetails.Columns[j].Name.ToLower().Contains("accountgroup")
                        && (int.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out _groupId)))
                    {
                        string _groupName = "";
                        using (dbEntities db = new dbEntities(0))
                        {
                            _groupName = db.AccountGroups.Find(_groupId).GroupTitle;
                        }
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = _groupName;// dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (
                        dgvDetails.Columns[j].Name.ToLower().Contains("expensecategory")
                        && (int.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out _groupId)))
                    {
                        string _groupName = "";
                        using (dbEntities db = new dbEntities(0))
                        {
                            _groupName = db.ExpenseCategories.Find(_groupId).Title;
                        }
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = _groupName;// dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        decimal value;

                        if (Decimal.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out value))
                        {
                            if (dgvDetails.Columns[j].Name.ToLower().Contains("qty") || dgvDetails.Columns[j].Name.ToLower().Contains("quantity") ||
                                dgvDetails.Columns[j].Name.ToLower().Contains("stock"))
                            {
                                if (value == 0)
                                    worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.000";
                                else
                                    worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.000";
                            }
                            else
                            {
                                switch (_decimalPlaces)//ClsCommonSettings.DecimalPlaces)
                                {
                                    case "0":
                                        if (value == 0)
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################";
                                        break;

                                    case "1":
                                        if (value == 0)
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.0";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.0";
                                        break;

                                    case "2":
                                        if (value == 0)
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.00";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.00";
                                        break;

                                    case "3":
                                        if (value == 0)
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.000";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.000";
                                        break;

                                    case "4":
                                        if (value == 0)
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.0000";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.0000";
                                        break;
                                }
                            }

                            worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        }
                        else if (dgvDetails.Columns[j].Name == "ExpenseAmt" || dgvDetails.Columns[j].Name == "IncomeAmt" ||
                            dgvDetails.Columns[j].Name == "LiabilityAmt" || dgvDetails.Columns[j].Name == "AssetAmt")
                        {
                            if (dgvDetails.Rows[i].Cells[j].Value.ToString().Contains("("))
                            {
                                worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "@";
                                worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                            }
                        }

                        worksheet.Cells[i + RowIndex, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            // Auto fit columns
            worksheet.Columns.AutoFit();
            worksheet.PageSetup.TopMargin = 0.75;
            worksheet.PageSetup.LeftMargin = 0.25;
            worksheet.PageSetup.RightMargin = 0.25;
            worksheet.PageSetup.BottomMargin = 0.75;
            worksheet.PageSetup.CenterHorizontally = true;
            worksheet.PageSetup.PrintGridlines = true;
            // Exit from the application
            app.Quit();
        }

        public static string GetColumnAlphabet(int ColumnCount)
        {
            if (ColumnCount > 0 && ColumnCount < 27)
                return ((char)(ColumnCount + 64)).ToString();
            else
                return "A" + ((char)((ColumnCount - 26) + 64)).ToString();
        }

        public static DataGridView CopyDataGridView(DataGridView dgv)
        {
            DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_copy.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv.Columns)
                    {
                        if (dgvc.Visible)
                            dgv_copy.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    int intColIndex = 0;
                    dgv_copy.Rows.Add();

                    foreach (DataGridViewCell cell in dgv.Rows[i].Cells)
                    {
                        if (cell.Visible)
                        {
                            dgv_copy.Rows[i].Cells[intColIndex].Value = cell.Value;
                            intColIndex++;
                        }
                    }
                }

                dgv_copy.AllowUserToAddRows = false;
                dgv_copy.Refresh();
            }
            catch { }

            return dgv_copy;
        }

        public static void ExportToPDF(this DataGridView dgv)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    try
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                    catch { }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public static void EXPDF(this DataGridView dgv)
        {
        }

        #endregion DataGridView Extensions

        #region Images

        public static byte[] imageToByteArray(this System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
            else
            {
                return null;
            }
        }

        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn.Length > 0)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                return returnImage;
            }
            else
            {
                return null;
            }
        }

        #endregion Images
    }
}