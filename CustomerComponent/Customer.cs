﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerComponent
{
    //Step 1: What(Abstraction)
    //abstraction is a thought process/ modelling term i.e. show what is necessary/minimal
   //Step 2: How

   //Step 3: Made those Complicated methods as private(Encapsulation)
   //Encapsulation is bringing down complexity. Encapsulation implements abstraction.
    public class Customer
    {
        public string CustomerCode = "";
        public string CustomerName = "";
        //public void Add()
        //{
        //    Validate();
        //    CeateDBObjects();
        //    //My Database Will go here;
        //}
        //Granular
        public bool Validate()
        {
            Console.WriteLine("Abstraction.");
            //Customer Code and Customer Name           
            return true;
        }
        //private bool Validate()
        //{
        //    Console.WriteLine("Encapsulation.");
        //    //Customer Code and Customer Name           
        //    return true;
        //}
        public bool CeateDBObjects()
        {
            Console.WriteLine("Abstraction Completed!");
            Console.ReadLine();
            //DB Connection, SQL
            return true;
        }
        //private bool CeateDBObjects()
        //{
        //    Console.WriteLine("Encapsulation Completed!");
        //    Console.ReadLine();
        //    //DB Connection, SQL
        //    return true;
        //}
        static void Main(string[] args)
        {
        }
    }
}
