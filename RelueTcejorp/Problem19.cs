using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * You are given the following information, but you may prefer to do some research for yourself.

     * 1 Jan 1900 was a Monday.
     * Thirty days has September,
     * April, June and November.
     * All the rest have thirty-one,
     * Saving February alone,
     * Which has twenty-eight, rain or shine.
     * And on leap years, twenty-nine.
        
     * A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        
     * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
     */
    public class Problem19
    {
        public string Solve()
        {
            int sundays = 0;
            DateTime current = DateTime.Parse("1901-01-01T00:00:00");
            DateTime last = DateTime.Parse("2000-12-31T23:59:59");
            while (current < last)
            {
                if (current.DayOfWeek == DayOfWeek.Sunday) sundays++;
                current = current.AddMonths(1);
            }
            return sundays.ToString();
        }
    }
}
