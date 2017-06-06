using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace Second_Space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
class TestClass
{
    static void Main(string[] args)
    {
        First_Space.namespace_cl fc = new First_Space.namespace_cl();
        Second_Space.namespace_cl sc = new Second_Space.namespace_cl();
        fc.func();
        sc.func();
        Console.ReadKey();
    }
}
