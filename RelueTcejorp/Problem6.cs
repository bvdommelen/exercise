using System.Collections.Generic;
using System.Linq;
using System;

namespace ProjectEuler
{
    /*
     * The sum of the squares of the first ten natural numbers is,
     *      12 + 22 + ... + 102 = 385
     * The square of the sum of the first ten natural numbers is,
     *      (1 + 2 + ... + 10)2 = 552 = 3025
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */

    public class Problem6
    {
        public string Solve()
        {
            var numbers = Enumerable.Range(1, 100);
            var sumOfSquares = numbers.Select(n => n * n).Sum();
            var squareOfSums = numbers.Sum();
            squareOfSums *= squareOfSums;
            return (squareOfSums - sumOfSquares).ToString();
        }
    }
}