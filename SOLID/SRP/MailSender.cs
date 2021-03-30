using System;

namespace SOLID
{
    class MailSender
    {
        public string From { get; set; }

        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public void SendEmail()
        {
            Console.WriteLine("Email send!");
        }
    }
}