using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_8a
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data_UT_Lab8_a.csv", "data_UT_Lab8_a#csv",
            DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab8_a.csv"), TestMethod]

        public void QuickSortTest()
        {
            // test cho use case 1,2,3,6,8
            MethodLibrary.MethodLibrary mtd = new MethodLibrary.MethodLibrary();
            // Đọc dữ liệu từ tệp CSV
            var data = TestContext.DataRow;
            string list = (string)data[0];
            string[] elements = list.ToString().Trim('(', ')').Split(';');

            int[] intarr = new int[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                Int32.TryParse(elements[i], out intarr[i]);

            }
            int left = (int)data[1];
            int right = (int)data[2];
            string expected = (string)data[3];
            string[] ex = expected.ToString().Trim('(', ')').Split(';');
            int[] exint = new int[ex.Length];
            for (int i = 0; i < ex.Length; i++)
            {
                Int32.TryParse(ex[i], out exint[i]);
            }
            // Thực hiện thuật toán quicksort
            mtd.QuickSort(intarr, left, right);

            // Kiểm tra kết quả
            if (expected == null)
            {
                // Nếu kết quả mong đợi là Exception, kiểm tra xem kết quả thực tế có phải là null hay không.
                Assert.IsNull(expected, "Expected an Exception but got a result.");
            }
            else
            {
                // Nếu kết quả mong đợi không phải là Exception, kiểm tra kết quả thực tế có khớp với kết quả mong đợi hay không.
                CollectionAssert.AreEqual(exint, intarr, "Sorting result doesn't match the expected result.");

            }
        }


    }
}
