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
        public void Test101()
        {
            var sut = new Lab1_triangle_.Controller();
            var expect = "Данные записаны в базу данных и просчитаны впервые";
            var actual = sut.ControllerTest("3", "356", "5");
            Assert.AreEqual(expect, actual.Item4);
        }

        [TestCase("3", "0", "5")]
        [TestCase("0", "3", "5")]
        [TestCase("3", "5", "0")]
        [TestCase("3", "", "5")]
        [TestCase("3", "5", "")]
        [TestCase("", "3", "5")]
        [TestCase("3", null, "5")]
        [TestCase(null, "3", "5")]
        [TestCase("3", "5", null)]
        public void Test100(string a, string b, string c) //Тест на 0 значение
        {
            var sut = new Lab1_triangle_.Controller();
            var expect = "не треугольник";
            var actual = sut.ControllerTest(a, b, c);
            Assert.AreEqual(expect, actual.Item1);
            //
        }

        [TestCase("3", "0", "5")]
        [TestCase("0", "3", "5")]
        [TestCase("3", "5", "0")]
        [TestCase("3", "", "5")]
        [TestCase("3", "5", "")]
        [TestCase("", "3", "5")]
        [TestCase("3", null, "5")]
        [TestCase(null, "3", "5")]
        [TestCase("3", "5", null)]
        public void Test1(string a, string b, string c) //Тест на 0 значение
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method(a, b, c);
            Assert.AreEqual(expect, actual.Item1);
            //
        }
        [Test]
        public void Test2() //Тест на неправильный треугольник
        {
            var sut = new TriangleType(); 
            var expect = "не треугольник";
            var actual = sut.Method("3", "356", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test3() //Тест на тип треугольника - разносторонний №1
        {
            var sut = new TriangleType();
            var expect = "Разносторонний";
            var actual = sut.Method("3", "4", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test4() //Тест на тип треугольника - разносторонний №2
        {
            var sut = new TriangleType();
            var expect = "Разносторонний";
            var actual = sut.Method("5", "4", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test5() //Тест на тип треугольника - равносторонний
        {
            var sut = new TriangleType();
            var expect = "Равносторонний";
            var actual = sut.Method("3", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test6() //Тест на тип треугольника - равнобедренный №1
        {
            var sut = new TriangleType();
            var expect = "Равнобедренный";
            var actual = sut.Method("3", "4", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test7() //Тест на тип треугольника - равнобедренный №2
        {
            var sut = new TriangleType();
            var expect = "Равнобедренный";
            var actual = sut.Method("4", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test8() //Тест на пустые значения
        {
            var sut = new TriangleType();
            var expect = "Не введены значения сторон";
            var actual = sut.Method("", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test9() //Тест на пустые значения
        {
            var sut = new TriangleType();
            var expect = "Не введены значения сторон";
            var actual = sut.Method("4", "", "");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test10() //Тест на пустые значения
        {
            var sut = new TriangleType();
            var expect = "Не введены значения сторон";
            var actual = sut.Method("", "", "");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test11() //Тест на значение 0
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method("0", "0", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test12() //Тест на значение 0
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method("0", "0", "0");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test13() //Тест на большие числа
        {
            var sut = new TriangleType();
            var expect = "Равносторонний";
            var actual = sut.Method("10000000000000000000000000000000", "10000000000000000000000000000000", "10000000000000000000000000000000");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test14() //Тест на минусовое значение
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method("-4", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test15() //Тест на буквы 
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method("пять", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test16() //Тест на символы
        {
            var sut = new TriangleType();
            var expect = "не треугольник";
            var actual = sut.Method("*8", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test] 
        public void Test17() //Тест на точку
        {
            var sut = new TriangleType();
            var expect = "Разносторонний";
            var actual = sut.Method("8.7", "6.7", "6.4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test18() //Тест на дробные числа
        {
            var sut = new TriangleType();
            var expect = "Разносторонний";
            var actual = sut.Method("8,7", "6,7", "6,4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test19()  //Тест на маленькие значения (меньше единицы)
        {
            var sut = new TriangleType();
            var expect = "Разносторонний";
            var actual = sut.Method("0,9", "0,7", "0,4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test20() //Тест на большие числа 
        {
            var sut = new TriangleType();
            var expect = new[] { -1, -1, -1, -1, -1, -1 };
            var actual = sut.Method("0,9", "7839043,7", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test21() //Тест на пустые значения
        {
            var sut = new TriangleType();
            var expect = new[] { -2, -2, -2, -2, -2, -2 };
            var actual = sut.Method("", "", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test22() //тест на округление до целых чисел
        {
            var sut = new TriangleType();
            var expect = new[] { 0, 0, 5, 0, 2, 4 };
            var actual = sut.Method("5", "5", "5");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test23() //тест на масштабируемость координат вершин треугольника (не больше 100)
        {
            var sut = new TriangleType();
            var expect = new[] { 0, 0, 100, 0, 49, 86 };
            var actual = sut.Method("1000000000000000000000000", "1000000000000000000000000", "1000000000000000000000000");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test24() //Тест на значение 0
        {
            var sut = new TriangleType();
            var expect = new[] { -2, -2, -2, -2, -2, -2 };
            var actual = sut.Method("0,9", "0", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
       
    }
}