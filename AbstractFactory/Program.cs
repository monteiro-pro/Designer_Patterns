using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroLuxo = AbstractFactory.FabricarCarro("luxo");
            Carro carroSimples = AbstractFactory.FabricarCarro("popular");

            Console.ReadKey();
        }
    }
}
