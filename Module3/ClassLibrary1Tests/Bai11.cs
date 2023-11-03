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
    public class Bai11
    {
        [TestMethod()]
        public void Method1()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.CalculatePrice(-9, 151, 200, 500);
                int ex = 0;
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
                int ac = o.CalculatePrice(80, 125, 152, 60);
                int ex = 4800;
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
                int ac = o.CalculatePrice(50, 130, 160, 200);
                int ex = 19500;
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
        public void Method4()
        {
            try
            {
                ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
                int ac = o.CalculatePrice(62, 127, 175, 111);
                int ex = 7597;
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