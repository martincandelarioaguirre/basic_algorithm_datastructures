using System;

namespace DesignPatterns.Creational
{
    public class Report
    {
        public string ReportType { set; get; }
        public string ReportHeader { set; get; }
        public string ReportFooter { set; get; }
        public string ReportContent { set; get; }

        public void DisplayReport()
        {
            Console.WriteLine($"Report Type: {ReportType}");
            Console.WriteLine($"Header {ReportHeader}");
            Console.WriteLine($"Content {ReportContent}");
            Console.WriteLine($"Footer {ReportFooter}");
        }
    }

    public abstract class ReportBuilder
    {
        protected Report reportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateNewReport()
        {
            reportObject = new Report();
        }

        public Report GetReport()
        {
            return reportObject;
        }
    }

    class ExcelReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "Excel Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "Excel Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "Excel Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "Excel";
        }
    }

    public class PDFReport : ReportBuilder
    {
        public override void SetReportContent()
        {
            reportObject.ReportContent = "PDF Content Section";
        }
        public override void SetReportFooter()
        {
            reportObject.ReportFooter = "PDF Footer";
        }
        public override void SetReportHeader()
        {
            reportObject.ReportHeader = "PDF Header";
        }
        public override void SetReportType()
        {
            reportObject.ReportType = "PDF";
        }
    }

    public class ReportDirector
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateNewReport();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();
            return reportBuilder.GetReport();
        }
    }

    public class BuilderTest
    {
        public void Run()
        {
            // Client Code
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }
    }

}