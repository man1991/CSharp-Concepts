using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    //public class Student //User-define type: Student which has four values
    //{
    //    public int SId { get; set; }
    //    public string Name { get; set; }
    //    public int Class { get; set; }
    //    public float Marks { get; set; }
    //}
    public class Student : IComparable<Student> //User-define type: Student which has four values
                                                //using IComparable interface so that Sort() function can work on complex types such as Student
                                                //IComparable interface is inherited for the complex type.
                                                //CompareTo() method is present in IComparable interface
    {
        public int SId { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        //Sorting will be done in increasing order
        public int CompareTo(Student other) //Sorting based on SId, can be done on any parameter e.g. Name, Class, Marks etc.
        {
            if (this.SId > other.SId)
                return 1;
            else if (this.SId < other.SId)
                return -1;
            else
                return 0;
        }

        //Sorting to be done in descending order
        //public int CompareTo(Student other) //Sorting based on SId, can be done on any parameter e.g. Name, Class, Marks etc.
        //{
        //    if (this.SId > other.SId)
        //        return -1;
        //    else if (this.SId < other.SId)
        //        return 1;
        //    else
        //        return 0;
        //}
    }

    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    class IComparable_And_IComparer
    {
        //public static int CompareNames(Student s1, Student s2)//To sort using Names
        //{
        //    return s1.Name.CompareTo(s2.Name);
        //}
        static void Main()
        {
            Student s1 = new Student { SId = 103, Name = "Ajay", Class = 10, Marks = 575.00f };
            Student s2 = new Student { SId = 106, Name = "Stuart", Class = 10, Marks = 535.00f };
            Student s3 = new Student { SId = 104, Name = "Williams", Class = 10, Marks = 592.00f };
            Student s4 = new Student { SId = 102, Name = "Venkat", Class = 10, Marks = 453.00f };
            Student s5 = new Student { SId = 101, Name = "David", Class = 10, Marks = 512.00f };
            Student s6 = new Student { SId = 105, Name = "Jhon", Class = 10, Marks = 498.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6 }; // This way of adding is called as collection initializer
                                                                                     // the above four items are stored at a time into List and not individually
                                                                                     //Student is also a complex type as it's storing four values at a time and adding it to List of values called Students.

            //Students.Sort();//Sorting is performed on SId.

            //CompareStudents obj = new CompareStudents();// To sort using Marks
            //Students.Sort(obj);//if we do not pass obj in Sort(), sorting is performed on SId.

            //Students.Sort(1, 4, obj);//Number of items to be compared/sorted i.e. range can be passed and sorting will be performed accordingly.

            //Comparison<Student> obj = new Comparison<Student>(CompareNames);//Sort using delegate;Comparison is a delegate
            //Students.Sort(obj);
            //Students.Sort(CompareNames);//Direct call to method is also possible.

            //Students.Sort(delegate(Student stud1, Student stud2)  // Sort using Anonymous methods.
            //{
            //    return stud1.Name.CompareTo(stud2.Name);
            //});

            Students.Sort((S1,S2) => S1.Name.CompareTo(S2.Name));//// Sort using Lambda Operator.
            //Students.Reverse();//Instead of implementing reverse method for CompareTo() we can directly call Reverse() after Sort()
            foreach (Student stud in Students)
            {
                Console.WriteLine(stud.SId + " " + stud.Name + " " + stud.Class + " " + stud.Marks);
            }
            Console.ReadLine();
        }
    }
}
