using Microsoft.Office.Interop.Excel;
using Microsoft.Reporting.WinForms;

//using Microsoft.Reporting.WinForms;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Alver.MISC
{
    public static class Exporter
    {
        public static SaveFileDialog sfd = new SaveFileDialog();

        /// <summary>
        /// Exports the datagridview values to Excel.
        /// </summary>
        public static void ExportToExcel(System.Windows.Forms.DataGridView DGV, string WorksheetName)
        {
            if (DGV == null)
                return;
            // Creating a Excel object.
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {
                worksheet = workbook.ActiveSheet;
                if (string.IsNullOrWhiteSpace(WorksheetName))
                {
                    worksheet.Name = "ExportedFromDatGrid";
                }
                else
                {
                    worksheet.Name = WorksheetName;
                }

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column.
                for (int i = 0; i < DGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < DGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check.
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = DGV.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user.
                System.Windows.Forms.SaveFileDialog saveDialog = new System.Windows.Forms.SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    System.Windows.Forms.MessageBox.Show("تم التصدير بنجاح");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
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

        public static void SavePDF(ReportViewer viewer)
        {
            sfd.DefaultExt = "pdf";
            sfd.AddExtension = true;
            sfd.Filter = "PDF File (.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");
                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }
                MessageBox.Show(sfd.FileName + " تم الحفظ بنجاح");
            }
        }

        public static void SaveExcel(ReportViewer viewer)
        {
            sfd.DefaultExt = "xlsx";
            sfd.AddExtension = true;
            sfd.Filter = "Excel File (.xlsx)|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] Bytes = viewer.LocalReport.Render(format: "EXCELOPENXML", deviceInfo: "");

                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }
                MessageBox.Show(sfd.FileName + " تم الحفظ بنجاح");
            }
        }

        public static void SaveWord(ReportViewer viewer)
        {
            sfd.DefaultExt = "docx";
            sfd.AddExtension = true;
            sfd.Filter = "Word File (.docx)|*.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                byte[] Bytes = viewer.LocalReport.Render(format: "WORDOPENXML", deviceInfo: "");

                using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                {
                    stream.Write(Bytes, 0, Bytes.Length);
                }
                MessageBox.Show(sfd.FileName + " تم الحفظ بنجاح");
            }
        }

        public static void EXPXLS(DataGridView dgv, string ReportName, string ReportHeader, string Head1 = "", string Head2 = "", string Head3 = "")
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
            worksheet.Cells[1, 1] = "ClsCommonSettings.GlobalCompany";
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range["A1:" + strColumnAlphabet + "1"].Merge();

            worksheet.Cells[2, 1] = "GSTIN : " + "ClsCommonSettings.CompanyTINNo" + ", " + "ClsCommonSettings.CompanyAddress";
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
                for (int j = 0; j < dgvDetails.Columns.Count; j++)
                {
                    if (dgvDetails.Columns[j].Name.Contains("BillNo") || dgvDetails.Columns[j].Name.Contains("GSTIN") || dgvDetails.Columns[j].Name.Contains("InvoiceNo") ||
                        dgvDetails.Columns[j].Name.Contains("HSN") || dgvDetails.Columns[j].Name.Contains("Description") || dgvDetails.Columns[j].Name.Contains("TinNo") ||
                        dgvDetails.Columns[j].Name.Contains("SlNo"))
                    {
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "@";
                        worksheet.Cells[i + RowIndex, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (dgvDetails.Columns[j].Name.Contains("Date") && dgvDetails.Rows[i].Cells[j].Value.ToString() != string.Empty)
                    {
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "@";
                        worksheet.Cells[i + RowIndex, j + 1] = ReportName == "B2B" ? dgvDetails.Rows[i].Cells[j].Value.ToString() : dgvDetails.Rows[i].Cells[j].Value.ToString();//.ToDateTime().ToShortDateString();
                    }
                    else if (dgvDetails.Columns[j].Name == "Balance")
                    {
                        worksheet.Cells[i + RowIndex, j + 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                        worksheet.Cells[i + RowIndex, j + 1] = dgvDetails.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        decimal value;

                        if (Decimal.TryParse(dgvDetails.Rows[i].Cells[j].Value.ToString(), out value))
                        {
                            if (dgvDetails.Columns[j].Name.Contains("Qty") || dgvDetails.Columns[j].Name.Contains("Quantity") ||
                                dgvDetails.Columns[j].Name.Contains("Stock"))
                            {
                                if (value == 0)
                                    worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.000";
                                else
                                    worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.000";
                            }
                            else
                            {
                                switch ("2")//ClsCommonSettings.DecimalPlaces)
                                {
                                    case "1":
#pragma warning disable CS0162 // Unreachable code detected
                                        if (value == 0)
#pragma warning restore CS0162 // Unreachable code detected
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
#pragma warning disable CS0162 // Unreachable code detected
                                        if (value == 0)
#pragma warning restore CS0162 // Unreachable code detected
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "0.000";
                                        else
                                            worksheet.Cells[i + RowIndex, j + 1].NumberFormat = "###################.000";
                                        break;

                                    case "4":
#pragma warning disable CS0162 // Unreachable code detected
                                        if (value == 0)
#pragma warning restore CS0162 // Unreachable code detected
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

        public static void DataGridView2Excel(DataGridView datagridview)
        {
            object missing = System.Reflection.Missing.Value;
            int nRowCount = datagridview.Rows.Count;
            int nDispalyColumnCount = 0;
            for (int i = 0; i <= datagridview.ColumnCount - 1; i++)
            {
                if (datagridview.Columns[i].Visible == true)
                {
                    nDispalyColumnCount++;
                }
            }

            if (nRowCount <= 0 || nDispalyColumnCount <= 0 || nDispalyColumnCount > 255) return;
            Microsoft.Office.Interop.Excel.Application objExcel = null;
            Workbook workbook = null;
            Worksheet worksheet = null;
            try
            {
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                workbook = objExcel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                worksheet = (Worksheet)workbook.Worksheets[1];//取得sheet1

                if (nRowCount > 65535)
                {
                    long pageRows = 60000;//定义每页显示的行数
                    int pageCount = (int)(nRowCount / pageRows);
                    if (pageCount * pageRows < nRowCount)//当总行数不被pageRows整除时，经过四舍五入可能页数不准
                    {
                        pageCount = pageCount + 1;
                    }
                    for (int sc = 1; sc <= pageCount; sc++)
                    {
                        if (sc > 1)
                        {
                            worksheet = (Worksheet)workbook.Worksheets.Add(missing, missing, missing, missing);//添加一个sheet
                        }
                        else
                        {
                            worksheet = (Worksheet)workbook.Worksheets[sc];//取得sheet1
                        }
                        string[,] datas = new string[pageRows + 1, nDispalyColumnCount + 1];
                        int displayColumnsCount = 1;
                        for (int i = 0; i <= datagridview.ColumnCount - 1; i++)
                        {
                            if (datagridview.Columns[i].Visible == true)
                            {
                                datas[0, i] = datagridview.Columns[i].HeaderText.Trim();
                                displayColumnsCount++;
                            }
                        }
                        Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, nDispalyColumnCount]];
                        range.Interior.ColorIndex = 15;//15代表灰色
                        range.Font.Bold = true;
                        range.Font.Size = 9;

                        int init = int.Parse(((sc - 1) * pageRows).ToString());
                        int r = 0;
                        int index = 0;
                        int result;
                        if (pageRows * sc >= nRowCount)
                        {
                            result = nRowCount;
                        }
                        else
                        {
                            result = int.Parse((pageRows * sc).ToString());
                        }
                        for (r = init; r < result; r++)
                        {
                            index = index + 1;
                            for (int i = 0; i < datagridview.ColumnCount; i++)
                            {
                                if (datagridview.Columns[i].Visible == true)
                                {
                                    if (datagridview.Columns[i].ValueType == typeof(string) || datagridview.Columns[i].ValueType == typeof(Decimal) ||
                                        datagridview.Columns[i].ValueType == typeof(DateTime) || datagridview.Columns[i].ValueType == typeof(Double) ||
                                        datagridview.Columns[i].ValueType == typeof(int))
                                    {
                                        object obj = datagridview.Rows[r].Cells[datagridview.Columns[i].Name].Value;
                                        datas[index, i] = obj == null ? "" : "'" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                                    }
                                }
                            }
                            System.Windows.Forms.Application.DoEvents();
                        }
                        Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 2, nDispalyColumnCount + 1]];
                        fchR.Value2 = datas;

                        worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                        range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[index + 1, nDispalyColumnCount]];
                        //15代表灰色
                        range.Font.Size = 9;
                        range.RowHeight = 14.25;
                        range.Borders.LineStyle = 1;
                        range.HorizontalAlignment = 1;
                    }
                }
                else
                {
                    string[,] datas = new string[nRowCount + 2, nDispalyColumnCount + 1];
                    int displayColumnsCount = 1;
                    for (int i = 0; i <= datagridview.ColumnCount - 1; i++)
                    {
                        if (datagridview.Columns[i].Visible == true)
                        {
                            datas[0, i] = datagridview.Columns[i].HeaderText.Trim();
                            displayColumnsCount++;
                        }
                    }
                    Range range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, nDispalyColumnCount]];
                    range.Interior.ColorIndex = 15;//15代表灰色
                    range.Font.Bold = true;
                    range.Font.Size = 9;
                    int r = 0;
                    for (r = 0; r < nRowCount; r++)
                    {
                        for (int i = 0; i < datagridview.ColumnCount; i++)
                        {
                            if (datagridview.Columns[i].Visible == true)
                            {
                                if (datagridview.Columns[i].ValueType == typeof(string) || datagridview.Columns[i].ValueType == typeof(Decimal) ||
                                    datagridview.Columns[i].ValueType == typeof(DateTime) || datagridview.Columns[i].ValueType == typeof(Double) ||
                                    datagridview.Columns[i].ValueType == typeof(int))
                                {
                                    object obj = datagridview.Rows[r].Cells[datagridview.Columns[i].Name].Value;
                                    datas[r + 1, i] = obj == null ? "" : "'" + obj.ToString().Trim();//在obj.ToString()前加单引号是为了防止自动转化格式
                                }
                            }
                        }
                        System.Windows.Forms.Application.DoEvents();
                    }
                    Range fchR = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[nRowCount + 2, nDispalyColumnCount + 1]];
                    fchR.Value2 = datas;
                    worksheet.Columns.EntireColumn.AutoFit();//列宽自适应。
                    range = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[nRowCount + 1, nDispalyColumnCount]];
                    //15代表灰色
                    range.Font.Size = 9;
                    range.RowHeight = 14.25;
                    range.Borders.LineStyle = 1;
                    range.HorizontalAlignment = 1;
                }

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.DefaultExt = "xls";
                dlg.Filter = "Excel File(*.XLS)|*.xls";
                dlg.InitialDirectory = "C:";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string sFilePath = dlg.FileName;
                    if (sFilePath != "")
                    {
                        try
                        {
                            workbook.SaveAs(sFilePath, 56, missing, missing, missing, missing, XlSaveAsAccessMode.xlShared, missing, missing, missing, missing, missing);
                            workbook.Saved = true;
                            //workbook.SaveCopyAs(m_FilePath);
                            MessageBox.Show("Succeeding in exporting excel file!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error happened when exporting excel file!\n" + ex.Message);
                        }
                    }
                }
            }
            finally
            {
                //关闭Excel应用
                if (workbook != null)
                    workbook.Close(missing, missing, missing);
                if (objExcel.Workbooks != null)
                    objExcel.Workbooks.Close();
                if (objExcel != null)
                    objExcel.Quit();
                worksheet = null;
                workbook = null;
                objExcel = null;
                GC.Collect();//强行销毁
            }
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
    }
}