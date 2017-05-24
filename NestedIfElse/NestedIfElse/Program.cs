using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Local Variable Definition*/
            int a = 100;
            int b = 200;

            /*Check the boolean condition*/

            if(a == 100)
            {
                /*if condition is true then check the following*/
                if(b == 200)
                {
                    Console.WriteLine("Value of a is {0}", a);
                    Console.WriteLine("Value of b is " + b);
                }
            }
            Console.ReadLine();
        }
    }
}
