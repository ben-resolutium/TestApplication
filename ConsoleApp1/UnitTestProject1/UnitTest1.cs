using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp1;
using Moq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expectedId = 7;
            var repo = new MyRepository(new Mock<IListService<Item>>().Object);
            var item = repo.GetItem(expectedId);
            Assert.IsNotNull(item);
            Assert.AreEqual(expectedId, item.Id);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var expectedList = new List<Item>()
            {
                new Item() { Id = 2, Name = Guid.NewGuid().ToString(), Description = "Description 2" },
                new Item() { Id = 4, Name = Guid.NewGuid().ToString(), Description = "Description 4" },
                new Item() { Id = 6, Name = Guid.NewGuid().ToString(), Description = "Description 6" }
            };
            Mock<IListService<Item>> listServiceMock = new Mock<IListService<Item>>();
            listServiceMock.Setup(itemList => itemList.GetItems()).Returns(expectedList);

            var repo = new MyRepository(listServiceMock.Object);
            var items = repo.GetItems();
            Assert.IsNotNull(items);
            CollectionAssert.AreEqual(expectedList, items);
        }
    }
}
