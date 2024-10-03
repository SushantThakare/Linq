using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FilteringOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WhereOperator
            //Student s = new Student();
            //var students = s.GetStudents();
            //foreach (var item in students)
            //{
            //    Console.WriteLine($"RollNUmber: {item.RollNumber} Name: {item.Name}" +
            //          $" City: {item.City} age:{item.Age}");
            //}
            //Console.WriteLine("*** age filter ***");
            //var result = students.Where(s1 => s1.Age >=18 && s1.Age<=25);
            //foreach(var item in result)
            //{
            //    Console.WriteLine($"RollNUmber: {item.RollNumber} Name: {item.Name}" +
            //          $" City: {item.City} age:{item.Age}");
            //}
            //Console.WriteLine("*** City filter ***");
            //var cityresult = students.Where(s2 => s2.City.Equals("Pune"));
            //foreach (var  item  in cityresult)
            //{
            //    Console.WriteLine($"RollNUmber: {item.RollNumber} Name: {item.Name}" +
            //          $" City: {item.City} age:{item.Age}");
            //}

            //Console.WriteLine("*** City and age filter ***");
            ////var agecityresult = students.Where(s2 => s2.City.Equals("Ytl") && s2.Age<=25);//method

            //var agecityresult = from s2 in students
            //                    where  s2.City.Equals("Ytl") && s2.Age <= 25
            //                    select s2;
            //foreach (var item in agecityresult)
            //{
            //    Console.WriteLine($"RollNUmber: {item.RollNumber} Name: {item.Name}" +
            //          $" City: {item.City} age:{item.Age}");
            //}
            //Console.WriteLine("*** list of object ***");
            //List<object> list = new List<object>() {1,"Sus",2,"seth",10.4,new Student(),10.4555f};
            //var result1 = list.Where(l1 => l1.GetType().Name == "String");
            //foreach(var item in result1)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("*** list of object ***");

            //var result2 = list.Where(l1 => l1.GetType().Name == "Int32");
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion WhereOperator

            #region OfType Operator
            Console.WriteLine("*** list of object ***");
            List<object> list = new List<object>() { 1, "Sus", 2, "seth", 10.4, new Student(),
                10.4555f,34,56 };
            //var result = list.OfType<int>();
            //var result = list.OfType<string>();
            //var result = list.OfType<double>();
            var result = list.OfType<float>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            List<CAR> cars = new List<CAR>()
            {
                new AUDI(),
                new AUDI(),
                new AUDI(), 
                new BMW(),
                new BMW(),
                new AUDI(),
                new BMW()
            };
            var result2 = cars.OfType<AUDI>();
            foreach (var item in result2)
            {
                Console.WriteLine(item.CName);
            }

            #endregion OfType Operator
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
            };
        }
    }
    public class CAR
    {
        public string CName { get; set; }
    }
    public class BMW : CAR
    {
        
        public BMW()
        {
            CName = "BMW";
        }
    }
    public class AUDI : CAR
    {
        public AUDI()
        {
            CName = "AUDI";
        }
    }

}
