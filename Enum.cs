using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Enum
    {

        public static void Main()
        {
            Test();
            TestOne(UserRole.super);
            TestThree(Gear.N);
            TestThree(Gear.S);
        }

        public static void Test()
        {
            UserRole userRole = UserRole.user;
            Console.WriteLine(userRole);  // user
            Console.WriteLine(userRole.GetType().Name);  //UserRole
        }

        public static void TestOne(UserRole role)
        {
            if(role ==  UserRole.super) Console.WriteLine("Awesome super ");
            Console.WriteLine($"You are {role}");
        }

        public enum UserRole
        {
            guest,
            user,
            admin,
            super
        }

        public enum Gear
        {
            N = 0,
            D = 1,
            L = 2,
            H = 3,
            S = 4,
        }

        public static void TestThree(Gear g)
        {
            Console.WriteLine($"You use {g} , lvl = {Convert.ToInt32(g)}");
        }



    }
}
