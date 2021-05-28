using System;

namespace POO___Pillars.Classes
{
    public class Debito : Cartao
    {
        private float Saldo = 10600f;

        public void Pagar(){
            float Valor = this.Valor;

            if(Valor > Saldo){
                Console.WriteLine("Saldo insuficiente para o pagamento!");
            }else{
                Console.WriteLine($"O valor {Valor:C2} foi pago com sucesso!");
            }
        }
    }
}