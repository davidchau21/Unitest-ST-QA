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
    public class Bai9
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            bool ac = o.isTriangle(3, 4, 5);
            bool ex = true;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            bool ac = o.isTriangle(-15,-6,5);
            bool ex = false;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            bool ac = o.isTriangle(1,3,6);
            bool ex = false;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            bool ac = o.isTriangle(2,5,1);
            bool ex = false;
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            bool ac = o.isTriangle(10,5,3);
            bool ex = false;
            Assert.AreEqual(ex, ac);
        }

    }
}