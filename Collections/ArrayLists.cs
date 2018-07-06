using System;
using System.Collections;

namespace Collections
{
    class ArrayLists
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[10];
            //Array.Resize(ref arr, 15);
            //this mechanism is called auto resizing
           ArrayList al = new ArrayList();//Parameter less or default constructor
            //ArrayList al = new ArrayList(10);//Parameterize constructor
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            //al.Add(200); al.Add(300); al.Add(400);
            al.Add("Hello"); al.Add(true); al.Add(23.45);
            Console.WriteLine(al.Capacity);
            //al.Add(500);
            al.Add('A');
            Console.WriteLine(al.Capacity);
            Console.WriteLine();

            Console.WriteLine("After Adding Elements in ArrayList:");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();


            al.Insert(3,350);//inserted in middle
            Console.WriteLine();
            Console.WriteLine("After Inserting Elements in middle of an ArrayList:");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            //al.Remove(200);//removing by value itself
            al.RemoveAt(1);//remove by index itslef
            Console.WriteLine();
            Console.WriteLine("After Removing Elements from middle of an ArrayList:");
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
