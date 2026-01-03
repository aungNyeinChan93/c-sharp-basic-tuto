using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleApp2
{
    internal class Function
    {
        public static void Main(string[] args)
        {
            Console.Title = "Function";
            string text = "Nullam quis arcu in magna pulvinar tincidunt. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam hendrerit nulla ut cursus laoreet. Nullam elementum lorem vel facilisis laoreet. Cras ac turpis vel erat vehicula venenatis.";

            //var f1 = new Function(); // function class -> use new keyword -> object or instance
            //f1.TestOne();
            //Function.TestThree();
            //TestFour(txt: "Hello World");
            //TestFour(txt: "Hello World 2");
            //Console.WriteLine(TestAge(16) ? "you have permission" : "you can not access");
            //TestFive();
            //GuestNumber();
            //Print(text);
            //TestSix();
            //TestSeven();
            ////TestEight();

            //int res = Add(33,1);
            //int res2 = Add();
            //Console.WriteLine(new {res,res2});

            //TestNine();

            //TestTen(1,1);

            //TestEleven("coca cola");
            //TestEleven("water");

            TestTwelve();

        }

        public void TestOne()
        {
            this.TestTwo();
            TestThree();

        }

        public void TestTwo()
        {
            Console.WriteLine("Test Two function");
        }

        public static void TestThree()
        {
            var f1 = new Function();
            f1.TestTwo();
        }

        public static void TestFour(string txt)
        {
            Console.WriteLine(txt);
        }

        public static bool TestAge(int age)
        {
            if (age >= 18) return true;
            return false;
        }

        public static void TestFive()
        {
            string name = "susu ";
            string res = name.Substring(0, 2); // [s,u,s,u] [0-3]-> [index-length]
            Console.WriteLine(res);

            //GuestNumber();

        }

        public static void GuestNumber()
        {
            int num = 9;
            int intRes = 2
;

            while (intRes != 0)
            {
                Console.Write("Enter your Guest Number 1 to 10 : ");
                int.TryParse(Console.ReadLine(), out var number);
                intRes = num.CompareTo(number);

                if (intRes > 0)
                {
                    Console.WriteLine(" guest number is less than ");
                }
                else if (intRes < 0)
                {
                    Console.WriteLine("Guest Number is Grather than ");
                }
            }
            Console.WriteLine("correct");
        }

        public static void Print(string text)
        {
            foreach (char t in text)
            {
                Thread.Sleep(10);
                Console.Write(t);
            }
        }

        public static int[] CreateArray(int num)
        {
            int[] newNumberArray = new int[num];
            for (int i = 0; i < num; i++)
            {
                newNumberArray[i] = i;
            }
            return newNumberArray;
        }


        public static void TestSix()
        {
            int[] numbers = CreateArray(10);
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        public static void Action(string direction)
        {
            Console.WriteLine($" {direction} ->");
        }

        public static void TestSeven()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i % 2 == 0)
                {
                    Action("right");
                }
                else
                {
                    Action("left");
                }

                if (i == 9)
                {
                    Console.WriteLine("One By One Goal Keeper!");
                    Action("shoot");
                }

            }
            Console.WriteLine("Gool!");
            return;
        }

        public static int ReadNumber(string? message = "")
        {
            Console.WriteLine(!string.IsNullOrEmpty(message) ? message : "Enter number");
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }

        public static void TestEight()
        {
            int number = ReadNumber();
            Console.WriteLine(number);

            int num2 = ReadNumber("Age ");
            Console.WriteLine(num2);
        }

        public static int Add([Optional] int a, int b = default)
        {
            return a + b;
        }

        public static string About(string name, string? address = default)
        {
            return $" My name is {name} and I live In {address}";
        }

        public static void TestNine()
        {
            string res1 = About(name: "susu", address: "ygn");
            string res2 = About(name: "koko");

            Console.WriteLine(new { res1, res2 });
        }

        public static bool OutTest(int a, int b, out int res)
        {
            if (a + b > 0)
            {
                res = a + b;
                return true;
            }
            res = 0;
            return false;
        }

        public static void TestTen(int a , int b)
        {
            bool isSuccess = OutTest(a, b, out int result);
            if (isSuccess)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static bool FindInList(string a,List<string> list,out int index)
        {
            index = -1;
            bool found = false;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(a.ToLower()))
                {
                    index = i;
                    found = true;
                    break;
                }
            }   
            return found;

        }

        public static void TestEleven(string d)
        {
            List<string> drinks = ["coffee", "lemon", "late", "water"];

            bool isFound = FindInList(d, drinks, out int resIndex);

            Console.WriteLine(isFound ? $"Found {d} in index {resIndex}":$"not Found! {d} INDEX-{resIndex}");
        }

        public static void RefTest(ref int a , ref int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("done!");
        }

        public static void TestTwelve()
        {
            int num1 = 10;
            int num2 = 20;

            RefTest(ref num1, ref num2);
            Console.WriteLine(new { num1,num2});
        }


    }
}
