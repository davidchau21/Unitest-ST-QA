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
    public class Bai1
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            int ac = o.getPositionOf2Cir(3, 3, 0);
            int ex = 0;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            int ac = o.getPositionOf2Cir(2, 2, 4);
            int ex = 3;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            int ac = o.getPositionOf2Cir(6, 7, 0);
            int ex = 1;
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            int ac = o.getPositionOf2Cir(10, 5, 0);
            int ex = 2;
            Assert.AreEqual(ac, ex);
        }

    }
}