using FinalTest.FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NFluent;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParTrois_LaValeurRetourneeEstFizz()
        {
            var fizzBuzz = new FizzBuzz();
            Check.That(fizzBuzz.TesterNombre(3)).IsEqualTo("Fizz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParCinq_LaValeurRetourneeEstBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            Check.That(fizzBuzz.TesterNombre(5)).IsEqualTo("Buzz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleParTroisEtParCinq_LaValeurRetourneeEstFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();
            Check.That(fizzBuzz.TesterNombre(15)).IsEqualTo("FizzBuzz");
        }

        [TestMethod]
        public void TestUnNombreEnvoyeDivisibleNiParTroisNiParCinq_LaValeurRetourneeEstVide()
        {
            var fizzBuzz = new FizzBuzz();
            Check.That(fizzBuzz.TesterNombre(8)).IsEqualTo(string.Empty);
        }
    }
}
