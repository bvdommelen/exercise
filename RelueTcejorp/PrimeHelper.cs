using System.Collections.Generic;

namespace ProjectEuler
{
    public static class PrimeHelper
    {
        /// <summary>
        /// Returns the collection of all prime numbers smaller or equal to the given value.
        /// </summary>
        /// <param name="highestValueInclusive">The highest value to test for primeness.</param>
        /// <returns>Collection of prime numbers smaller or equal the given value.</returns>
        public static IEnumerable<long> AllPrimes(long highestValueInclusive)
        {
            var primeFactors = new List<long>();

            // Start with number 5 (the first 6k+-1 prime)
            int currentNumber = 5;

            // Repeat until currentNumber > highestValueInclusive
            while (currentNumber <= highestValueInclusive)
            {
                // Test if number is divisble by any so far found prime factors; if not it is itself prime
                // Test 6k-1
                if (!PrimeHelper.IsDivisbleByAny(currentNumber, primeFactors)) primeFactors.Add(currentNumber);
                // Test 6k+1
                if (!PrimeHelper.IsDivisbleByAny(currentNumber+2, primeFactors)) primeFactors.Add(currentNumber+2);

                // Skip by 6
                currentNumber += 6;
            }

            // Add 2 and 3 (the only non-6k+-1 primes);
            primeFactors.Add(2);
            primeFactors.Add(3);
            return primeFactors;
        }

        /// <summary>
        /// Tests whether the given number is divisible by any of the numbers in the given collection.
        /// </summary>
        /// <param name="number">The number to test.</param>
        /// <param name="factors">The numbers to try as dividers.</param>
        /// <returns>True if the number is divisible by any number in the collection, false otherwise.</returns>
        public static bool IsDivisbleByAny(long number, IEnumerable<long> factors)
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