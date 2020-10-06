using System;

namespace logical_exercise.LanguageDotNet


{
    public class Func
    {
        public static int Sumatoria(int num1, int num2)
        {
            return num1 + num2;
        }

        public Func<int, int, int> Suma = Sumatoria;

        public Func<int, int, int> Suma2 = delegate (int num1, int num2)
        {
            return num1 + num2;
        };

        public Func<int, int, int> Suma3 = (int num1, int num2) => num1 + num2;

        public void Run()
        {
            Func func = new Func();
            ConsoleUtility.WriteLine($"The sum of two numbers: {func.Suma(3, 4)}");
            ConsoleUtility.WriteLine($"The sum of two numbers: {func.Suma2(4, 5)}");
            ConsoleUtility.WriteLine($"The sum of two numbers: {func.Suma3(6, 7)}");
        }

    }
}