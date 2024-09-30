using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            { 
             new Student() {RollNumber = 1,Name="Sushant",Age=25 } ,
              new Student() {RollNumber = 2,Name="Shifa",Age=22 } ,
              new Student() {RollNumber = 3,Name="Seth",Age=26 } ,
              new Student() {RollNumber = 4,Name="Sumit",Age=26 } ,
              new Student() {RollNumber = 5,Name="Akshay",Age=24 } ,

            };
            foreach(var items in students)
            {
                Console.WriteLine($"RollNumber: {items.RollNumber} Name: {items.Name} " +
                    $"Age: {items.Age}");
            }

            //Filter by Age 18-25
            //List<Student> Result = new List<Student>();
            //foreach(var item in students)
            //{
            //    if(item.Age >=18 && item.Age < 25)
            //    {
            //        Result.Add(item);
            //    }
            //}
            Console.WriteLine();
            Console.WriteLine("Age Between 18 to 25");
            //var Result = students.Where(s => s.Age >= 18 && s.Age <= 25);
            //var Result = from s in students select s;
            //var Result = from s in students
            //             where s.Age >= 18 && s.Age <= 25
            //             select s;

            // var Result = students.Select(s => s);//Method to select all 
            //var Result = students.Where(s => s.Age >= 18 && s.Age <= 25);//method to filter age.
            //var Result = from s in students 
            //             orderby s.Age
            //             select s; // order by age ascending 
            //var Result = from s in students
            //             orderby s.Name
            //             select s;
            var Result = students.OrderBy(s => s.Name);

            foreach (var items in Result)
            {
                Console.WriteLine($"RollNumber: {items.RollNumber} Name: {items.Name} " +
                    $"Age: {items.Age}");
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
