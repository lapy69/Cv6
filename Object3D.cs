using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cv6
{
    abstract class Object3D : GrObject
    {
        public abstract double CalculateSurface();
        public abstract double CalculateVolume();
    }
}
