using Alver.Properties;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;

public static class LocalReportExtensions
{
    private static int m_currentPageIndex = 0;

    //
    private static List<Stream> m_streams;

    public static Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType, bool willSeek)
    {
        Stream stream = new MemoryStream();
        m_streams.Add(stream);
        return stream;
    }

    public static void DisposePrint()
    {
        if (m_streams != null)
        {
            foreach (Stream stream in m_streams)
                stream.Close();
            m_streams = null;
        }
    }

    public static void Export(LocalReport report, bool print = true)
    {
        string deviceInfo =
         @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>3in</PageWidth>
                <PageHeight>8.3in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0.1in</MarginLeft>
                <MarginRight>0.1in</MarginRight>
                <MarginBottom>0in</MarginBottom>
            </DeviceInfo>";
        Warning[] warnings;
        m_streams = new List<Stream>();
        report.Render("Image", deviceInfo, CreateStream, out warnings);
        foreach (Stream stream in m_streams)
            stream.Position = 0;

        if (print)
        {
            Print();
        }
    }

    public static void Print(this LocalReport report)
    {
        var pageSettings = new PageSettings();
        PaperSize _paperSize = new PaperSize();
        _paperSize.Width = 0;
        pageSettings.PaperSize = report.GetDefaultPageSettings().PaperSize;
        pageSettings.Landscape = report.GetDefaultPageSettings().IsLandscape;
        pageSettings.Margins = report.GetDefaultPageSettings().Margins;
        Print(report, pageSettings);
    }

    public static void Print(this LocalReport report, PageSettings pageSettings)
    {
        string deviceInfo =
            $@"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>{pageSettings.PaperSize.Width * 100}in</PageWidth>
                <PageHeight>{pageSettings.PaperSize.Height * 100}in</PageHeight>
                <MarginTop>{pageSettings.Margins.Top * 100}in</MarginTop>
                <MarginLeft>{pageSettings.Margins.Left * 100}in</MarginLeft>
                <MarginRight>{pageSettings.Margins.Right * 100}in</MarginRight>
                <MarginBottom>{pageSettings.Margins.Bottom * 100}in</MarginBottom>
            </DeviceInfo>";

        Warning[] warnings;
        var streams = new List<Stream>();
        var currentPageIndex = 0;

        report.Render("Image", deviceInfo,
            (name, fileNameExtension, encoding, mimeType, willSeek) =>
            {
                var stream = new MemoryStream();
                streams.Add(stream);
                return stream;
            }, out warnings);

        foreach (Stream stream in streams)
            stream.Position = 0;

        if (streams == null || streams.Count == 0)
            throw new Exception("Error: no stream to print.");

        var printDocument = new PrintDocument();
        printDocument.DefaultPageSettings = pageSettings;
        string _printer = Settings.Default.BillPrinter;
        if (_printer.Length > 0)
        {
            printDocument.PrinterSettings.PrinterName = _printer;
        }
        if (!printDocument.PrinterSettings.IsValid)
            throw new Exception("الطابعة غير متصلة او لم يتم تعريف طابعة بعد!");
        else
        {
            printDocument.PrintPage += (sender, e) =>
            {
                Metafile pageImage = new Metafile(streams[currentPageIndex]);
                Rectangle adjustedRect = new Rectangle(
                    e.PageBounds.Left - (int)e.PageSettings.HardMarginX,
                    e.PageBounds.Top - (int)e.PageSettings.HardMarginY,
                    e.PageBounds.Width,
                    e.PageBounds.Height);
                e.Graphics.FillRectangle(Brushes.White, adjustedRect);
                e.Graphics.DrawImage(pageImage, adjustedRect);
                currentPageIndex++;
                e.HasMorePages = (currentPageIndex < streams.Count);
                e.Graphics.DrawRectangle(Pens.Red, adjustedRect);
            };
            printDocument.EndPrint += (Sender, e) =>
            {
                if (streams != null)
                {
                    foreach (Stream stream in streams)
                        stream.Close();
                    streams = null;
                }
            };
            printDocument.Print();
        }
    }

    public static void Print()
    {
        if (m_streams == null || m_streams.Count == 0)
            throw new Exception("Error: no stream to print.");
        PrintDocument printDoc = new PrintDocument();
        if (!printDoc.PrinterSettings.IsValid)
        {
            throw new Exception("Error: cannot find the default printer.");
        }
        else
        {
            printDoc.PrinterSettings.PrinterName = Settings.Default.BillPrinter;
            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            m_currentPageIndex = 0;
            printDoc.Print();
        }
    }

    public static void PrintPage(object sender, PrintPageEventArgs ev)
    {
        Metafile pageImage = new
           Metafile(m_streams[m_currentPageIndex]);

        // Adjust rectangular area with printer margins.
        Rectangle adjustedRect = new Rectangle(
            ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
            ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
            ev.PageBounds.Width,
            ev.PageBounds.Height);

        // Draw a white background for the report
        ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

        // Draw the report content
        ev.Graphics.DrawImage(pageImage, adjustedRect);

        // Prepare for the next page. Make sure we haven't hit the end.
        m_currentPageIndex++;
        ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
    }

    public static void PrintToPrinter(this LocalReport report)
    {
        Export(report);
    }
}