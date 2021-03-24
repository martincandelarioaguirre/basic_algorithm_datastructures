using System;

namespace DesignPatterns.SOLID.SRP
{
    public class Invoice
    {
        public long InvoiceAmount { set; get; }
        public DateTime InvoiceDate { set; get; }
        private ILogger fileLogger;
        private MailSender emailSender;
        public Invoice()
        {
            fileLogger = new Logger();
            emailSender = new MailSender();
        }

        public void AddInvoice()
        {
            try
            {
                fileLogger.Info("Add method start");
                emailSender.EMailFrom = "emailfrom@xyz.com";
                emailSender.EMailTo = "emailto@xyz";
                emailSender.EMailSubject = "Single Responsibility PRinciple";
                emailSender.EmailBody = "A class should have onlye one reason to change";
                emailSender.SendEmail();
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error occurred while generating invoice", ex);
            }
        }

        public void DeleteInvoice()
        {
            try
            {
                fileLogger.Info("Delete Invoice Start at @" + DateTime.Now);
            }
            catch (Exception ex)
            {
                fileLogger.Error("Error occurred while deleting invoice", ex);
            }
        }

        public void Run()
        {
            Invoice invoice = new Invoice();
            invoice.AddInvoice();
            invoice.DeleteInvoice();
        }

    }
}