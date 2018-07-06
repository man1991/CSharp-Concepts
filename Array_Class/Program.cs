using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array stringArray = Array.CreateInstance(typeof(String),3);
            //stringArray.SetValue("Mahesh Chand", 0);
            //stringArray.SetValue("Raj Kumar", 1);
            //stringArray.SetValue("Neel Beniwal", 2);
            //foreach (string str in stringArray)
            //{
            //    Console.WriteLine(str);
            //}

            //Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            //for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
            //    for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
            //        for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++)
            //        {
            //            intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
            //        }
            //foreach (int ival in intArray3D)
            //{
            //    Console.WriteLine(ival);
            //}

            //int[] intArray = new int[3] {
            //                                0,
            //                                1,
            //                                2
            //                            };
            //if (intArray.IsFixedSize)
            //{
            //    Console.WriteLine("Array is fixed size");
            //    Console.WriteLine("Size :" + intArray.Length.ToString());
            //    Console.WriteLine("Rank :" + intArray.Rank.ToString());
            //}

            // Create an array and add 5 items to it  
            //Array stringArray = Array.CreateInstance(typeof(String), 5);
            //stringArray.SetValue("Mahesh", 0);
            //stringArray.SetValue("Raj", 1);
            //stringArray.SetValue("Neel", 2);
            //stringArray.SetValue("Beniwal", 3);
            //stringArray.SetValue("Chand", 4);
            //// Find an item  
            //object name = "Neel";
            //int nameIndex = Array.BinarySearch(stringArray, name);
            //if (nameIndex >= 0) Console.WriteLine("Item was at " + nameIndex.ToString() + "th position");
            //else Console.WriteLine("Item not found");

            // Create an array and add 5 items to it  
            Array stringArray = Array.CreateInstance(typeof(String), 5);
            stringArray.SetValue("Mahesh", 0);
            stringArray.SetValue("Raj", 1);
            stringArray.SetValue("Neel", 2);
            stringArray.SetValue("Beniwal", 3);
            stringArray.SetValue("Chand", 4);
            // Find an item  
            object name = "Neel";
            int nameIndex = Array.BinarySearch(stringArray, name);
            if (nameIndex >= 0) Console.WriteLine("Item was at " + nameIndex.ToString() + "th position");
            else Console.WriteLine("Item not found");
            Console.WriteLine();
            Console.WriteLine("Original Array");
            Console.WriteLine("---------------------");
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            Console.WriteLine("---------------------");
            //Array.Sort(stringArray);     //sorts an entire array in ascending order
            Array.Sort(stringArray, 2, 3);//sorts an array with starting index e.g. 2 upto number of elements specified i.e. 3
                                         //in ascending order
            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
            Console.ReadLine();
        }
    }
}
