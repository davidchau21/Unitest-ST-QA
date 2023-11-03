using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class Bai13
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();

                var result = o.CreateIcon(-1, 0);

            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();

                var result = o.CreateIcon(5, 2);
                double expectedX = 1.5;
                float expectedY = 0;
                float expectedS = 2;

                Assert.AreEqual(expectedX, result.x);
                Assert.AreEqual(expectedY, result.y);
                Assert.AreEqual(expectedS, result.s);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                var result = o.CreateIcon(3, 7);
                float expectedX = 0;
                float expectedY = 2;
                float expectedS = 3;

                Assert.AreEqual(expectedX, result.x);
                Assert.AreEqual(expectedY, result.y);
                Assert.AreEqual(expectedS, result.s);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Invalid input values";
                Assert.AreEqual(ex, ac);
            }
        }

    }
}