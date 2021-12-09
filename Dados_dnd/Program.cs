using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading;

namespace ConsoleApp2
{
     
    class Program
    {
        public static int counter = 0;
        public static int counterall = 0;
        public static int[] results = new int[9000];
        //usar enum para criar a lista das armas para usar no switch linha 144
        public enum Weapon_Type
        {
            Dagger,
            Shortsword,
            Battleaxe
        };
        public static Weapon_Type weapon_Type;
        public static int close = 1;

        static void Main(string[] args) // Main Function
        {
        
            int dados, qdados;
             
            int[] dadosarray = { 4, 6, 8, 10, 12, 20, 100 };//array
            do
            { 
                Console.WriteLine("Introduza um numero: "); // 4, 6, 8, 10, 12, 20 ou 100
                dados = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                int pos = Array.IndexOf(dadosarray, dados); //criar variavel para guardar a posicao do array

                if (pos > -1 /*verificar existencia de dados no array, faz o mesmo que: if(dados == 4 || dados == 6 || dados == 8 || dados == 10 || dados == 12 || dados == 20 || dados == 100)*/)
                {
                    do
                    {
                        Console.WriteLine("Introduza o numero de dados a rolar"); // qq numero positivo
                        qdados = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (qdados == 0)
                        {
                            close = 0;
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
                            close = BasicAttack(qdados);
                        }
                    }while (close != 0);
                }
                else if (dados == 0)
                {
                    close = 0;
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
            while (close != 0);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Pressione uma tecla para sair");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }

        //funcao para rodar e calcular (parte da main2)
        public static int Rolldice(int x, int w)
        {
            int soma = 0;
            int random;
            Random r = new();

            for (int i = 1; i <= w; i++)
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
                close = 0;
                return w;
        }

        //funcao para o roll + basic atk + damage
        public static int  BasicAttack(int y)
        {
            int valorcustom;
            Console.Clear();
            Console.WriteLine("Escolhe a tua arma: Dagger, Shortsword, Battleaxe");
            
            string compare = Console.ReadLine();
            if (compare == "Dagger") {

            } else if (compare == "Shortsword") {

            } else if (compare == "Battlesword") {

            }
            else
            {
               Console.WriteLine("Por favor introduza um valor correto");
            }

            //exercicio 2 da lesson 6, nao perguntamos ao user o nr de dots.
            Console.Clear();
            Console.WriteLine("Introduza o numero de vezes que quer rolar");
            valorcustom = Console.Read();
            int attk = Rolldice(20/*nr da face fixo*/, valorcustom/*nr de rolls varia no ex2 lesson 6*/) ;
            int dmg;

            //adicionar AC | modificador de damage perguntando ao user
            Console.WriteLine("Escolhe um valor para o dmg.multiplicador(superior a 10)");
            int AC = Convert.ToInt32(Console.ReadLine());
            results[counterall] = attk;
            counterall++; //all count
            if (attk >= AC)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result {attk}: Attack succeeded, rolling for damage…\n");
                counter++; //successful count
                Console.ForegroundColor = ConsoleColor.White; 

                switch (weapon_Type)
                {

                    case Weapon_Type.Dagger:
                        {
                            dmg = AC + Rolldice(4, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nAverage:{results.Average()}\nCounter:{counter}\nCounterAll:{counterall}\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case Weapon_Type.Shortsword:
                        {
                            dmg = AC + Rolldice(6, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nAverage:{results.Average()}\nCounter(success):{counter}\nCounterAll:{counterall}\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    case Weapon_Type.Battleaxe:
                        {
                            dmg = AC + Rolldice(8, 1);
                            Console.WriteLine($"Attack resulted in {dmg} points of damage.\nAverage:{results.Average()}\nCounter:{counter}\nCounterAll:{counterall}\nPrima uma tecla para continuar");
                            Console.ReadKey();
                            break;
                        }
                    default:
                    {
                        Console.WriteLine("Por favor introduz uma arma valida.\n");
                        break;
                    }
                }
            }
            else if (attk <= 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Result {attk}: Attack failed !\nPrima uma tecla para continuar");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                Console.Clear();
                //close = 1;
            }
            return 1;
        }

    }
}