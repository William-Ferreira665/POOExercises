using System;

namespace POO___Pillars.Classes
{
    public class Credito : Cartao
    {
         private float Limite = 3000f;
        int vezes;

        public void Pagar() {
            float Valor = this.Valor;

            if(Valor > Limite){
                Console.WriteLine("Você não tem limite suficiente para fazer essa compra");
            }else{
                do
                {  
                Console.WriteLine($"Em quantas vezes deseja parcelar o valor {Valor:C2}? (1x a 12x)");
                vezes = int.Parse(Console.ReadLine());

                if(vezes >= 1 && vezes <= 6){
                    Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 5% do valor total");
                    Console.WriteLine($"Você pagará {Valor * 1.05:C2} em {vezes} vezes de {(Valor * 1.05)/ vezes:C2}");
                }else if(vezes >= 7 && vezes <= 12){
                    Console.WriteLine($"Você optou por parcelar em {vezes} vezes, dessa forma o juros será de 8% do valor total");
                    Console.WriteLine($"Você pagará {Valor * 1.08:C2} em {vezes} vezes de {(Valor * 1.08)/ vezes:C2}");

                }else{
                    Console.WriteLine($"Impossivel parcelar nessa quantidade, escolha um numero de vezes entre 1 e 12.");
                }
                } while (vezes > 12 || vezes < 1);
            }
        }
    }
}