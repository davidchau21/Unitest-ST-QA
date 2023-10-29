using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_1b
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab1_b.csv", "data_UT_Lab1_b#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab1_b.csv"), TestMethod]
        public void MaxNumberException()
        {
            // test cho use case 2,3,10,11,12,13,14,15
            int a;
            int b;
            int c;
            string expectedException;
            MethodLibrary.MethodLibrary mth = new MethodLibrary.MethodLibrary();
            var data = TestContext.DataRow;
            a = (int)data[0];
            b = (int)data[1];
            c = (int)data[2];
            expectedException = data[3].ToString();

            try
            {
                int act = mth.Max(a, b, c);

            }
            catch (Exception ex)
            {
                // Assert that the actual exception message matches the expected string
                Assert.IsInstanceOfType(ex, typeof(IndexOutOfRangeException));
            }
        }
    }
}
