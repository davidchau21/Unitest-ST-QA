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
    public class Bai2
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            char ac = o.checkValues(1, 2, 5);
            char ex = 'A';
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            char ac = o.checkValues(3, 8, 5);
            char ex = 'B';
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            char ac = o.checkValues(3, 12, 4);
            char ex = 'C';
            Assert.AreEqual(ac, ex);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            char ac = o.checkValues(3, 12, 8);
            char ex = 'D';
            Assert.AreEqual(ac, ex);
        }
    }
}