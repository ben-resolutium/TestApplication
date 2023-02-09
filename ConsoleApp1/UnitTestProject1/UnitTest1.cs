using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repo = new MyRepository();
            var item = repo.GetItem(1);
            Assert.IsNotNull(item);
            Assert.AreEqual("First Item", item.Name);
        }
    }
}
