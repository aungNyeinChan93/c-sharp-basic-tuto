using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Interface
    {
        public static void Main()
        {
            TestOne();
        }

        public static void TestOne()
        {
            Customer u1 = new User() { Name = "user1", Email = "user1@123" };
            u1.Info();
        }
    }

    interface Customer
    {
        string Name { get; set; }

        string Email { get; set; }

         void Info();


    }

    class User : Customer
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public void Info()
        {
            Console.WriteLine("Info");
            Console.WriteLine(new {name =this.Name, email = this.Email});
        }
    }
}
