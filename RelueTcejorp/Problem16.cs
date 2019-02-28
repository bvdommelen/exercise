using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
     * What is the sum of the digits of the number 2^1000?
     */
    public class Problem16
    {
        public string Solve()
        {
            BigInteger big = BigInteger.Pow(2, 1000);
            return big
                .ToString()
                .ToCharArray()
                .Select(c => (int)(c - '0'))
                .Aggregate((agg, i) => agg += i)
                .ToString();
        }
    }
}
