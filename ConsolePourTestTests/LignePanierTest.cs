using ConsolePourTestTests.Entites;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTestTests
{
    [TestClass]
    class LignePanierTest
    {
        [TestMethod]
        public void ValiderQuantitePositive()
        {
            var lignePanier = new LignePanier
            {
                Produit = new Produit(),
                Quantite = -1
            };
        var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
        Assert.AreEqual("Quantite doit être positive", exception.Message); // pensez a bien mette "exception.Message
        }

        [TestMethod]
        public void ValiderProduitRenseigne()
        {
            var lignePanier = new LignePanier
            {
                Produit = null,
                Quantite = 1
            };
            var exception = Assert.ThrowsException<Exception>(() => lignePanier.Valider());
            Assert.AreEqual("Produit est requis", exception.Message);
        }

    }

}
