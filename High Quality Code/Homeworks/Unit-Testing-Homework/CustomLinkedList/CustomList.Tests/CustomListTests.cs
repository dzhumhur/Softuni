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
        public void AddMethod_ShouldAdd_TheValueInTheEndOF()
        {
            this.linkedList
        }

        [TestMethod]
        public void Index_ShouldReturn_TheValueOfSearchedIndex()
        {
            this.linkedList.Add(4);
            var returnedNumber = this.linkedList[0];
            Assert.AreEqual(4, returnedNumber);
        }

       

        [TestMethod]
        public void removeat()
        {

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
