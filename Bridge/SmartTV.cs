using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class SmartTV
    {
        public ICanal canal_atual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (canal_atual != null)
                Console.WriteLine(canal_atual.Canal());
            else
                Console.WriteLine("Por favor selecione um canal!");
        }

        public void PlayTV()
        {
            if (canal_atual != null)
                Console.WriteLine(canal_atual.Status());
            else
                Console.WriteLine("Por favor selecione um canal!");
        }
    }
}
