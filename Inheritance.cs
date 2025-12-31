using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Inheritance
    {
        public static void Main()
        {
            Computer dell = new Dell();
            dell.name = "Dell Latitube 7000";
            dell.CPU = "i9 11gen";
            dell.RAM = "ddr5 16gb";
            dell.price = 500;

            dell.Info();

            string test = "test";


            Computer lenovo = new Lenovo();
            lenovo.name = "Think Pad";
            lenovo.CPU = "Rhyzan 7";
            lenovo.RAM = "ddr4 16gb";
            lenovo.price = 700;

            lenovo.Info();
            Console.WriteLine(new{ test });

        }
    }

    class Computer
    {
        public string name { get; set; }

        public string CPU { get; set; }

        public string RAM { get; set; }

        public double price { get; set; }

        public void Info()
        {
            Console.WriteLine($"Brand: {name} \n CPU: {CPU} \n RAM:{RAM} \n Price: { price } ");
        }
    }

    class Dell : Computer
    {

    }

    class Lenovo : Computer 
    {

    }

}
