using System;
using POO___Elevator.Classes;

namespace POO___Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;
            bool repeticao = true;

            SocialElevator social = new SocialElevator();
            ServiceElevator servico = new ServiceElevator();
            Console.WriteLine(social.Inicializar());

            Console.Write(@"Social = 1 ou de Serviço = 2?
Deseja utilizar qual dos elevadores: ");
            escolha = int.Parse(Console.ReadLine());
            if (escolha == 1)
            {

                do
                {
                    Console.WriteLine($@"
_____________________________________
||       Elevador Social           ||
||¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨||
|| 1 - Subir uma pessoa            ||
|| 2 - Descer uma pessoa           ||
|| 3 - Subir um andar              ||
|| 4 - Descer um andar             ||
|| 0 - Sair                        ||
¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(social.Entrar());
                            break;
                        case 2:
                            Console.WriteLine(social.Sair());
                            break;
                        case 3:
                            Console.WriteLine(social.Subir());
                            break;
                        case 4:
                            Console.WriteLine(social.Descer());
                            break;
                        case 0:
                            Console.WriteLine("Programa finalizado!");
                            repeticao = false;
                            break;
                    }


                } while (repeticao == true);

            }
            else if(escolha == 2)
            {
                do
                {
                    Console.WriteLine($@"
_____________________________________
||       Elevador Serviço          ||
||¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨||
|| 1 - Subir uma pessoa            ||
|| 2 - Descer uma pessoa           ||
|| 3 - Subir um andar              ||
|| 4 - Descer um andar             ||
|| 5 - subir uma caixa             ||
|| 6 - Descer uma caixa            ||
|| 0 - Sair                        ||
¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                    escolha = int.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine(servico.Entrar());
                            break;
                        case 2:
                            Console.WriteLine(servico.Sair());
                            break;
                        case 3:
                            Console.WriteLine(servico.Subir());
                            break;
                        case 4:
                            Console.WriteLine(servico.Descer());
                            break;
                        case 5:
                            Console.WriteLine(servico.AdicionarCaixa());
                            break;
                        case 6:
                            Console.WriteLine(servico.RetirarCaixa());
                            break;
                        case 0:
                            Console.WriteLine("Programa finalizado!");
                            repeticao = false;
                            break;
                    }


                } while (repeticao == true);

            }
        }
    }
}
