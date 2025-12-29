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
            //TestThree();
            //TestFour();
            //TestFive();
            TestSix();

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

            //foreach (User user in users)
            //{
            //    if (user.Name.Equals("dodo"))
            //    {
            //        user?.Name = "ronaldo";
            //        user?.Email = "ronaldo@123";
            //    }
            //    Console.WriteLine(user?.Name);
            //    Console.WriteLine(user?.Email);
            //    user?.Info();

            //    int.TryParse(Console.ReadLine(), out int num);
            //    Console.WriteLine(num);
            //}

            for (int i = 0; i < users?.Count; i++)
            {
                Console.WriteLine(users[i]?.Name);
                users[i].Info();
            }
        }

        public static void TestFour()
        {
            Queue<string> member = new Queue<string>();
            member.Enqueue("hello");
            member.Enqueue("hello");
            member.Enqueue("hello");


            //Console.WriteLine(member.Dequeue());

            foreach (var item in member)
            {
                Console.WriteLine(item);
            }
        }

        public static void TestFive()
        {
            try
            {
                Console.Write("Enter count: ");

                //int.TryParse(Console.ReadLine(), out int result);

                int result = Convert.ToInt32(Console.ReadLine());

                int[] counter = new int[result];

                for (int i = 0; i < counter?.Length; i++)
                {
                    Console.WriteLine("Happy NewYear!");
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err?.Message);
            }


        }

        public static void TestSix()
        {

            int.TryParse(Console.ReadLine(), out int res);

            List<int> number = new List<int>();

            for (int i = 1; i <= res; i++)
            {
                number.Add(i);
                Console.Write($" {i} + ");
            };

            int total = 0;
            foreach (int n in number)
            {
                total += n;
            };

            Console.WriteLine($" = {total}");

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
