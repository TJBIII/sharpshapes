using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cylinder : Shape, IShape
    {
        public int numberOfSides { get; set; }
        public double radius { get; set; }
        public double height { get; set; }

        public double surfaceArea()
        {
            return (2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius);
        }

        public double volume()
        {
            return Math.PI * radius * radius * height;
        }

        public Cylinder (double r, double h)
        {
            this.radius = r;
            this.height = h;
            this.type = "Cylinder";
            this.numberOfSides = 3;
        }
    }
}
