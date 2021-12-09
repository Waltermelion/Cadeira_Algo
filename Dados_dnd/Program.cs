using System;

namespace testbed3
{
    class Program
    {
        public static int dados, qdados;
        static void Main(string[] args) // Main Function
        {

            do
            {
                Console.WriteLine("Introduza um numero: "); // 4, 6, 8, 10, 12, 20 ou 100
                dados = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (dados == 4 || dados == 6 || dados == 8 || dados == 10 || dados == 12 || dados == 20 || dados == 100)
                {
                    do
                    {
                        Console.WriteLine("Introduza o numero de dados a rolar"); // qq numero positivo
                        qdados = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (qdados == 0)
                        {
                            dados = 0;
                        }
                        else if (qdados < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Por favor introduza um numero valido (pressionar entre para continuar)");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Rolldice(dados);
                        }
                    }
                    while (qdados != 0);
                }
                else if (dados == 0)
                {

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor introduza um numero valido (pressionar entre para continuar)");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            while (dados != 0);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Prima uma tecla para terminar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            

        }
        public static int Rolldice(int x)
        {
            //declare random
            int soma = 0;
            int random = 0;
            Random r = new Random();
            // calculate random (insert in loop)
            for (int i = 0; i < qdados; i = i + 1)
            {
                random = r.Next(1, x + 1);
                soma += random;
                Console.WriteLine($"O valor da face {i} é: {random}");
            }
            Console.WriteLine($"A soma das faces e: {soma}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("pressione enter para continuar");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
            qdados = 0;

            return random;
        }

    }
}