using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using qsec.mission6;
using System.Threading;

namespace qsec.mission6.test
{
    [TestClass]
    public class DelayedQueueTests
    {
        [TestMethod]
        public void Test_Delayed_Queue()
        {
            var time = TimeSpan.FromSeconds(5);
            var q = new DelayedQueue<int>();
            q.AddAsync(10,time);
            Assert.AreEqual(q.QueueSize, 0);
            Thread.Sleep(5);
            Assert.AreEqual(q.QueueSize, 1);

        }

    }
}
