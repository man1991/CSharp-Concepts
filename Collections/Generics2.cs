using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //class Generics2
    //{
    //    public void Add<T>(T a, T b)
    //    {
    //        dynamic d1 = a;
    //        dynamic d2 = b;
    //        Console.WriteLine(d1 + d2);
    //    }

    //    public void Substract<T>(T a, T b)
    //    {
    //        dynamic d1 = a;
    //        dynamic d2 = b;
    //        Console.WriteLine(d1 - d2);
    //    }

    //    public void Multiply<T>(T a, T b)
    //    {
    //        dynamic d1 = a;
    //        dynamic d2 = b;
    //        Console.WriteLine(d1 * d2);
    //    }

    //    public void Divide<T>(T a, T b)
    //    {
    //        dynamic d1 = a;
    //        dynamic d2 = b;
    //        Console.WriteLine(d1 / d2);
    //    }
    //    static void Main()
    //    {
    //        Generics2 obj = new Generics2();
    //        obj.Add<int>(10, 20); obj.Substract<int>(10, 20);
    //        obj.Multiply<int>(10, 20); obj.Divide<int>(10,20);
    //        Console.ReadLine();
    //    }
    class Generics2<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Substract(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Multiply(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

        public void Divide(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }

    class TestGenerics
    { 
        static void Main()
        {
            Generics2<int> obj = new Generics2<int>();
            //obj.Add<int>(10, 20); obj.Substract<int>(10, 20);
            //obj.Multiply<int>(10, 20); obj.Divide<int>(10,20);

            obj.Add(10, 20); obj.Substract(10, 20);
            obj.Multiply(10, 20); obj.Divide(10, 20);

            Console.ReadLine();
        }
    }
}
