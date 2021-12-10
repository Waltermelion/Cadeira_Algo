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
            int ammountOfa = 0;
            Boolean Ex1 = true;
            Console.WriteLine("Escreve uma frase oh jovem:");
            do
            {
                string sentence = Console.ReadLine();
                if (sentence.Contains("."))
                {
                    Console.WriteLine("Escreve uma frase COMPATIVEL oh jovem:");
                    continue;
                }

                string[] strArray = new string[10];
                string sep = " ";
                strArray = sentence.Split(sep);
                
                foreach (var lavras in strArray)
                {
                    if (lavras.Contains(" a") || lavras.Contains(" A") || lavras.StartsWith("a") || lavras.StartsWith("A"))
                    {
                        ammountOfa += 1;
                    }
                }

                if (ammountOfa == 0)
                {
                    Console.WriteLine("A tua frase não tem às morcao do caralho foda-se");
                    Console.ReadLine();
                    Ex1 = false;
                }
                else
                {
                    Console.Write("A tua frase tem ");
                    Console.Write(ammountOfa);
                    Console.WriteLine(" a's! queres um biscoito?");
                    Console.ReadLine();
                    Ex1 = false;
                }

            } while (Ex1);
        }

        static void Ex2()
        {
            Boolean Ex2 = true;
            Random randomNum = new Random(); 
            int generatedNum = randomNum.Next(1, 21);
            Console.WriteLine(generatedNum);
            Console.WriteLine("Wich number out of 20 was randomly chosen?");
            do
            {
                int writtenNum = int.Parse(Console.ReadLine());
                if (generatedNum == writtenNum)
                {
                    Console.Write("You got it right! The number was: ");
                    Console.WriteLine(generatedNum);
                    Console.WriteLine("Press any key to go back to the menu.");
                    Console.ReadKey();
                    Ex2 = false;
                }else if (writtenNum > generatedNum)
                {
                    Console.Write("Lower...");
                }else if (writtenNum < generatedNum)
                {
                    Console.Write("Higher...");
                }
            } while (Ex2);
        }
    }
}