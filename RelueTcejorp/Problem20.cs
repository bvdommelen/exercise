using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * n! means n × (n − 1) × ... × 3 × 2 × 1

     * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
     * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

     * Find the sum of the digits in the number 100!
     */
    public class Problem20
    {
        public string Solve()
        {
            return SumOfDigits(Permutations(100).ToString()).ToString();
        }

        private BigInteger Permutations(int n, int startAt = 2)
        {
            BigInteger result = new BigInteger(1);
            for (int i = startAt; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private int SumOfDigits(string number)
        {
            return number.ToCharArray().Select(c => c - '0').Sum();
        }
    }
}
