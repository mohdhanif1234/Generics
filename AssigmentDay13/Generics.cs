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
            Console.WriteLine("Maximum integer number = {0} out of {1}, {2}, and {3}", MaxOfThreeValues<int>.FindMaxGeneric(11, 22, 33), 11, 22, 33);
            Console.WriteLine("Maximum decimal number = {0} out of {1}, {2}, and {3}", MaxOfThreeValues<double>.FindMaxGeneric(11.23, 22.54, 33.69), 11.23, 22.54, 33.69);
            Console.WriteLine("Maximum string value = {0} out of {1}, {2}, and {3}", MaxOfThreeValues<string>.FindMaxGeneric("Apple", "Peach", "Banana"), "Apple", "Peach", "Banana"); 
            Console.ReadLine();
        }
    }
}
