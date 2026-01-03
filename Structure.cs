namespace ConsoleApp2
{
    internal class Structure
    {
        public static void Main()
        {
            //TestOne();
            //Test.TestStruct();
            //TestTwo();
            TestThree();
        }

        public struct User
        {
            public string Name { get; set; }

            public string Email { get; set; }

            public int Age { get; set; }

            public void Info()
            {
                Console.WriteLine($"Name is {this.Name} .Email is {Email} , Age is {Age}");
            }
        }

        public static void TestOne()
        {
            User user1 = new User();
            user1.Name = "Test";
            user1.Email = "User@123";
            user1.Age = 30;

            User user2 = user1; // note ->  struct is value type  & class is refrence type
            user2.Age = 21;

            user1.Info();
            Console.WriteLine(new { name = user1.Name, email = user1.Email, age = user1.Age, user2_age = user2.Age });
        }

        public static bool ChangeName(ref User user, string changeName)
        {
            if (user.Name != "")
            {
                user.Name = changeName;
                return true;
            }
            ;
            return false;
        }

        public static void TestTwo()
        {
            User newUser = new User() { Name = "abc", Email = "asbc@123" };
            var isSuccess = ChangeName(ref newUser, "zxc");
            if (isSuccess)
            {
                newUser.Info();
            }

        }

        public static User CreateUser(string name)
        {
            User user = new() { Name = name };
            return user;
        }

        public static void TestThree()
        {
            var koko = CreateUser("koko");
            koko.Info();
        }

    }

    public class Test
    {
        public static void TestStruct()
        {
            Structure.User aung = new()
            {
                Name = "anc",
                Age = 30,
                Email = "anc@123"
            };

            Console.WriteLine($"Name :{aung.Name} , Email: {aung.Email} , Age : {aung.Age}");
        }
    }
}
