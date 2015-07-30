namespace FinalTest.FizzBuzz
{
    public class FizzBuzz
    {
        public string TesterNombre(int nombre)
        {
            if (nombre%5 == 0 && nombre % 3 == 0)
            {
                return "FizzBuzz";
            }

            if (nombre % 5 == 0)
            {
                return "Buzz";
            }

            if (nombre%3 == 0)
            {
                return "Fizz";
            }
            return string.Empty;
        }
    }
}