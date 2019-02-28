using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler
{
    /*
	 * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
	 * How many such routes are there through a 20×20 grid?
	 */

    public class Problem15
    {
        private Dictionary<int, int> cachedRoutes = new Dictionary<int, int>();

        public string Solve()
        {
            // Note: number of routes is (40) over (20)
            return Combinations(40, 20).ToString();
        }

        private BigInteger Combinations(int top, int bottom)
        {
            // Value is top!/bottom!/(top-bottom)!
            return Permutations(top, bottom + 1) / Permutations(top - bottom);
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
    }
}