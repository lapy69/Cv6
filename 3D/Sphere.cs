using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Sphere : Object3D
    {

        private double r;

        public Sphere(double R)
        {
            r = R;
        }

        public override double CalculateSurface()
        {
            return 4 * Math.PI * Math.Pow(r,2);
        }

        public override double CalculateVolume()
        {
            return (4 * Math.PI * Math.Pow(r,3)) / 3;
        }

        public override void Draw()
        {
            Console.WriteLine("Sphere:\nradius:{0}\n",r);
        }
    }
}
