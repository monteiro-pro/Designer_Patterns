using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetIntancia;
            jogador1.Menssagem("Jogador 1 Está com a Bola!");

            Singleton jogador2 = Singleton.GetIntancia;
            jogador2.Menssagem("Jogador 2 recebeu a Bola!");

            Singleton jogador3 = Singleton.GetIntancia;
            jogador3.Menssagem("Jogador 3 recebeu a Bola!");

            Console.ReadKey();
        }
    }
}
