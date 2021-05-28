namespace POO___Football_Player.Classes
{
    public class AttackPlayer : Player
    {
        public string Aposentar()
        {
            if (idade < 35)
            {
                return "você ainda está na idade para jogar";
            }
            else
            {
                return "É recomendado que você se aposente na sua idade atual";
            }
        }
    }
}