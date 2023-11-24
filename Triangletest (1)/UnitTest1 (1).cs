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
            var expect = "������ �������� � ���� ������ � ���������� �������";
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
        public void Test100(string a, string b, string c) //���� �� 0 ��������
        {
            var sut = new Lab1_triangle_.Controller();
            var expect = "�� �����������";
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
        public void Test1(string a, string b, string c) //���� �� 0 ��������
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method(a, b, c);
            Assert.AreEqual(expect, actual.Item1);
            //
        }
        [Test]
        public void Test2() //���� �� ������������ �����������
        {
            var sut = new TriangleType(); 
            var expect = "�� �����������";
            var actual = sut.Method("3", "356", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test3() //���� �� ��� ������������ - �������������� �1
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("3", "4", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test4() //���� �� ��� ������������ - �������������� �2
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("5", "4", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test5() //���� �� ��� ������������ - ��������������
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("3", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test6() //���� �� ��� ������������ - �������������� �1
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("3", "4", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test7() //���� �� ��� ������������ - �������������� �2
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("4", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test8() //���� �� ������ ��������
        {
            var sut = new TriangleType();
            var expect = "�� ������� �������� ������";
            var actual = sut.Method("", "3", "3");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test9() //���� �� ������ ��������
        {
            var sut = new TriangleType();
            var expect = "�� ������� �������� ������";
            var actual = sut.Method("4", "", "");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test10() //���� �� ������ ��������
        {
            var sut = new TriangleType();
            var expect = "�� ������� �������� ������";
            var actual = sut.Method("", "", "");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test11() //���� �� �������� 0
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method("0", "0", "5");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test12() //���� �� �������� 0
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method("0", "0", "0");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test13() //���� �� ������� �����
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("10000000000000000000000000000000", "10000000000000000000000000000000", "10000000000000000000000000000000");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test14() //���� �� ��������� ��������
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method("-4", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test15() //���� �� ����� 
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method("����", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test16() //���� �� �������
        {
            var sut = new TriangleType();
            var expect = "�� �����������";
            var actual = sut.Method("*8", "6", "4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test] 
        public void Test17() //���� �� �����
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("8.7", "6.7", "6.4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test18() //���� �� ������� �����
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("8,7", "6,7", "6,4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test19()  //���� �� ��������� �������� (������ �������)
        {
            var sut = new TriangleType();
            var expect = "��������������";
            var actual = sut.Method("0,9", "0,7", "0,4");
            Assert.AreEqual(expect, actual.Item1);
        }
        [Test]
        public void Test20() //���� �� ������� ����� 
        {
            var sut = new TriangleType();
            var expect = new[] { -1, -1, -1, -1, -1, -1 };
            var actual = sut.Method("0,9", "7839043,7", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test21() //���� �� ������ ��������
        {
            var sut = new TriangleType();
            var expect = new[] { -2, -2, -2, -2, -2, -2 };
            var actual = sut.Method("", "", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test22() //���� �� ���������� �� ����� �����
        {
            var sut = new TriangleType();
            var expect = new[] { 0, 0, 5, 0, 2, 4 };
            var actual = sut.Method("5", "5", "5");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test23() //���� �� ���������������� ��������� ������ ������������ (�� ������ 100)
        {
            var sut = new TriangleType();
            var expect = new[] { 0, 0, 100, 0, 49, 86 };
            var actual = sut.Method("1000000000000000000000000", "1000000000000000000000000", "1000000000000000000000000");
            Assert.AreEqual(expect, actual.Item2);
        }
        [Test]
        public void Test24() //���� �� �������� 0
        {
            var sut = new TriangleType();
            var expect = new[] { -2, -2, -2, -2, -2, -2 };
            var actual = sut.Method("0,9", "0", "0,4");
            Assert.AreEqual(expect, actual.Item2);
        }
       
    }
}