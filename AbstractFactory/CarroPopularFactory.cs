using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda montarRoda()
        {
            return new RodaSimples();
        }

        public override Som montarSom()
        {
            return new CDPlayer();
        }
    }
}
