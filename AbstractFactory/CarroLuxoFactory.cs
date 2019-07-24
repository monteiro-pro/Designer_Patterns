using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som montarSom()
        {
            return new BluetoohPlayer();
        }
    }
}
