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
    public class Bai12
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                bool ac = o.IsPointInRectangle(5, 5, 7, 1, 3, 3);
                bool ex = true;
                Assert.AreEqual(ex, ac);

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
                bool ac = o.IsPointInRectangle(9, 5, 2, 1, 3, 3);
                bool ex = false;
                Assert.AreEqual(ex, ac);
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
                bool ac = o.IsPointInRectangle(7, 1, 5, 5, 6, 3);
                bool ex = true;
                Assert.AreEqual(ex, ac);
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