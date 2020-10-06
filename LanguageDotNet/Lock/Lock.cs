using System;
using System.Threading.Tasks;

namespace logical_exercise.LanguageDotNet
{

    public class Account
    {
        private readonly object balanceLock = new object();
        private decimal balance;
        public Account(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public decimal Debit(decimal amount)
        {
            lock (balanceLock)
            {
                if (balance >= amount)
                {
                    ConsoleUtility.WriteLine($"Balance before debit :{balance,5}");
                    ConsoleUtility.WriteLine($"Amount to remove     :{amount,5}");
                    balance = balance - amount;
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void Credit(decimal amount)
        {
            lock (balanceLock)
            {
                ConsoleUtility.WriteLine($"Balance before credit:{balance,5}");
                ConsoleUtility.WriteLine($"Amount to add        :{amount,5}");
                balance = balance + amount;
                ConsoleUtility.WriteLine($"Balance after credit :{balance,5}");
            }
        }


    }
    public class LockTest
    {

        public void runTest()
        {
            var account = new Account(10000);
            var tasks = new Task[100];
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
        }
        static void RandomlyUpdate(Account account)
        {
            var rdn = new Random();
            for (int i = 0; i < 10; i++)
            {
                var amount = rdn.Next(1, 100);
                bool doCredit = rdn.NextDouble() < 0.5;
                if (doCredit)
                {
                    account.Credit(amount);
                }
                else
                {
                    account.Debit(amount);
                }
            }
        }


    }
}