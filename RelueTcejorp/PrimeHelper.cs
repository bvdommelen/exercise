using System;
using System.Linq;
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
            var primes = new List<long>();

            // Start with number 5 (the first 6k+-1 prime)
            int currentNumber = 5;

            // Repeat until currentNumber > highestValueInclusive
            while (currentNumber <= highestValueInclusive)
            {
                // Test if number is divisble by any so far found prime factors; if not it is itself prime
                // Test 6k-1
                if (!PrimeHelper.IsDivisbleByAny(currentNumber, primes)) primes.Add(currentNumber);
                // Test 6k+1
                if (!PrimeHelper.IsDivisbleByAny(currentNumber+2, primes)) primes.Add(currentNumber+2);

                // Skip by 6
                currentNumber += 6;
            }

            // Add 2 and 3 (the only non-6k+-1 primes);
            primes.Add(2);
            primes.Add(3);
            return primes;
        }

        /// <summary>
        /// Returns the collection of all prime factors of the given number.
        /// </summary>
        /// <param name="number">The number for which to get prime factors.</param>
        /// <returns>Collection of prime numbers that are prime factors of the given number.</returns>
        public static IEnumerable<long> PrimeFactors(long number)
        {
            return PrimeFactors(number, AllPrimes((long)Math.Floor(Math.Sqrt(number))));
        }

        public static IEnumerable<long> PrimeFactors(long number, IEnumerable<long> primeTable)
        {
            return primeTable.Where(f => number % f == 0);
        }

        /// <summary>
        /// Returns the collection of all factors of the given number.
        /// </summary>
        /// <param name="number">The number for which to get prime factors.</param>
        /// <returns>Collection of prime numbers that are prime factors of the given number; every prime factor is present as many times as it is a divider.</returns>
        public static IEnumerable<long> AllFactors(long number)
        {
            return AllFactors(number, AllPrimes((long)Math.Floor(Math.Sqrt(number))));
        }

        public static IEnumerable<long> AllFactors(long number, IEnumerable<long> primeTable)
        {
            var primeFactors = PrimeFactors(number, primeTable);
            var allFactors = new List<long>();
            // To find how many times each prime factor is a divisor simply keep dividing by the given prime factor and test the remainder.
            foreach (var f in primeFactors)
            {
                while (number % f == 0)
                {
                    number = number / f;
                    allFactors.Add(f);
                }
            }
            return allFactors;
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