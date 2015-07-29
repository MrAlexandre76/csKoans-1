using System.Linq;

namespace FinalTest
{
    public class SynthèseCompteBancaireProjection
    {
        private readonly ISynthèseCompteBancaireRepository _repository;

        public SynthèseCompteBancaireProjection(ISynthèseCompteBancaireRepository repository)
        {
            _repository = repository;
        }

        public void Handle(IEvénementMétier operationRealise)
        {
            var synthèseDuCompte =
                ((FakeRepository)_repository).Synthèses.First(
                    s => s.NuméroDeCompte == operationRealise.NuméroDeCompte);

            if (operationRealise is DépotRéalisé)
            {
                synthèseDuCompte.Credits += ((DépotRéalisé)operationRealise).MontantDepot.ValeurMontant;
            }
            else
            {
                synthèseDuCompte.Debits += ((RetraitRéalisé)operationRealise).MontantRetrait.ValeurMontant;
            }

            var index = ((FakeRepository)_repository).Synthèses.FindIndex(s => s.NuméroDeCompte == operationRealise.NuméroDeCompte);
            ((FakeRepository)_repository).Synthèses[index] = synthèseDuCompte;
        }
    }
}
