using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
     *      a2 + b2 = c2
     * For example, 32 + 42 = 9 + 16 = 25 = 52.
     * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
     * Find the product abc.
     */
    public class Problem9
    {
        public string Solve()
        {
            // a<b<c so a<=332
            for (int a = 1; a <= 332; a++)
            {
                // a<b<c so b>a and b<1/2 * 999-a
                for (int b = a+1; b < (999-a)/2; b++)
                {
                    int c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        return (a * b * c).ToString();
                    }
                }
            }

            return "0";
        }
    }
}
