using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay13
{
    class MaxOfThreeValues<T> where T:IComparable
    {
        // Refactor-1 To find the maximum integer, decimal and the string values using the concept of Generics
        public static T FindMaxGeneric(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                return default;
            }
        }
    }
}
