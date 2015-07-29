using System;

namespace FinalTest
{
    public struct DépotRéalisé : IEvénementMétier
    {
        public readonly Montant MontantDepot;
        public readonly DateTime DateDepot;

        public string NuméroDeCompte { get; set; }

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            NuméroDeCompte = numéroDeCompte;
            MontantDepot = montantDepot;
            DateDepot = dateDepot;
        }
    }
}