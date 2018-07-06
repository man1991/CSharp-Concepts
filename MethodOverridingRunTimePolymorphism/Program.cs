using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingRunTimePolymorphism
{
    class Program
    {
        class A
        {
            public virtual void Print()
            {
                Console.WriteLine("class A");
            }
        }

        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("class B");
            }
        }

        class C : A
        {
            public new void Print()
            {
                Console.WriteLine("class C");
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            b.Print();      //  class B (override)

            A a = (A)b;
            a.Print();      //  class B (override)


            C c = new C();
            c.Print();      //  class C (new)

            a = (A)c;
            a.Print();      //  class A (new)
            Console.ReadLine();
        }
    }
}
//When we use override keyword, in both cases Print method of class B is called. Same behavior when we use a new keyword
//and calling for Print method from instance of inherited class. But if derived class is cast to an instance of the base class,
//then method of the base class is called.
