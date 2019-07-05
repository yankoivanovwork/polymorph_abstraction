using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_abstract
{
    public class Message
    {
        protected readonly List<string> sender= new List<string> { "Yanko", "Stamen", "Kiro" };
        protected readonly List<string> recipients = new List<string>{ "Mitko", "Ivailo", "Kamen" };
        protected readonly List<string> message = new List<string> { "Good morning!", "Hello", "Have a nice day!" };

        /*public virtual void AddMessage(string desiredMessage = "No message")
        {
            //message = desiredMessage;
        }*/

        public virtual void DisplayMessage()
        {
            Console.WriteLine("Displaying message...");
        }
    }
}
