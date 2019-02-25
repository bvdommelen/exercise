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
            var primeFactors = new List<long>() { 2 };

            // Start with number 3 (the second prime)
            int currentNumber = 3;

            // Repeat until currentNumber > highestValueInclusive
            while (currentNumber <= highestValueInclusive)
            {
                // Test if number is divisble by any so far found prime factors; if not it is itself prime
                if (!PrimeHelper.IsDivisbleByAny(currentNumber, primeFactors)) primeFactors.Add(currentNumber);

                // Next number (skip even numbers; they're not prime anyway)
                currentNumber += 2;
            }

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