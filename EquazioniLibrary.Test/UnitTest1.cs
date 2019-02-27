using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDetermined1()
        {
            double a = 3;
            bool Risp_aspettata = true;

            bool risp = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risp_aspettata, risp);

        }

        [TestMethod]
        public void TestIsDetermined2()
        {
            double a = -5;

            bool Risp_aspettata = true;

            bool risp = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risp_aspettata, risp);

        }

        [TestMethod]
        public void TestIsDetermined3()
        {
            double a = 0;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsDetermined(a);

            Assert.AreEqual(Risp_aspettata, risp);
        }


        [TestMethod]
        public void TestInconsisted1()
        {
            double a = 0, b = 0;
            bool Risp_aspettata = true;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted2()
        {
            double a = 3, b = 0;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted3()
        {
            double a = 0, b = 3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted4()
        {
            double a = -3, b = 0;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted5()
        {
            double a = 0, b = -3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted6()
        {
            double a = 3, b = 3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted7()
        {
            double a = -3, b = -3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted8()
        {
            double a = -3, b = 3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestInconsisted9()
        {
            double a = 3, b = -3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsInconsisted(a, b);

            Assert.AreEqual(Risp_aspettata, risp);

        }

        [TestMethod]
        public void TestIsDegree2_1()
        {
            double a = 0;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsDegree2(a);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestIsDegree2_2()
        {
            double a = 3;
            bool Risp_aspettata = false;

            bool risp = Equazioni.IsDegree2(a);

            Assert.AreEqual(Risp_aspettata, risp);
        }


        [TestMethod]
        public void TestDelta()
        {
            double a = 0;

            bool Risp_aspettata = false;

            bool risp = Equazioni.IsDegree2(a);

            Assert.AreEqual(Risp_aspettata, risp);
        }

        [TestMethod]
        public void TestEquationDegree1()
        {
            double a = 0;
            double b = 0;

            string Risp_aspettata = "Indeterminato || Impossibile";

            string risp = Equazioni.EquationDegree1(a, b);

            Assert.AreEqual(Risp_aspettata, risp);
        }

    }

}
