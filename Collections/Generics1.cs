using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Generics1
    {
        //public bool Compare(int a, int b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}

        //public bool Compare(float a, float b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}

        //public bool Compare(object a, object b)
        //{
        //    if (a.Equals(b))
        //        return true;
        //    return false;
        //}

        public bool Compare<T>(T a, T b)//Generics 
        {
            if (a.Equals(b))
                return true;
            return false;
        }
        static void Main()
        {
            Generics1 obj = new Generics1();
            //bool result = obj.Compare(10.45f, 10.46f);//False - with Compare method paramtere datatype as float and object
            //bool result = obj.Compare(10.45f, 10.45f);//True - with Compare method paramtere datatype as float and object
            //bool result = obj.Compare(10.45f, 23.56);//False - with Compare method paramtere datatype as float and double
            bool result1 = obj.Compare<float>(10.45f, 23.56f);//False - with Compare method paramtere Generics datatype
            //bool result = obj.Compare(true, true);//true - with Compare method paramtere datatype as object
            //bool result = obj.Compare(true, false);//False - with Compare method paramtere datatype as object
            //bool result = obj.Compare(10, 10);//true - with Compare method paramtere datatype as int
            //bool result = obj.Compare(10, 20);//false - with Compare method paramtere datatype as int
            Console.WriteLine(result1);
            bool result2 = obj.Compare<int>(10, 10);//False - with Compare method paramtere Generics datatype
            Console.WriteLine(result2);
            Console.ReadLine();
        }
    }
}
