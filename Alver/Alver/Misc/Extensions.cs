using Alver.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Alver.Misc
{
    public static class Extensions
    {
        #region Clear Controls
        private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() {
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

        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }

        }
        #endregion

        #region DataGridView Extensions
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
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
            catch (Exception ex) { }
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
            catch (Exception ex) { }
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
            catch (Exception ex) { }
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
            catch (Exception ex) { }
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
            catch (Exception ex) { }
        }
        public static void ExportToPdf(this DataGridView dgv)
        {
            //Creating iTextSharp Misc Entries Table from the DataTable data
            //PdfPTable miscTable = new PdfPTable(dgv.ColumnCount);
            //miscTable.DefaultCell.Padding = 3;
            //float[] miscWidthPosit = new float[] { 1000f, 200f };
            //miscTable.WidthPercentage = 80;
            //miscTable.SetWidths(miscWidthPosit);
            //miscTable.HorizontalAlignment = Element.ALIGN_CENTER;
            //miscTable.DefaultCell.BorderWidth = 1;
            //miscTable.SpacingBefore = 10;
            //miscTable.DefaultCell.HorizontalAlignment = Element.ALIGN_LEFT;

            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        if (cell.Value != null)
            //        {
            //            miscTable.AddCell(cell.FormattedValue.ToString());
            //        }
            //    }
            //}
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
        public static string DGVCellFontAndValueToHTML(string value, Font font)
        {
            Font _defualt = new Font("segoe ui", 9, FontStyle.Regular);
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
            using (dbEntities db = new dbEntities())
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
        public static DataTable OverviewTotalsDGV(this DataGridView dgv)
        {
            DataTable dt = new DataTable();
            using (dbEntities db = new dbEntities())
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
        #endregion

        #region Images
        public static byte[] imageToByteArray(this System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }
        #endregion
    }
}
