using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Select a shape by entering a number from the list: \n 1. Cube \n 2. Sphere \n 3. Cylinder \n");
            var choice = Console.ReadKey();

            if (choice.KeyChar == '1')
            {
                Console.Clear();
                Console.WriteLine("Enter a l, h, w as comma separated integers.");
                string s = Console.ReadLine();
                var l = Char.GetNumericValue(s[0]);
                var h = Char.GetNumericValue(s[2]);
                var w = Char.GetNumericValue(s[4]);

                Cube myCube = new Cube(l, h, w);
                Console.WriteLine(myCube.l);
                Console.WriteLine(myCube.w);
                Console.WriteLine(myCube.h);

                Console.WriteLine("Number of sides: " + myCube.numberOfSides);
                Console.WriteLine("Surface area: " + myCube.surfaceArea());
                Console.WriteLine("Volume: " + myCube.volume());
                Console.ReadKey();
            }
            else if (choice.KeyChar == '2')
            {
                Console.Clear();
                Console.WriteLine("Enter a radius");
                string s = Console.ReadLine();
                var r = Convert.ToDouble(s);

                Sphere mySphere = new Sphere(r);

                Console.WriteLine("Number of sides: " + mySphere.numberOfSides);
                Console.WriteLine("Surface Area: " + mySphere.surfaceArea() );
                Console.WriteLine("Volume: " + mySphere.volume());
                Console.ReadKey();
            }
            else if (choice.KeyChar == '3')
            {
                Console.Clear();
                Console.WriteLine("Enter a radius and height separated by a comma");
                string s = Console.ReadLine();
                var r = Char.GetNumericValue(s[0]);
                var h = Char.GetNumericValue(s[2]);

                Cylinder myCylinder = new Cylinder(r, h);

                Console.WriteLine("Number of sides: " + myCylinder.numberOfSides);
                Console.WriteLine("Surface Area: " + myCylinder.surfaceArea());
                Console.WriteLine("Volume: " + myCylinder.volume());
                Console.ReadKey();
            }
        }
    }
}
