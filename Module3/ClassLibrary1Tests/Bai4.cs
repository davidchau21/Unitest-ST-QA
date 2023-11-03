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
    public class Bai4
    {
        [TestMethod()]
        public void Method1()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(3, 3, 3);
            string ex = "Triangle is Equilateral";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method2()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(10,5,6);
            string ex = "Triangle is Scalene";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method3()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(5,5,2);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method4()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(2,7,2);
            string ex = "Not a Triangle";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method5()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(3,5, 11);
            string ex = "Not a Triangle";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method6()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(11, 3, 5);
            string ex = "Not a Triangle";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method7()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(3, 11, 5);
            string ex = "Not a Triangle";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method8()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(8, 8, 11);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method9()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(8, 5, 8);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method10()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(8, 5, 13);
            string ex = "Triangle is Equilateral";
            Assert.AreEqual(ex, ac);
        }
        [TestMethod()]
        public void Method11()
        {
            ClassLibrary1.ClassLibraryMethod o = new ClassLibrary1.ClassLibraryMethod();
            string ac = o.Triangle(8, 13, 8);
            string ex = "Triangle is Isosceles";
            Assert.AreEqual(ex, ac);
        }
    }
}