using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Collection
    {
        public static void Main()
        {
            //QueueTest();
            //ListTest();
            StackTest();
        }

        public static void QueueTest()
        {
            Queue<int> q = new();

            var colors = new Queue<string>();

            colors.Enqueue("red");
            colors.Enqueue("green");
            colors.Enqueue("blue");
            colors.Enqueue("yellow");
            colors.Enqueue("skyblue");

            string red = colors.Dequeue();

            Console.WriteLine(red);

            foreach (var color in colors) 
            {
                Thread.Sleep(500);
                Console.Write($" {color} ");
            }

        }


        public static void ListTest()
        {
            List<string> names = ["mgmg", "susu", "aung"];

            names.Add("chan");
            names.Add("koko");


            names.Remove("susu");
            names.RemoveAt(names.Count -1);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }

        public static void StackTest()
        {
            var marks = new Stack<int>();
            marks.Push(1);
            marks.Push(2);
            marks.Push(3);
            marks.Push(4);

            marks.Pop();

            foreach (var mark in marks)
            {
                Console.WriteLine(mark);
            }


        }

    }
}
