using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public interface IShape
    {
        int numberOfSides { get; set; }

        double volume();
        double surfaceArea();
    }
}
