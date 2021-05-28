namespace POO___Elevator.Classes
{
    public abstract class Elevator
    {
        private int andarAtual;
        private int totalAndares = 10;
        private int ocupacao;
        private int capacidade = 8;

        public string Inicializar(){
            andarAtual = 0;
            ocupacao = 0;
            return "Elevador inicializado";
        }

        public string Entrar(){
            if(ocupacao < capacidade){
                ocupacao++;
                return $@"Uma pessoa subiu no elevador
Há {ocupacao} pessoa(s) no elevador";
            }else{
                return $@"Elevador lotado!
Há {ocupacao} pessoa(s) no elevador";
                ;
            }
        }
        public string Sair(){
            if(ocupacao != 0){
                ocupacao--;
                return $@"Uma pessoa saiu do elevador
Há {ocupacao} pessoa(s) no elevador";
                ;
            }else{
                return $@"Elevador vazio
Há {ocupacao} pessoa(s) no elevador";
                ;
            }
        }
        public string Subir(){
            if(andarAtual < totalAndares){
                andarAtual++;
                return $@"O elevador subiu um andar
Andar atual {andarAtual}° Andar";
            }else{
                return $@"Já estamos no último andar do prédio
Andar atual {andarAtual}° Andar";
            }
        }
        public string Descer(){
            if(andarAtual != 0){
                andarAtual--;
                return $@"O elevador desceu um andar
Andar atual {andarAtual}° Andar";
            }else{
                return $@"Já estamos no térreo prédio
Andar atual {andarAtual}° Andar";
            }
        }

    }
}