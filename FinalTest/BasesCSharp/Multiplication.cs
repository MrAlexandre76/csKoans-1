namespace FinalTest
{
    public class Multiplication : IOperation
    {
        public bool PeutCalculer(string p0)
        {
            var nombres = p0.Split('*');
            foreach (var nombre in nombres)
            {
                double nombreConverti;
                if (!double.TryParse(nombre, out nombreConverti))
                {
                    return false;
                }
            }
            return true;
        }

        public double Calculer(string s)
        {
            var nombres = s.Split('*');
            double resultat = 1;
            foreach (var nombre in nombres)
            {
                double nombreConverti;
                if (double.TryParse(nombre, out nombreConverti))
                {
                    resultat *= nombreConverti;
                }
            }
            return resultat;
        }
    }
}