using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Elipse : Object2D
    {
        private double a;
        private double b;

        public Elipse(double A, double B)
        {
            a = A;
            b = B;
        }

        public override double CalculateArea()
        {
            return Math.PI * a * b;
        }

        public override void Draw()
        {
            Console.WriteLine("Elipse:\nHalf-Axis A: {0}\nHalf-Axis B: {1}\n", a, b);
        }
    }
}
