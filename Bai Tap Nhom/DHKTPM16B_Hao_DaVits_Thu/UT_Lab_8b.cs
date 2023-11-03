using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHKTPM16B_Hao_DaVits_Thu
{
    [TestClass]
    public class UT_Lab_8b
    {
        // test cho use case 4,5,7,9,10
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data_UT_Lab8_b.csv", "data_UT_Lab8_b#csv",
            DataAccessMethod.Sequential),
        DeploymentItem("data_UT_Lab8_b.csv"), TestMethod]

        public void QuickSortTestException()
        {
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


            try
            {
                // Thực hiện thuật toán quicksort
                mtd.QuickSort(intarr, left, right);
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(IndexOutOfRangeException));
            }
        }
    }
}
