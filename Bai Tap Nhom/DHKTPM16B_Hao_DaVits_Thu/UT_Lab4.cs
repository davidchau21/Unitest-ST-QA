using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab4
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            long s;
            long expected = obj.Sum(6, out s);
            Assert.AreEqual(expected, 4);
            Assert.AreEqual(10, s);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            long s;
            long expected = obj.Sum(-5, out s);
            Assert.AreEqual(expected, null);
            Assert.AreEqual("Lỗi",s);
        }
        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            long s;
            long expected = obj.Sum(0, out s);
            Assert.AreEqual(expected, 1);
            Assert.AreEqual(0, s);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            long s;
            long expected = obj.Sum(-1, out s);
            Assert.AreEqual(expected, null);
            Assert.AreEqual("Lỗi", s);
        }

    }
}
