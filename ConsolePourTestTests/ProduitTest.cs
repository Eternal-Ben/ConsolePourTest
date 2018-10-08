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
    public class ProduitTest
    {
        [DataTestMethod]
        [DataRow("0")] // test quantite ?
        [DataRow("-1")]
        public void ValiderPrix(decimal rawPrix)
        {
            var exeception = Assert.ThrowsException<Exception>())=>{
                var produit = new Produit
                {
                    Nom = "Bouteille Bordeaux",
                    Prix = prix

                });

        }

        [TestMethod]
        public void ImpossibleDeMettreNomVide()
        {
            Assert.ThrowsException<Exception>(() =>
            {
                var produit = new Produit
                {
                    Nom = "",
                    Prix = 10
                };
                produit.Valider();
            });
        }

        [TestMethod]
        public void ImpossibleDeMettrePrixInfOuEgal0()
        {
            });
            Assert.AreEqual("Prix ne peut pas être négatif", Exception.Message);
            }
        }


    }
}
