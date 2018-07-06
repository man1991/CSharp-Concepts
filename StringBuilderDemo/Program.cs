using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append("This is the beggining of a sentence,");
            //sb.Replace("the beggining of","");
            //sb.Insert(sb.ToString().IndexOf("a")+2,"complete ");
            //sb.Replace(",",".");
            StringBuilder sb = new StringBuilder("This is the beggining of a sentence,");
            sb.Replace("the beggining of", "").Insert(sb.ToString().IndexOf("a") + 2, "complete ").Replace(",", ".");
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
