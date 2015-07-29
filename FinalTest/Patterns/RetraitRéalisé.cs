using System;

namespace FinalTest
{
    public struct RetraitRéalisé : IEvénementMétier
    {
        public readonly Montant MontantRetrait;
        public readonly DateTime DateRetrait;

        public string NuméroDeCompte { get; set; }

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            NuméroDeCompte = numéroDeCompte;
            MontantRetrait = montantRetrait;
            DateRetrait = dateRetrait;
        }
    }
}