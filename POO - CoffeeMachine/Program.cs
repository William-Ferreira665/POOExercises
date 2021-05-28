using System;

namespace POO___CoffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
             bool outroCafe = true;
            bool cafe = true;
            CoffeeMachine cafeteira = new CoffeeMachine();

            Console.WriteLine(@"
Super CafeteiraTabajaras Plus++ inicializada");
            do
            {
                cafeteira.fazerCafe();
                do
                {

                    Console.WriteLine($@"
Sim(S) / Não(N)
Deseja faze outro café?");
                    string Sn = Console.ReadLine().ToLower();
                    if (Sn == "s")
                    {
                        outroCafe = false;
                        cafe = true;
                    }
                    else if (Sn == "n")
                    {
                        outroCafe = true;
                        cafe = true;
                    }
                    else
                    {
                        Console.WriteLine(@"
Comando inválido");
                        cafe = false;
                    }
                } while (cafe == false);
            } while (outroCafe == false);
        }
    }
}
