using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Bai2
    {
        [Test]
        public void Test1()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 0;
                bool isSymmetry = false;
                long ac = o.BinaryToDe("100100111011010000", out isSymmetry);
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "The number is to big";
                Assert.AreEqual(ex, ac);
            }

        }

        [Test]
        public void Test2()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 0;
                bool isSymmetry = false;
                long ac = o.BinaryToDe("120", out isSymmetry);
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid binary format";
                Assert.AreEqual(ex, ac);
            }

        }

        [Test]
        public void Test3()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 5;
                bool isSymmetry = true;
                long ac = o.BinaryToDe("101", out isSymmetry);
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid binary format";
                Assert.AreEqual(ex, ac);
            }

        }

        [Test]
        public void Test4()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 4;
                bool isSymmetry = false;
                long ac = o.BinaryToDe("100", out isSymmetry);
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid binary format";
                Assert.AreEqual(ex, ac);
            }

        }
    }
}
