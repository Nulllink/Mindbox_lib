using System;
using NUnit.Framework;

namespace Mindbox_lib.Test
{
    [TestFixture]
    public class AreaOfTests
    {
        [Test]
        public void CircleByRadius_10_314p1593returned()
        {
            //arange
            double r = 10;
            double expected = 314.1593;
            //act
            double actual = AreaOf.CircleByRadius(r);
            //assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void TriangleBy3Sides_5and4and3_6returned()
        {
            //arange
            double a = 5;
            double b = 4;
            double c = 3;
            double expected = 6;
            //act
            double actual = AreaOf.TriangleBy3Sides(a,b,c);
            //assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void AnyFigure_10p5_346p3606returned()
        {
            //arange
            double r = 10.5;
            double expected = 346.3606;
            //act
            double actual = AreaOf.AnyFigure(r);
            //assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void AnyFigure_5and4and3_6returned()
        {
            //arange
            double a = 5;
            double b = 4;
            double c = 3;
            double expected = 6;
            //act
            double actual = AreaOf.AnyFigure(a,b,c);
            //assert
            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void IsRightTriangle_5and4and3_6returned()
        {
            //arange
            double a = 5;
            double b = 4;
            double c = 3;
            bool expected = true;
            //act
            bool actual = Triangle.IsRightTriangle(a,b,c);
            //assert
            Assert.AreEqual(expected,actual);
        }
    }
}