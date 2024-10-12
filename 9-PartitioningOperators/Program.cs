using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PartitioningOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Take
            // List<int> numbers = new List<int>() {2,4,1,3,5,6,5,7,85,4};
            // Console.WriteLine("*** All Numbers ***");
            // foreach (int i in numbers)
            // {
            //     Console.Write($"{i} ");
            // }
            // Console.WriteLine();
            // Console.WriteLine("*** Using Take ***");
            //IEnumerable<int> result = numbers.Take(6).OrderBy(r=>r);
            // foreach (int i in result)
            // {
            //     Console.Write($"{i} ");
            // }
            // //Console.WriteLine("*** Using TakeWhile(r=> r<=10) ***");
            //// Console.WriteLine("*** Using TakeWhile(r=> r% 2 ==0)***");

            // //IEnumerable<int> result2 = numbers.TakeWhile(r=> r% 2 ==0).OrderBy(r=>r);
            // Console.WriteLine("*** Using TakeWhile(r=> r>10) ***");
            // IEnumerable<int> result2 = numbers.TakeWhile(r=> r>10).OrderBy(r=>r);//no output because first item is false(2!>10)
            // foreach(int item in result2)
            // {
            //     Console.Write($"{item} ");
            // }
            #endregion Take

            #region Skip
            //List<int> numbers = new List<int>() { 2, 4, 1, 3, 5, 6, 5, 7, 85, 4 };
            //Console.WriteLine("*** All Numbers ***");
            //foreach (int i in numbers)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();
            ////Console.WriteLine("*** Skip(2) ***");
            ////IEnumerable<int> result3 = numbers.Skip(2).OrderBy(r => r);

            //Console.WriteLine("*** SkipWhile(r=> r<10) ***");
            //IEnumerable<int> result3 = numbers.SkipWhile(r => r < 10);
            //foreach (int i in result3)
            //{
            //    Console.Write($"{i}  ");
            //}
            #endregion Skip
            #region Second Heighest Number
            List<int> numbers = new List<int>() { 2, 4, 1, 3, 5, 6, 5, 7, 85, 4 };
            var max = numbers.Max();
            Console.WriteLine($"Max no : {max}");
            var min = numbers.Min();
            Console.WriteLine($"Min no : {min}");

            //IEnumerable<int> secondHighest=numbers.OrderByDescending(s=>s).Take(2).OrderBy(s=>s).Take(1);
            //foreach(int i in secondHighest)
            //{
            //    Console.WriteLine(i);
            //}
            int secondHighest = numbers.OrderByDescending(s => s).Take(2).OrderBy(s => s).Take(1).FirstOrDefault();
            Console.WriteLine($"Second Highest: {secondHighest}");
            #endregion Second Heighest Number
            Console.ReadLine();
        }
    }
}
