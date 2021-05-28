namespace POO___Poliformismo.Classes
{
    public abstract class Player
    {
        private float velocidade;
        private float forcaPulo;

        public virtual string Correr() {
            return "O Player correu";
        }
        public virtual string Pular() {
            return "O Player pulou";
        }
    }
}