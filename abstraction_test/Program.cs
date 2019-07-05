using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new BasicOperation(0);
            calc1.A = 5;
            calc1.B = -3;
            calc1.Result();

            Console.WriteLine();

            Calculator calc2 = new BasicOperation(1);
            calc2.A = 10;
            calc2.B = -1;
            calc2.Result();

            Console.WriteLine();
        }
    }
}
