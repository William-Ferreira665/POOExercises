using System;

namespace POO___Football_Player.Classes
{
    public abstract class Player
    {
        protected string nome, nacionalidade;
        protected int dia, mes, ano, idade;
        protected int diaAtual = DateTime.Now.Day;
        protected int mesAtual = DateTime.Now.Month;
        protected int anoAtual = DateTime.Now.Year;
        protected float altura, peso;

        public void BuscarDados(){
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o dia que você nasceu: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write("Digite o mês que você nasceu: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Digite o ano que você nasceu: ");
            ano = int.Parse(Console.ReadLine());
            Console.Write("Digite sua nacionalidade: ");
            nacionalidade = Console.ReadLine();
            Console.Write("Digite sua altura: ");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            peso = float.Parse(Console.ReadLine());
        }
        public string MostrarDados(int idade)
        {
            return $@"
Nome: {nome}
Data de nascimento: {dia}/{mes}/{ano}
Idade: {idade}
Nacionalidade: {nacionalidade}
Altura: {altura}
Peso: {peso}";
        }
        public int Idade()
        {
            if(diaAtual >= dia && mesAtual >= mes){
                idade = anoAtual - ano;
            }else{
                idade = (anoAtual - ano) - 1;
            }
            return idade;
        }
    }
}