using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();

        public void Armado()
        {
            int danoAtaque = this.gerador.Next(10) + 1;

            Console.WriteLine("Dano do tanque inimigo: " + danoAtaque);
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(10) + 1;

            Console.WriteLine("Movimentações do tanque inimigo: " + movimento);
        }

        public void Pilota(string piloto)
        {
            Console.WriteLine(piloto + " está pilotando");
        }
    }
}
