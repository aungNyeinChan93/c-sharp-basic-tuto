using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Inheritance_02
    {
        public static void Main()
        {
            Dog dog = new Dog();
            dog.Sleep();
            dog.GetClassName();
            Dog dog2 = new();

            List<Animal> animals = [dog, dog2];

            foreach (var d in animals)
            {
                d.Sleep();
            }

            Console.WriteLine("----------------");

            Dog aungNet = new Dog(ClassName: "dog class", age: 6);
            //Console.WriteLine(aungNet.GetAge());
            Console.WriteLine(aungNet.Age);
            aungNet.Eat();
            aungNet.Sleep();
            aungNet.Run();

            Console.WriteLine(aungNet.test);


        }
    }

    abstract class Animal
    {
        public abstract void Run();

        public Animal()
        {

        }

        public Animal(string className)
        {
            this.ClassName = className;
        }

        protected string ClassName = "Animal";

        public readonly string test = "readOnly test";

        public void Eat()
        {
            Console.WriteLine($"Animal is eating!");
        }
        public void Sleep()
        {
            Console.WriteLine($"Animal is sleep!");
        }
    }

    class Dog : Animal
    {

        public Dog()
        {

        }

        public Dog(string ClassName, int age)
        {
            base.ClassName = ClassName;
            this.age = age;
        }

        private int age;

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public int Age { set { age = value; } get { return age; } }
        public int Age { get; set; }

        public void Bark()
        {
            Console.WriteLine("Dog is Bark , wok wok !");
        }

        public new void Sleep()
        {
            Console.WriteLine("Dog is sleeping");
        }

        public void GetClassName()
        {
            this.ClassName = "Dog";
            Console.WriteLine(this.ClassName);
        }

        public override void Run()
        {
            Console.WriteLine("Running!!!");
        }
    }


}
