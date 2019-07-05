using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_abstract
{
    public class Mail : Message
    {
        private string customName;
        private string customMessage;
        private string senderName;
        private string mailMessage;
        private string recipientName;

        public string Message
        {
            get
            {
                return mailMessage;
            }
            set
            {
                mailMessage = value;
            }
        }

        public string SenderName
        {
            get
            {
                return senderName;
            }
            set
            {
                senderName = value;
            }
        }

        public string RecipientName
        {
            get
            {
                return recipientName;
            }
            set
            {
                recipientName = value;
            }
        }

        public Mail(int enterOptionSelection)
        {
            if (enterOptionSelection >= 0 && enterOptionSelection < 3)
            {
                customName = base.sender[enterOptionSelection];
                customMessage = base.message[enterOptionSelection];
            }
        }

        /*public override void AddMessage(string desiredMessage = "No message")
        {
            message = desiredMessage;
        }*/

        public override void DisplayMessage()
        {
            base.DisplayMessage();
            Console.WriteLine("Sent by: " + customName);
            Console.WriteLine("Message: " + customMessage);
            Console.WriteLine("At " + DateTime.Now);
            Console.WriteLine();
        }
    }
}
