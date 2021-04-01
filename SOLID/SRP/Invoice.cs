using System;

namespace SOLID
{
    class Invoice
    {
        private MailSender _emailSender;

        public Invoice()
        {
            _emailSender = new MailSender();
        }

        public int InvoceAmount { get; set; }

        public DateTime InvoceDate { get; set; }

        public void AddInvoice()
        {
            _emailSender.From = "admin@test.com";
            _emailSender.To = "moderator@test.com";
            _emailSender.Subject = "SRP";
            _emailSender.SendEmail();

            Console.WriteLine("Invoice added");
        }

        public void DeleteInvoice()
        {
            Console.WriteLine("Invoce deleted");
        }
    }
}
