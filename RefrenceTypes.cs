using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp2
{
    internal class RefrenceTypes
    {

        public static void Main()
        {
            RefrenceTypes r = new ();

            List<int> numbers = [1, 2, 3, 4 ,5,6,7];

            var result = r.Test(numbers);
            
            foreach(int res in result)
            {
                Console.WriteLine((decimal)res);
            }

            //
            Phone p1 = new() { Brand = "Apple" };
            p1.Price = 900;
            
            var p2 = Clone(p1);
            p2.Brand = "Redmi";
            Console.WriteLine(new { phoneTwoBrand = p2.Brand ,PhoneOneBrand = p1?.Brand });

            RefrenceTypes.PhonesBrand([p1!,p2]);


            // usage of ref 
            string returnRes = "";
            RefTest(name: "this is test parameter for ref Test method", value: ref returnRes);
            Console.WriteLine(returnRes);

        }

        public  List<int> Test(List<int> rate)
        {
            rate?.RemoveAt(0);
            rate?.Remove(7);
            return rate!;
        }

        public static Phone Clone(Phone ph)
        {
            ph.Info();
            var json = JsonSerializer.Serialize(ph); 
            var p2 = JsonSerializer.Deserialize<Phone>(json);
            return p2;
        }

        public static void PhonesBrand(Phone[] phones)
        {
            foreach(var phone in phones)
            {
                Console.WriteLine(phone?.Brand);
            }
        }

        public static void RefTest(string name,ref string value)
        {
            value = name;
            Console.WriteLine("reftest run ... ");
        }

    }

    class Phone
    {
        public required string Brand { get; set; }

        public int Price { get; set; }

        public void Info()
        {
            Console.WriteLine($" Brand {this.Brand} , Price {Price}");
        }

    }
}
