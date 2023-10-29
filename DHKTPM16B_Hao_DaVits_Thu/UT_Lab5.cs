using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab5
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data_UT_Lab5.csv", "data_UT_Lab5#csv", DataAccessMethod.Sequential),
            DeploymentItem("data_UT_Lab5.csv"), TestMethod()]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String s = TestContext.DataRow[0].ToString();
            int n = Int32.Parse(TestContext.DataRow[1].ToString());
            int p = Int32.Parse(TestContext.DataRow[2].ToString());
            String expectedResult = TestContext.DataRow[3].ToString();
            String actualResult = obj.HuyChuoi(s, n, p);
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
