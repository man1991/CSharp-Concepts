using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithConstructors
{
    class Software
    {
        public Software()
        {
            m_x = 100;
        }
        public Software(int y)
        {
            m_x = y;
        }
        protected int m_x;
        static void Main(string[] args)
        {
            MicrosoftSoftware m1 = new MicrosoftSoftware();
            //MicrosoftSoftware m2 = new MicrosoftSoftware(100);//won't compile as Constructors are not inherited by 
            //derived classes. Thus we cannot instantiate a derived class(MicrosoftSoftware) object using the constructor that takes an int 
            //as parameter. 
            DundasSoftware du1 = new DundasSoftware(50);
            DundasSoftware du2 = new DundasSoftware("test", 75);
            Console.ReadLine();
        }
    }
    class MicrosoftSoftware : Software
    {
        public MicrosoftSoftware()
        {
            Console.WriteLine(m_x);
        }
    }
    class DundasSoftware : Software
    {
        //Here I am telling the compiler which
        //overload of the base constructor to call
        public DundasSoftware(int y) : base(y)//base access keyword can be used on other methods too, and not just on constructors.
        {
            Console.WriteLine(m_x);
        }
        //Here we are telling the compiler to first
        //call the other overload of the constructor
        public DundasSoftware(string s, int f) : this(f)//this access keyword can be used on other methods too, and not just on constructors.
        {
            Console.WriteLine(s);
        }
    };
}
