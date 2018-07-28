using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerComponent.Customer obj = new CustomerComponent.Customer();
            obj.CustomerCode = "s001";
            obj.CustomerName = "shiv";
            obj.Validate();
            obj.CeateDBObjects();
            //obj.Add();

        }
    }
}
