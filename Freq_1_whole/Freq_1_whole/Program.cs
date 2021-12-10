using System;

namespace Freq_1_whole
{
    class Program
    {
        static void Main(string[] args)
        {
            int em;
            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma opcao:\n1> Exercício 1\n2> Exercício 2\n0>Sair");
                em = Convert.ToInt32(Console.ReadLine());
                switch (em)
                {
                    case 1:
                    {
                        Console.Clear();
                        Ex1();
                        break;
                    }

                    case 2:
                    {
                        Console.Clear();
                        Ex2();
                        break;
                    }

                    case 0:
                    {

                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Escolha uma opção valida!");
                        break;
                    }
                }
            }while (em != 0);
            Console.WriteLine("Prima uma tecla para terminar");
            Console.ReadKey();
        }

        static void Ex1()
        {
            Boolean Ex1 = true;
            Console.WriteLine("Escreve uma frase oh jovem:");
            do
            {
                string sentence = Console.ReadLine();
                if (sentence.Contains("."))
                {
                    Console.WriteLine("Escreve uma frase COMPATIVEL oh jovem:");
                }
                else
                {
                    Ex1 = false;
                }
            } while (Ex1);
        }

        static void Ex2()
        {
            
        }
    }
}