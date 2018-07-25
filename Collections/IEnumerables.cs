using Collections;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
    }
    public class Organization : IEnumerable //Foreach loop cannot be implemented as it doesn't implement GetEnumator() method
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee emp)
        {
            Emps.Add(emp);
        }
        public int Count
        {
            get { return Emps.Count; }
        }
        public Employee this[int index]
        {
            get
            {
                return Emps[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            //return Emps.GetEnumerator();
            return new OrganizationEnumerator(this);
        }
    }
    public class OrganizationEnumerator : IEnumerator
    {
        Organization OrgColl;
        int CurrentIndex;
        Employee CurrentEmployee;
        public OrganizationEnumerator(Organization org)
        {
            OrgColl = org;
            CurrentIndex = -1;
        }
        public object Current//gives the current record
        {
            get
            {
                return CurrentEmployee;
            }
        }

        public bool MoveNext()//moves pointer to the next record
        {
            if (++CurrentIndex >= OrgColl.Count)
                return false;
            else
                CurrentEmployee = OrgColl[CurrentIndex];
            return true;
        }

        public void Reset()
        {
        }
    }
    class IEnumerables
    {
        static void Main()
        {
            //List<Employee> Employees = new List<Employee>();
            Organization Employees = new Organization();
            Employees.Add(new Employee { Id = 101, Name = "Raju", Job = "Manager", Salary = 25000.00 });
            Employees.Add(new Employee { Id = 102, Name = "Ajay", Job = "Analyst", Salary = 20000.00 });
            Employees.Add(new Employee { Id = 103, Name = "Venkat", Job = "Salesman", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 104, Name = "David", Job = "Salesman", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 105, Name = "Peter", Job = "Salesman", Salary = 15000.00 });
            Employees.Add(new Employee { Id = 106, Name = "John", Job = "Clerk", Salary = 5000.00 });
            foreach(Employee emp in Employees)
                Console.WriteLine(emp.Id + " " + emp.Name + " " + emp.Job + " " + emp.Salary);
            Console.ReadLine();
        }
    }
}
