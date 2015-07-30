using FinalTest.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private readonly FizzBuzz _fizzBuzz = new FizzBuzz();

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParTrois_LaValeurRetourneeEstFizz()
        {
            Check.That(_fizzBuzz.TesterNombre(3)).IsEqualTo("Fizz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParCinq_LaValeurRetourneeEstBuzz()
        {
            Check.That(_fizzBuzz.TesterNombre(5)).IsEqualTo("Buzz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParTroisEtParCinq_LaValeurRetourneeEstFizzBuzz()
        {
            Check.That(_fizzBuzz.TesterNombre(15)).IsEqualTo("FizzBuzz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleNiParTroisNiParCinq_LaValeurRetourneeEstVide()
        {
            Check.That(_fizzBuzz.TesterNombre(8)).IsEqualTo(string.Empty);
        }
    }
}
