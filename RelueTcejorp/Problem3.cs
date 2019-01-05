using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /*
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    public class Problem3
    {
        public string Solve()
        {
            var factors = GetFactors(600851475143);
            return this.MakePrime(factors).Max().ToString();
        }

        private IEnumerable<long> GetFactors(long number)
        {
            var result = new List<long>();
            long maxFactor = (long)System.Math.Sqrt(number);
            for (long i = 2; i <= maxFactor; i++)
            {
                if (number % i == 0) result.Add(i);
            }
            return result;
        }

        private IEnumerable<long> MakePrime(IEnumerable<long> factors)
        {
            // Rationale: a factor is prime if it is not divisable by any of it's predecessors
            var result = new List<long>();
            foreach (long factor in factors)
            {
                // See if it is divisible by any of it's predecessors
                bool isPrime = factors.All(f => f >= factor || factor % f != 0);
                if (isPrime) result.Add(factor);
            }
            return result;
        }
    }
}