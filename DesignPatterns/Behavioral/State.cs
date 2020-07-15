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

    public class DebitCardNotInsertedState : IATMState {
        public void InsertDebitCard(){
            Console.WriteLine("Debit Card Inserted");
        }
        public void EjectDebitCard(){
            Console.WriteLine("You cannot eject the Debit Card, as no debit card is ATM Machine slot");
        }
        public void EnterPin(){
            Console.WriteLine("You cannot enter the pin, as No Debit Card in ATM Machine slot");
        }
        public void WithdrawMoney(){
            
        }
    }
}