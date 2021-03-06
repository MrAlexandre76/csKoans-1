using System.Collections.Generic;
using System.Linq;

namespace FinalTest
{
    public class Nombres
    {
        public readonly IEnumerable<KeyValuePair<string, int>> KeyValuePairs;
        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            KeyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> QuatreNombresSupérieursSuivant3
        {
            get { return KeyValuePairs.OrderBy(kvp => kvp.Value).SkipWhile(kvp => kvp.Value <= 3).Take(4).Select(kvp => kvp.Value); }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get { return KeyValuePairs.First(v => v.Key.Length > 5).Key; }
        }

        public IEnumerable<int> NombresPairs
        {
            get { return KeyValuePairs.Where(v => v.Value%2 == 0).Select(kvp => kvp.Value);}
        }

        public string TexteNombresImpairs
        {
            get { return KeyValuePairs.Where(kvp => kvp.Value % 2 != 0).OrderBy(kvp => kvp.Value).Select(kvp => kvp.Key).Aggregate((a, b) => a + ", " + b); }
        }
    }
}