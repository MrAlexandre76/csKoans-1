using System;

namespace FinalTest
{
    public struct BalanceNégativeDétectée : IEvénementMétier
    {
        public readonly DateTime DateRetrait;
        public readonly Montant Montant;

        public string NuméroDeCompte { get; set; }

        public BalanceNégativeDétectée(string numéroDeCompte, Montant montant, DateTime dateRetrait)
        {
            NuméroDeCompte = numéroDeCompte;
            Montant = montant;
            DateRetrait = dateRetrait;
        }
    }
}