using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UTLab7
    {
        [TestMethod]

        public void TestMethod1()
        {


            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            int[] a = new int[] { 2, 15, 28, 9, 1200, 2002 };
            int actualResult = obj.Largest(a);
            int expectedResult = 2002;
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void TestMethod2()
        {


            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            // Mảng a rỗng
            int[] a = new int[] { };
            int actualResult = obj.Largest(a);

            int expectedResult = 2147483647;
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
