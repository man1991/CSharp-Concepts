﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] Members = new string[4][]{
               new string[]{"Rocky", "Sam", "Alex"},
               new string[]{"Peter", "Sonia", "Prety", "Ronnie", "Dino"},
            new string[]{"Yomi", "John", "Sandra", "Alex", "Tim", "Shaun"},
            new string[]{"Teena", "Mathew", "Arnold", "Stallone", "Goddy", "Samson", "Linda"},
                };

            for (int i = 0; i < Members.Length; i++)
            {
                System.Console.Write("Name List ({0}): ", i + 1);

                for (int j = 0; j < Members[i].Length; j++)
                {
                    System.Console.Write(Members[i][j] + "\t");
                }
                System.Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
