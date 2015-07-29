namespace FinalTest
{
    public struct CompteCréé : IEvénementMétier
    {
        public readonly int AutorisationDeCrédit;

        public string NuméroDeCompte { get; set; }

        public CompteCréé(string numéroDeCompte, int autorisationDeCrédit)
        {
            NuméroDeCompte = numéroDeCompte;
            AutorisationDeCrédit = autorisationDeCrédit;
        }
    }
}