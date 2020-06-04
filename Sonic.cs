namespace Atividade10Polimorfismo
{
    public class Sonic : Player
    {
        public override void Queda(){
            
            base.Queda();
            System.Console.WriteLine("Sonic está rodando enquanto cai!! Que demais!!");      
        }
    }
}