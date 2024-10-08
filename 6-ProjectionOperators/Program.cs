using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_ProjectionOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Type Collection using select
           
           // List<string> names= new List<string>() {"Sushant","Sumit","Vrushabh","Sagar","Saurabh"};
           // //List<string> namesInCapitals = new List<string>();
           // //foreach(string items in names)
           // //{
           // //    namesInCapitals.Add(items.ToUpper());
           // //}

           //IEnumerable<string> namesInCapitals =names.Select(c=> c.ToUpper());

           // foreach (string items in namesInCapitals)
           // {
           //     Console.WriteLine($"Name in Capital: {items} ");
           // }
           // //List<int> length= new List<int>();
           // //foreach(var items in names)
           // //{
           // //    length.Add(items.Length);
           // //}
           //IEnumerable<int> length = names.Select(l => l.Length);
           // foreach(int items in length)
           // {
           //     Console.Write($"{items} ");
           // }
#endregion Simple Type Collection using select

            Student s1 = new Student();
            List<Student> students = s1.GetStudents();
            //to do List<Student>=List<string>name
            // IEnumerable<string> names =students.Select(s => s.Name);
            IEnumerable<string> names= from s in students
                                       select s.Name;
            foreach (string items in names)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();
            //IEnumerable<StudentShortData> shorts =
            //    students.Select(s => new StudentShortData { Name = s.Name, City = s.City });
            //var shorts = students.Select(s => new { Name = s.Name, City = s.City });
            var shorts = from s in students
                          select new {Name = s.Name,City = s.City}; 
            foreach (var items in shorts)
            {
                Console.WriteLine($"Name: {items.Name} City: {items.City}");
            }

          IEnumerable<List<string>> subjects = students.Select(s => s.Subjects);
            foreach (var subject in subjects)
            {
                foreach (var items in subject)
                {
                    Console.Write($"{items} ");
                }
            }
            Console.WriteLine("\n with Select Many()");

          IEnumerable<string> subjects2= students.SelectMany(s => s.Subjects);
            foreach(var items in subjects2)
            {
                Console.Write($"{items} ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public List<string> Subjects { get; set; }
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
          new Student{RollNumber=1,Name="Sushant",City="Ytl",Age=24,Subjects=new List<string>(){ "s1", "s2","s3" } },
          new Student{RollNumber=2,Name="Seth",City="Pune",Age=26 ,Subjects=new List<string>(){ "s1", "s2" } },
          new Student{RollNumber=3,Name="Sumit",City="Mumbai",Age=26,Subjects=new List<string>(){ "s1", "s2","s3","s4"} },
          new Student{RollNumber=4,Name="Akshay",City="Nagpur",Age=25,Subjects=new List<string>(){ "s1", "s2","s3" } },
          new Student{RollNumber=5,Name="Avi",City="Ytl",Age=27, Subjects = new List < string >() { "s1", "s2" }},
          new Student{RollNumber=6,Name="Tushar",City="Ytl",Age=27,Subjects=new List<string>(){ "s1", "s2" } },
            };
        }
    }
    public class StudentShortData
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
