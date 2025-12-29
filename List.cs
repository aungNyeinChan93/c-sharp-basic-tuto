using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class List
    {
        public static void Main(string[] args)
        {
            TestOne();
        }


        public static void TestOne()
        {
            int[] numbers = [1, 4, 3, 2, 6, 5, 7, 9, 8];

            Array.Sort(numbers);

            foreach (var number in numbers)
            {
                Thread.Sleep(400);
                Console.Write($"{number} ");
            }
        }
    }
}
