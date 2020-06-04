namespace Atividade10Polimorfismo
{
    public class Tails : Player
    {
        public override void Queda(){
            base.Queda();
            System.Console.WriteLine("Tails consegue planar usando seu rabo!! Uma coisa mais impressionante que a outra, caramba!");
        }



    }
}