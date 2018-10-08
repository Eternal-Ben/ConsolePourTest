using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTestTests.Entites
{
    class Panier
    {
        public int MyProperty { get; set; }//a completer

        public  List<LignePanier> Lignes { get; set; } // contien une liste de ligne, donc une liste...
        public decimal FraisPort { get; set; } = 10m; // 10m pour preciser qu'il s'agit d'une decimal

        public decimal GetTotal()
        {
            if (!Lignes.Any())
            {
                return 0;
            }
            var totalLignes = Lignes.Sum(x => x.Produit.Prix * x.Quantite); // calcul...
            var fraisPort = totalLignes > 100 ? 0 : 10; // ternaire
            return totalLignes + FraisPort;
        }

        public void Valider()
        {
            foreach(var ligne in Lignes)
            {
                ligne.Valider();
            }
        }

    }
}
