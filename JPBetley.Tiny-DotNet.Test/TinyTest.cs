using System;
using NUnit.Framework;

namespace JPBetley.Tiny_DotNet.Test
{
    [TestFixture]
    public class TinyTest
    {
        private Tiny tiny;
        [SetUp]
        public void Initialize()
        {
            this.tiny = new Tiny("5SX0TEjkR1mLOw8Gvq2VyJxIFhgCAYidrclDWaM3so9bfzZpuUenKtP74QNH6B");
        }

        [Test]
        public void TestToTiny()
        {
            var converted = this.tiny.To(5);
            Assert.AreEqual("E", converted);
        }

        [Test]
        public void TestFromTiny()
        {
            var reversed = this.tiny.From("E");
            Assert.AreEqual(5, reversed);
        }

        [Test]
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
