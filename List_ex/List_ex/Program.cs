using System;
using System.Collections.Generic;

namespace List_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A list of words");
            List<string> palavras = new List<string>(10);
            for (int i = 0; i < palavras.Capacity; i++)
            {
                palavras.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ",palavras));

        }
    }
}
