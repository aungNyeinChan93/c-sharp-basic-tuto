using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace ConsoleApp2
{
    internal class Guest
    {

        public static void Main(string[] args)
        {
            Guest g = new ();
            g.Game();
        }

        public void Game()
        {
            Console.WriteLine("Guest number 1 to 10 !");
            int realNumber = 10;
            int guestNumber = 0;
            do
            {
                Console.Write("Enter Guest Number : ");
                guestNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(realNumber == guestNumber ? $"Great you number {guestNumber } is correct":"try again");
            }
            while (realNumber != guestNumber);
        }
    }
}
