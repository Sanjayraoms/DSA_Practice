using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class BaseConditionHypothesisInductionPattern
    {
        public void Print1tonRecursively(int n)
        {
            //Base Condition
            if(n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            //Hypothesis and induction
            Print1tonRecursively(n - 1);
            Console.WriteLine(n);
        }

        public void Printnto1Recursively(int n)
        {
            //Base Condition
            if (n == 1)
            {
                Console.WriteLine(n);
                return;
            }
            //Hypothesis and induction
            Console.WriteLine(n);
            Printnto1Recursively(n - 1);
        }

        public int Factorial(int n)
        {
            if(n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }
}
