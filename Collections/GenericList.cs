using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class GenericList
    {
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20); li.Add(30);
            li.Add(40); li.Add(50); li.Add(60);//li.Add(60.5); -- this is not possible with List

            Console.WriteLine("After Adding Elements in List:");
            for (int i = 0; i < li.Count; i++)
                Console.Write(li[i] + " ");
                Console.WriteLine();

            li.Insert(3, 35);//inserted in middle
            Console.WriteLine();
            Console.WriteLine("After Inserting Elements in middle of an List:");
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            li.RemoveAt(2);//remove by index itslef
            Console.WriteLine();
            Console.WriteLine("After Removing Elements from middle of an List:");
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();

            //foreach (int i in li)
            //    Console.Write(i  + " ");
            //Console.WriteLine();

            Console.ReadLine();
        }
    }
}
