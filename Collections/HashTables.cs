using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class HashTables
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            //Every item contains key, value and a HashCode where key is object, value is object, HashCode is a integer
            ht.Add("EId", 1010);
            ht.Add("EName", "Scott");
            ht.Add("Job", "Manager");
            ht.Add("Salary", 25000.00);
            ht.Add("MgrId", 1002);
            ht.Add("Phone", "23746666");
            ht.Add("EMail", "scott@gmail.com");
            ht.Add("DName", "Sales");
            ht.Add("Location", "Mumbai");
            ht.Add("DId", 30);

            //Console.WriteLine("Hello".GetHashCode());//GetHashCode() is a numeric representation for a value

            Console.WriteLine(ht["EMail"]);//to fetch value from HashTable
            Console.WriteLine();

            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ": " + ht[key]);
            }
            Console.ReadLine();

        }
    }
}
