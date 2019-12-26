using NUnit.Framework;
using System;

namespace TestProject
{
    [TestFixture]
    public class Class1
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("DF");
        }
        [Test]
        public void MyTestMethod()
        {
            Assert.AreEqual(8, new ClassLibrary1.Class1().TestFunction());
        }

        [Test]
        public void TestLineEndings()
        {
            string testString = @"Das ist CRLF
Zweite Zeile";


            string expected = "Das ist CRLF\r\nZweite Zeile";

            Assert.AreEqual(expected, testString);
        }
    }
}
