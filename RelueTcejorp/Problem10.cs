using System.Linq;

namespace ProjectEuler
{
    /*
     * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
     * Find the sum of all the primes below two million.
     */

    public class Problem10
    {
        public string Solve()
        {
            var primes = PrimeHelper.AllPrimes(1999999);
            return primes.Sum().ToString();
        }
    }
}