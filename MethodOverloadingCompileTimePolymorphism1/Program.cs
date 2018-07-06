using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingCompileTimePolymorphism1
{
    class Program
    {
        public class Shape
        {
            public void Area(float r)
            {
                float a = (float)3.14 * r;
                // here we have used funtion overload with 1 parameter.
                Console.WriteLine("Area of a circle: {0}", a);
            }

            public void Area(float l, float b)
            {
                float x = (float)l * b;
                // here we have used funtion overload with 2 parameters.
                Console.WriteLine("Area of a rectangle: {0}", x);

            }

            public void Area(float a, float b, float c)
            {
                float s = (float)(a * b * c) / 2;
                // here we have used funtion overload with 3 parameters.
                Console.WriteLine("Area of a circle: {0}", s);
            }
        }
        static void Main(string[] args)
        {
            Shape ob = new Shape();
            ob.Area(2.0f);
            ob.Area(20.0f, 30.0f);
            ob.Area(2.0f, 3.0f, 4.0f);
            Console.ReadLine();
        }
    }
}
