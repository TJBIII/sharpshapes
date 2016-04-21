using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace SharpShapesTests
{
    [TestClass]
    public class TestCube
    {

        [TestMethod]
        public void TestShapeType()
        {
            Cube myShape = new Cube(2,2,2);
            Assert.IsInstanceOfType(myShape, typeof(Cube));
        }

        [TestMethod]
        public void TestCubeArea()
        {
            Cube myShape = new Cube(2, 3, 5);
            Assert.AreEqual(myShape.volume(), 30);
        }

        [TestMethod]
        public void TestCubeSurfaceArea()
        {
            Cube myShape = new Cube(2, 3, 5);
            Assert.AreEqual(myShape.surfaceArea(), 62);
        }
    }
}
