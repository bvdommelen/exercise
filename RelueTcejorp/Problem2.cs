﻿using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    /*
     * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
     * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
     */

    public class Problem2
    {
        public string Solve()
        {
            var fibonacciSequence = GenerateFibonacciSequence(4000000);
            return fibonacciSequence.Where(i => i % 2 == 0).Sum().ToString();
        }

        private IEnumerable<int> GenerateFibonacciSequence(int maxValueInclusive)
        {
            var result = new List<int>();
            // Define initial grandparent and parent and add them to the result list
            int numGrandparent = 1;
            int numParent = 1;
            result.Add(1);
            result.Add(1);

            // Define current number and run until current > maxValueInclusive
            int numCurrent = 2;
            while (numCurrent <= maxValueInclusive)
            {
                result.Add(numCurrent);
                numGrandparent = numParent;
                numParent = numCurrent;
                numCurrent = numGrandparent + numParent;
            }
            return result;
        }
    }
}