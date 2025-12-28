using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ConsoleApp2
{
    internal class Error
    {

        public static void Main(string[] args)
        {
            Error error = new Error();
            //error.TestTwo();

            Error.HappyNewYear();
        }

        public static void TestOne()
        {
            bool success = true;

            while (success)
            {
                Console.Write("Enter Your Number: ");
                //int number = 0;
                //int.TryParse(Console.ReadLine(), out number);  // TryParse(string,out int) => if !true override number;
                //Console.WriteLine(number);

                bool res = double.TryParse(Console.ReadLine(), out double number2);

                if (res)
                {
                    Console.WriteLine($"number is {number2}");
                }
                else
                {
                    Console.WriteLine("only number!");
                    Console.WriteLine(number2);
                    Console.WriteLine(int.MinValue);
                    success = false;
                }
            }
        }

        public void TestTwo()
        {
            Console.WriteLine("Test two");


            Console.WriteLine("Enter Your Number");
            bool isInt = int.TryParse(Console.ReadLine(), out int number);

            if (!isInt) return;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {i} * {number} = {i*number}");
            }

        }

        public static void HappyNewYear()
        {
            for (int i = 5; i >= 0; --i)
            {
                if(i == 0) Console.WriteLine("Happy NewYear!🎇🎇🎇");
                Console.WriteLine(i);
            }
        }
    }
}
