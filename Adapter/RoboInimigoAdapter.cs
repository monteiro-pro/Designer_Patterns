using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;

        public RoboInimigoAdapter(RoboInimigo roboInimigo)
        {
            this.robo = roboInimigo;
        }

        public void Armado()
        {
            this.robo.AtaqueRoboInimigo();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilota(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}
