using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JurnalModul12_2311104079;

namespace UnitTestProjectJurnal12.Properties
{

[TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPangkatNormal()
        {
            Assert.AreEqual(8, Form1.CariNilaiPangkat(2, 3));
        }

        [TestMethod]
        public void TestPangkat0()
        {
            Assert.AreEqual(1, Form1.CariNilaiPangkat(0, 0));
        }

        [TestMethod]
        public void TestPangkatNegatif()
        {
            Assert.AreEqual(-1, Form1.CariNilaiPangkat(3, -1));
        }

        [TestMethod]
        public void TestBPangkatLebihDari10()
        {
            Assert.AreEqual(-2, Form1.CariNilaiPangkat(2, 11));
        }

        [TestMethod]
        public void TestANilaiLebihDari100()
        {
            Assert.AreEqual(-2, Form1.CariNilaiPangkat(101, 2));
        }

        [TestMethod]
        public void TestOverflow()
        {
            Assert.AreEqual(-3, Form1.CariNilaiPangkat(99999, 10));
        }
    }

}
