using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class StrTuto
    {
        public static void Main()
        {
            Console.WriteLine(@"string test");
            Console.WriteLine("--------------");

            //Test();
            //TestTwo();
            //ListTest();
            new StrTuto().TestThree();
            //TestFour();
        }

        public static void Test()
        {

            string bio = $"this is information \\usaer\\fasdfdfasd\\ \t system \" people,hardware,software,data and network!  \" sdfasd ";
            string peopleResource = $"end users ,IS specialist ,who use to information system and information it produce,customer ,saleperson and Accountants";


            string path = "C:\\user\\desktop\\coffee\\experso";
            string title = $@"Basic Resource {path}  of \n \t 'information system' ";
            Console.WriteLine(path);

            string address = @"
                        dfadsafdsfa
                    sadfjkalsdjf
                            dfasdfasdf
                            dfasdf          sdfasd
                        ""hello world""
                    c/users/anc/code/\c_sharp
                ";
            Console.WriteLine(address);

            Console.WriteLine("this is {0} file and \n{1} ", path, peopleResource);



        }


        public static void TestTwo()
        {
            string name = "aung nyein chan";
            int age = 30;
            string address = "yangon";


            // string concat 
            Console.WriteLine("My name is " + name + " I am " + age + " year old. I live in " + address);
            Console.WriteLine(string.Concat("My name is ", name, " I live in ", address));

            // string interpolation with index placeholder 
            Console.WriteLine("My name is {0}. I'm {1} years old. I live in {2}", name, age, address);

            // $ string interpolation
            Console.WriteLine($"My name is {name} I am {age} years old I live in {address}");

            // @ string laterial
            string path = "C:\\user\\anc\\dfasd # \"dadsfasd\" ";
            string path2 = @"C:\user\anc\dfasd # ""dadsfasd"" ";
            Console.WriteLine(path);
            Console.WriteLine(path2);


            string[] names = ["mgmg", "koko"];
            Console.WriteLine(string.Concat(names));

            //string nothing = "";
            string nothing = string.Empty;
            Console.WriteLine(nothing);
            Console.WriteLine(nothing);

            Console.WriteLine("----------");


            object[][] values = [[1, 2, 3, 4, "koko"], [1, 2, 3, "gogo"],];
            foreach (var item in values)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
            ;


            string username = "aung nyein chan";
            foreach (char u in username)
            {
                Console.WriteLine(u);
            }
            Console.WriteLine($"------{username[0].ToString().ToUpper()}");

            char[] numbers = ['a', 'b', 'c'];
            foreach (char u in numbers)
            {
                Console.WriteLine(u);
            }


            Console.WriteLine("++++++++++++++++++++");

            List<object[]> roles = [[1, 2, 3, 4], ["mgmgmg", "koko"], ['a', 'b', 'c']];
            roles.Add([100, 90, "susu", 's']);
            foreach (var r in roles)
            {
                foreach (var i in r)
                {
                    Console.WriteLine(i);
                }
            }




        }

        public static void ListTest()
        {
            //List<User> users = new List<User>
            //{
            //    new User("mgmg","mgmg@123"),
            //    new User("susu","susu@123"),
            //    new User("koko","koko@123"),
            //    new User("momo","momo@123"),
            //};

            List<User> customers =
            [
                new User("mgmg","mgmg@123"),
                new User("susu","susu@123"),
                new User("koko","koko@123"),
                new User("momo","momo@123"),
            ];

            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer name is {customer?.name} and email:{customer?.email}");
            }
        }

        public void TestThree()
        {
            for (int i = 10; i >=0; i--)
            {
                System.Threading.Thread.Sleep(1000);
                if(i == 0)
                {
                    this.TestFour();
                    return;
                }
                Console.WriteLine($" Count : {i}");
            }

        }

        public  void TestFour()
        {
            string text = "Happy NewYear!";
            for(int i = 0; i < text.Length; i++)
            {
                System.Threading.Thread.Sleep(200);
                Console.Write(text[i]);
            }
        }
    };



    internal class User
    {
        public string name { get; set; }
        public string email {  get; set; }

        public User(string name,string email)
        {
            this.name = name;
            this.email = email;
        }

    }

}
