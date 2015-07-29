using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class CompteBancaire
    {
        private readonly IEnumerable<IEvénementMétier> _evenementsMetiers;

        public CompteBancaire(params IEvénementMétier[] evenementsMetier)
        {
            _evenementsMetiers = new List<IEvénementMétier>();
            _evenementsMetiers = _evenementsMetiers.Concat(evenementsMetier);
        }

        public CompteBancaire(IEvénementMétier evenementMetier)
        {
            _evenementsMetiers = new List<IEvénementMétier>();
            _evenementsMetiers = _evenementsMetiers.Concat(new[] { evenementMetier });
        }

        public static IEnumerable<IEvénementMétier> Ouvrir(string numéroDeCompte, int autorisationDeCrédit)
        {
            var compteCree = new CompteCréé(numéroDeCompte, autorisationDeCrédit);
            return new[] { (IEvénementMétier)compteCree };
        }

        public IEnumerable<IEvénementMétier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            var numeroDeCompte = RecupererNumeroDeCompte();
            if (numeroDeCompte == string.Empty)
            {
                return null;
            }

            var depot = new DépotRéalisé(numeroDeCompte, montantDepot, dateDepot);
            return new[] { (IEvénementMétier)depot };
        }

        public IEnumerable<IEvénementMétier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            var numeroDeCompte = RecupererNumeroDeCompte();
            if (numeroDeCompte == string.Empty)
            {
                return null;
            }

            var retrait = new RetraitRéalisé(numeroDeCompte, montantRetrait, dateRetrait);
            var montantRestantSurLeCompte = CalculerMontantRestantSurLeCompteApresRetrait(retrait);

            if (montantRestantSurLeCompte >= 0)
            {
                return new[] { (IEvénementMétier)retrait };
            }

            if (Math.Abs(montantRestantSurLeCompte) > RecupererAutorisationDeCredit())
            {
                throw new RetraitNonAutorisé();
            }

            var balanceNegative = new BalanceNégativeDétectée(numeroDeCompte, new Montant(Math.Abs(montantRestantSurLeCompte)), dateRetrait);
            return new[] { (IEvénementMétier)retrait, balanceNegative };
        }

        private string RecupererNumeroDeCompte()
        {
            var compteCree = _evenementsMetiers.FirstOrDefault(e => e is CompteCréé);
            return compteCree != null ? ((CompteCréé)compteCree).NuméroDeCompte : string.Empty;
        }

        private int RecupererAutorisationDeCredit()
        {
            var compteCree = _evenementsMetiers.FirstOrDefault(e => e is CompteCréé);
            return compteCree != null ? ((CompteCréé)compteCree).AutorisationDeCrédit : 0;
        }

        private int CalculerMontantRestantSurLeCompteApresRetrait(RetraitRéalisé retraitRealise)
        {
            var listeDebitsEtCredits = _evenementsMetiers.Where(e => e is RetraitRéalisé || e is DépotRéalisé);
            var soldeCompte = 0;
            foreach (var debitCredit in listeDebitsEtCredits)
            {
                if (debitCredit is DépotRéalisé)
                {
                    soldeCompte += ((DépotRéalisé)debitCredit).MontantDepot.ValeurMontant;
                }
                else
                {
                    soldeCompte -= ((RetraitRéalisé)debitCredit).MontantRetrait.ValeurMontant;
                }
            }

            return soldeCompte - retraitRealise.MontantRetrait.ValeurMontant;
        }
    }
}
