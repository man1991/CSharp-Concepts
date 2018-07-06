using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 1;
            object Obj = val;  //Boxing
            int i = (int)Obj; //Unboxing
            Console.WriteLine("The value is   :"  + i);
            Console.ReadLine();
        }
    }
}
