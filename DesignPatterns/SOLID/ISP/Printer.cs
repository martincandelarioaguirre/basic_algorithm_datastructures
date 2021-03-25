using System;
using logical_exercise.DesignPatterns.SOLID.ISP;

namespace DesignPatterns.SOLID.ISP
{

    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }

    public class LiquidInjectPrint : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }

    public class Printer
    {
        public void Run()
        {
            HPLaserJetPrinter hPLaserJetPrinter = new HPLaserJetPrinter();
            LiquidInjectPrint liquidInjectPrint = new LiquidInjectPrint();

            hPLaserJetPrinter.Fax("");
            hPLaserJetPrinter.Print("");
            hPLaserJetPrinter.Scan("");
            hPLaserJetPrinter.PrintDuplex("");

            liquidInjectPrint.Print("");
            liquidInjectPrint.Scan("");

        }
    }
}