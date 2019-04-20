using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
     * For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
     * What is the total of all the name scores in the file?
     */
    public class Problem22
    {
        public string Solve()
        {
            // Get lines from file, join by comma then split by comma
            var lines = File.ReadAllLines("..\\..\\..\\p022_names.txt");
            var allData = string.Join(",", lines);
            var data = allData.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            // Strip double quotes
            var strippedData = data.Select(d => d.Trim('"'));

            // Sort alphabetically
            var sortedData = strippedData.OrderBy(d => d);

            // Calculate value of each element
            var alphabeticValues = sortedData.Select(d => this.GetAlphabeticValue(d));

            // Multiply each value with it's index position
            int index = 1;
            long result = 0;
            foreach (int i in alphabeticValues)
            {
                result += index * i;
                index++;
            }

            return result.ToString();
        }

        public int GetAlphabeticValue(string s)
        {
            var cArray = s.ToCharArray();
            var iValues = cArray.Select(c => (int)c - (int)'A' + 1);
            return iValues.Sum();
        }
    }
}
