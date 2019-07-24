using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
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
