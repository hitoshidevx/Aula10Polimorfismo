namespace Atividade10Polimorfismo
{
    public class Player
    {
        
        public virtual void Pular(){
            System.Console.WriteLine("Pulando normalmente!");
        }
        
        public virtual void Queda(){
            System.Console.WriteLine("Caindo normalmente!");
        }


    }
}