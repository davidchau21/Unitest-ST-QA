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
    public class Bai5
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.Average(5, 1);
            double ex = 5;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.Average(15, 60);
            double ex = 0.25;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            double ac = o.Average(11, -5);
            double ex = 0;
            Assert.AreEqual(ex, ac);
        }

    }
}