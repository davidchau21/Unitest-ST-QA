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
    public class Bai7
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                string ac = o.Solve(0, 4, 7);
                string ex = "error";
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method2()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                string ac = o.Solve(1,-3,2);
                string ex = "2,1";
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method3()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                string ac = o.Solve(1,2,3);
                string ex = "no result";
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ex, ac);
            }
        }
        [TestMethod()]
        public void Method4()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                string ac = o.Solve(1,2,1);
                string ex = "-1";
                Assert.AreEqual(ex, ac);
            }
            catch (Exception e)
            {
                string ac = e.Message;
                string ex = "Coefficient 'a' cannot be zero";
                Assert.AreEqual(ac, ex);
            }
        }
    }
}