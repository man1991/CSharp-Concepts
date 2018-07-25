using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Customer //User-define type: Customer which has four values
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Balance { get; set; }
    }
    class List_UserDefined
    {
        static void Main()
        {
            List<Customer> Customers = new List<Customer>(); // the above four items are stored at a time into List and not individually
            //Customer is also a complex type as it's storing four values at a time and adding it to List of values called Customers.
            Customer c1 = new Customer { CustId = 101, Name = "Scott", City = "Hyderabad", Balance = 25000 };
            Customer c2 = new Customer { CustId = 102, Name = "Smith", City = "Chennai", Balance = 29000 };
            Customer c3 = new Customer { CustId = 103, Name = "Dave", City = "Delhi", Balance = 34000 };
            Customer c4 = new Customer { CustId = 104, Name = "David", City = "Hyderabad", Balance = 59000 };

            Customers.Add(c1); Customers.Add(c2); Customers.Add(c3); Customers.Add(c4);

            foreach (Customer obj in Customers)
            {
                Console.WriteLine(obj.CustId + " " + obj.Name + " " + obj.City + " " + obj.Balance);
            }
            Console.ReadLine();
        }
    }
}
