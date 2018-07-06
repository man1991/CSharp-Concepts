using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_LooseCoupling
{
    class Program
    {
        //Define a delegate that accepts a string and returns bool
        //delegate bool TestDel(string s);//Custom delegate
        static void Main(string[] args)
        {
            string[] items = {"Larry", "Moe", "Curly", "Shemp" };

            Console.WriteLine("Max Length:");
            int max = int.Parse(Console.ReadLine());

            Func<string, bool> test = delegate (string s)//Anonymous Method
            {
                return s.Length > max;
            };
            //string[] result = Where(items, TestForLength);

            //string[] result = Where(items, test);//Using Anonymous method
            //string[] result = Where(items, delegate (string s)//Using anonymous method as an expression
            //{
            //    return s.Length > max;
            //});

            string[] result = Where(items, s => s.Length > max);//Using Lambda expression


            foreach (var s in result)
            {
                Console.WriteLine(s);
                //Console.ReadLine();
            }
        }

        //Create a TestForLength method that matches the delegate
        static bool TestForLength(string s)
        {
            return s.Length > 3;
        }

        //Where methods that filters a string array
        //static string[] Where(string[] items, TestDel test)
        static string[] Where(string[] items, Func<string, bool> test)//Using built-in Func<> delegate
        {
            var result = new List<string>();
            foreach (var item in items)
            {
                if (test(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
