using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    using MyLINQ;
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Call where as a classic static method
            IEnumerable<int> evens = MyLINQ.Enumerable.Where(ints, i => i % 2 == 0);

            //Call Where as an extension method
            //IEnumerable<int> evens = ints.Where(i => i % 2 == 0);
            foreach (var i in evens)
            {
                Console.WriteLine(i);
            }
        }
    }
}
