using ConsolePourTestTests.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTestTests
{
    class LignePanier
    {
        public Produit Produit { get; set; }
        public int Quantite { get; set; }
        public void Valider()
        {
            if (Quantite <0)
                throw new execution
            {

            }
        }
    }
}
