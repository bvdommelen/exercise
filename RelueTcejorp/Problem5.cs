using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /*
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */

    public class Problem5
    {
        public string Solve()
        {
            /*
             * Rationale: any number that must be divided by a set of numbers X must contain at least n time the prime factor in each number x in X where n is the largest occurence of this prime factor in all numbers in X.
             * Example: consider the set 4,5,8. Any number divisable by these three should contain at least 3 factors 2 and 1 factor 5 because the largest occurrence of the factor 2 is 3 (number 8) and the largest occurrence of the factor 5 is 1 (in the number 5).
             * The smalles possible number that can be divided by 4,5,8 is therefore 2*2*2*5=40.
             */
            IEnumerable<int> factors = new List<int>();

            // For each number that the result must be divisible by calculate its factors and take the excess with respect to the current list of factors.
            for (var i = 1; i < 20; i++)
            {
                var currentFactors = GetPrimeFactors(i);
                factors = MergeFactors(factors, currentFactors);
            }

            // The final result is the product of all factors
            return factors.Aggregate(1, (total, next) => total * next).ToString();
        }

        public IEnumerable<int> MergeFactors(IEnumerable<int> first, IEnumerable<int> second)
        {
            // Take copy of first to keep track of which factors we've covered (to allow differences between having a factor n and m times).
            var firstCopy = first.ToList();

            // Calculate the remaining factors in the second set that are not covered by the first set.
            // e.g. 2,3,5 + 2,2,7 = 2,2,3,5,7
            var remainder = new List<int>();
            foreach (var factor in second)
            {
                if (firstCopy.Contains(factor))
                {
                    // first contains this so remove the 'matching' factor from first so if second contains more of these they will be emitted!
                    firstCopy.Remove(factor);
                }
                else
                {
                    remainder.Add(factor);
                }
            }

            // Join first with remainder to produce merged terms.
            return first.Concat(remainder);
        }

        public IEnumerable<int> GetPrimeFactors(int number)
        {
            var result = new List<int>();
            var remainder = number;
            // Largest prime divisor is Sqrt(number) so stop checking after that.
            // Once remainder is 1 checks are also pointless.
            for (int divisor = 2; divisor <= Math.Sqrt(number) && remainder > 1;)
            {
                if (remainder % divisor == 0)
                {
                    remainder = remainder / divisor;
                    result.Add(divisor);
                }
                else
                {
                    divisor++;
                }
            }

            if (remainder > 1) result.Add(remainder);

            return result;
        }
    }
}