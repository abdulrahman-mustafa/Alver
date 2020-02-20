using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
