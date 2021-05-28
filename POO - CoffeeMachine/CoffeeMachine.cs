using System;

namespace POO___CoffeeMachine
{
    public class CoffeeMachine
    {
        private int acucarDisponivel = 1000;
        public void fazerCafe(int acucar)
        {
            if (acucarDisponivel < acucar)
            {
                Console.WriteLine(@"
Quantidade de café desejada indisponível");
            }
            else
            {
                Console.WriteLine($@"
Seu café com {acucar} gramas de acucar está sendo preparado");
                acucarDisponivel = acucarDisponivel - acucar;
                Console.WriteLine($@"
Seu café com açucar está pronto
Agora há {acucarDisponivel} gramas de açucar disponível na sua máquinda de café");
            }
        }
        public void fazerCafe()
        {
            bool loopUm = true;
            bool loopDois = true;
            do
            {

                Console.WriteLine(@"
Com(C) / Sem(S)
Você deseja fazer um café com ou sem açucar?");
                string escolha = Console.ReadLine().ToLower();
                if (escolha == "c")
                {
                    loopUm = true;
                    do
                    {
                        Console.WriteLine(@"
Sim(S) / Não(N)
Deseja escolher quantas gramas de café irão ser colocadas em seu café?");
                        string Sn = Console.ReadLine().ToLower();
                        if (Sn == "s")
                        {
                            Console.WriteLine(@"
Digite a quantidade de açucar");
                            int acucar = int.Parse(Console.ReadLine());
                            fazerCafe(acucar);
                            loopDois = true;
                        }
                        else if (Sn == "n")
                        {
                            acucarDisponivel = acucarDisponivel - 10;
                            Console.WriteLine($@"
Por padrão colocamos 10 gramas de açucar no seu café
Seu café com açucar está pronto para consumo
Restam {acucarDisponivel} gramas de açucar na sua máquina de café");
                            loopDois = true;
                        }
                        else
                        {
                            Console.WriteLine("Comando inválido");
                            loopDois = false;
                        }
                    } while (loopDois == false);
                }
                else if (escolha == "s")
                {
                    loopUm = true;
                    Console.WriteLine(@"
Seu café sem açucar está pronto para consumo");
                }
                else
                {
                    Console.WriteLine(@"
Comando inválido");
                    loopUm = false;
                }
            } while (loopUm == false);
        }
    }
}