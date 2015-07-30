namespace FinalTest
{
    public class Calculatrice
    {
        public readonly IOperation[] Operation;

        public Calculatrice(IOperation[] operation)
        {
            Operation = operation;
        }

        public double Calculer(string p0)
        {
            //Operation[0] = multiplication
            if (Operation[0].PeutCalculer(p0))
            {
                return Operation[0].Calculer(p0);
            }

            //Operation[1] = somme
            if (Operation[1].PeutCalculer(p0))
            {
                return Operation[1].Calculer(p0);
            }
            return 0;
        }
    }
}