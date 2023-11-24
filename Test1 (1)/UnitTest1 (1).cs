using NUnit.Framework;

namespace Test1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var mainwindow = new Lab1_triangle_.MainWindow();
            var expect = "не треугольник";
            var actual = new TriangleType().Method("3", "345", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
    }
}