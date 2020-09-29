using System;

namespace logical_exercise.LanguageDotNet
{
    public class PrintHelper
    {
        public delegate void BeforePrint(string message);
        public event BeforePrint beforePrintEvent;

        public void PrintNumber(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent.Invoke("PrintNumber");
            ConsoleUtility.WriteLine($"Number: {num,-12:N0}");
        }

        public void PrintDecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintDecimal");
            Console.WriteLine("Decimal: {0:G}", dec);
        }

        public void PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemperature");
            Console.WriteLine("Money: {0:C}", money);
        }

        public void PrintTemperature(int num)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintTemerature");

            Console.WriteLine("Temperature: {0,4:N1} F", num);
        }

        public void PrintHexadecimal(int dec)
        {
            if (beforePrintEvent != null)
                beforePrintEvent("PrintHexadecimal");

            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }

    public class Number
    {
        private PrintHelper _printHelper;
        private int _value;
        public Number(int val)
        {
            _value = val;
            _printHelper = new PrintHelper();
            // Subscribe to beforePrintEvent event
            _printHelper.beforePrintEvent += PrintHelper_beforePrintEvent;
        }

        public Number()
        {

        }

        public void PrintHelper_beforePrintEvent(string message)
        {
            Console.WriteLine("BeforePrintEvent fires from {0}", message);
        }

        public void PrintMoney()
        {
            _printHelper.PrintMoney(_value);
        }

        public void PrintNumber()
        {
            _printHelper.PrintNumber(_value);
        }

        public void PrintTemperature()
        {
            _printHelper.PrintTemperature(_value);
        }

        public void Run()
        {
            Number number = new Number(20000);
            number.PrintMoney();
            number.PrintNumber();
            number.PrintTemperature();
        }

    }
}