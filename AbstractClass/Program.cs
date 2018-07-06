using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Creating an Abstract Class
    abstract class absClass //abstract sealed class absClass: Incorrect
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        //An abstract method, to be overridden in derived class
        //private abstract int MultiplyTwoNumbers(int Num1, int Num2);: Incorrect
        //public abstract virtual int MultiplyTwoNumbers(int Num1, int Num2);:Incorrect
        //public abstract static int MultiplyTwoNumbers(int Num1, int Num2);: Incorrect

        public abstract int MultiplyTwoNumbers(int Num1, int Num2);

    }
    //A Child Class of absClass
    class absDerived : absClass
    {
        static void Main(string[] args)
        {
            //You can create an instance of the derived class
            //absClass calculate = new absClass();//Incorrect
            absDerived calculate = new absDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Added : {0}, Multiplied : {1}", added, multiplied);
        }
        //using override keyword,implementing the abstract method MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }
}
