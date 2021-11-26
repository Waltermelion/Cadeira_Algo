using System;
using System.Collections.Generic;

namespace List_ex3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A list of numbers");
            List<int> numbers = new List<int>(new int[] { 65, 47, 100, 3, 19 });
            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}