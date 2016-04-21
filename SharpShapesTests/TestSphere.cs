using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace SharpShapesTests
{
    [TestClass]
    public class TestSphere
    {
        [TestMethod]
        public void TestShapeType()
        {
            Sphere myShape = new Sphere(2);
            Assert.IsInstanceOfType(myShape, typeof(Sphere));
        }

        [TestMethod]
        public void TestSphereVolume()
        {
            Sphere myShape = new Sphere(2);
            Assert.IsTrue(Math.Abs(myShape.volume() - 33.51) < 0.1);
        }

        [TestMethod]
        public void TestSphereSurfaceArea()
        {
            Sphere myShape = new Sphere(2);
            Assert.IsTrue(Math.Abs(myShape.surfaceArea() - 50.27) < 0.1);
        }
    }
}
