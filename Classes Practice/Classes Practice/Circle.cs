using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Practice
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
           double a = Math.PI * Math.Pow(Radius,2);
           return a;
        }

        public double CalculatePerimeter()
        {
            double p = 2 * Math.PI * Radius;
            return p;
        }

    }
}
