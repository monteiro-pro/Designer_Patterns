using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetIntancia;
            jogador1.Menssagem("Jogador 1 iniciou com a Bola!");

            Singleton jogador2 = Singleton.GetIntancia;
            jogador2.Menssagem("Jogador 2 recebeu a Bola!");

            Singleton jogador3 = new Singleton();
            jogador3.Menssagem("Jogador 3 recebeu e chutou a Bola!");

            Console.ReadKey();
        }
    }
}
