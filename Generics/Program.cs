using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Check<int> obj = new Check<int>();
            //Check<string> i;
            //i.Compare("Singh", "Manish");
            bool b1 = obj.Compare(1, 1);
            Console.WriteLine(b1);

            Check<string> objString = new Check<string>();
            bool b2 = objString.Compare("Singh", "Manish");
            Console.WriteLine(b2);


        }
    }
    class Check<UNKNOWNDATATYPE>
    {
        public bool Compare(UNKNOWNDATATYPE i, UNKNOWNDATATYPE y)
        {
            if (i.Equals(y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
