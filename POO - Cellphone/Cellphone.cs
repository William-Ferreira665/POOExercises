namespace POO___Cellphone
{
    public class Cellphone
    {
        public string cor = "springtime purple";
        public string modelo = "Iphone 12 Pro";
        public string Tamanho = "6.53 Polegadas";
        private bool ligado = false;

        public bool Ligar(){
            ligado = true;
            return(true);
        }
        public bool Desligar(){
            ligado = false;
            return(false);
        }
        public void Ligacao(){

        }
        public void EnviarMensagem(){

        }

    }
}