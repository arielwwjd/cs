using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorManagerLibrary.Models;

namespace TestVector
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Dot point = new Dot(2, 5);
            Assert.AreEqual(point.px == 2, point.py == 5);
        }
    }
}
