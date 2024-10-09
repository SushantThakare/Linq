using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AggrigationOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers= new List<int>() {1,2,3,4,5,6,7};
            var c1 = numbers.Count();
            Console.WriteLine($"(Count)Numbers of items {c1}");
            var c2 = numbers.LongCount();
            Console.WriteLine($"(LongCount)Numbers of items {c2}");
            var c3=numbers.Min();
            Console.WriteLine($"(Min)Numbers of items {c3}");
            var c4 = numbers.Max();
            Console.WriteLine($"(Max)Numbers of items {c4}");
            var c5 = numbers.Sum();
            Console.WriteLine($"(Sum)Numbers of items {c5}");
            var c6 = numbers.Aggregate((i,j)=>i+j);
            Console.WriteLine($"(Aggregate)Numbers of items {c6}");
            var c7 = numbers.Average();
            Console.WriteLine($"(Average)Numbers of items {c7}");
            //Quantifiers Operators
            var c8 = numbers.Contains(6);
            Console.WriteLine($"(Contains) {c8}");
            c8 = numbers.Contains(60);
            Console.WriteLine($"(Contains) {c8}");
            c8 = numbers.All(i=>i<0);
            Console.WriteLine($"(All) {c8}");
            c8 = numbers.All(i => i > 0);
            Console.WriteLine($"(All) {c8}");//true all items from numbers matches the condition
            c8 = numbers.All(i => i >1);
            Console.WriteLine($"(All) {c8}");//2,3,4,5,6,7 are greater than two but 1 is not so it will return false all needs all items to match 
            c8 = numbers.Any(i => i >6);//only 7 is greater 
            Console.WriteLine($"(Any) {c8}");//any checks any one to match if any one matches it returns true.

            c8 = numbers.All(i => i>8);//8 not present in list
            Console.WriteLine($"(All) {c8}");

            c8 = numbers.All(i => i % 2 == 0);
            Console.WriteLine($"(All) {c8}");
            c8 = numbers.Any(i => i % 2 == 0);
            Console.WriteLine($"(All) {c8}");

            Student s1 = new Student() { FirstName="Sushant",LastName="Thakare"};
            Student s2 = new Student() { FirstName="Sumit",LastName="Rokade"};
            Student s3 = new Student() { FirstName="Vrushabh",LastName="Kawale"};

            List<Student> s = new List<Student>() {s1,s2,s3};
            Student s4 = new Student() { FirstName = "Sushant", LastName = "Thakare" };
           c8= s.Contains(s4,new StudentHelper());
            Console.WriteLine(c8);
            foreach (var items in s)
            {
                Console.WriteLine($"Fn: {items.FirstName} Ln: {items.LastName}");
            }
            Console.ReadLine();
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Student s= obj as Student;
        //    return this.FirstName.Equals(s.FirstName)&& this.LastName.Equals(s.LastName);
        //}

        //public override int GetHashCode()
        //{
        //    return FirstName.GetHashCode() ^ LastName.GetHashCode();    
        //}
    }
    public class StudentHelper : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.FirstName.Equals(y.FirstName) && x.LastName.Equals(y.LastName);
        }

        public int GetHashCode(Student obj)
        {
          return obj.FirstName.GetHashCode() ^ obj.LastName.GetHashCode();  
        }
    }
}
