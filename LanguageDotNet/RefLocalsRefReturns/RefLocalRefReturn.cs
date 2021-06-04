using System;

namespace logical_exercise.LanguageDotNet.RefLocalsRefReturns
{
    public class RefLocalRefReturn
    {
        public void Run()
        {
            Console.WriteLine("Pass by value");
            int no = 1;
            PassByValue(no);
            Console.WriteLine($"After the invocation of {nameof(PassByValue)} method, {nameof(no)} = {no}");
            Console.WriteLine("Pass by Reference");
            PassByReference(ref no);
            Console.WriteLine($"After the invocation of {nameof(PassByReference)} method, {nameof(no)} = {no}");
            Out(out no);
            Console.WriteLine($"After the invocation of {nameof(Out)} method, {nameof(no)} = {no}");
            LocalRef();
            int[] x = { 2, 4, 62, 54, 33, 55, 66, 71, 92 };
            ref int oddNum = ref GetFirstOddNumber(x);
            Console.WriteLine($"\t\t{oddNum}");
            oddNum = 35;
            for (var i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static void PassByValue(int x)
        {
            x = 2;
        }

        static void PassByReference(ref int x)
        {
            x = 2;
        }

        static void Out(out int x)
        {
            x = 2;
        }

        static void LocalRef()
        {
            int no1 = 1;
            ref int no2 = ref no1;
            no2 = 2;
            Console.WriteLine($"Local variable {nameof(no1)} after the change: {no1}");
        }

        static ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    return ref numbers[i];
                }
            }
            throw new Exception("Odd number not found");
        }
    }
}