using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{
    internal class Boxing_UnBoxing
    {
        public static void Main()
        {
            TestOne();
        }

        public static void TestOne()
        {
            double number = 20;
            int age = (int)number; // downCasting
            decimal meter = (decimal)number; // upCasting

            object size = (object)meter; //boxing 
            decimal rate = (decimal)size; // UnBoxing

            Console.WriteLine(rate.GetType().Name);

            //object user = new
            //{
            //    name = "anc",
            //    age,
            //    meter,
            //};

            //var user2 = user;

            var user = new { name = "anc", age, meter };
            Console.WriteLine(user.name);
            Console.WriteLine(user.age);
            Console.WriteLine(user.meter);

            object user2 = user;
            Console.WriteLine("-----");
            //Console.WriteLine(((dynamic)user2).name="susu");
            Console.WriteLine(((dynamic)user2).name);

            //user?.name = "update" // object,anonymous type are immutable 


            object num = 12;
            int num2 = (int)num;
            num = 21;
            Console.WriteLine(new { number, age, meter, size, user, num, num2,rate,});
             
            // string is refrence?? 
            string address = "yangon";
            string address2 = address;
            address = address.ToUpper();
            Console.WriteLine(new {address,address2}); //ans: Reference type but immutable.

            // record
            var g1 = new Game(name: "dota", year: 2018); // immutable 
            Console.WriteLine(g1.name);
            var g2 = g1 with { name = "cs" };
            Console.WriteLine(g2.name);

        }

        public record Game(string name,int year);
    }

}
