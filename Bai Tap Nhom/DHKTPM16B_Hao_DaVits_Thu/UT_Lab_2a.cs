using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_2a
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\data_UT_Lab2_a.csv", "data_UT_Lab2_a#csv",
        DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab2_a.csv"), TestMethod]
        public void SolveQuadratic()
        {
            // test cho use case 1,2,3,4,5,6
            MethodLibrary.MethodLibrary mtd = new MethodLibrary.MethodLibrary();
            // Initialize variables
            int a, b, c;
            float x1, x2;
            string expectedOutcome;

            // Read data from CSV
            var data = TestContext.DataRow;
            a = (int)data[0];
            b = (int)data[1];
            c = (int)data[2];
            expectedOutcome = (string)data[3];
            byte[] utf = System.Text.Encoding.Default.GetBytes(expectedOutcome);
            string ex = System.Text.Encoding.UTF8.GetString(utf);

            // Call the SolveQuadratic method
            string actualOutcome = mtd.SolveQuadratic(a, b, c, out x1, out x2);

            // Check the result
            Assert.AreEqual(ex, actualOutcome);

            // Check the roots (x1 and x2) if applicable
            if (expectedOutcome.Contains("Có 2 nghiệm") || expectedOutcome.Contains("Có nghiệm kép"))
            {
                Assert.AreEqual((float)data[4], x1, 1e-6f);
                Assert.AreEqual((float)data[5], x2, 1e-6f);
            }

        }
    }
}
