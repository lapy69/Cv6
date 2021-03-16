using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Rectangle : Object2D
    {
        private double a;
        private double b;

        public Rectangle(double A, double B)
        {
            a = A;
            b = B;
        }

        public override double CalculateArea()
        {
            return a * b;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle:\na:{0}\nb:{1}\n", a, b);
        }
    }
}
