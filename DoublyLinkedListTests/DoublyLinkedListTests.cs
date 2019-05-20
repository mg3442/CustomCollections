using System;
using DoublyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DoublyLinkedListTests
{
    [TestClass]
    public class DoublyLinkedListTests
    {
        DoublyLinkedList<string> list = new DoublyLinkedList<string>();
        [TestMethod]
        public void AddFirstAndContainsTest()
        {
            list.AddFirst("10");
            var actual = list.Contains("10");
            Assert.AreEqual(true, actual);
        }

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void CheckAddFirstForException()
        {
            list.AddFirst(null);
        }

        [TestMethod]
        public void AddLastAndRemoveData()
        {
            list.AddLast("20");
            list.Remove("20");
            var actual = list.Contains("20");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void FindDataById()
        {
            list.AddLast("20");
            var actual = list.FindIdOfElement("20");
            var expected = $"Element {20} has id {0} in list";
            Assert.AreEqual(expected, actual);
        }
    }
}
