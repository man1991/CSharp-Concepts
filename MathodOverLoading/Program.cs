using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        public class TestOverLoading
        { 
            public void Add(string s1, string s2)
            {
                Console.WriteLine("Adding Two String :" + s1 + s2);
            }
            public void Add(int s1, int s2)
            {
                Console.WriteLine("Adding Two Integer :" +(s1 + s2));
            }
        }
        static void Main(string[] args)
        {
            TestOverLoading obj = new TestOverLoading();
            obj.Add("Manish","Singh");
            obj.Add(5,10);
            Console.ReadLine();
        }
    }
}
