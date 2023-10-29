using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab3.csv", "data_UT_Lab3#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab3.csv"), TestMethod]
        public void TestMethod1()
        {
            int chiSoCu = Convert.ToInt32(TestContext.DataRow[0].ToString());
            int chiSoMoi = Convert.ToInt32(TestContext.DataRow[1].ToString());
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            double actualResult = obj.TinhTienDien(chiSoCu, chiSoMoi);
            double expectedResult = Convert.ToDouble(TestContext.DataRow[2].ToString());
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }
    }
}
