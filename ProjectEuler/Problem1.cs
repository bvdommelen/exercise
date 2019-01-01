using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
     * Find the sum of all the multiples of 3 or 5 below 1000.
     */
    public class Problem1
    {
        public string Solve()
        {
            var multiplesOf3 = FindMultiplesOf3(1000);
            var multiplesOf5 = FindMultiplesOf5(1000);
            var uniqueMultiplesOf3Or5 = multiplesOf3.Concat(multiplesOf5).Distinct();
            return uniqueMultiplesOf3Or5.Sum().ToString();
        }

        private IEnumerable<int> FindMultiplesOf3(int maxValue)
        {
            var result = new List<int>();
            for (var i = 3; i < maxValue; i+=3)
            {
                result.Add(i);
            }
            return result;
        }

        private IEnumerable<int> FindMultiplesOf5(int maxValue)
        {
            var result = new List<int>();
            for (var i = 5; i < maxValue; i+=5)
            {
                result.Add(i);
            }
            return result;
        }
    }
}
