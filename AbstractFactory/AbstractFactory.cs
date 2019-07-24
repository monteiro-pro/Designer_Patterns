using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        public static Carro FabricarCarro(string modelo)
        {
            CarroFactory cf = null;

            switch (modelo)
            {
                case "popular":
                    cf =  new CarroPopularFactory();
                    break;
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                default:
                    return null;
            }

            Carro carro = new Carro();
            carro.roda = cf.montarRoda();
            carro.som = cf.montarSom();
            return carro;
        }
    }
}
