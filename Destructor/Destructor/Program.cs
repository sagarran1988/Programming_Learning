using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class Line
    {
        private double length; // Length of a line
        public Line() // constructor
        {
            Console.WriteLine("Object is being created");
        }

        ~Line() //destructor
        {
            Console.WriteLine("Object is being deleted");
        }

        public void SetLength(double len)
        {
            length = len;
        }
        public double GetLength()
        {
            return length;
        }
        static void Main(string[] args)
        {
            Line line = new Line();
            // set line length
            line.SetLength(6.0);
            Console.WriteLine("Length of line : {0}", line.GetLength());
            Console.ReadKey();
        }
    }
}
