//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    internal class Calculator
//    {

//        static void Main(string[] args)
//        {
//            Calculator c1 = new ();

//            Console.Write("number 1: ");
//            string n1 = Console.ReadLine();

//            Console.Write("number 2: ");
//            string n2 = Console.ReadLine();

//            Console.Write("operator: ");
//            string opera = Console.ReadLine();

//            double result = c1.Cal(number1: n1, number2: n2, ope: opera);
//            Console.WriteLine($"Your final result is {result}");
//        }


//        public int Cal(string number1,string number2,string ope)
//        {
//             int num2 = Convert.ToInt32(number2);
//             int num1 = Convert.ToInt32(number1);

//            if(ope == "")  Console.WriteLine("please select operator€!"); 

//            if(ope == "+") return num1 + num2;
//            if(ope == "-") return num1 - num2;
//            if(ope == "*") return num1 * num2;
//            if(ope == "/") return num1 / num2;
//            if(ope == "%") return num1 % num2;

//            return 0;
//        }
         
//    }
//}
