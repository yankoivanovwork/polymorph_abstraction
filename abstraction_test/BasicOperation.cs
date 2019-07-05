using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_test
{
    public class BasicOperation : Calculator
    {
        private double result;
        private int choice;

        public BasicOperation(int choiceOperation)
        {
            choice = choiceOperation;
        }

        private void Calculate()
        {
            switch (choice)
            {
                case 0:
                    result = base.A + base.B;
                    break;
                case 1:
                    result = base.A - base.B;
                    break;
                case 2:
                    result = base.A * base.B;
                    break;
                default:
                    // '/'
                    result = base.A / base.B;
                    break;
            }
        }

        public override void Result()
        {
            
            if (choice >= 0 && choice < 4)
            {
                Calculate();
            }
            else
            {
                choice = 3;
                Calculate();
            }
            base.Result();
            Console.WriteLine(result.ToString());
        }
    }
}
