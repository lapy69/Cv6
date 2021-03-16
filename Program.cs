using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObject[] Objects = new GrObject[]
            {
                    new Circle(4),
                    new Elipse(2, 5),
                    new Rectangle(1, 2),
                    new Triangle(3, 6),

                    new Cuboid(1,2,3),
                    new Cylinder(3, 12),
                    new Pyramid(5, 6, 10),
                    new Sphere(4)
            };

            double area = 0;
            double surface = 0;
            double volume = 0;

            foreach (var obj in Objects)
            {
                if (obj is Object2D)
                {
                    area += ((Object2D)obj).CalculateArea();
                }
                else
                {
                    surface += ((Object3D)obj).CalculateSurface();
                    volume += ((Object3D)obj).CalculateVolume();
                }
                obj.Draw();
            }

            Console.WriteLine("Area:{0}\nSurface:{1}\nVolume:{2}", area, surface, volume);
            Console.ReadLine();

        }
    }
}
