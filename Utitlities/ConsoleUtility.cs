using System;

namespace logical_exercise
{
    public static class ConsoleUtility
    {
        public static void WriteLine(string text)
        {
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.Length / 2)) + "}", text));
        }

        // public static void WriteLine(int text)
        // {
        //     Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (text.ToString().Length / 2)) + "}", text));
        // }
    }
}