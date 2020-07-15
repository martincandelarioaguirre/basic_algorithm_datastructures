using System;

namespace DesignPatterns.Behavioral
{
    public abstract class Handler
    {
        public Handler rsHAndler;
        public void nextHandler(Handler rsHAndler)
        {
            this.rsHAndler = rsHAndler;
        }

        public abstract void dispatchRs(long requestedAmount);
    }

    public class TwoThousandHanlder : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 2000;
            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine($"{numberOfNotesToBeDispatched} Two thousand nothes are dispatched by TwoThousandHandler");
                }
                else
                {
                    Console.WriteLine($"{numberOfNotesToBeDispatched} Two thoiusand note are dispatched by TwoThousandHanlder");
                }
                long pendingAmountToBeProcessed = requestedAmount % 2000;
                if (pendingAmountToBeProcessed > 0)
                {
                    rsHAndler.dispatchRs(pendingAmountToBeProcessed);
                }
            }
        }
    }

    public class FiveHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 500;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred notes are dispatched by FiveHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Five Hundred note is dispatched by FiveHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHAndler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class TwoHundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 200;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred notes are dispatched by TwoHundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Two Hundred note is dispatched by TwoHundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 200;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHAndler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class HundredHandler : Handler
    {
        public override void dispatchRs(long requestedAmount)
        {
            long numberofNotesToBeDispatched = requestedAmount / 100;
            if (numberofNotesToBeDispatched > 0)
            {
                if (numberofNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred notes are dispatched by HundredHandler");
                }
                else
                {
                    Console.WriteLine(numberofNotesToBeDispatched + " Hundred note is dispatched by HundredHandler");
                }
            }
            long pendingAmountToBeProcessed = requestedAmount % 100;
            if (pendingAmountToBeProcessed > 0)
            {
                rsHAndler.dispatchRs(pendingAmountToBeProcessed);
            }
        }
    }

    public class ATM
    {
        private TwoThousandHanlder twoThousandHanlder = new TwoThousandHanlder();
        private FiveHundredHandler fiveHundredHandler = new FiveHundredHandler();
        private TwoHundredHandler twoHundredHandler = new TwoHundredHandler();
        private HundredHandler hundredHandler = new HundredHandler();
        public ATM()
        {
            // Prepare the chain of Handlers
            twoThousandHanlder.nextHandler(fiveHundredHandler);
            fiveHundredHandler.nextHandler(twoHundredHandler);
            twoHundredHandler.nextHandler(hundredHandler);
        }
        public void withdraw(long requestedAmount)
        {
            twoThousandHanlder.dispatchRs(requestedAmount);
        }
    }

    public class ChainOfResponsability
    {
        public void Run()
        {

            ATM atm = new ATM();
            Console.WriteLine("\n Requested Amount 4600");
            atm.withdraw(4600);
            Console.WriteLine("\n Requested Amount 1900");
            atm.withdraw(1900);
            Console.WriteLine("\n Requested Amount 600");
            atm.withdraw(600);
            Console.Read();
        }
    }

}