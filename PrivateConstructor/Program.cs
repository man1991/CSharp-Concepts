using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    public class PrivateConstructor
    {
        public string param1, param2;
        public PrivateConstructor(string a, string b)
        {
            param1 = a;
            param2 = b;
        }
        private PrivateConstructor()  // Private Constructor Declaration
        {
            Console.WriteLine("Private Constructor with no prameters");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PrivateConstructor obj = new PrivateConstructor("Welcome", "to Aspdotnet-Manish");// it will works fine
            //PrivateConstructor obj1 = new PrivateConstructor();// it will not work because of inaccessability
            Console.WriteLine(obj.param1 + " " + obj.param2);
            Console.ReadLine();
        }
    }
}
