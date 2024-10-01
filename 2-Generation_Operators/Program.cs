using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Generation_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers1= Enumerable.Empty<int>();
            Console.WriteLine($"{numbers1.Count()}");

            //IEnumerable<int> numbers2= Enumerable.DefaultIfEmpty(numbers1);
            //Console.WriteLine($"{numbers2.Count()} : {numbers2.ElementAt(0)}");

            IEnumerable<int> numbers3=Enumerable.Repeat(5, 10);
            foreach(int items in numbers3)
            {
                Console.Write(items);
            }
            Console.WriteLine();
            IEnumerable<int> numbers2 = Enumerable.DefaultIfEmpty(numbers3);
            Console.WriteLine($"{numbers2.Count()} : {numbers3.ElementAt(2)}");

            IEnumerable<int> numbers4 = Enumerable.Range(1, 100);
            foreach(int items in numbers4)
            {
                Console.Write(items + " ");
            }
            Console.ReadLine();
        }
    }
}
