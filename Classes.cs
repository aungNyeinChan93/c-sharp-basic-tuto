using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp2
{
    internal class Classes
    {
        public static void Main()
        {
            TestOne();
            TestTwo();
            TestThree();
            TestFour();
        }

        public static void TestOne()
        {
            var c1 = new Customer("Koko", 12);

            c1.SetName("aung nyein chan");
            c1.SetAge(31);

            Console.WriteLine(new { name = c1.GetName(), age = c1.GetAge() });
        }

        public static void TestTwo()
        {
            object user = new { name = "koko", email = "koko@123" };
            Console.WriteLine(user);
        }

        public static void TestThree()
        {
            var myStar = Star.five;
            Console.WriteLine(myStar);
        }

        public static void TestFour()
        {
            var user = new User("aung", 21);
            user.Name = "";
            user.Age = 131;
            user?.AboutUs();
        }
    }

    public enum Star
    {
        one,
        two,
        three,
        four,
        five
    }

    public class Customer
    {
        private string _name;

        private int _age;

        public Customer(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public void SetName(string name) => this._name = !string.IsNullOrEmpty(name) ? name : "invalid name";

        public string GetName() => this._name;

        public void SetAge(int age) => this._age = age > 0 && age < 150 ? age : -1;

        public int GetAge() => this._age;
    }

    public class User
    {
        private string _name;

        private int _age;

        public User(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string Name
        { 
            get { return _name; } 
            set { _name = !string.IsNullOrEmpty(value) ? value: "invalid name" ; } 
        }

        public int Age
        {
            get => _age; 
            set => _age = (value > 0 && value < 100 ) ? value :-1; 
        }

        public void AboutUs()
        {
            Console.WriteLine(new {name = this.Name ,age = this.Age});
        }
    }

}


