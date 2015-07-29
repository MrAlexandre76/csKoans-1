namespace FinalTest
{
    public class SynthèseCompteBancaire
    {
        public int Credits { get; set; }
        public int Debits { get; set; }

        public string NuméroDeCompte { get; set; }

        public SynthèseCompteBancaire(string numéroDeCompte, int debits, int credits)
        {
            NuméroDeCompte = numéroDeCompte;
            Debits = debits;
            Credits = credits;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var s = (SynthèseCompteBancaire)obj;
            return (NuméroDeCompte == s.NuméroDeCompte) && (Credits == s.Credits) && (Debits == s.Debits);
        }

        public bool Equals(SynthèseCompteBancaire s)
        {
            if (s == null)
            {
                return false;
            }

            return (NuméroDeCompte == s.NuméroDeCompte) && (Credits == s.Credits) && (Debits == s.Debits);
        }
    }
}
