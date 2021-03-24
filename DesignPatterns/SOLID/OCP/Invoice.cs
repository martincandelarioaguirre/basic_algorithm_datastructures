using System;

namespace DesignPatterns.SOLID.OCP
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount){
            return amount-10;
        }
        
    }

    public class FinalInvoice : Invoice{
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 50;
        }
    }

    public class ProposedInvoice : Invoice {
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }

    public class RecurringInvoice : Invoice{
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }

    public class InvoiceOCP {
        public void Run(){
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Showing multiples {FInvoiceAmount}, {PInvoiceAmount}, {RInvoiceAmount}");
        }
    }
}