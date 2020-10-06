using System;

namespace logical_exercise.LanguageDotNet
{
    public class Predicate
    {
        private static bool Validation(string val)
        {
            return val == "hello";
        }

        public Predicate<String> Validate = Validation;

        public Predicate<string> Validate1 = delegate (String val)
        {
            return val == "hello";
        };

        public Predicate<string> Validate2 = (String val) => val == "hello";

        public void Run()
        {
            Predicate predicate = new Predicate();
            Console.WriteLine("The validation {0}", predicate.Validate("hola"));
            Console.WriteLine("The validation {0}", predicate.Validate1("hola"));
            Console.WriteLine("The validation {0}", predicate.Validate2("hola"));

        }
    }
}