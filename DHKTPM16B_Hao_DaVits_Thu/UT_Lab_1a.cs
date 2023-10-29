using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_1a
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab1_a.csv", "data_UT_Lab1_a#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab1_a.csv"), TestMethod]

        public void MaxNumberTest()
        {
            //test cho utc 1,4,5,6,7,8,9
            int a;
            int b;
            int c;
            int maxNum; // Change the type to string
            MethodLibrary.MethodLibrary mth = new MethodLibrary.MethodLibrary();
            var data = TestContext.DataRow;
            a = (int)data[0];
            b = (int)data[1];
            c = (int)data[2];
            maxNum = (int)data[3]; // Handle it as a string

            int act = mth.Max(a, b, c);

            Assert.AreEqual(maxNum, act);

        }

    }
}
