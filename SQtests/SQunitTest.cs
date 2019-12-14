using SQlibrary.models;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQlibrary.factory;

namespace SQtests
{
    [TestClass]
    public class SQunitTest
    {
        [TestMethod]
        public void Circle_getSquare()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.5, circle.getSquare());
        }

        [TestMethod]
        public void Triangle_getSquare()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.getSquare());
        }

        [TestMethod]
        public void Triangle_isRight()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(true, triangle.isRightAngle());

            triangle = new Triangle(3, 7, 10);
            Assert.AreEqual(false, triangle.isRightAngle());
        }

        [TestMethod]
        public void TriangleFactory_isTriangleOK()
        {
            TriangleFactory factory = new TriangleFactory(null);
            Assert.AreEqual(true, factory.isTriangleOK(3, 10, 7));
            Assert.AreEqual(false, factory.isTriangleOK(1, 2, 15));
        }
    }
}
