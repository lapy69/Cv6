using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Cylinder : Object3D
    {
        private double r;
        private double h;

        public Cylinder(double R, double H)
        {
            r = R;
            h = H;
        }

        public override double CalculateSurface()
        {
            return 2 * Math.PI * Math.Pow(r,2) + 2 * Math.PI * r * h;
        }

        public override double CalculateVolume()
        {
            return Math.PI * Math.Pow(r,2) * h;
        }

        public override void Draw()
        {
            Console.WriteLine("Cylinder:\nradius:{0}\nheight:{1}\n",r,h);
        }
    }
}
