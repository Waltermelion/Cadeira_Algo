using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstword = "test";
            string lastword = "yes";
            string space = " ";            

            Console.WriteLine("Write the sentence.");
            string sentence = Console.ReadLine();


            if (firstword == lastword)
            {
                Console.WriteLine("The first and the last word are the same: ");
                Console.Write(firstword);
            }
            else
            {
                Console.WriteLine("The first and the last word are not the same");
            }
            
                      
        }
    }
}
