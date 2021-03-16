using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Pyramid : Object3D
    {
        private double a;
        private double b;
        private double h;

        public Pyramid(double A, double B, double H)
        {
            a = A;
            b = B;
            h = H;
        }

        public override double CalculateSurface()
        {
            //     base    triangles with a                                       triangles with b
            return a * b + a * Math.Sqrt(Math.Pow((b / 2), 2) + Math.Pow(h, 2)) + b * Math.Sqrt(Math.Pow((a / 2), 2) + Math.Pow(h, 2));
        }

        public override double CalculateVolume()
        {
            return (a * b * h) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine("Pyramid:\na:{0}\nb:{1}\nheight:{2}\n", a, b, h);
        }
    }
}
