using System;

namespace DesignPatterns.SOLID.SRP
{
    public class MailSender
    {
        public string EMailFrom { set; get; }
        public string EMailTo { set; get; }
        public string EMailSubject { set; get; }
        public string EmailBody { set; get; }
        public void SendEmail()
        {
            Console.WriteLine("Sending email...");
        }
    }
}