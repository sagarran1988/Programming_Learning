using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritanceApplication
{
    class Shape
    {
        protected int height;
        protected int width;
        public void SetHeight(int h)
        {
            height = h;
        }

        public void SetWidth(int w)
        {
            width = w;
        }
        
    }

    // Base class PaintCost

     public interface PaintCost
    {
        int GetCost(int area);
    }

    //Derived class

    class Rectangle : Shape, PaintCost
    {
        public int GetArea()
        {
            return (width * height);
        }

        public int GetCost(int area)
        {
            return area * 70;
        }
    }

    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();
            int area;
            Rect.SetWidth(5);
            Rect.SetHeight(7);
            area = Rect.GetArea();
            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.GetArea());
            Console.WriteLine("Total paint cost: ${0}", Rect.GetCost(area));
            Console.ReadKey();
        }
    }
}
