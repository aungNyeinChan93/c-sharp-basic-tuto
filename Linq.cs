using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Linq
    {
       
        public static void Main()
        {
            LinqTest();
        }

        public static void LinqTest()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var rate = new int[] { 1, 2, 3, 4, 5, 6 };
            var users = new string[] { "mgmg", "koko", "jojo", "hoho" };

            var res = (from n in numbers
                       from u in users
                       select (n.ToString() + u)
                       ).ToList();

            var numRes = (from n in numbers
                          from r in rate
                          select n + r).ToList();

            foreach (var r in res)
            {
                Console.WriteLine(r);
            }


            var teams = new List<string> { "myanmar", "thai", "lao", "malaysia" };
            var matches = (from t1 in teams
                          from t2 in teams
                           where t1 != t2
                           select $" {t1} Vs {t2}"
                          ).ToList();

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }


    }
}
