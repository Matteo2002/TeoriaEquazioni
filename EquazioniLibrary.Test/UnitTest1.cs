﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 3;
            bool risp_aspettata = true;
            bool risp = Equazioni.IsDetermined(a);
            Assert.AreEqual(risp_aspettata, risp);
        }
    }
}