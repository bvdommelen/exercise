using System.Linq;

namespace ProjectEuler
{
    /*
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    public class Problem4
    {
        public string Solve()
        {
            int highestProduct = 0;
            // We keep track of the highest value of J that yielded a palindrome;
            // if we find a palindrome with some value of J there is no need to continue checking for values of i < J
            // since we find the highest palindrome for (x,y) where x>y first (the highest palindrome with i=y would be j=x and yields the same value).
            // and because the highest found palindrome (x,y) is always higher than (i<x,j<y)
            int highestJFactor = 0;
            for (int i = 999; i > highestJFactor; i--)
            {
                // Note: no point in checking for j>i as the pair (x,y) and (y,x) are the same result given x>y so check only for i>j!
                for (int j = i; j > 99; j--)
                {
                    int product = i * j;
                    if (IsPalindrome(product.ToString()))
                    {
                        // If we found a palindrome it's guaranteed to be the highest for this value of i
                        // but there may be lower values of i with higher value palindromes!
                        // Therefore we want to 
                        //   1) exit the inner loop as no value of j left will give a higher palindrome than this one
                        //   2) only update our highest product if the one we found here is higher than the one we already have
                        //   3) inform our outer loop of the value of J that yielded this product
                        if (product > highestProduct)
                        {
                            highestProduct = product;
                            highestJFactor = j;
                        }
                        break;
                    }
                }
            }
            return highestProduct.ToString();
        }

        public bool IsPalindrome(string s)
        {
            return s.Equals(new string(s.Reverse().ToArray()));
        }
    }
}