using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /*
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
     */

    public class Problem7
    {
        public string Solve()
        {
            var primeFactors = new List<int>() { 2 };

            // Start with number 3 (the second prime)
            int currentNumber = 3;

            // Repeat until 10001 primes found
            while (primeFactors.Count() < 10001)
            {
                // Test if number is divisble by any so far found prime factors; if not it is itself prime
                if (!IsDivisbleByAny(currentNumber, primeFactors)) primeFactors.Add(currentNumber);

                // Next number (skip even numbers; they're not prime anyway)
                currentNumber+=2;
            }

            return primeFactors.Last().ToString();
        }

        public bool IsDivisbleByAny(int number, IEnumerable<int> factors)
        {
            foreach (var f in factors)
            {
                if (number % f == 0) return true;
                if (f * f > number) return false;
            }

            return false;
        }
    }
}