using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_test
{
    public class Calculator //: ICalculation
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public virtual void Result()
        {
            Console.Write("Result for basic math calculation is: ");
        }
    }
}