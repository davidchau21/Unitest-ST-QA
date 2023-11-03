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
    public class Bai6
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2002, 3);
            double ex = 31;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2004, 13);
            double ex = 0;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2004, 11);
            double ex = 30;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2032, 2);
            double ex = 29;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2100, 2);
            double ex = 28;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method6()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2025, 2);
            double ex = 28;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method7()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.daysInMonth(2400, 2);
            double ex = 29;
            Assert.AreEqual(ex, ac);
        }
    }
}