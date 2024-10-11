using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_SetOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Distinct
            //List<int> numbers = new List<int>() {1,2,3,2,4,2,5,4,6};
            //  Console.WriteLine("Original Numbers");
            //  foreach (int i in numbers) { Console.Write($"{i} "); }
            // var unique= numbers.Distinct();
            //  Console.WriteLine("Using Distinct");
            //  foreach (int item in unique)
            //  {
            //      Console.Write($"{item} ");
            //  }
            #endregion Distinct

            #region Union
            //List<int> num1 = new List<int>() {3,2,1};
            //List<int> num2 = new List<int>() {5,4,6,2};
            //IEnumerable<int> result=num1.Union(num2).OrderBy(n => n);

            ////IEnumerable<int> result=num1.Concat(num2);
            //foreach(int items in result)
            //{
            //    Console.Write($"{items} ");
            //}
            #endregion Union
            #region Intersect
            ////List<int> num1 = new List<int>() { 3, 2, 1 ,4};
            ////List<int> num2 = new List<int>() { 5, 4, 6, 2 };
            //////IEnumerable<int> result =num1.Intersect(num2);
            ////IEnumerable<int> result =num1.Except(num2);
            ////foreach (int items in result)
            ////{
            ////    Console.Write($"{items} ");
            ////}
            #endregion Intersect
            #region SequenceEqual
            List<int> num1 = new List<int>() { 3, 2, 1 };
            List<int> num2 = new List<int>() { 1, 2, 3 };
            num1.Sort();
            num2.Sort();
            bool b1 = num1.SequenceEqual(num2);
            Console.WriteLine($"Sequence Equal: {b1}");
            #endregion SequenceEqual
            Console.ReadLine();
        }
    }
}
