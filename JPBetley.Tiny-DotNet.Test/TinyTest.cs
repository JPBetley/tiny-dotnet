using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JPBetley.Tiny_DotNet.Test
{
    [TestClass]
    public class TinyTest
    {
        private Tiny tiny;
        [TestInitialize]
        public void Initialize()
        {
            this.tiny = new Tiny("5SX0TEjkR1mLOw8Gvq2VyJxIFhgCAYidrclDWaM3so9bfzZpuUenKtP74QNH6B");
        }

        [TestMethod]
        public void TestToTiny()
        {
            var converted = this.tiny.To(5);
            Assert.AreEqual("E", converted);
        }

        [TestMethod]
        public void TestFromTiny()
        {
            var reversed = this.tiny.From("E");
            Assert.AreEqual(5, reversed);
        }

        [TestMethod]
        public void TestReversingRandomInt()
        {
            for (int i = 0; i <= 100; i++)
            {
                var translated = this.tiny.From(this.tiny.To(i));
                Assert.AreEqual(i, translated);
            }
        }
    }
}
