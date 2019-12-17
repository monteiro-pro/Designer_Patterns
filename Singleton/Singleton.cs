using System;

namespace Singleton
{
    public sealed class Singleton //** Classes "sealed" não podem ser herdadas.
    {
        private static Singleton instancia = null;

        public static Singleton GetIntancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();

                    Console.WriteLine("Bola em Jogo!");
                }

                return instancia;
            }
        }

        public void Menssagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
