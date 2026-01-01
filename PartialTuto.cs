using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{
    internal class PartialTuto
    {

        public static void Main()
        {
            TestOne();
        }

        public static void TestOne()
        {

            Payment p1 = new Payment { ElectricBell = 1000, homeRent = 9000 };
            p1.HomeInfo();
            Console.WriteLine(new { homeRent = p1.homeRent, EBill = p1?.ElectricBell });

            Payment p2 = new Payment(500);
            Console.WriteLine(p2.bill);
            p2.bill = 9000;
            Console.WriteLine(p2.bill);
            Console.WriteLine(p2.name);
        }
    }

    partial class Payment 
    {
        public string name = "Payment Class";

        public int homeRent;

        public partial void HomeInfo();

        public int bill { get; set; }

        public Payment()
        {

        }
        public Payment(int b)
        {
            this.bill = b;
        }

    }
    partial class Payment
    {
        public int ElectricBell;

        public partial void HomeInfo()
        {
            Console.WriteLine(new {this.homeRent });
        }

    }

    interface WifiBill
    {
        public string name { get; set; }

        public int amount { get; set; }
    }


}
