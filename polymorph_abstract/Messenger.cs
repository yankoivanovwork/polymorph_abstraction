using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_abstract
{
    public class Messenger : Message
    {
        private string customName;
        private string customMessage;
        private string customRecipient;
        private string senderName;
        private string desiredMessage;
        private string recipientName;

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

        public string DesiredMessage
        {
            get
            {
                return desiredMessage;
            }
            set
            {
                desiredMessage = value;
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

        public Messenger()
        {
            customName = "Anonymous";
            customMessage = "Message not set.";
            customRecipient = "Anonymous recipient";
        }

        public Messenger(int choiceSenderName, int choiceMessage, int choiceRecipientName):this(choiceMessage, choiceRecipientName)
        {
            if (choiceSenderName >= 0 && choiceSenderName < 3)
            {
                customName = base.sender[choiceSenderName];
            }
            else
            {
                customName = "Anonymous";
            }
        }

        public Messenger(int choiceMessage, int choiceRecipientName)
        {
            if (choiceMessage >= 0 && choiceMessage < 3)
            {
                if (choiceRecipientName >= 0 && choiceRecipientName < 3)
                {
                    customMessage = base.message[choiceMessage];
                    customRecipient = base.recipients[choiceRecipientName];
                }
            }
            else
            {
                customName = "Anonymous";
                customMessage = "Message not set.";
                customRecipient = "Anonymous recipient";
            }
        }

        public override void DisplayMessage()
        {
            base.DisplayMessage();
            Console.WriteLine("Sent by: " + customName + " from Messenger");
            Console.WriteLine("Message: " + customMessage);
            Console.WriteLine("For: " + customRecipient);
            Console.WriteLine("At " + DateTime.Now);
            Console.WriteLine();
        }
    }
}
