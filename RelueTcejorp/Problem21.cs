using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
     * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.

     * For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

     * Evaluate the sum of all the amicable numbers under 10000.
     */
    public class Problem21
    {
        public string Solve()
        {
            Dictionary<int, bool> amicables = new Dictionary<int, bool>();
            for (int i = 2; i < 10000; i++)
            {
                if (amicables.ContainsKey(i)) continue;
                var divisors = GetProperDivisors(i);
                var divisorSum = divisors.Sum();
                if (i == divisorSum) continue;
                var reverseDivisors = GetProperDivisors(divisorSum);
                var reverseDivisorSum = reverseDivisors.Sum();
                if (i == reverseDivisorSum)
                {
                    amicables.Add(i, true);
                    amicables.Add(divisorSum, true);
                }
                else
                {
                    amicables[i] = false;
                }
            }

            var realAmicables = amicables.Where(k => k.Key < 10000 && k.Value).Select(k => k.Key);
            return realAmicables.Sum().ToString();
        }

        public IEnumerable<int> GetProperDivisors(int number)
        {
            List<int> result = new List<int>();
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                    result.Add(number / i);
                }
            }
            result.Add(1);
            return result;
        }
    }
}
