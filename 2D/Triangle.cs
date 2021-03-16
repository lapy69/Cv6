using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Triangle : Object2D
    {
        private double a;
        private double h;

        public Triangle(double A, double H)
        {
            a = A;
            h = H;
        }

        public override double CalculateArea()
        {
            return a * h / 2;
        }

        public override void Draw()
        {
            Console.WriteLine("Triangle:\nBase:{0}\nHeight:{1}\n", a, h);
        }
    }
}
