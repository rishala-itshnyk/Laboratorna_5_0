using System;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int t = Program.Sum(2, 3);
            Assert.AreEqual(5, t);
        }
    }
}