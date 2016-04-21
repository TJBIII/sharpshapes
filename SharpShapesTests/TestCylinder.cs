using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace SharpShapesTests
{
    [TestClass]
    public class TestCylinder
    {
        [TestMethod]
        public void TestShapeType()
        {
            Cylinder myShape = new Cylinder(2,5);
            Assert.IsInstanceOfType(myShape, typeof(Cylinder));
        }

        [TestMethod]
        public void TestCylinderVolume()
        {
            Cylinder myShape = new Cylinder(2, 3);
            Assert.IsTrue(Math.Abs(myShape.volume() - 37.7) < 0.1);
        }

        [TestMethod]
        public void TestCylinderSurfaceArea()
        {
            Cylinder myShape = new Cylinder(2, 3);
            Assert.IsTrue(Math.Abs(myShape.surfaceArea() - 62.83) < 0.1);
        }
    }
}
