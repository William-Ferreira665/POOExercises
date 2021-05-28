using System;
using POO___Pillars.Classes;

namespace POO___Pillars
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            do
            {

                Console.WriteLine($@"
_____________________________________
|  Escolha um método de pagamento:  | 
|___________________________________|      
| B - Boleto                        |
| C - Crédito                       |
| D - Débito                        |
| X - Cancelar pagamento            |
|___________________________________|");

                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boleto b = new Boleto();
                        b.Registrar();
                        opcaoValida = true;
                        break;
                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoValida = true;
                        break;
                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoValida = true;
                        break;
                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        break;
                    default:
                    Console.WriteLine("Opção inválida!");
                        opcaoValida = false;
                    break;
                }
            } while (opcaoValida == false);
        }
    }
}
