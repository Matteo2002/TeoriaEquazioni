using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined()
        {
            double a = 3;
            bool risp_aspettata = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_aspettata, risp);
        }

        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = - 3;
            bool risp_aspettata = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_aspettata, risp);
        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = 0;
            bool risp_aspettata = false;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_aspettata, risp);
        }

        [TestMethod]
        public void TestIsConsisted3()
        {
            double a = 0, b = 0;
            bool risp_aspettata = true;
            bool risp = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risp_aspettata, risp);
        }

        [TestMethod]
        public void TestIsDegree2()
        {
            double a = 0;
            bool risp_aspettata = false;
            bool risp = Equazioni.IsDegree2(a);
            Assert.AreEqual(risp_aspettata, risp);
        }


    }
}
