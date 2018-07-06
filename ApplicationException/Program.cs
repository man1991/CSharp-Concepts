using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNsp // Defining own namespace for exception class
{
    public class DivideByOddNoException : ApplicationException//Defining Our Own Exception Class i.e. ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Attempted To Divide By Odd Number";
            }
        }
    }
}
    namespace UserApplicationException
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
                Console.Write("Enter 1st Number");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd Number");
                int y = int.Parse(Console.ReadLine());
                if (y % 2 > 0)
                {
                    //throw new ApplicationException("Divisor Value Cannot Be Odd Number.");//Application Exception
                    throw new MyNsp.DivideByOddNoException();// Defined own namespace MyNsp and ApplicationException
                }                                               //DivideByOddNoException()
                int z = x / y;
                Console.WriteLine("The result is:" + z);
                Console.WriteLine("End Of the program.");

            }
        }
    }
}
