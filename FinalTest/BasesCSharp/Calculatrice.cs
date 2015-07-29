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
            if (Operation[0].PeutCalculer(p0))
            {
                return Operation[0].Calculer(p0);
            }

            if (Operation[1].PeutCalculer(p0))
            {
                return Operation[1].Calculer(p0);
            }
            return 0;
        }
    }
}