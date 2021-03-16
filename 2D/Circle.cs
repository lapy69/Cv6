using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Circle : Object2D
    {
        private double r;

        public Circle(double R)
        {
            r = R;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(r,2);
        }

        public override void Draw()
        {
            Console.WriteLine("Circle:\nRadius:{0}\n",r);
        }
    }
}
