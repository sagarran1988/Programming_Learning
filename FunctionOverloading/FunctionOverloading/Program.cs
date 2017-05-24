using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class PrintData
    {
        void Print (int i)
        {
            Console.WriteLine("Printing int: {0}", i);
        }

        void Print (double f)
        {
            Console.WriteLine("Printing float: {0}", f);
        }

        void Print (string s)
        {
            Console.WriteLine("Printing string: {0}", s);
        }

        static void Main(string[] args)
        {
            PrintData p = new PrintData();
            p.Print(5);
            p.Print(9.3333873937);
            p.Print("Sagar is the Best");
            Console.ReadKey();
        }
    }
}
