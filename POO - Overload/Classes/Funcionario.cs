using System;

namespace POO___Overload.Classes
{
    public class Funcionario
    {
        public string[] lista = new string[4];

        public void Mostrar(){
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
        public void Mostrar(int Indice){
            Console.WriteLine(lista[Indice]);
        }
        public void Mostrar(string Busca){
            for (var i = 0; i < lista.Length; i++)
            {
                if (lista[i] == Busca)
                {
                    Console.WriteLine($"O item da {lista[i]} foi encontrado na posição {i + 1}");
                }
            }
        }
    }
}