using System;
using System.Collections.Generic;

namespace logical_exercise.LanguageDotNet.Tuples
{
    public class Tuples
    {

        public void Run()
        {
            var values = new List<double>() { 10, 20, 30, 40, 50 };
            Tuple<int, double> t = Calculate(values);
            Console.WriteLine($"There are {t.Item1} values and their sum is {t.Item2}");
            var result = CalculateNew(values);
            Console.WriteLine($"There are {result.Item1} values and their sum is {result.Item2}");
            var result1 = CalculateWithName(values);
            Console.WriteLine($"There are {result1.count} values and their sum is {result1.sum}");
            var (countResult, sumResult) = CalculateExplicitlyNames(values);
            Console.WriteLine($"There are {countResult} values and their sum is {sumResult}");
            Console.ReadKey();
        }
        private static Tuple<int, double> Calculate(IEnumerable<double> values)
        {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count++;
                sum += value;
            }
            // Creating an object of Tuple class by calling the state Create method
            Tuple<int, double> t = Tuple.Create(count, sum);
            return t;
        }

        private static (int, double) CalculateNew(IEnumerable<double> values){
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count ++;
                sum += value;
            }
            return (count, sum);
        }

        private static (int count, double sum) CalculateWithName(IEnumerable<double> values){
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count ++;
                sum += value;
            }
            return(count, sum);
        }

        private static (int count, double sum) CalculateExplicitlyNames(IEnumerable<double> values) {
            int count = 0;
            double sum = 0.0;
            foreach (var value in values)
            {
                count ++;
                sum += value;
            }
            return (count, sum);
        }
 
    }
}