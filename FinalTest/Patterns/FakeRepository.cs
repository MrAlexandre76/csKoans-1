using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class FakeRepository : ISynthèseCompteBancaireRepository
    {
        public List<SynthèseCompteBancaire> Synthèses = new List<SynthèseCompteBancaire>();

        public SynthèseCompteBancaire Get(string numeroDeCompte) // c'est la seule méthode à mettre dans l'interface
        {
            return Synthèses.First(x => x.NuméroDeCompte == numeroDeCompte);
        }
    }
}
