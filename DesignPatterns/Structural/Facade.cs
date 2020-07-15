using System;

namespace DesignPatterns.Structural
{
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the product details");
        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    public class Invoice
    {
        public void SendInvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }

    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");
            Product product = new Product();
            product.GetProductDetails();
            Payment payment = new Payment();
            payment.MakePayment();
            Invoice invoice = new Invoice();
            invoice.SendInvoice();
            Console.WriteLine("Order Placed Successfully");
        }
    }

    public class FacadeTest
    {
        public void Run()
        {
            Order order = new Order();
            order.PlaceOrder();
            Console.Read();
        }
    }
}