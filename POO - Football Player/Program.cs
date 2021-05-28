using System;
using POO___Football_Player.Classes;

namespace POO___Football_Player
{
    class Program
    {
        static void Main(string[] args)
        {
             string posicao;
            bool verificacao = true;

            AttackPlayer attack = new AttackPlayer();
            MiddlePlayer middle = new MiddlePlayer();
            DefensePlayer defense = new DefensePlayer();

            do
            {
            Console.WriteLine(@" (A)Ataque, (M)Meio-Campo e (D)Defesa
Digite em que posição você joga: ");
            posicao = Console.ReadLine().ToLower();
            switch (posicao)
            {
                case "a":
                attack.BuscarDados();
                Console.WriteLine(attack.MostrarDados(attack.Idade()));
                Console.WriteLine(attack.Aposentar());
                    break;
                case "m":
                middle.BuscarDados();
                Console.WriteLine(middle.MostrarDados(middle.Idade()));
                Console.WriteLine(middle.Aposentar());
                    break;
                case "d":
                defense.BuscarDados();
                Console.WriteLine(defense.MostrarDados(defense.Idade()));
                Console.WriteLine(defense.Aposentar());
                    break;
                default:
                    Console.WriteLine("Comando inválido digite novamente");
                    verificacao = false;
                    break;
            }
            } while (verificacao == false);
        }
    }
}
