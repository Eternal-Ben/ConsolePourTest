using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsolePourTestTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int i = 1;
            int j = 2;
            Assert.AreEqual(3, i + j); // test des int
        }

        [TestMethod]
        public void TestMethodAge() // Nommage : "TestMethode+Nom de la methode à tester"
        {
            var dateNaissance = new DateTime(2010, 5, 1);
            Assert.IsTrue(
                DateTime.Today.Subtract(dateNaissance).Days / 356 > 10);
        }

    }
}
