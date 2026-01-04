using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Class
    {
        public static void Main()
        {
            MyClass myClass = new() { ClassName = "My Class" };

            //MyClass.TestOne();
            //MyClass.TestTwo();
            //myClass.TestThree();
            //myClass.TestFour();
            MyClass.TestFive();
            //MyClass.TestSix();
        }
    }


    public class MyClass
    {
        public required string ClassName { get; set; }

        public static void TestOne()
        {
            Animal dog1 = new Dog() { Name = "Mike", age = 4, color = "brown" };

            dog1.Sleep();
            dog1.Eat();
        }

        public static void TestTwo()
        {
            var d1 = new Dog("jack", 3, "black");
            d1.Info();
        }

        public void TestThree()
        {
            var p1 = new Position() { X = 1, Y = 2 };
            Console.WriteLine($"You are object position is X-{p1.X} and Y-{p1.Y}");
        }

        public string AboutDog(Dog d)
        {
            string result = $" Dog name is {d.Name} and Age is {d.age}.His Color is {d.color}";
            return result;
        }

        public void TestFour()
        {
            var newDog = new Dog(name: "bonyi", age: 4, color: "brown");
            string res = this.AboutDog(newDog);
            Console.WriteLine(res);
        }

        public static void DogNames(Dog[] dogs)
        {
            foreach (var dog in dogs)
            {
                Console.WriteLine($"{dog?.Name}");
            }
        }

        public static void TestFive()
        {
            Dog[] dogs = new Dog[3]
            {
                new ("bobo",3,"red"),
                new ("gogo",3,"white"),
                new ("xoxo",4,"yellow-brown"),
            };

            MyClass.DogNames(dogs);
        }

        public static void TestSix()
        {
            var userOne = new User() { Email = "mgmg@123", Name = "mgmg" };

            var users = new Users();

            users.AddUser(userOne);

            var findUser = users.GetUser("mgmg");

            Console.WriteLine($"Find user's email is {findUser.Email}");

        }


    }

    abstract public class Animal
    {
        public  string Name { get; set; }

        public  int age { get; set; }

        public Animal()
        {

        }

        public Animal(string name,int age)
        {
            this.Name = name;
            this.age = age;
        }


        public abstract void Sleep();

        public abstract void Eat();
    }

    public class Dog :Animal
    {
        public  string color { get; set; }

        public Dog()
        {

        }

        public Dog(string name,int age, string color)
        {
            base.Name = name;
            base.age = age;
            this.color = color;
        }


        public override void Sleep()
        {
            Console.WriteLine(Name + " is sleep .zzZ");
        }

        public override void Eat()
        {
            Console.WriteLine(base.Name + " eating ");
        }

        public void Info()
        {
            Console.WriteLine( $" name :{Name} ,Age :{this.age} , Color: {color}" );
        }
    }

    struct Position
    {
        public int X{  get; set; }
        public int Y { get; set; } 
    }


    public class Users
    {
        public List<User> users ;

        public void AllUsersNames()
        {
            foreach (var user in this.users!)
            {
                Console.WriteLine(user?.Name);
            }
        }

        public void AddUser(User user)
        {
            users!.Add(user);
        }

        public User GetUser(string name)
        {
            var res = new User();
            foreach(var user in this.users!)
            {
               if(user.Name == name)
                {
                    res = user; break;
                }
            };
            return res;
        }

    }

    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set { Password = value; } }
        
    }
}
