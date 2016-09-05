using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Hello
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHello()
        {
            Assert.AreEqual("Hello", Functions.Hello());
        }
        [TestMethod]
        public void TestHelloFred()
        {
            string name = "Fred";
            Assert.AreEqual("Hello, "+name, Functions.Hello(name));
        }
    }
}
