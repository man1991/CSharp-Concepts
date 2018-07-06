using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Define a delegate that accepts two integers and accepts two integers and returns an integer
    public delegate int IntDel(int a, int b);
    class Delegates1
    {
        static void Main(string[] args)
        {
            //Write code in Main that initializes and invokes the delegate
            //var del = new IntDel(Add);//Optional
            IntDel del = Add;

            //Invoke the delegate
            //int result = del(1, 2);//Optional
            int result = del.Invoke(1,2);

            Console.WriteLine("Add Result: {0}", result);
            Console.ReadLine();

        }
        //Define a static Add method that matches the delegate definition
        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
