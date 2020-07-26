using System;

namespace DesignPatterns.Behavioral
{
    public interface IATMState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }

    public class DebitCardNotInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("Debit Card Inserted");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject the Debit Card, as no debit card is ATM Machine slot");
        }
        public void EnterPin()
        {
            Console.WriteLine("You cannot enter the pin, as No Debit Card in ATM Machine slot");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("You cannot withdraw money, as No debit Card in ATM machine slot");
        }
    }

    public class DebitCardInsertedState : IATMState
    {
        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert the Debit Card, as the Debit card is already there ");
        }
        public void EjectDebitCard()
        {
            Console.WriteLine("Debit Card is ejected");
        }
        public void EnterPin()
        {
            Console.WriteLine("Pin number has been entered correctly");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("Money has been withdrawn");
        }
    }

    public class ATMMachine : IATMState
    {
        public IATMState atmMachineState { set; get; }
        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();
            // Debit csrd has been inserted so internal state of ATM Machine
            // Has been changed to 'DebitCardNotInserted'
            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                Console.WriteLine($"ATM machine internal state has been moved to : {atmMachineState.GetType().Name}");
            }
        }
        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to 'DebitCardNotInsertedState'

            if (atmMachineState is DebitCardInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine("ATM Machine internal state has been moved to : "
                                + atmMachineState.GetType().Name);
            }
        }
        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }
        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }

    public class StateTest
    {
        public void Run()
        {
            // Initially ATM Machine in DebitCardNotInsertedState
            ATMMachine atmMachine = new ATMMachine();
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to DebitCardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to DebitCardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.Read();
        }
    }
}