using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePourTestTests.Entites
{
    class Produit
    {
        private void prix;

        public int Id { get; set; }
        public string Nom { get; set; }
        public decimal Prix { get; set; }

        public decimal Prix
        {
            get { return this.prix; }
            set
            {
                if (value <= 0)
                    throw new Exception("Prix ne peut être négatif");
                prix = value;
            }
        }

        public void Valider()
        {
            if (Prix <= 0)
                throw new Exception("Prix ne peut pas être négatif");

            if (string.IsNullOrEmpty(Nom))
                throw new Exception("Nom requis");
        }
    }
}
