using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Cuboid : Object3D
    {
        private double a;
        private double b;
        private double c;

        public Cuboid(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public override double CalculateSurface()
        {
            return 2 * (a * b + a * c + b * c);
        }

        public override double CalculateVolume()
        {
            return a * b * c;
        }

        public override void Draw()
        {
            Console.WriteLine("Cuboid:\na:{0}\nb:{1}\nc:{2}\n", a, b, c);
        }
    }
}
