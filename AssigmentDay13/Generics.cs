using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentDay13
{
    class Generics
    { 
        static void Main(string[] args) 
        {
            int[] arr = { 778, 344, 112, 555, 438 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.PrintMaxValue();
            Console.ReadLine();
        }
    }
}
