using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Dictionary
    {
        static void Main()
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("EId", 1010);
            dict.Add("EName", "Scott");
            dict.Add("Job", "Manager");
            dict.Add("Salary", 25000.00);
            dict.Add("MgrId", 1002);
            dict.Add("Phone", "23746666");
            dict.Add("EMail", "scott@gmail.com");
            dict.Add("DName", "Sales");
            dict.Add("Location", "Mumbai");
            dict.Add("DId", 30);

            foreach (string key in dict.Keys)
            {
                Console.WriteLine(key + ": " + dict[key]);
            }
        }
    }
}
