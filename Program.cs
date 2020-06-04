using System;

namespace Atividade10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sonic sonic = new Sonic();
            Console.WriteLine("Vejamos o que sonic é capaz...");
            sonic.Pular();
            sonic.Queda();

            Console.WriteLine("");

            Tails tails = new Tails();
            Console.WriteLine("Vez do tails...");
            tails.Pular();
            tails.Queda();
        }
    }
}
