using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void AtaqueRoboInimigo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("Dano do ataque do robo inimigo: " + danoAtaque);
        }

        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("Robo inimigo se movimentou " + movimento + " para frente");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("Robo inimigo ataca " + piloto);
        }
    }
}
