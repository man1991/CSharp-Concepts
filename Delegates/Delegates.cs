using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //Step 1: Defining a delegate
    public delegate void AddDelegate(int x, int y);
    public delegate string SayDelegate(string str);
    class Delegates
    {
        public void AddNums(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Delegates p = new Delegates();
            //Step 2: Instantiating a delegate
            AddDelegate ad = new AddDelegate(p.AddNums);
            //Step 3: Calling a delegate
            ad.Invoke(100, 50);
            //ad(100, 50); -- Optional way to call delegate
            //Step 2: Instantiating a delegate
            SayDelegate sd = new SayDelegate(Delegates.SayHello);
            //Step 3: Calling a delegate
            string str = sd.Invoke("Manish");
            // string str = sd("Manish"); 

            //p.AddNums(100, 50);
            //string str = Delegates.SayHello("Manish");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
