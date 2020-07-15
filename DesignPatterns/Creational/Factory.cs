using System;

namespace DesignPatterns.Creational
{
    public interface CreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class MoneyBack : CreditCard
    {

        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCreditLimit()
        {
            return 15000;
        }

        public string GetCardType()
        {
            return "Money Back";
        }
    }

    public class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
        }

        public string GetCardType()
        {
            return "Titanium Edge";
        }

        public int GetCreditLimit()
        {
            return 25000;
        }
    }

    public class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
        }

        public string GetCardType()
        {
            return "Platinum Plus";
        }

        public int GetCreditLimit()
        {
            return 35000;
        }
    }

    public class FactoryTest
    {
        public void Run(){
            // Generally we will get the Card Type from UI
            // Here we are hardcoded the card type
            string cardType = "MoneyBack";
            CreditCard cardDetails = null;
            // Based of the CreditCard Type we are creating the
            // appropiate type instrance using if else condition
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            } 
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }

            if (cardDetails != null)
            {
                Console.WriteLine($"CardType: {cardDetails.GetCardType()}");
                Console.WriteLine($"CreditLimit: {cardDetails.GetCreditLimit()}");
                Console.WriteLine($"AnnualCharge: {cardDetails.GetAnnualCharge()}");
            }
            else{
                Console.WriteLine("Invalid Card Type");
            }
            Console.ReadLine();
        }
    }
}