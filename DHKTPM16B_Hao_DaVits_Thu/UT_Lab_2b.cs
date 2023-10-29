using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_2b
    {
        // test cho use case 7,8
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data_UT_Lab2_b.csv", "data_UT_Lab2_b#csv",
            DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab2_b.csv"), TestMethod]

        public void SolveQuadraticTestException()
        {
            MethodLibrary.MethodLibrary mtd = new MethodLibrary.MethodLibrary();
            // Read data from CSV
            var data = TestContext.DataRow;
            int a, b, c;
            string expectedOutcome, expectedMessage;

            if (int.TryParse(data[0].ToString(), out a) &&
                int.TryParse(data[1].ToString(), out b) &&
                int.TryParse(data[2].ToString(), out c))
            {
                // Chỉ tiếp tục nếu a, b, và c là số nguyên hợp lệ
                expectedOutcome = data[3].ToString();
                expectedMessage = data[4].ToString();

                try
                {
                    float x1, x2;
                    string actualOutcome = mtd.SolveQuadratic(a, b, c, out x1, out x2);

                    // Kiểm tra kết quả
                    Assert.AreEqual(expectedOutcome, actualOutcome, $"For a={a}, b={b}, c={c}");

                    // Kiểm tra thông báo
                    Assert.AreEqual(expectedMessage, actualOutcome, $"For a={a}, b={b}, c={c}");
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có và đánh dấu bài kiểm tra là thất bại
                    Assert.Fail($"Ngoại lệ xảy ra: {ex.Message}");
                }
            }
            else
            {
                // Xử lý trường hợp dữ liệu đầu vào không phải số nguyên
                Assert.Fail("Dữ liệu đầu vào không phải số nguyên.");
            }

        }
    }
}
