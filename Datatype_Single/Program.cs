using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype_Single
{
    class Program
    {
        static void Main()
        {
            {
                Single a = 1;
                Double b = 1;

                Console.WriteLine(a.GetType());
                Console.WriteLine(b.GetType());
            }
            {
                float a = 1;
                double b = 1;
                Console.WriteLine(a.GetType());
                Console.WriteLine(b.GetType());
                Console.ReadLine();
            }
        }
    }
}
