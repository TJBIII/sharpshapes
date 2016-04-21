using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Cube : Shape, IShape
    {   
        //length, height, width
        public double l { get; set; }
        public double h { get; set; }
        public double w { get; set; }

        public int numberOfSides { get; set; }

        public double surfaceArea()
        {
            return 2 * ((l * h) + (l * w) + (h * w));
        }

        public double volume()
        {
            return l * h * w;
        }

        public Cube(double length, double height, double width)
        {
            this.l = length;
            this.h = height;
            this.w = width;
            this.numberOfSides = 6;
        }
    }
}
