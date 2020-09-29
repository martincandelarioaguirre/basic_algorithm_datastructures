using System;

namespace logical_exercise.LanguageDotNet {
    /// <summary>
    /// Action delegate can be used with a method that has void return type.
    /// Class implement an action delegate with input parameter
    /// </summary>
    public class Action {
        public static void Saludo (string greeting) {
            ConsoleUtility.WriteLine ($"Hello World: {greeting}");
        }

        public Action<String> Greeter = Saludo;

        public Action<string> Greeter2 = delegate (string greeting) {
            ConsoleUtility.WriteLine ($"Hello World: {greeting}");
        };

        public Action<string> Greeter3 = (string greeting) => ConsoleUtility.WriteLine ($"Hello World {greeting}");

        public void Run () {
            Action action = new Action ();
            action.Greeter ("Martin");
            action.Greeter2 ("Martin");
            action.Greeter3 ("Martin");
        }
    }
}