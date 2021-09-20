using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay13
{
    class MaxOfThreeStrings
    {
        // UC-3 To find the maximum string value out of the three string values
        public static void FindMaxString(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.Write("{0} is the maximum string value out of {1}, {2} and {3}", first, first, second, third);
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.Write("{0} is the maximum string value out of {1}, {2} and {3}", second, first, second, third);
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.Write("{0} is the maximum string value out of {1}, {2} and {3}", third, first, second, third);
            }
            Console.ReadLine();
        }
    }
}
