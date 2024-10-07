using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_sortMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Sort()
            //List<int> numbers = new List<int>() {1,45,32,56,21,67,84,34,3,6,456,76};
            //Console.WriteLine("All Numbers");
            //foreach (int items in numbers)
            //{
            //    Console.Write($"{items} ");
            //}
            //Console.WriteLine("\nAll Numbers with sort()");
            //numbers.Sort();
            //foreach(int items in numbers)
            //{
            //    Console.Write($"{items} ");
            //}
            //Console.WriteLine();
            //List<string> name = new List<string>() { "t", "n", "h", "s", "u", "S" };
            //name.Sort();
            //foreach (string items in name)
            //{
            //    Console.Write($"{items} ");
            //}
            //IComparer<Student> o = new StudentHelper();
            //Student s = new Student();
            //var students = s.GetStudents();
            //students.Sort(0,4,o);

            //public delegate int Comparison<in T>(T x, T y);
            //Comparison<Student> comp= (X,Y)=> X.Name.CompareTo(Y.Name);
            //    students.Sort(comp);
            // students.Sort((X,Y)=> X.Age.CompareTo(Y.Age));
            //students.Sort((X,Y)=> Y.Age.CompareTo(X.Age));
            //    foreach (var item in students)
            //    {
            //        Console.WriteLine($"RollNUmber: {item.RollNumber} Name: {item.Name}" +
            //      $" City: {item.City} age:{item.Age}");
            //    }
            #endregion 1. Sort()
            #region Grouping Operators
            Student s= new Student();
            var students=s.GetStudents();
            Console.WriteLine("** All Students **");
            foreach(var items in students)
            {
                Console.WriteLine($"RollNumber: {items.RollNumber} Name: {items.Name} Age: {items.Age} City: {items.City}");
            }

            Console.WriteLine(" ** GroupBy City **");
            //var groups=students.GroupBy(s1 => s1.City);
            var groups = from s1 in students
                         group s1 by s1.Name;          
            Console.WriteLine($" Group Count {groups.Count()}");
            foreach(var items in groups)
            {
                Console.WriteLine($" City: {items.Key} Total Students: {items.Count()}");//here we have used key because group by returns string type of key.
                foreach(var i in items)
                {
                    Console.WriteLine($"Name: {i.Name}");//we use this because items is a collection and ever items has its group by city.     
                }
                Console.WriteLine("-------------------------------------------------x");
            }
            #endregion Grouping Operators
            Console.ReadLine();
        }
    }
    public class Student : IComparable
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student s = obj as Student;
            //if (this.Age > s.Age){
            //    return -1;
            //}
            //else if (this.Age < s.Age) { return 1; }
            //else { return 0; }//logic we wrote.

            return this.Age.CompareTo(s.Age);
        }

        public List<Student> GetStudents()
        {
            return new List<Student>
            {
          new Student{RollNumber=1,Name="Sushant",City="Ytl",Age=24},
          new Student{RollNumber=2,Name="Seth",City="Pune",Age=26},
          new Student{RollNumber=3,Name="Sumit",City="Mumbai",Age=26},
          new Student{RollNumber=4,Name="Akshay",City="Nagpur",Age=25},
          new Student{RollNumber=5,Name="Avi",City="Ytl",Age=27},
          new Student{RollNumber=6,Name="Tushar",City="Ytl",Age=27},
            };
        }
    }
    public class StudentHelper : IComparer<Student>
    {
      
        public int Compare(Student x, Student y)
        {
          return x.Name.CompareTo(y.Name);
        }
    }
}
