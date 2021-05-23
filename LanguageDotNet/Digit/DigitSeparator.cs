using System;

namespace logical_exercise.LanguageDotNet.Digit
{
    public class DigitSeparator
    {
        public void Run(){
            long bigNumber = 123456789012345678;
            long bigNumberSplit = 123_456_789_012_345_678;
            Console.WriteLine("bigNumber: {0}, bigNumberSplit: {1}", bigNumber, bigNumberSplit);
            Console.ReadKey();
        }
    }
}