using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorph_abstract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //polymorphism
            //primer1
            Message message1 = new Mail(0);
            message1.DisplayMessage();

            Message message2 = new Mail(1);
            message2.DisplayMessage();

            Message message3 = new Mail(2);
            message3.DisplayMessage();

            Console.WriteLine("---------------------------");

            //primer2
            Message message4 = new Messenger();
            message4.DisplayMessage();

            Message message5 = new Messenger(0,2);
            message5.DisplayMessage();

            Message message6 = new Messenger(1,0,2);
            message6.DisplayMessage();
        }
    }
}
