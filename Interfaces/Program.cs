using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program : abc,def,man
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Interfaces");
            //xyz();//An object reference is required for the non-static field, method, or property 'Program.xyz()'
            Program obj = new Program();//obj is a reference to the object of class Program.
            obj.xyz();
            Sample SampleObj = new Sample();//SampleObj is a reference to the object of class Sample.
            SampleObj.xyz();
            abc interface_obj = new Program();
            interface_obj.xyz();
            abc Sample_interface_obj = new Sample();
            Sample_interface_obj.xyz();
            abc[] refabc = { new Program(), new Sample() };
            for (int i = 0; i <= 1; i++)
                refabc[i].xyz();
            def refdef = obj;
            refdef.pqr();
            refdef.xyz();
            man inheriobj = obj;
            inheriobj.xyz();
            inheriobj.pqr();
            Console.ReadLine();
        }
        public void xyz()
        {
            System.Console.WriteLine("In xyz : Interface abc");
        }
        public void pqr()
        {
            System.Console.WriteLine("In xyz : Interface def");
        }
        void def.xyz()
        {
            System.Console.WriteLine("In def.xyz");

        }
    }
    interface abc
    {
        //int x;//Interfaces cannot contain fields


        //'abc.xyz()': interface members cannot have a definition
        //void xyz()
        //{
        //    System.Console.WriteLine("In xyz");
        //}
        void xyz();//Interfaces in C# can only contain function declarations.
    }
    class Sample : abc
    {
        public void xyz()
        {
            System.Console.WriteLine("In Sample :: xyz");
        }
    }

    interface def
    {
        void pqr();
        void xyz();//Interfaces in C# can only contain function declarations.

    }
    interface man : abc
    {
        void pqr();
    }
}
