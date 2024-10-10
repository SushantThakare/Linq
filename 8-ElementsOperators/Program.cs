using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ElementsOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            int item = numbers.ElementAt(0);
            Console.WriteLine($"(ElementAt): {item}");
            item = numbers.ElementAt(4);
            Console.WriteLine($"(ElementAt): {item}");
            item = numbers.ElementAtOrDefault(9);// handles exception and returns default value.
            Console.WriteLine($"(ElementAt): {item}");

            item = numbers.First(i => i % 2 == 0);
            Console.WriteLine($"(First): {item}");
            item = numbers.FirstOrDefault(i => i > 50);
            Console.WriteLine($"(FirstOrDefault): {item}");


            item = numbers.Last(i => i % 2 == 0);
            Console.WriteLine($"(Last): {item}");
            item = numbers.LastOrDefault(i => i > 50);
            Console.WriteLine($"(LastOrDefault): {item}");

            //item = numbers.Single();
            //Console.WriteLine($"(Single): {item}");
            //item = numbers.Single(i=> i%2==0);
            //Console.WriteLine($"(Single(i=> i%2==0)): {item}");//error
            //item = numbers.SingleOrDefault(i => i % 2 == 0);
            //Console.WriteLine($"(Single(i=> i%2==0)): {item}");//error
            item = numbers.Single(i => i >7);
           Console.WriteLine($"(Single(i=> i%2==0)): {item}");
            item = numbers.SingleOrDefault(i => i > 40);
            Console.WriteLine($"Single(i => i > 40): {item}");
            Console.ReadLine();
        }
    }
}
