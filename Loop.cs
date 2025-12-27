//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    internal class Loop
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("How many get odd number? ");
//            int totalNumber = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < totalNumber; i++)
//            {
//                Console.WriteLine($"Odd Number is : {++i}");
//            }

//            Console.WriteLine("-----------");

//            Console.Write("count? : ");
//            int count = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Message: ");
//            string message = Console.ReadLine();
//            Loop.Repeat(count, message);


//            Console.Write("Enter Number : ");
//            int number = Convert.ToInt32(Console.ReadLine());
//            Loop.Test(number);
//        }


//        public static void Repeat(int count,string message)
//        {
//            for (int i = 0; i <= count; i++)
//            {
//                Console.WriteLine($" {i} : {message}");
//            }
//        }

//        public static void Test(int number)
//        {
//            for (int i = 1; i <= 12; i++)
//            {
//                Console.WriteLine($" {number} * {i} = {number*i} ");
//            }
//        }


//    }
//}
