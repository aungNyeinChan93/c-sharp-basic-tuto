//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ConsoleApp2
//{
//    internal class Week
//    {

//        static void Main(string[] args)
//        {
//            Console.Write("Enter the day of the week : ");
//            int day = Convert.ToInt32(Console.ReadLine());
//            Week.GetDay(day);
//        }

//        public static void GetDay(int day)
//        {
//            if (day == 0 || day <0 || day>7) Console.WriteLine("Invalid Day");

//            switch (day)
//            {
//                case 1:
//                    Console.WriteLine("monday");
//                    break;
//                case 2:
//                    Console.WriteLine("tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                case 4:
//                    Console.WriteLine("Thusday");
//                    break;
//                case 5:
//                    Console.WriteLine("friday");
//                    break;
//                case 6:
//                    Console.WriteLine("Sat");
//                    break;
//                case 7:
//                    Console.WriteLine("Sunday");
//                    break;
//                default: Console.WriteLine("______");
//                    break;

//            }
//        }
//    }
//}
