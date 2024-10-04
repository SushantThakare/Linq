using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_SortingOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // List<int> numbers = new List<int>() { 78,1, 34, 54, 65, 78, 98, 23, 21, 1, 2, 4, 5, 3456 };
           // foreach (int items in numbers)
           // {
           //     Console.Write($"{items} ");
           // }
           // //Console.WriteLine("\n    *** Reverse() ***");
           // //numbers.Reverse();
           // //foreach (int items in numbers)
           // //{
           // //    Console.Write($"{items} ");
           // //}


           // //List<char> numbers1 = new List<char>() { 's', 'u','s','h','a','n','t' };
           // //foreach (var items in numbers1)
           // //{
           // //    Console.Write($"{items} ");
           // //}
           // //Console.WriteLine("\n    *** Reverse() ***");
           // //numbers1.Reverse();
           // //foreach (var items in numbers1)
           // //{
           // //    Console.Write($"{items} ");
           // //}
           // var result=numbers.OrderBy(t => t);
           // Console.WriteLine("\n    *** OrderBy(t=>t) ***");
           // foreach (int items in result)
           // {
           //     Console.Write($"{items} ");
           // }

           //var result1=numbers.OrderByDescending(t => t);
           // Console.WriteLine("\n    *** OrderByDescending(t => t) ***");
           // foreach (int items in result1)
           // {
           //     Console.Write($"{items} ");
           // }

            Student s = new Student();
            var Students = s.GetStudents();
            Console.WriteLine("*** All Students() ***");
            foreach (var item in Students)
            {
                Console.WriteLine($"{item.RollNumber}: {item.Name}: {item.Age}: {item.City}");
            }

            var result = Students.OrderBy(s1 => s1.City);
          Console.WriteLine("*** OrderBy(s1 => s1.City) ***");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.RollNumber}: {item.Name}: {item.Age}: {item.City}");
            }

            //var result2 = Students.OrderBy(s1 => s1.City).ThenBy(s1=>s1.Name);
            //Console.WriteLine("*** Students.OrderBy(s1 => s1.City).ThenBy(s1=>s1.City) ***");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine($"{item.RollNumber}: {item.Name}: {item.Age}: {item.City}");
            //}

            var result2 = Students.OrderBy(s1 => s1.City).ThenByDescending(s1 => s1.Name);
            Console.WriteLine("*** OrderBy(s1 => s1.City).ThenByDescending(s1 => s1.Name) ***");
            foreach (var item in result2)
            {
                Console.WriteLine($"{item.RollNumber}: {item.Name}: {item.Age}: {item.City}");
            }

            //var result11 = Students.OrderByDescending(s1 => s1.City);
            //Console.WriteLine("*** OrderByDescending((s1 => s1.City) ***");
            //foreach (var item in result11)
            //{
            //    Console.WriteLine($"{item.RollNumber}: {item.Name}: {item.Age}: {item.City}");
            //}
            Console.ReadLine();

        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

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
}
