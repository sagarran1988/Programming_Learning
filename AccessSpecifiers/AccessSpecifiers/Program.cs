using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    class Rectangele
    {
        private double length;
        private double width;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }
        
        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());
        }

    }// End Class Rectangle

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangele r = new Rectangele();
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
