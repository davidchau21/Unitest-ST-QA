using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab6
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data_UT_Lab6.csv", "data_UT_Lab6#csv", DataAccessMethod.Sequential),
            DeploymentItem("data_UT_Lab6.csv"), TestMethod()]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            String s1 = TestContext.DataRow[0].ToString();
            String s2 = TestContext.DataRow[1].ToString();
            String s3 = TestContext.DataRow[2].ToString();
            String expectedResult = TestContext.DataRow[3].ToString();
            String actualResult = obj.ThayThe(s1, s2, s3);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

