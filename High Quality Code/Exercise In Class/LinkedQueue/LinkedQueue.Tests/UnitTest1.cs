namespace LinkedQueue.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using _01.LinkedQueue;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DequeueElement_ShouldReturn_FirstAddedElement()
        {
            var queue = new LinkedQueue<int>();
            queue.Enqueue(5);
            var deQueuedElement = queue.Dequeue();
            Assert.AreEqual(5, deQueuedElement);
        }

        [TestMethod]
        public void DequeueElements_ShouldReturn_TheSameCollection()
        {
            var queue = new LinkedQueue<int>();
            int[] numbers = { 1, 2, 3, 4, 5 };

            numbers.ToList().ForEach(n => queue.Enqueue(n));
            var result = queue.Select(e => queue.Dequeue()).ToList();

            CollectionAssert.AreEqual(numbers, result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DequeueOfEmptyQueue_ShouldReturn_Error()
        {
            var queue = new LinkedQueue<int>();

            queue.Dequeue();
        }

        [TestMethod]
        public void EnqueueSomeElements_ShouldReturn_TheSameCount()
        {
            var queue = new LinkedQueue<int>();

            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);
            queue.Enqueue(5);

            Assert.AreEqual(5, queue.Count);
        }
    }
}