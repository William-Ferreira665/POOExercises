namespace POO___Elevator.Classes
{
    public class ServiceElevator : Elevator
    {
        private int caixasAtual;
       private int capacidadeCaixas = 4;

        public string AdicionarCaixa(){
            if(caixasAtual < capacidadeCaixas){
                caixasAtual++;
                return $@"Uma caixa foi adicionada
Há {caixasAtual} caixa(s) no elevador";
            }else{
                return $@"Elevador lotado!
Há {caixasAtual} caixa(s) no elevador";
                
            }
        }
        public string RetirarCaixa(){
            if(caixasAtual != 0){
                caixasAtual--;
                return $@"Uma caixa foi retirada
Há {caixasAtual} caixa(s) no elevador";
                
            }else{
                return $@"Não há caixas
Há {caixasAtual} caixa(s) no elevador";
                
            }
        }
    }
}