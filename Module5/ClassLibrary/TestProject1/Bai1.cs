
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Bai1
    {
        [Test]
        public void Test1()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 0;
                long sum;
                long ac = o.K(-5, out sum);
                Assert.AreEqual(ex, ac);
            }
            catch(Exception e)
            {
                string ac = e.Message;
                string ex = "tong nho hon 1";
                Assert.AreEqual(ex, ac);
            }
          
        }

        [Test]
        public void Test2()
        {
            try
            {
                ClassLibrary.ClassLibrary o = new ClassLibrary.ClassLibrary();
                long ex = 4;
                long sum;
                long ac = o.K(5, out sum);
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "tong nho hon 1";
                Assert.AreEqual(ex, ac);
            }


        }
    }
}