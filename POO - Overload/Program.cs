using System;
using POO___Overload.Classes;

namespace POO___Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < 4; i++)
            {
                Console.Write($"Digite o item {i + 1} da lista: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("");

            Console.WriteLine("Mostrar sem argumentos.");
            f.Mostrar();

            Console.WriteLine("Mostrar com argumento tipo 'int'");
            f.Mostrar(2);

            Console.WriteLine("Mostrar com argumento tipo 'string'");
            f.Mostrar("Banana");
        }
    }
}
