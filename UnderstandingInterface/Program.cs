using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInterface
{
    class Program
    {
        public static void Main(string[] args)
        {
            //BaseEmployee be = new BaseEmployee()
            //{
            //    ID = 101,
            //    FirstName = "David",
            //    LastName = "Pie",
            //};

            //Console.WriteLine(be.GetFullName());
            //Console.WriteLine(be.GetMonthlySalary());

            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "David",
                LastName = "Pie",
                AnnualSalary = 60000
            };

            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("-------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sam",
                LastName = "Brooks",
                HourlyPay = 100,
                TotalHoursWorked = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
        }
    }
}
