using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    class Circle
    {
        public const double PI = 3.14;
        public Circle()
        {
            //The left-hand side of an assignment must be a variable, property or indexer Constants
            //PI = 3.15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.PI);
            //Member 'Circle.PI' cannot be accessed with an instance reference; qualify it with a type name instead Constants
            //Circle C = new Circle(C.PI);
        }
    }
}
