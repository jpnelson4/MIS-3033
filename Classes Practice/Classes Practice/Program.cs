using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Length = 5;
            rect.Width = 5;

            Console.WriteLine(rect.CalculateArea());
            Console.WriteLine(rect.CalculatePerimeter());

           
            Circle c1 = new Circle(7);
            Console.WriteLine(c1.CalculatePerimeter().ToString("N2"));
            Console.WriteLine(c1.CalculateArea().ToString("N2"));

            Console.ReadKey();
        }
    }
}
