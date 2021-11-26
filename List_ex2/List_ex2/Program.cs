using System;
using System.Collections.Generic;

namespace List_ex2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A list of numbers");
            List<int> numbers = new List<int>(10);
            for (int i = 0; i < numbers.Capacity; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}