using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Split
    {

        public static void Main()
        {
            TestOne();
        }

        public static void TestOne()
        {
            string url = "https://www.5google.com/users/aung";

            string protocol = url.Split("://").First();

            string[] result = url.Split("://");

            string domain = result[1].Split("/").First();
            string endPoint = result[1].Split("/", 2).Last();

            Console.WriteLine(result[0]);
            Console.WriteLine(new { url, protocol, domain, endPoint });

            object other = new { url, protocol, domain, endPoint, test = "testing" };
            Console.WriteLine(other);

            object user = new
            {
                name = "aung nyein chan",
                age = 31,
                address = "yangon"
            };
            Console.WriteLine(user);
        }
    }
}
