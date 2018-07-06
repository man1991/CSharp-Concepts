using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void Talk()
        {

            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Talk();
            a1.Sing();
            a1.Greet();
            Animal a2 = new Dog(); // Object of type Animal which references to object of type Dog
            a2.Talk();
            a2.Sing();
            a2.Greet();
            Console.ReadLine();
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }
    };
}
//Output for object a1: Output is as desired
//Animal constructor
//Animal talk
//Animal song
//Animal says Hello

//Output for object a2
//Animal constructor: Base class constructor
//Dog constructor: Derived class constructor
//Animal talk: Base class method as object was declared to be of the base type which in our case is Animal.
//Dog song: Derived class method as in the derived class we have overridden it by using override keyword which is used in C# explicitly
//Animal says Hello: Base class method