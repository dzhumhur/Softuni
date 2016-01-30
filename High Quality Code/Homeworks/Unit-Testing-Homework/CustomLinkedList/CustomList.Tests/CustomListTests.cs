using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomList.Tests
{
    using CustomLinkedList;

    [TestClass]
    public class CustomListTests
    {
        private DynamicList<int> linkedList;

        [TestInitialize]
        public void InitializeLinkedList()
        {
            this.linkedList = new DynamicList<int>();
        }

        [TestMethod]
        public void AddMethod_ShouldAdd_TheValueAtTheEndOfList()
        {
            this.linkedList.Add(5);
            var value = this.linkedList[0];

            Assert.AreEqual(5, value);
        }

        [TestMethod]
        public void Index_ShouldReturn_TheValueOfSearchedIndex()
        {
            this.linkedList.Add(4);
            var returnedNumber = this.linkedList[0];
            Assert.AreEqual(4, returnedNumber);
        }
        
        [TestMethod]
        public void RemoveAt_ShouldDelete_ElementFromTheGivenPosition()
        {
            this.linkedList.Add(5);
            this.linkedList.Add(50);
            this.linkedList.Add(500);
            var removedElement = this.linkedList.RemoveAt(2);

            Assert.AreEqual(500, removedElement);
        }

        [TestMethod]
        public void remove()
        {

        }

        [TestMethod]
        public void contains()
        {

        }
    }
}
