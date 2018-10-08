using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsolePourTestTests.Entites;

namespace ConsolePourTestTests
{
    [TestClass]
    public class PanierTest
    {
        [TestMethod]
        public void CalculPrixTotalQuandVide()
        {
            var panier = new Panier();
            Assert.AreEqual(0, panier.GetTotal());
        }

        [TestMethod]
        public void CalculPrixTotalNormal()
        {
            var panier = new Panier();
            panier.Lignes.Add(new LignePanier
            {
                Produit = new Produit
                {
                    Nom = "Troçoneuses",
                    Prix = 90
                },
                Quantite = 1
            });
            Assert.AreEqual(100, panier.GetTotal());
        }

        [TestMethod]
        public void FraisPortOffertsSiSuperieur100()
        {
            var panier = new Panier();
            panier.Lignes.Add(new LignePanier
            {
                Produit = new Produit
                {
                    Nom = "Troçoneuses",
                    Prix = 90
                },
                Quantite = 2
            });
            Assert.AreEqual(180, panier.GetTotal());
        }

    }
}
