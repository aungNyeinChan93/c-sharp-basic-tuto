using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ConsoleApp2
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Array a = new Array();

            //a.TestOne();
            //TestTwo();
            TestThree();

        }

        public void TestOne()
        {
            string[] customers = ["mgmg", "susu"];

            string[] users = new string[4];
            users[0] = "koko";
            users[1] = "mumu";
            users[2] = "chan";
            users[0] = "change";

            int[] numbers = new int[3] { 1, 2, 3 };

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            int total = 0;
            foreach (var n in numbers)
            {
                total += n;
            }

            Console.WriteLine(total);
        }

        public static void TestTwo()
        {
            List<string> games = ["coc", "mlbb", "pubg", "csgo", "dota"];

            games.Add("run");
            bool isSuccess = games.Remove("coc");

            games[0] = "change";

            if (isSuccess) Console.WriteLine("coc remove!");

            foreach (var g in games)
            {
                //if (g == "change") games.Remove(g);   
                Console.WriteLine(g);
            }

            string test = string.Join(", ", games);
            Console.WriteLine(test);


        }

        public static void TestThree()
        {
            List<User> users = [
                new User("koko","koko@123"),
                new User("mumu","mumu@123"),
                new User("dodo","dodo@123")];

            foreach(User user in users)
            {
                if(user.Name.Equals("dodo"))
                {
                    user?.Name = "ronaldo";
                    user?.Email = "ronaldo@123";
                }
                Console.WriteLine(user?.Name);
                Console.WriteLine(user?.Email);
                user?.Info();
            }
        }
    }



    internal class User
    {
        private string name;

        private string email;

        public string Name { get { return this.name; } set { name = value; } }

        public string Email { get { return this.email; } set { email = value; } }

        public User(string n, string e)
        {
            name = n;
            email = e;
        }

        public  void Info()
        {
            Console.WriteLine($"name is {this.name} and email is {this.email} ");
        }
    }
}
