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
    public class Bai3
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
               ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.max(7, 12, 15);
                int ex = 15;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.max(10, 7, 9);
                int ex = 10;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.max(4,8,-2);
                int ex = 8;
                Assert.AreEqual(ac, ex);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "a, b, and c must be greater than 0";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}