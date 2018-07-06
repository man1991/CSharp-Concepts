using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    class inheri: vehicle
    {
        public void noise()
        {
            Console.WriteLine("All Vehicles Create Noise!");
        }
        static void Main(string[] args)
        {
            inheri obj = new inheri();
            obj.mode();
            obj.feature();
            obj.noise();
            Console.Read();
        }
    }
    class Mode
    {
        public void mode()//class name and member/method name should not be same e.g.Class Mode and public void Mode are not allowed
        {                //whereas Class Mode and public void mode are allowed
            Console.WriteLine("There are many modes of transport!!");
        }
    }
    class vehicle : Mode
    {
        public void feature()
        {
            Console.WriteLine("They mainly help in travelling!!!");
        }
    }
}
