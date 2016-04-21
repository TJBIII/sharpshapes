using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Sphere : Shape, IShape
    {
        public int numberOfSides { get; set; }
        public double radius { get; set; }

        public double surfaceArea()
        {
            return 4 * Math.PI * radius * radius ;
        }

        public double volume()
        {
            return 4 * Math.PI * radius * radius * radius / 3;
        }

        public Sphere(double r)
        {
            this.radius = r;
            this.numberOfSides = 0;
        }
    }
}
