namespace FinalTest
{
    public class TypeReference
    {
        public readonly int Valeur;
        public TypeReference(int i)
        {
            Valeur = i;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var s = (TypeReference)obj;
            return (Valeur == s.Valeur);
        }

        public bool Equals(TypeReference s)
        {
            return Valeur == s?.Valeur;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ Valeur;
        }
    }
}